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
    public partial class ReadMægler : Form
    {
        public ReadMægler()
        {
            InitializeComponent();
        }

        private void ReadMægler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kaspermark_dk_db_realboligDataSet4.Ejendomsmægler' table. You can move, or remove it, as needed.
            this.ejendomsmæglerTableAdapter1.Fill(this.kaspermark_dk_db_realboligDataSet4.Ejendomsmægler);
            // TODO: This line of code loads data into the 'kaspermark_dk_db_realboligDataSet1.Bolig_Status' table. You can move, or remove it, as needed.
            this.bolig_StatusTableAdapter.Fill(this.kaspermark_dk_db_realboligDataSet1.Bolig_Status);
            // TODO: This line of code loads data into the 'kaspermark_dk_db_realboligDataSet3.Ejendomsmægler' table. You can move, or remove it, as needed.
            this.ejendomsmæglerTableAdapter.Fill(this.kaspermark_dk_db_realboligDataSet3.Ejendomsmægler);

        }

        private void SearchMægler_Click(object sender, EventArgs e)
        {
            if (tbMiD.Text == "")
            {
                DisplayDataNummer();
            }
            else if (tbTlf.Text == "")
            {
                DisplayDataKiD();
            }
            
            
        }
        public void DisplayDataKiD()
        {


            SqlConnection conn = new SqlConnection(ConnString.getConnStr());


            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Ejendomsmægler where AiD = '" + tbMiD.Text + "'", conn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        public void DisplayDataNummer()
        {


            SqlConnection conn = new SqlConnection(ConnString.getConnStr());


            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Ejendomsmægler where Tlf = '" + tbTlf.Text + "'", conn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnString.getConnStr());

            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Ejendomsmægler", conn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            conn.Close();
            tbMiD.Text = "";
            tbTlf.Text = "";
        }
    }
}
