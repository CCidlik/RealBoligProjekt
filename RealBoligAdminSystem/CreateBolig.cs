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
    public partial class CreateBolig : Form
    {

        private const bool test = false;

        public CreateBolig()
        {
            InitializeComponent();
        }

        private void CreateBolig_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kaspermark_dk_db_realboligDataSet2.Kunde' table. You can move, or remove it, as needed.
            this.kundeTableAdapter.Fill(this.kaspermark_dk_db_realboligDataSet2.Kunde);
            // TODO: This line of code loads data into the 'kaspermark_dk_db_realboligDataSet.Bolig' table. You can move, or remove it, as needed.
            this.boligTableAdapter.Fill(this.kaspermark_dk_db_realboligDataSet.Bolig);

        }

        private void btnOpretBolig_Click(object sender, EventArgs e)
        {
            string KiD = mKiDTextbox.Text;
            string PostNR = mPostNRTextbox.Text;
            string Adresse = mAdresseTextbox.Text;
            string Område = mOmrådeTextbox.Text;
            string Kvm = mKvmTextbox.Text;
            string SalgsPris = mSalgsPrisTextbox.Text;
            //string SalgsDato = "";

            EBolig bolig = new EBolig(KiD, PostNR, Adresse, Område, SalgsPris, Kvm, 0);
            OBolig boligOP = new OBolig();

            boligOP.Insert(bolig);

            mKiDTextbox.Text = "";
            mPostNRTextbox.Text = "";
            mAdresseTextbox.Text = "";
            mOmrådeTextbox.Text = "";
            mKvmTextbox.Text = "";
            mSalgsPrisTextbox.Text = "";

            UpdateData.updateGridView("select * from Bolig", dataGridView1);

        }

        private void btnForslåPris_Click(object sender, EventArgs e)
        {
            int tbPost = Convert.ToInt32(mPostNRTextbox.Text);
            int tbKvm = Convert.ToInt32(mKvmTextbox.Text);

            int avgKvm = getAvgKvm(tbPost);
            int avgPris = getAvgPris(tbPost);
            
            


            double proposePrice = (avgPris / avgKvm) * tbKvm;

            int recommendPrice = Convert.ToInt32(proposePrice);

            string priceToString = Convert.ToString(recommendPrice);

            mSalgsPrisTextbox.Text = priceToString;
        }

        public int getAvgKvm(int post)
        {
            SqlConnection conn = new SqlConnection(ConnString.getConnStr());
            string sqltest = "SELECT AVG(Kvm) FROM Bolig WHERE PostNR = '" + post + "'";
            SqlCommand cmd = new SqlCommand(sqltest, conn);

            using (conn)
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                reader.Read();

                decimal hent = reader.GetDecimal(0);

                string returned = Convert.ToString(hent);

                double returToDoub = Convert.ToDouble(returned);

                int toInt = Convert.ToInt32(returToDoub);

                return toInt;

            }

        }

        public int getAvgPris(int post)
        {
            SqlConnection conn = new SqlConnection(ConnString.getConnStr());
            string sqltest = "select AVG(SalgsPris) from Bolig where PostNR = '" + post+"'";
            SqlCommand cmd = new SqlCommand(sqltest, conn);

            using (conn)
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                reader.Read();

                decimal hent = reader.GetDecimal(0);

                string returned = Convert.ToString(hent);

                double returToDoub = Convert.ToDouble(returned);

                int Toint = Convert.ToInt32(returToDoub);

                return Toint;

            }

        }

        private void mKiDTextbox_MouseHover(object sender, EventArgs e)
        {
          

        }

        private void btnForslåPris_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Der skal være oprettet en bolig i det postnummer i forvejen", btnForslåPris);
        }

        private void btnOpretBolig_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Alle felter skal være udfyldt", btnOpretBolig);
        }
    }
}
