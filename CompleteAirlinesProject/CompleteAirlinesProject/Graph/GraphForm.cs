using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompleteAirlinesProject.Graph
{
    public partial class GraphForm : Form
    {
        private MainAirlinesForm mainAirlinesForm;
        private List<int> originID;
        private List<int> destinationID;

        public GraphForm(MainAirlinesForm mainAirlinesForm)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.mainAirlinesForm = mainAirlinesForm;
            this.mainAirlinesForm.Enabled = false;

            this.originBox.SelectedIndex = -1;
            this.destinationBox.SelectedIndex = -1;
        }

        private List<int> SetupOrigin()
        {
            var id = new List<int>();
            if (this.originBox.SelectedIndex == 0)
            {
                id.Add(1);
                id.Add(2);
                id.Add(3);
                id.Add(4);
            }

            if (this.originBox.SelectedIndex > 0)
                id.Add(this.originBox.SelectedIndex + 4);
            return id;
        }

        private List<int> SetupDestination()
        {
            if (this.destinationBox.SelectedIndex == this.originBox.SelectedIndex)
            {
                MessageBox.Show("Error #1: Can not create a flight with the same location.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            var id = new List<int>();
            if (this.destinationBox.SelectedIndex == 0)
            {
                id.Add(1);
                id.Add(2);
                id.Add(3);
                id.Add(4);
            }

            if (this.destinationBox.SelectedIndex > 0)
                id.Add(this.destinationBox.SelectedIndex + 4);
            return id;
        }

        private void DataGridView_FilterStringChanged(object sender, EventArgs e)
        {
            this.bindingSource.DataSource = this.DataGridView.DataSource;
            this.bindingSource.Filter = this.DataGridView.FilterString;
        }

        private void DataGridView_SortStringChanged(object sender, EventArgs e)
        {
            this.bindingSource.DataSource = this.DataGridView.DataSource;
            this.bindingSource.Sort = this.DataGridView.SortString;
        }

        private void bindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            this.lbTotal.Text = string.Format("Found: {0}", this.bindingSource.List.Count);
        }

        private void GraphForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.mainAirlinesForm.Enabled = true;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            this.originID = this.SetupOrigin();
            this.destinationID = this.SetupDestination();

            if (this.originID == null || this.destinationID == null)
            {
                MessageBox.Show("Error #2: Location is NOT selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var connection = new SqlConnection(@"Data Source=ORED-SA;Initial Catalog=Airlines;Integrated Security=True"))
            {
                connection.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd;
                if (this.originID.Count > 1)
                    cmd = new SqlCommand("FlightFromMoscowSearching", connection);
                else if (this.destinationID.Count > 1)
                    cmd = new SqlCommand("FlightToMoscowSearching", connection);
                else
                    cmd = new SqlCommand("FlightSearching", connection); 

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which
                // will be passed to the stored procedure
                if (this.originID.Count > 1)
                {
                    cmd.Parameters.Add(new SqlParameter("@destination", this.destinationID[0]));
                }
                else if (this.destinationID.Count > 1)
                {
                    cmd.Parameters.Add(new SqlParameter("@origin", this.originID[0]));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@from", this.originID[0]));
                    cmd.Parameters.Add(new SqlParameter("@to", this.destinationID[0]));
                }

                // 4. execute the command
                cmd.ExecuteNonQuery();

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    this.DataGridView.DataSource = dt;
                    this.bindingSource.DataSource = dt;
                }
            }

            if (priceBtn.Checked)
            {
                this.bindingSource.DataSource = this.DataGridView.DataSource;
                this.bindingSource.Sort = "[Price] ASC";
            }

            if (timeBtn.Checked)
            {
                this.bindingSource.DataSource = this.DataGridView.DataSource;
                this.bindingSource.Sort = "[Flight Time] ASC";
            }
        }

        private bool isTimeChecked = false;

        private void timeBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.isTimeChecked = this.timeBtn.Checked;
        }

        private void timeBtn_Click(object sender, EventArgs e)
        {
            if (this.timeBtn.Checked && !this.isTimeChecked)
                this.timeBtn.Checked = false;
            else
            {
                this.timeBtn.Checked = true;
                this.isTimeChecked = false;
            }
        }

        private bool isPriceChecked = false;

        private void priceBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.isPriceChecked = this.priceBtn.Checked;
        }

        private void priceBtn_Click(object sender, EventArgs e)
        {
            if (this.priceBtn.Checked && !this.isPriceChecked)
                this.priceBtn.Checked = false;
            else
            {
                this.priceBtn.Checked = true;
                this.isTimeChecked = false;
            }
        }
    }
}
