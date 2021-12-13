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
    public partial class UpdateKunde : Form
    {
        public UpdateKunde()
        {
            InitializeComponent();
        }

        private void UpdateKunde_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kaspermark_dk_db_realboligDataSet2.Kunde' table. You can move, or remove it, as needed.
            this.kundeTableAdapter.Fill(this.kaspermark_dk_db_realboligDataSet2.Kunde);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelTlf_Click(object sender, EventArgs e)
        {
           
        }

        private void SearcgKunde_Click(object sender, EventArgs e)
        {
            string KiD = KiDTextBox.Text;
            int intKiD;

            bool success = Int32.TryParse(KiD, out intKiD);

            if (success == true)
            {
                intKiD = Convert.ToInt32(KiD);
                
            }
            else if (success == false)
            {
                KiDTextBox.Text = "";
                MessageBox.Show("Skriv kun tal ");
            }



            mFnavnTextBox.Text = getNavn(intKiD);
            mTlfTextBox.Text = Convert.ToString(getTLF(intKiD));
            mMailTextBox.Text = getMail(intKiD);
            mAdresseTextBox.Text = getAdresse(intKiD);


        }

        private void updateOplysninger_Click(object sender, EventArgs e)
        {
            int intTlf;
            bool tlfsucces = Int32.TryParse(mTlfTextBox.Text, out intTlf);



            if (tlfsucces == false || mTlfTextBox.Text.Length != 8)
            {
                MessageBox.Show("Indtast kun 8 tal i kunden telefonnummer");
            }
            else {
                setNavn(Convert.ToInt32(KiDTextBox.Text));
                setMail(Convert.ToInt32(KiDTextBox.Text));
                setAdresse(Convert.ToInt32(KiDTextBox.Text));
                setTLF(Convert.ToInt32(KiDTextBox.Text), intTlf);
                MessageBox.Show("success: Oplysninger rettet");

                KiDTextBox.Text = "";
                mFnavnTextBox.Text = "";
                mTlfTextBox.Text = "";
                mMailTextBox.Text = "";
                mAdresseTextBox.Text = "";
            }
            
            UpdateData.updateGridView("SELECT * FROM Kunde", dataGridView1);
        }

        public void setAdresse(int KiD)
        {
            SqlConnection conn = new SqlConnection(ConnString.getConnStr());
            string sqltest = "UPDATE Kunde SET Adresse = '" + mAdresseTextBox.Text + "' WHERE KiD = '" + KiD + "'";
            SqlCommand cmd = new SqlCommand(sqltest, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void setMail(int KiD)
        {
            SqlConnection conn = new SqlConnection(ConnString.getConnStr());
            string sqltest = "UPDATE Kunde SET Mail = '" + mMailTextBox.Text + "' WHERE KiD = '" + KiD + "'";
            SqlCommand cmd = new SqlCommand(sqltest, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void setTLF(int KiD, int tlf)
        {
            SqlConnection conn = new SqlConnection(ConnString.getConnStr());
            string sqltest = "UPDATE Kunde SET Tlf = '" + tlf + "' WHERE KiD = '" + KiD + "'";
            SqlCommand cmd = new SqlCommand(sqltest, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }


        public void setNavn(int KiD)
        {
            SqlConnection conn = new SqlConnection(ConnString.getConnStr());
            string sqltest = "UPDATE Kunde SET FuldeNavn = '" + mFnavnTextBox.Text + "' WHERE KiD = '" + KiD + "'";
            SqlCommand cmd = new SqlCommand(sqltest, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public string getNavn(int KiD)
        {
            SqlConnection conn = new SqlConnection(ConnString.getConnStr());
            string sqltest = "SELECT FuldeNavn FROM Kunde WHERE KiD = '" + KiD + "'";
            SqlCommand cmd = new SqlCommand(sqltest, conn);

            using (conn)
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();


                reader.Read();
                try
                {
                    string returned = reader.GetString(0);
                    return returned;
                }
                catch (InvalidOperationException)
                {
                }

                return null;


            }

        }

        public int? getTLF(int KiD)
        {
            SqlConnection conn = new SqlConnection(ConnString.getConnStr());
            string sqltest = "SELECT Tlf FROM Kunde WHERE KiD = '" + KiD + "'";
            SqlCommand cmd = new SqlCommand(sqltest, conn);

            using (conn)
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();


                reader.Read();
                try
                {
                    int returned = reader.GetInt32(0);
                    return returned;
                }
                catch (InvalidOperationException)
                {
                }

                return null;


            }

        }

        public string getMail(int KiD)
        {
            SqlConnection conn = new SqlConnection(ConnString.getConnStr());
            string sqltest = "SELECT Mail FROM Kunde WHERE KiD = '" + KiD + "'";
            SqlCommand cmd = new SqlCommand(sqltest, conn);

            using (conn)
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();


                reader.Read();
                try
                {
                    string returned = reader.GetString(0);
                    return returned;
                }
                catch (InvalidOperationException)
                {
                }

                return null;


            }

        }

        public string getAdresse(int KiD)
        {
            SqlConnection conn = new SqlConnection(ConnString.getConnStr());
            string sqltest = "SELECT Adresse FROM Kunde WHERE KiD = '" + KiD + "'";
            SqlCommand cmd = new SqlCommand(sqltest, conn);

            using (conn)
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();


                reader.Read();
                try
                {
                    string returned = reader.GetString(0);
                    return returned;
                }
                catch (InvalidOperationException)
                {
                }

                return null;


            }

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void KiDTextBox_MouseHover(object sender, EventArgs e)
        {
            
            //toolTip1.Show("Indtast kundes ID. Du kan finde kundes ID i listen ovenover eller inde i indlæs menuen", labelTlf);
            
        }

        private void KiDTextBox_MouseLeave(object sender, EventArgs e)
        {
            //toolTip1.Show("", labelTlf);
        }

        private void SearcgKunde_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Indtast kun kunde ID", SearcgKunde);
        }

        private void updateOplysninger_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Alle felte skal være udfyldt", updateOplysninger);
        }
    }
}
