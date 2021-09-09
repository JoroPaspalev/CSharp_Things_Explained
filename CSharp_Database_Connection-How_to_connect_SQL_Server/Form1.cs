using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CSharp_Database_Connection_How_to_connect_SQL_Server
{
    public partial class connectionForm : Form
    {
        public connectionForm()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ///////////////////      C# Database Connection: How to connect SQL Server     ////////////////////////
            //===================================================================================================//

            //1 We create connection string
            string connectionString = @"Server=.;Database=RentAnything;Trusted_Connection=True;";

            //2 create connection
            SqlConnection connection = new SqlConnection(connectionString);

            //3 Open connection
            connection.Open();

            //4 create sql query
            string query = @"SELECT * FROM Ads";

            //5 we pass query and connection to sql command
            SqlCommand command = new SqlCommand(query, connection);

            //6 here, with the ExecuteReader() method send the Sql query to the connection and build and return SqlDataReader
            //dataReader is something which keep result (DataTable) against the executed query
            SqlDataReader dataReader = command.ExecuteReader();

            //7
            string result = "";

            while (dataReader.Read())//Here we take all rows (from result DataTable) one by one until they finish
            {
                result += dataReader.GetValue(0) + ". " + dataReader.GetValue(1) + " - " + 
                    dataReader.GetDecimal(dataReader.GetOrdinal("Price")) + "\n";

                //.GetValue(0) - Takes the value on the current row which is intersect with column with index 0
                //.GetValue(1) - Takes the value on the current row which is intersect with column with index 1
                //dataReader.GetOrdinal("Price") - Takes on which index is ь column with ь name "Price" => index 7 in this case
                //dataReader.GetDecimal(7) - Cast the fetched value of index 7 to decimal
            }

            MessageBox.Show(result);

            //8
            connection.Close();
        }
    }
}
