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
    public partial class FlightForm : Form
    {
        private MainAirlinesForm mainAirlinesForm;
        private AppLibraries app;

        public FlightForm(MainAirlinesForm mainAirlinesForm)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.mainAirlinesForm = mainAirlinesForm;
            this.mainAirlinesForm.Enabled = false;
            this.app = new AppLibraries();
            this.app.iData = 4;
            this.display();
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DataGridView.Rows[e.RowIndex];

                this.edtFlightID.Text = row.Cells[0].Value.ToString();
                this.edtAirplaneID.Text = row.Cells[1].Value.ToString();
                this.edtAirlineID.Text = row.Cells[2].Value.ToString();
                this.edtFlightNumber.Text = row.Cells[3].Value.ToString();
                this.edtOrigin.Text = row.Cells[4].Value.ToString();
                this.edtDepartureTime.Text = row.Cells[5].Value.ToString();
                this.edtDestination.Text = row.Cells[6].Value.ToString();
                this.edtArrivalTime.Text = row.Cells[7].Value.ToString();
                this.edtFreeSeats.Text = row.Cells[8].Value.ToString();
                this.edtPrice.Text = row.Cells[9].Value.ToString();
                this.edtCreateDate.Text = row.Cells[10].Value.ToString();
            }
        }

        private bool isExisted()
        {
            this.app.executeRequest("Select * from " + this.app.dboSource + 
                                    " where AirplaneID = " + this.edtAirplaneID.Text +
                                    " and AirlineID = " + this.edtAirlineID.Text +
                                    " and FlightNumber = " + this.edtFlightNumber.Text +
                                    " and Origin = " + this.edtOrigin.Text + 
                                    " and Destination = " + this.edtDestination.Text);
                                               
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
            this.edtFlightID.Clear();
            this.edtAirplaneID.Clear();
            this.edtAirlineID.Clear();
            this.edtFlightNumber.Clear();
            this.edtOrigin.Clear();
            this.edtDepartureTime.Clear();
            this.edtDestination.Clear();
            this.edtArrivalTime.Clear();
            this.edtFreeSeats.Clear();
            this.edtPrice.Clear();
            this.edtCreateDate.Clear();
        }

        private void insertRequest()
        {
            //DateTime departureTime = DateTime.ParseExact(this.edtDepartureTime.Text, "yyyy-MM-dd HH:mm:ss,fff",
            //                                             System.Globalization.CultureInfo.InvariantCulture);
            //DateTime arrivalTime = DateTime.ParseExact(this.edtArrivalTime.Text, "yyyy-MM-dd HH:mm:ss,fff",
            //                                             System.Globalization.CultureInfo.InvariantCulture);
            //DateTime createTime = DateTime.ParseExact(this.edtCreateTime.Text, "yyyy-MM-dd HH:mm:ss,fff",
            //                                             System.Globalization.CultureInfo.InvariantCulture);
            
            //app.executeRequest("SET IDENTITY_INSERT " + dboSource + " ON");
            string cmd = "insert into " + this.app.dboSource + " values(" + this.edtAirplaneID.Text + ", "
                                        + this.edtAirlineID.Text + ", " + this.edtFlightID.Text + ", "
                                        + this.edtOrigin.Text + ", '" + this.edtDepartureTime.Text + "', "
                                        + this.edtDestination.Text + ", '" + this.edtArrivalTime.Text + "', "
                                        + this.edtFreeSeats.Text + ", " + this.edtPrice.Text
                                        + ", '" + this.edtArrivalTime.Text + "')";
            this.app.executeRequest(cmd);
            //app.executeRequest("SET IDENTITY_INSERT " + dboSource + " OFF");
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            if (this.edtAirplaneID.Text == "" || this.edtAirlineID.Text == "" || this.edtFlightNumber.Text == "" ||
                this.edtOrigin.Text == "" || this.edtDepartureTime.Text == "" || this.edtDestination.Text == "" ||
                this.edtDestination.Text == "" || this.edtArrivalTime.Text == "" || this.edtFreeSeats.Text == "" ||
                this.edtPrice.Text == "" || this.edtCreateDate.Text == "")
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

        private void FlightForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.mainAirlinesForm.Enabled = true;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string cmd = "delete from " + this.app.dboSource + " where flightID = " + this.edtFlightID.Text;
            this.app.executeRequest(cmd);
            this.display();
            MessageBox.Show("Delete successfully! One row is affected!", "Message");
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            this.edtFlightID.ReadOnly = true;
            string cmd = "update " + this.app.dboSource + " set AirplaneID = " + this.edtAirplaneID.Text +
                         ", AirlineID = " + this.edtAirlineID.Text + ", FlightNumber = " + this.edtFlightNumber.Text + 
                         ", Origin = " + this.edtOrigin.Text + ", DepatureTime = '" + this.edtDepartureTime.Text + "'" +
                         ", Destination = " + this.edtDestination.Text + ", ArrivalTime = '" + this.edtArrivalTime.Text + "'" +
                         ", FreeSeats = " + this.edtFreeSeats.Text + ", Price = " + this.edtPrice.Text +
                         ", '" + this.edtCreateDate.Text + "'" +
                         " where AirportID = " + this.edtFlightID.Text;
            this.app.executeRequest(cmd);
            this.display();
            MessageBox.Show("Updated successfully!", "Message");
            this.edtFlightID.ReadOnly = false;
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            int airplaneID;
            if (!int.TryParse(this.edtAirplaneID.Text, out airplaneID) || !(airplaneID > 0 && airplaneID < 8))
            {
                MessageBox.Show("Error #1: Invalid data in AirplaneID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int airlineID;
            if (!int.TryParse(this.edtAirlineID.Text, out airlineID) || !(airlineID > 0 && airlineID < 9))
            {
                MessageBox.Show("Error #2: Invalid data in AirlineID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int flightNumber;
            if (!int.TryParse(this.edtFlightNumber.Text, out flightNumber))
            {
                MessageBox.Show("Error #3: Invalid data in FlightNumber.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int origin;
            if (!int.TryParse(this.edtOrigin.Text, out origin) || !(origin > 0 && origin < 26))
            {
                MessageBox.Show("Error #4: Invalid data in Origin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] formats = { "M/d/yyyy h:mm:ss tt", "M/d/yyyy h:mm tt", 
                                 "MM/dd/yyyy hh:mm:ss", "M/d/yyyy h:mm:ss", 
                                 "M/d/yyyy hh:mm tt", "M/d/yyyy hh tt", 
                                 "M/d/yyyy h:mm", "M/d/yyyy h:mm", 
                                 "MM/dd/yyyy hh:mm", "M/dd/yyyy hh:mm" };

            DateTime departureTime;
            if (!DateTime.TryParseExact(this.edtDepartureTime.Text, formats, 
                                        new CultureInfo("en-US"), 
                                        DateTimeStyles.None, 
                                        out departureTime))
            {
                MessageBox.Show("Error #5: Unable to parse DepartureTime.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int destination;
            if (!int.TryParse(this.edtDestination.Text, out destination) || !(destination > 0 && destination < 26))
            {
                MessageBox.Show("Error #6: Invalid data in Destination.");
                return;
            }

            DateTime arrivalTime;
            if (!DateTime.TryParseExact(this.edtArrivalTime.Text, formats,
                                        new CultureInfo("en-US"),
                                        DateTimeStyles.None,
                                        out arrivalTime))
            {
                MessageBox.Show("Error #5: Unable to parse ArrivalTime.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            int freeSeats;
            if (!int.TryParse(this.edtFreeSeats.Text, out freeSeats) || !(freeSeats >= 0 && freeSeats <= 300))
            {
                MessageBox.Show("Error #8: Invalid data in Price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double price;
            if (!double.TryParse(this.edtPrice.Text, out price))
            {
                MessageBox.Show("Error #9: Invalid data in Price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime createDate;
            if (!DateTime.TryParseExact(this.edtCreateDate.Text, formats,
                                        new CultureInfo("en-US"),
                                        DateTimeStyles.None,
                                        out createDate))
            {
                MessageBox.Show("Error #5: Unable to parse CreateDate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("All is correct! Check data successfully!", "Success");
        }
    }
}
