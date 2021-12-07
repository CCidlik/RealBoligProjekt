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

namespace RealBolig
{
    public partial class DeleteBolig : Form
    {

        private const bool test = false;

        public DeleteBolig()
        {
            InitializeComponent();
        }

        private void DeleteBolig_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kaspermark_dk_db_realboligDataSet4.Bolig' table. You can move, or remove it, as needed.
            this.boligTableAdapter1.Fill(this.kaspermark_dk_db_realboligDataSet4.Bolig);
            // TODO: This line of code loads data into the 'kaspermark_dk_db_realboligDataSet.Bolig' table. You can move, or remove it, as needed.
            this.boligTableAdapter.Fill(this.kaspermark_dk_db_realboligDataSet.Bolig);

        }

        private void btnSletBolig_Click(object sender, EventArgs e)
        {
            string BiD = mBoligIDTextBox.Text;
            int intBiD;

            // assumption:
            bool BiD_ok = true;

            bool success = int.TryParse(BiD, out intBiD);

            // action
            if (success == true)
            {
                intBiD = Convert.ToInt32(BiD);

                // database med kundetabel:
                SqlConnection conn = new SqlConnection(ConnString.getConnStr());

                //(CRU)D:
                string sqlCom = "DELETE FROM Bolig WHERE BiD = '" + intBiD + "'";

                /*
                    Hvis man siger       string sqlCom = "DELETE FROM Bolig_Status WHERE BiD = '"+intBiD+"'";
                køre programmet og sletter fx 15, så siger den success men den er ikke slettet...

                Hvis man så efter køre dette:      string sqlCom = "DELETE FROM Bolig WHERE BiD = '"+intBiD+"'";
                og indtaster samme BiD, så bliver den slette. Jeg fatter hat. 
                
                 */

                SqlCommand cmd = new SqlCommand(sqlCom, conn);
                cmd.Parameters.Add("@BiD", System.Data.SqlDbType.Int);
                cmd.Parameters["@BiD"].Value = Convert.ToInt32(BiD);

                // Attempt to execute query


                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("SUCCESS :\n" + sqlCom + "\nmed værdierne: (" +
                                cmd.Parameters["@BiD"].Value + ")");
                mBoligIDTextBox.Text = "";
                this.boligTableAdapter.Fill(this.kaspermark_dk_db_realboligDataSet.Bolig);





            }
            else
                MessageBox.Show("Indtast kun heltal.");
            mBoligIDTextBox.Text = "";
        }
    }


}
