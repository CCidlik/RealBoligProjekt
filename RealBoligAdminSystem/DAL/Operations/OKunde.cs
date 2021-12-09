﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using RealBolig.DAL.Entities;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RealBolig.DAL.Operations
{
    public class OKunde
    {



        //CRUD
        public void Insert(EKunde kdInsert)
        {
            // assumption:
            bool FuldeNavn_ok = true, Tlf_ok = true, Mail_ok = true, Adresse_ok = true;

            // length check:
            if (kdInsert.FuldeNavn.Length > 51) FuldeNavn_ok = false;
            if (kdInsert.Tlf.Length > 9) Tlf_ok = false;
            if (kdInsert.Mail.Length > 51) Mail_ok = false;
            if (kdInsert.Adresse.Length > 76) Adresse_ok = false;

            // Check for alphanumeric characters
            Regex retal = new Regex(@"(^[0-9 ]*$)");
            if (!retal.IsMatch(kdInsert.Tlf)) Tlf_ok = false;

            // action
            if (FuldeNavn_ok && Tlf_ok && Mail_ok && Adresse_ok)
            {
                // database med bolig tabel:
                SqlConnection conn = new SqlConnection(ConnString.getConnStr());

                //C(RUD):
                string sqlCom = "INSERT INTO Kunde VALUES (@FuldeNavn, @Tlf, @Mail, @Adresse);";
                SqlCommand cmd = new SqlCommand(sqlCom, conn);

                cmd.Parameters.Add("@FuldeNavn", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@FuldeNavn"].Value = Convert.ToString(kdInsert.FuldeNavn);

                cmd.Parameters.Add("@Tlf", System.Data.SqlDbType.Int);
                cmd.Parameters["@Tlf"].Value = Convert.ToInt32(kdInsert.Tlf);

                cmd.Parameters.Add("@Mail", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@Mail"].Value = Convert.ToString(kdInsert.Mail);

                cmd.Parameters.Add("@Adresse", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@Adresse"].Value = Convert.ToString(kdInsert.Adresse);

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
                                    cmd.Parameters["@Adresse"].Value +
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

            else if (!Adresse_ok)
            {
                MessageBox.Show("Der må maks være 75 tegn i Adresse feltet.");

            }
        }


    }
}
