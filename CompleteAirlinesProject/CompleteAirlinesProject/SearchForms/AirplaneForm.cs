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
    public partial class AirplaneForm : Form
    {
        private MainAirlinesForm mainAirlinesForm;

        public AirplaneForm(MainAirlinesForm mainAirlinesForm)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.mainAirlinesForm = mainAirlinesForm;
        }

        private void AirplaneForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airlinesDataSet.Airplanes' table. You can move, or remove it, as needed.
            this.airplanesTableAdapter.Fill(this.airlinesDataSet.Airplanes);
            this.mainAirlinesForm.Enabled = false;
            this.lbTotal.Text = string.Format("Total: {0} row(s) affected!", DataGridView.RowCount);
        }

        private void airplanesBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            this.lbTotal.Text = string.Format("Total: {0} row(s) affected!", this.airplanesBindingSource.List.Count);
        }

        private void DataGridView_SortStringChanged(object sender, EventArgs e)
        {
            this.airplanesBindingSource.Sort = this.DataGridView.SortString;
        }

        private void DataGridView_FilterStringChanged(object sender, EventArgs e)
        {
            this.airplanesBindingSource.Filter = this.DataGridView.FilterString;
        }

        private void AirplaneForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.mainAirlinesForm.Enabled = true;
        }
    }
}
