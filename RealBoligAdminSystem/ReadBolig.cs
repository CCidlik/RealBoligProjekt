using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using RealBolig.DAL.Entities;
using RealBolig.DAL.Operations;

namespace RealBolig
{
    public partial class ReadBolig : Form
    {

        public ReadBolig()
        {
            InitializeComponent();
        }

        private void ReadBolig_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kaspermark_dk_db_realboligDataSet.Bolig' table. You can move, or remove it, as needed.
            this.boligTableAdapter.Fill(this.kaspermark_dk_db_realboligDataSet.Bolig);

        }

        private void btnIndlæsBolig_Click(object sender, EventArgs e)
        {

            if (tbPostnummer.Text == "")
            {
                DisplayDataOmråde();
            }
            else if (tbOmråde.Text == "")
            {
                DisplayDataPostnummer();
            }


        }
        public void DisplayDataOmråde()
        {


            SqlConnection conn = new SqlConnection(ConnString.getConnStr());


            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Bolig where Område = '" + tbOmråde.Text + "'", conn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        public void DisplayDataPostnummer()
        {


            SqlConnection conn = new SqlConnection(ConnString.getConnStr());


            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Bolig where PostNR = '" + tbPostnummer.Text + "'", conn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
