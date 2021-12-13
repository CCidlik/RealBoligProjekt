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
    public partial class DeleteKunde : Form
    {
        public DeleteKunde()
        {
            InitializeComponent();
        }

        private void DeleteKunde_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kaspermark_dk_db_realboligDataSet2.Kunde' table. You can move, or remove it, as needed.
            this.kundeTableAdapter.Fill(this.kaspermark_dk_db_realboligDataSet2.Kunde);

        }

        private void deleteKiD_Click(object sender, EventArgs e)
        {
            string KiD = tbKiD.Text;
            int intKiD;

            // assumption:

            bool success = int.TryParse(KiD, out intKiD);

            // action
            if (success == true)
            {
                intKiD = Convert.ToInt32(KiD);

                // database med kundetabel:
                SqlConnection conn = new SqlConnection(ConnString.getConnStr());

                //(CRU)D:
                string sqlCom = "DELETE FROM Kunde WHERE KiD = '" + intKiD + "'";
                string sqlCom2 = "DELETE FROM Bolig WHERE KiD = '" + intKiD + "'";
                string sqlCom3 = "DELETE FROM Bolig_Status WHERE KiD = '" + intKiD + "'";


                SqlCommand cmd = new SqlCommand(sqlCom, conn);
                SqlCommand cmd2 = new SqlCommand(sqlCom2, conn);
                SqlCommand cmd3 = new SqlCommand(sqlCom3, conn);

                //cmd.Parameters.Add("@KiD", System.Data.SqlDbType.Int);
                //cmd.Parameters["@KiD"].Value = Convert.ToInt32(KiD);

                // Attempt to execute query

                conn.Open();
                cmd3.ExecuteReader();
                conn.Close();

                conn.Open();
                cmd2.ExecuteReader();
                conn.Close();

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                //MessageBox.Show("SUCCESS :\n" + sqlCom + "\nmed værdierne: (" +
                //                cmd.Parameters["@KiD"].Value + ")");
                tbKiD.Text = "";
                UpdateData.updateGridView("SELECT * FROM Kunde", dataGridView1);

            }
            else
                MessageBox.Show("Indtast kun heltal.");
            tbKiD.Text = "";

            UpdateData.updateGridView("SELECT * FROM Kunde", dataGridView1);

        }

        private void deleteKiD_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Indtast kunde ID på den kunde der ønskes slettet", deleteKiD);
        }
    }
}
