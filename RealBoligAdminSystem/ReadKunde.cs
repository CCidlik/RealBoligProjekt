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

namespace RealBolig
{
    public partial class ReadKunde : Form
    {
        public ReadKunde()
        {
            InitializeComponent();
        }

        private void ReadKunde_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kaspermark_dk_db_realboligDataSet2.Kunde' table. You can move, or remove it, as needed.
            this.kundeTableAdapter.Fill(this.kaspermark_dk_db_realboligDataSet2.Kunde);

        }

        private void SearchKunde_Click(object sender, EventArgs e)
        {
            if (tbKiD.Text == "")
            {
                DisplayDataNummer();
            }
            else if (tbNummer.Text == "")
            {
                DisplayDataKiD();
            }
        }

        public void DisplayDataKiD()
        {


            SqlConnection conn = new SqlConnection(ConnString.getConnStr());


            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Kunde where KiD = '" + tbKiD.Text + "'", conn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        public void DisplayDataNummer()
        {


            SqlConnection conn = new SqlConnection(ConnString.getConnStr());


            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Kunde where Tlf = '" + tbNummer.Text + "'", conn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void SearchKundeRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnString.getConnStr());

            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Kunde", conn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            conn.Close();
            tbKiD.Text = "";
            tbNummer.Text = "";
        }



    }
}
