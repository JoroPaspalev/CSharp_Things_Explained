using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTable_and_GridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("First", typeof(string));
            dt.Columns.Add("Last", typeof(string));
            dt.Columns.Add("Age", typeof(int));

            dt.Rows.Add(1, "Ivan", "Ivanov", 23);
            dt.Rows.Add(2, "Marin", "Ivanov", 563);
            dt.Rows.Add(3, "Asan", "Ivanov", 23);
            dt.Rows.Add(4, "Pesho", "Ivanov", 17);
            dt.Rows.Add(5, "Kiro", "Ivanov", 73);
            dt.Rows.Add(6, "Zoq", "Ivanov", 98);


            //dt.Select() е все едно Collection.Where(x => x)
            DataRow[] copyDtRows = dt.Select("Id = 1");


            //dataTable.AsEnumerable().CopyToDataTable();
            ////is 30% faster than 
            //dataTable.Copy()
            DataTable dtWithCopy = dt.Copy();
            DataTable dtAsEnumerable = dt.AsEnumerable().CopyToDataTable();


            //dataTable.AsEnumerable().Where(dr => dr.Field<double>("columnName") > 0);
            //// is 10x faster than
            //dataTable.Select("columnName > 0");
            DataTable copyDt = dt.Select("Id = 1").CopyToDataTable();



            dataGridView1.DataSource = dt;

            dataGridView2.DataSource = copyDt;


            

            

        }
    }
}
