using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataTableClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //1.Create SQL Connection Object
            SqlConnection sc = new SqlConnection(@"Data Source=DESKTOP-U7FBH7A;Initial Catalog=Dashboard;Integrated Security=True");

            //2. Now we have a connection Object and through this object we will take data from DB
            //3. We need something to send SQL Query through connection object - that is SqlCommand object
            var query = "SELECT * FROM MetricsPmd";
            SqlCommand command = new SqlCommand(query, sc);

            //4. Now we need a DataTable object where to load data from DB
            System.Data.DataTable dt = new System.Data.DataTable();

            //5. Also create a SQLDataAdapter object. This object want SqlCommand in constructor which we made already, to read from him 2 things: Sql Query and connectionString.
            //This will match automatically data from DB Table -> Roles and load them in memory in DataTable Object
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            //6. Now we will Fill read data from DB into in-memory DataTable object
            adapter.Fill(dt);

            //7. Here we pass data to GridView
            dataGridView1.DataSource = dt;

            //8. We can create DataSet - this object will hold all tables from Db
            System.Data.DataSet dataSet = new System.Data.DataSet();
            dataSet.Tables.Add(dt);

            //9. Extract another table from DB now and add it to dataSet
            var dataTable2 = new System.Data.DataTable("EntityLinkingCoverages_Table");
            var query2 = "SELECT * FROM EntityLinkingCoverage";
            //set new Sql query
            command.CommandText = query2;

            adapter.SelectCommand = command;
            adapter.Fill(dataTable2);
            dataSet.Tables.Add(dataTable2);

            //10. Now we want to take all column names from first Table in DataSet
            var columns = new List<string>();

            foreach (var column in dataSet.Tables[0].Columns)
            {
                columns.Add(column.ToString());
            }



            
            //Create DataTable object manually. Without to connect to DB

            //System.Data.DataTable dt = new System.Data.DataTable();
            //dt.Columns.Add("ID");
            //dt.Columns.Add("Name");
            //dt.Columns.Add("Age");
            //dt.Rows.Add("1", "Ivan", "12");
            //dt.Rows.Add("2", "Kiro", "77");
            //dt.Rows.Add("3", "Marinko", "44");
            //dataGridView1.DataSource = dt;
        }
    }
}
