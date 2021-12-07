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
            // TODO: This line of code loads data into the 'kaspermark_dk_db_realboligDataSet3.Kunde' table. You can move, or remove it, as needed.
            this.kundeTableAdapter.Fill(this.kaspermark_dk_db_realboligDataSet3.Kunde);

        }

        private void deleteKiD_Click(object sender, EventArgs e)
        {
            string KiD = tbKiD.Text;

            // assumption:
            bool KiD_ok = true;

            // action
            if (KiD_ok)
            {
                // database med kundetabel:
                SqlConnection conn = new SqlConnection(ConnString.getConnStr());


                try
                {
                    Convert.ToInt32(KiD);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("ERROR: \n\n" + exc.ToString());
                    tbKiD.Text = "";
                }

                //(CRU)D:
                string sqlCom = "DELETE FROM Kunde WHERE KiD = " + KiD + ";";
                SqlCommand cmd = new SqlCommand(sqlCom, conn);
                cmd.Parameters.Add("@BiD", System.Data.SqlDbType.Int);
                cmd.Parameters["@BiD"].Value = Convert.ToInt32(KiD);

                // Attempt to execute query
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("SUCCESS :\n" + sqlCom + "\nmed værdierne: (" +
                                    cmd.Parameters["@BiD"].Value + ")");
                    tbKiD.Text = "";
                    this.kundeTableAdapter.Fill(this.kaspermark_dk_db_realboligDataSet3.Kunde);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("ERROR: \n\n" + exc.ToString());
                    tbKiD.Text = "";
                }
            }
            else
                MessageBox.Show("Indtast kun heltal.");
            tbKiD.Text = "";
        }
    }
}
