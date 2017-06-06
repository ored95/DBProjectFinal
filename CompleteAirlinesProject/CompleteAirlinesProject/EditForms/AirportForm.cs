using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompleteAirlinesProject.EditForms
{
    public partial class AirportForm : Form
    {
        private MainAirlinesForm mainAirlinesForm;
        private AppLibraries app;

        public AirportForm(MainAirlinesForm mainAirlinesForm)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.mainAirlinesForm = mainAirlinesForm;
            this.mainAirlinesForm.Enabled = false;
            this.app = new AppLibraries();
            this.app.iData = 3;
            this.display();
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DataGridView.Rows[e.RowIndex];

                this.edtID.Text = row.Cells[0].Value.ToString();
                this.edtCity.Text = row.Cells[1].Value.ToString();
                this.edtTitle.Text = row.Cells[2].Value.ToString();
                this.edtIATA.Text = row.Cells[3].Value.ToString();
            }
        }

        private bool isExisted()
        {
            this.app.executeRequest("Select * from " + this.app.dboSource + " where City = N'" + this.edtCity.Text
                                                + "' and Title = N'" + this.edtTitle.Text 
                                                + "' and IATA = N'" + this.edtIATA.Text);
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
            this.edtID.Clear();
            this.edtCity.Clear();
            this.edtTitle.Clear();
            this.edtIATA.Clear();
        }

        private void insertRequest()
        {
            //app.executeRequest("SET IDENTITY_INSERT " + dboSource + " ON");
            string cmd = "insert into " + this.app.dboSource + " values(N'" + this.edtCity.Text + "', " 
                                        + this.edtTitle.Text + "', " + this.edtIATA.Text + ")";
            this.app.executeRequest(cmd);
            //app.executeRequest("SET IDENTITY_INSERT " + dboSource + " OFF");
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            if (this.edtCity.Text == "" || this.edtTitle.Text == "" || this.edtIATA.Text == "")
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

        private void AirportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.mainAirlinesForm.Enabled = true;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string cmd = "delete from " + this.app.dboSource + " where AirportID = " + this.edtID.Text;
            this.app.executeRequest(cmd);
            this.display();
            MessageBox.Show("Delete successfully! One row is affected!", "Message");
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            this.edtID.ReadOnly = true;
            string cmd = "update " + this.app.dboSource + " set City = N'" + this.edtCity.Text +
                         "', Title = " + this.edtTitle.Text + ", IATA = N'" + this.edtIATA.Text + "' where AirportID = " + this.edtID.Text;
            this.app.executeRequest(cmd);
            this.display();
            MessageBox.Show("Updated successfully!", "Message");
            this.edtID.ReadOnly = false;
        }
    }
}
