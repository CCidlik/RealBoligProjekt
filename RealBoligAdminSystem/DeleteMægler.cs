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
    public partial class DeleteMægler : Form
    {
        public DeleteMægler()
        {
            InitializeComponent();
        }
        private void DeleteMægler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kaspermark_dk_db_realboligDataSet3.Ejendomsmægler' table. You can move, or remove it, as needed.
            this.ejendomsmæglerTableAdapter.Fill(this.kaspermark_dk_db_realboligDataSet3.Ejendomsmægler);

        }



        private void deleteAiD_Click_1(object sender, EventArgs e)
        {
            
                string AiD = tbAiD.Text;
                int intAiD;

                // assumption:

                bool success = int.TryParse(AiD, out intAiD);

                // action
                if (success == true)
                {
                    intAiD = Convert.ToInt32(AiD);

                    // database med kundetabel:
                    SqlConnection conn = new SqlConnection(ConnString.getConnStr());

                    //(CRU)D:
                    string sqlCom = "DELETE FROM Ejendomsmægler WHERE AiD = '" + intAiD + "'";



                    SqlCommand cmd = new SqlCommand(sqlCom, conn);


                    //cmd.Parameters.Add("@KiD", System.Data.SqlDbType.Int);
                    //cmd.Parameters["@KiD"].Value = Convert.ToInt32(KiD);

                    // Attempt to execute query



                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    //MessageBox.Show("SUCCESS :\n" + sqlCom + "\nmed værdierne: (" +
                    //                cmd.Parameters["@KiD"].Value + ")");
                    tbAiD.Text = "";
                    UpdateData.updateGridView("SELECT * FROM Ejendomsmægler", dataGridView1);

                }
                else
                    MessageBox.Show("Indtast kun heltal.");
                tbAiD.Text = "";

                UpdateData.updateGridView("SELECT * FROM Ejendomsmælger", dataGridView1);

            

        }

        private void AiDdelete_Click(object sender, EventArgs e)
        {
            string AiD = tbAiD.Text;
            int intAiD;

            // assumption:

            bool success = int.TryParse(AiD, out intAiD);

            // action
            if (success == true)
            {
                intAiD = Convert.ToInt32(AiD);

                // database med kundetabel:
                SqlConnection conn = new SqlConnection(ConnString.getConnStr());

                //(CRU)D:
                string sqlCom = "DELETE FROM Ejendomsmægler WHERE AiD = '" + intAiD + "'";



                SqlCommand cmd = new SqlCommand(sqlCom, conn);


                //cmd.Parameters.Add("@KiD", System.Data.SqlDbType.Int);
                //cmd.Parameters["@KiD"].Value = Convert.ToInt32(KiD);

                // Attempt to execute query



                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                //MessageBox.Show("SUCCESS :\n" + sqlCom + "\nmed værdierne: (" +
                //                cmd.Parameters["@KiD"].Value + ")");
                tbAiD.Text = "";
                UpdateData.updateGridView("SELECT * FROM Ejendomsmægler", dataGridView1);

            }
            else
                MessageBox.Show("Indtast kun heltal.");
            tbAiD.Text = "";

            UpdateData.updateGridView("SELECT * FROM Ejendomsmægler", dataGridView1);
        }

        private void AiDdelete_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Indtast Mægler ID på den mægler du ønsker slettet", AiDdelete);
        }
    }
}
