using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompleteAirlinesProject.EditForms
{
    public partial class BookingForm : Form
    {
        private MainAirlinesForm mainAirlinesForm;
        private AppLibraries app;

        public BookingForm(MainAirlinesForm mainAirlinesForm)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.mainAirlinesForm = mainAirlinesForm;
            this.mainAirlinesForm.Enabled = false;
            this.app = new AppLibraries();
            this.app.iData = 5;
            this.display();
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DataGridView.Rows[e.RowIndex];

                this.edtBookingID.Text = row.Cells[0].Value.ToString();
                this.edtFlightID.Text = row.Cells[1].Value.ToString();
                this.edtPassportNumber.Text = row.Cells[2].Value.ToString();
                this.edtName.Text = row.Cells[3].Value.ToString();
                this.edtAge.Text = row.Cells[4].Value.ToString();
                this.edtGender.SelectedIndex = (row.Cells[5].Value.ToString() == "False") ? 0 : 1;
                this.edtCreateDate.Text = row.Cells[6].Value.ToString();
            }
        }

        private bool isExisted()
        {
            this.app.executeRequest("Select * from " + this.app.dboSource +
                                    " where BookingID = " + this.edtBookingID.Text +
                                    " and FlightID = " + this.edtFlightID.Text +
                                    " and PassportNumber = N'" + this.edtPassportNumber.Text + "'" + 
                                    " and PassName = N'" + this.edtName.Text + "'" +
                                    " and PassAge = " + this.edtAge.Text +
                                    " and PassGender = " + this.edtGender.SelectedIndex.ToString() +
                                    " and CreateDate = '" + this.edtCreateDate.Text + "'");

            if (this.app.DataTable.Rows.Count > 0)
                return true;
            return false;
        }

        private void display()
        {
            this.app.executeRequest("select * from " + this.app.dboSource);
            this.DataGridView.DataSource = this.app.DataTable;
        }

        private void ClearAll()
        {
            this.edtBookingID.Clear();
            this.edtFlightID.Clear();
            this.edtPassportNumber.Clear();
            this.edtName.Clear();
            this.edtAge.Clear();
            this.edtGender.SelectedIndex = -1;
            this.edtCreateDate.Clear();
        }
        
        private void insertRequest()
        {
            //DateTime departureTime = DateTime.ParseExact(this.edtGender.Text, "yyyy-MM-dd HH:mm:ss,fff",
            //                                             System.Globalization.CultureInfo.InvariantCulture);
            //DateTime arrivalTime = DateTime.ParseExact(this.edtArrivalTime.Text, "yyyy-MM-dd HH:mm:ss,fff",
            //                                             System.Globalization.CultureInfo.InvariantCulture);
            //DateTime createTime = DateTime.ParseExact(this.edtCreateTime.Text, "yyyy-MM-dd HH:mm:ss,fff",
            //                                             System.Globalization.CultureInfo.InvariantCulture);

            //app.executeRequest("SET IDENTITY_INSERT " + dboSource + " ON");
            string cmd = "insert into " + this.app.dboSource + " values(" + this.edtFlightID.Text + ", N'"
                                        + this.edtPassportNumber.Text + "', N'" + this.edtName.Text + "', "
                                        + this.edtAge.Text + ", " + this.edtGender.SelectedIndex.ToString()
                                        + ", '" + this.edtCreateDate.Text + "')";       /// INSERT BIT (EDIT!!!!!)
            this.app.executeRequest(cmd);
            //app.executeRequest("SET IDENTITY_INSERT " + dboSource + " OFF");
        }

        private string setGender(int value)
        {
            return (value == 1) ? "TRUE" : "FALSE";
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            if (this.edtFlightID.Text == "" || this.edtPassportNumber.Text == "" || this.edtName.Text == "" ||
                this.edtAge.Text == "" || this.edtGender.SelectedIndex == -1 || this.edtCreateDate.Text == "")
            {
                MessageBox.Show("Some cells are not filled. Try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!this.isExisted())
            {
                this.insertRequest();
                this.ClearAll();
                this.display();
                MessageBox.Show("New record is inserted successfully", "Message");
            }
            else
                MessageBox.Show("Fail to insert given record", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }

        private void BookingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.mainAirlinesForm.Enabled = true;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string cmd = "delete from " + this.app.dboSource + " where BookingID = " + this.edtBookingID.Text;
            this.app.executeRequest(cmd);
            this.display();
            MessageBox.Show("Delete successfully! One row is affected!", "Message");
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            this.edtBookingID.ReadOnly = true;
            string cmd = "update " + this.app.dboSource + " set FlightID = " + this.edtFlightID.Text +
                         ", PassportNumber = N'" + this.edtPassportNumber.Text + "', PassName = N'" + this.edtName.Text +
                         "', PassAge = " + this.edtAge.Text + ", PassGender = " + setGender(this.edtGender.SelectedIndex) +
                         ", '" + this.edtCreateDate.Text + "'" +
                         " where BookingID = " + this.edtBookingID.Text;
            this.app.executeRequest(cmd);
            this.display();
            MessageBox.Show("Updated successfully!", "Message");
            this.edtBookingID.ReadOnly = false;
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            int flightID;
            if (!int.TryParse(this.edtFlightID.Text, out flightID) || !(flightID > 0 && flightID < 500))
            {
                MessageBox.Show("Error #1: Invalid data in FlightID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int age;
            if (!int.TryParse(this.edtAge.Text, out age) || !(age > 0 && age < 100))
            {
                MessageBox.Show("Error #2: Invalid data in Age.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] formats = { "M/d/yyyy h:mm:ss tt", "M/d/yyyy h:mm tt", 
                                 "MM/dd/yyyy hh:mm:ss", "M/d/yyyy h:mm:ss", 
                                 "M/d/yyyy hh:mm tt", "M/d/yyyy hh tt", 
                                 "M/d/yyyy h:mm", "M/d/yyyy h:mm", 
                                 "MM/dd/yyyy hh:mm", "M/dd/yyyy hh:mm" };

            DateTime createDate;
            if (!DateTime.TryParseExact(this.edtCreateDate.Text, formats,
                                        new CultureInfo("en-US"),
                                        DateTimeStyles.None,
                                        out createDate))
            {
                MessageBox.Show("Error #3: Unable to parse CreateDate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("All is correct! Check data successfully!", "Success");
        }
    }
}
