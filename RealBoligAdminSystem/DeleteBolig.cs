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
            this.boligTableAdapter.Fill(this.kaspermark_dk_db_realboligDataSet.Bolig);
        }

        private void btnSletBolig_Click(object sender, EventArgs e)
        {
            string BiD = mBoligIDTextBox.Text;
            int intBiD;

            // assumption:

            bool success = int.TryParse(BiD, out intBiD);

            // action
            if (success == true)
            {
                intBiD = Convert.ToInt32(BiD);

                // database med kundetabel:
                SqlConnection conn = new SqlConnection(ConnString.getConnStr());

                //(CRU)D:
                string sqlCom = "DELETE FROM Bolig WHERE BiD = '" + intBiD + "'";
                string sqlCom2 = "DELETE FROM Bolig_Status WHERE BiD = '" + intBiD + "'";

                SqlCommand cmd = new SqlCommand(sqlCom, conn);
                SqlCommand cmd2 = new SqlCommand(sqlCom2, conn);
                cmd.Parameters.Add("@BiD", System.Data.SqlDbType.Int);
                cmd.Parameters["@BiD"].Value = Convert.ToInt32(BiD);

                // Attempt to execute query
                conn.Open();
                cmd2.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("SUCCESS :\n" + sqlCom + "\nmed værdierne: (" +
                                cmd.Parameters["@BiD"].Value + ")");
                mBoligIDTextBox.Text = "";
                UpdateData.updateGridView("SELECT * FROM Bolig", dataGridView1);

            }
            else
                MessageBox.Show("Indtast kun heltal.");
            mBoligIDTextBox.Text = "";
            
            UpdateData.updateGridView("SELECT * FROM Bolig", dataGridView1);
            

        }

        private void btnSletBolig_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Indtast ID på den bolig som du ønsker at slette", btnSletBolig);
        }
    }


}
