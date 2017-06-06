using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompleteAirlinesProject
{
    public partial class MainAirlinesForm : Form
    {
        #region Index Database
        
        /// <summary>
        /// Index of database
        /// </summary>
        private int iDatabase = 1;

        public int IData
        {
            get { return iDatabase; }
            set { iDatabase = value; }
        } 
        
        #endregion

        public MainAirlinesForm()
        {
            InitializeComponent();
        }

        #region Radio Button
        
        private void checkRadioBtn()
        {
            airplaneBtn.Checked = false;
            airlineBtn.Checked = false;
            airportBtn.Checked = false;
            flightBtn.Checked = false;
            userBtn.Checked = false;

            switch (iDatabase)
            {
                case 1: airplaneBtn.Checked = true; break;
                case 2: airlineBtn.Checked = true; break;
                case 3: airportBtn.Checked = true; break;
                case 4: flightBtn.Checked = true; break;
                case 5: userBtn.Checked = true; break;
            }
        }

        private void airplaneBtn_Click(object sender, EventArgs e)
        {
            this.IData = 1;
            checkRadioBtn();
        }

        private void airlineBtn_Click(object sender, EventArgs e)
        {
            this.IData = 2;
            checkRadioBtn();
        }

        private void airportBtn_Click(object sender, EventArgs e)
        {
            this.IData = 3;
            checkRadioBtn();
        }

        private void flightBtn_Click(object sender, EventArgs e)
        {
            this.IData = 4;
            checkRadioBtn();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            this.IData = 5;
            checkRadioBtn();
        }

        #endregion

        /// <summary>
        /// Searching by database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void byDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (this.iDatabase)
            {
                case 1: 
                    SearchForms.AirplaneForm sForm1 = new SearchForms.AirplaneForm(this);
                    sForm1.Show();
                    break;
                case 2:
                    SearchForms.AirlineForm sForm2 = new SearchForms.AirlineForm(this);
                    sForm2.Show();
                    break;
                case 3:
                    SearchForms.AirportForm sForm3 = new SearchForms.AirportForm(this);
                    sForm3.Show();
                    break;
                case 4:
                    SearchForms.FlightForm sForm4 = new SearchForms.FlightForm(this);
                    sForm4.Show();
                    break;
                case 5:
                    SearchForms.BookingForm sForm5 = new SearchForms.BookingForm(this);
                    sForm5.Show();
                    break;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (this.iDatabase)
            {
                case 1:
                    EditForms.AirplaneForm sForm1 = new EditForms.AirplaneForm(this);
                    sForm1.Show();
                    break;
                case 2:
                    EditForms.AirlineForm sForm2 = new EditForms.AirlineForm(this);
                    sForm2.Show();
                    break;
                case 3:
                    EditForms.AirportForm sForm3 = new EditForms.AirportForm(this);
                    sForm3.Show();
                    break;
                case 4:
                    EditForms.FlightForm sForm4 = new EditForms.FlightForm(this);
                    sForm4.Show();
                    break;
                case 5:
                    EditForms.BookingForm sForm5 = new EditForms.BookingForm(this);
                    sForm5.Show();
                    break;
            }
        }

        private void byTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForms.AllForm sForm = new SearchForms.AllForm(this);
            sForm.Show();
        }

        private void forTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graph.GraphForm gForm = new Graph.GraphForm(this);
            gForm.Show();
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("   Airline Database Project (C) 2017\n\n" +
                            " + Director: Просуков Евгений Алексеевич\n\n" +
                            " + Written by: Binh D. Nguyen\n\n" +
                            " + Group: IU7-61\n\n" +
                            " For more information please contact us at hhtp://www.bmstu.ru",
                            "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
