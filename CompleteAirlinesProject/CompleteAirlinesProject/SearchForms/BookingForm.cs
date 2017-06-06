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
    public partial class BookingForm : Form
    {
        private MainAirlinesForm mainAirlinesForm;

        public BookingForm(MainAirlinesForm mainAirlinesForm)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.mainAirlinesForm = mainAirlinesForm;
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airlinesDataSet.Bookings' table. You can move, or remove it, as needed.
            this.bookingsTableAdapter.Fill(this.airlinesDataSet.Bookings);
            this.mainAirlinesForm.Enabled = false;
            this.lbTotal.Text = string.Format("Total: {0} row(s) affected!", DataGridView.RowCount);
        }

        private void bookingsBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            this.lbTotal.Text = string.Format("Total: {0} row(s) affected!", this.bookingsBindingSource.List.Count);
        }

        private void DataGridView_SortStringChanged(object sender, EventArgs e)
        {
            this.bookingsBindingSource.Sort = this.DataGridView.SortString;
        }

        private void DataGridView_FilterStringChanged(object sender, EventArgs e)
        {
            this.bookingsBindingSource.Filter = this.DataGridView.FilterString;
        }

        private void AirplaneForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.mainAirlinesForm.Enabled = true;
        }
    }
}
