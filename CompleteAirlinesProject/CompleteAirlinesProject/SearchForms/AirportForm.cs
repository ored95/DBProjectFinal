using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompleteAirlinesProject.SearchForms
{
    public partial class AirportForm : Form
    {
        private MainAirlinesForm mainAirlinesForm;

        public AirportForm(MainAirlinesForm mainAirlinesForm)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.mainAirlinesForm = mainAirlinesForm;
        }

        private void AirportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airlinesDataSet.Airports' table. You can move, or remove it, as needed.
            this.airportsTableAdapter.Fill(this.airlinesDataSet.Airports);
            this.mainAirlinesForm.Enabled = false;
            this.lbTotal.Text = string.Format("Total: {0} row(s) affected!", DataGridView.RowCount);
        }

        private void airportsBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            this.lbTotal.Text = string.Format("Total: {0} row(s) affected!", this.airportsBindingSource.List.Count);
        }

        private void DataGridView_SortStringChanged(object sender, EventArgs e)
        {
            this.airportsBindingSource.Sort = this.DataGridView.SortString;
        }

        private void DataGridView_FilterStringChanged(object sender, EventArgs e)
        {
            this.airportsBindingSource.Filter = this.DataGridView.FilterString;
        }

        private void AirplaneForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.mainAirlinesForm.Enabled = true;
        }
    }
}
