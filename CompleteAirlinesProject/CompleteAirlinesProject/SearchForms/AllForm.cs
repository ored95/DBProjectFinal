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

namespace CompleteAirlinesProject.SearchForms
{
    public partial class AllForm : Form
    {
        private MainAirlinesForm mainAirlinesForm;

        public AllForm(MainAirlinesForm mainAirlinesForm)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.mainAirlinesForm = mainAirlinesForm;
            this.mainAirlinesForm.Enabled = false;

            using (var connection = new SqlConnection(@"Data Source=ORED-SA;Initial Catalog=Airlines;Integrated Security=True"))
            {
                connection.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("GetFullFlightInfor", connection);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. execute the command
                cmd.ExecuteNonQuery();

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    this.DataGridView.DataSource = dt;
                    this.bindingSource.DataSource = dt;
                }
            }
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
            this.lbTotal.Text = string.Format("Total: {0} row(s) affected!", this.bindingSource.List.Count);
        }

        private void AllForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.mainAirlinesForm.Enabled = true;
        }
    }
}
