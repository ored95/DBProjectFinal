using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteAirlinesProject.EditForms
{
    class AppLibraries
    {
        private SqlConnection _sqlConnection;
        private SqlCommand cmd;
        private DataTable dtTable;
        private SqlDataAdapter adapter;
        private string[] dbString = new string[] { "dbo.Airplanes", 
                                                   "dbo.Airlines", 
                                                   "dbo.Airports", 
                                                   "dbo.Flights", 
                                                   "dbo.Bookings" };
        private int iDbo;

        public int iData
        {
            get { return iDbo; }
            set { iDbo = value; }
        }

        public DataTable DataTable
        {
            get { return dtTable; }
        }

        public string dboSource
        {
            get { return dbString[iData - 1]; }
        }

        public AppLibraries()
        {
            iDbo = 1;
            _sqlConnection = new SqlConnection(@"Data Source=ORED-SA;Initial Catalog=Airlines;Integrated Security=True");
            cmd = _sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
        }

        public void executeRequest(string cmdText)
        {
            //_sqlConnection.Open();
            cmd.CommandText = cmdText;
            //cmd.ExecuteNonQuery();
            //_sqlConnection.Close();

            dtTable = new DataTable();
            adapter = new SqlDataAdapter(cmd);

            adapter.Fill(dtTable);
            //dataGrid.DataSource = dtTable;   
        }
    }
}
