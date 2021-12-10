using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace RealBolig
{
    public partial class UpdateMægler : Form
    {
        public UpdateMægler()
        {
            InitializeComponent();
        }

        private void UpdateMægler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kaspermark_dk_db_realboligDataSet5.Ejendomsmægler' table. You can move, or remove it, as needed.
            this.ejendomsmæglerTableAdapter.Fill(this.kaspermark_dk_db_realboligDataSet5.Ejendomsmægler);

        }

        private void SearchMægler_Click(object sender, EventArgs e)
        {
            string Eid = tbEiD.Text;
            int intEid = Convert.ToInt32(Eid);


            tbEfn.Text = getNavn(intEid);
            tbTlf.Text = Convert.ToString(getTLF(intEid));
            tbEmail.Text = getMail(intEid);
            
        }

        private void UpdateInfo_Click(object sender, EventArgs e)
        {
            setNavn(Convert.ToInt32(tbEiD.Text));
            setTLF(Convert.ToInt32(tbEiD.Text));
            setMail(Convert.ToInt32(tbEiD.Text));

            tbEiD.Text = "";
            tbEfn.Text = "";
            tbTlf.Text = "";
            tbEmail.Text = "";

            MessageBox.Show("success: Oplysninger rettet");
            UpdateData.updateGridView("SELECT * FROM Ejendomsmægler", dataGridView1);
        }

        

        public void setMail(int Eid)
        {
            SqlConnection conn = new SqlConnection(ConnString.getConnStr());
            string sqltest = "UPDATE Ejendomsmægler SET Mail = '" + tbEmail.Text + "' WHERE AiD = '" + Eid + "'";
            SqlCommand cmd = new SqlCommand(sqltest, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void setTLF(int Eid)
        {
            SqlConnection conn = new SqlConnection(ConnString.getConnStr());
            string sqltest = "UPDATE Ejendomsmægler SET Tlf = '" + tbTlf.Text + "' WHERE AiD = '" + Eid + "'";
            SqlCommand cmd = new SqlCommand(sqltest, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }


        public void setNavn(int Eid)
        {
            SqlConnection conn = new SqlConnection(ConnString.getConnStr());
            string sqltest = "UPDATE Ejendomsmægler SET FuldeNavn = '" + tbEfn.Text + "' WHERE AiD = '" + Eid + "'";
            SqlCommand cmd = new SqlCommand(sqltest, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public string getNavn(int Eid)
        {
            SqlConnection conn = new SqlConnection(ConnString.getConnStr());
            string sqltest = "SELECT FuldeNavn FROM Ejendomsmægler WHERE AiD = '" + Eid + "'";
            SqlCommand cmd = new SqlCommand(sqltest, conn);

            using (conn)
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();


                reader.Read();
                string returned = reader.GetString(0);
                return returned;


            }

        }

        public int getTLF(int Eid)
        {
            SqlConnection conn = new SqlConnection(ConnString.getConnStr());
            string sqltest = "SELECT Tlf FROM Ejendomsmægler WHERE AiD = '" + Eid + "'";
            SqlCommand cmd = new SqlCommand(sqltest, conn);

            using (conn)
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();


                reader.Read();
                int returned = reader.GetInt32(0);
                return returned;


            }

        }

        public string getMail(int Eid)
        {
            SqlConnection conn = new SqlConnection(ConnString.getConnStr());
            string sqltest = "SELECT Mail FROM Ejendomsmægler WHERE AiD = '" + Eid + "'";
            SqlCommand cmd = new SqlCommand(sqltest, conn);

            using (conn)
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();


                reader.Read();
                string returned = reader.GetString(0);
                return returned;


            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbEiD_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
