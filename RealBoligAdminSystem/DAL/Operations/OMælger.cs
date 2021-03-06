using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealBolig.DAL.Entities;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RealBolig.DAL.Operations
{
    class OMælger
    {

        SqlConnection conn = new SqlConnection(ConnString.getConnStr());

        //CRUD
        public void Insert(EMælger mInsert)
        {
            // assumption:
            bool FuldeNavn_ok = true, Tlf_ok = true, Mail_ok = true;

            // length check:
            if (mInsert.FuldeNavn.Length > 51) FuldeNavn_ok = false;
            if (mInsert.Tlf.Length > 9) Tlf_ok = false;
            if (mInsert.Mail.Length > 51) Mail_ok = false;

            // Check for alphanumeric characters
            Regex retal = new Regex(@"(^[0-9 ]*$)");
            if (!retal.IsMatch(mInsert.Tlf)) Tlf_ok = false;

            // action
            if (FuldeNavn_ok && Tlf_ok && Mail_ok)
            {
                // database med bolig tabel:
                SqlConnection conn = new SqlConnection(ConnString.getConnStr());

                //C(RUD):
                string sqlCom = "INSERT INTO Ejendomsmægler VALUES (@FuldeNavn, @Tlf, @Mail);";
                SqlCommand cmd = new SqlCommand(sqlCom, conn);

                cmd.Parameters.Add("@FuldeNavn", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@FuldeNavn"].Value = Convert.ToString(mInsert.FuldeNavn);

                cmd.Parameters.Add("@Tlf", System.Data.SqlDbType.Int);
                cmd.Parameters["@Tlf"].Value = Convert.ToInt32(mInsert.Tlf);

                cmd.Parameters.Add("@Mail", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@Mail"].Value = Convert.ToString(mInsert.Mail);

                // Attempt to execute query
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("SUCCESS :\n" + sqlCom + "\nmed værdierne: (" +
                                    cmd.Parameters["@FuldeNavn"].Value + ", " +
                                    cmd.Parameters["@Tlf"].Value + ", " +
                                    cmd.Parameters["@Mail"].Value + ", " +
                                    ")");

                }
                catch (Exception exc)
                {
                    MessageBox.Show("ERROR: \n\n" + exc.ToString());

                }
            }
            else if (!FuldeNavn_ok)
            {
                MessageBox.Show("Der må maks være 50 tegn i Fulde Navn feltet.");

            }

            else if (!Tlf_ok)
            {
                MessageBox.Show("Der må kun indtastes tal i Tlf. feltet, samt maks 8 tegn.");

            }

            else if (!Mail_ok)
            {
                MessageBox.Show("Der må maks være 50 tegn i E-Mail feltet.");

            }

        }

    }

}
