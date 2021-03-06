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
using System.IO;

namespace RealBolig
{
    public partial class ReadBolig : Form
    {

        public ReadBolig()
        {
            InitializeComponent();
        }

        private void ReadBolig_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kaspermark_dk_db_realboligDataSet.Bolig' table. You can move, or remove it, as needed.
            this.boligTableAdapter.Fill(this.kaspermark_dk_db_realboligDataSet.Bolig);

        }

        private void btnIndlæsBolig_Click(object sender, EventArgs e)
        {

            if (tbPostnummer.Text != "")
            {
                DisplayDataPostnummer();
            }
            
            else if (tbOmråde.Text != "")
            {
                DisplayDataOmråde();
            }

            else if (radioBtnSolgt.Checked == true)
            {
                SolgtChecked();
            }

            else if (radioBtnSalg.Checked == true)
            {
                TilSalgChecked();
            }

            else if (radioBtnAll.Checked == true)
            {
                AllChecked();
            }

        }

        //Click event method, som refresher dataGridViev, sletter indholdet i tekstboksene og unchecker radioknapperne
        private void BtnRefreshBoligSøg_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnString.getConnStr());

            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Bolig", conn);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
                tbOmråde.Text = "";
                tbPostnummer.Text = "";
                textFraDato.Text = "";
                textFraPris.Text = "";
                radioBtnSolgt.Checked = false;
                radioBtnSalg.Checked = false;
                radioBtnAll.Checked = false;
            }

            catch (Exception exc)
            {
                MessageBox.Show("ERROR: \n\n" + exc.ToString());
                tbOmråde.Text = "";
                tbPostnummer.Text = "";
                textFraDato.Text = "";
                textFraPris.Text = "";
                radioBtnSolgt.Checked = false;
                radioBtnSalg.Checked = false;
                radioBtnAll.Checked = false;
            }
        }

        #region Søg bolig metoder baseret på område eller postnummer
            //Metode der filtrer dataGridView baseret på område.
            public void DisplayDataOmråde()
            {
                //Laver nyt connection objekt
                SqlConnection conn = new SqlConnection(ConnString.getConnStr());

                //try-catch. Funktion der filtrer dataGridView baseret på område
                try
                {
                    conn.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Bolig WHERE Område LIKE '%" + tbOmråde.Text + "%'", conn);
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }

                catch (Exception exc)
                {
                    MessageBox.Show("ERROR: \n\n" + exc.ToString());
                    tbOmråde.Text = "";
                }
            }

            //Metode der filtrer dataGridView baseret på postnummer
            public void DisplayDataPostnummer()
            {
                SqlConnection conn = new SqlConnection(ConnString.getConnStr());

                try
                {
                    conn.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Bolig where PostNR = '" + tbPostnummer.Text + "'", conn);
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }

                catch (Exception exc)
                {
                    MessageBox.Show("ERROR: \n\n" + exc.ToString());
                    tbPostnummer.Text = "";
                }
                
            }
        #endregion

        #region Metoder som opfylder opgave 3.2.
            //Metode til første halvdel af opg. 3.2. Udskriver data omkring huse til salg, til en .txt fil
            private void BtnUdprintHuseTilSalg_Click(object sender, EventArgs e)
            {
                SqlConnection conn = new SqlConnection(ConnString.getConnStr());

                try
                {
                    conn.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Bolig WHERE Solgt = 0", conn);
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }

                catch (Exception exc)
                {
                    MessageBox.Show("ERROR: \n\n" + exc.ToString());

                }

                //Tildeler computerens navn en variabel, så print funktionen kan virke på de fleste computere.
                string userName = Environment.UserName;

                //Definere stien som .txt filerne skal gemmes i.
                string path = $@"C:\Users\{userName}\Documents\BoligData";

                try
                {
                    if (Directory.Exists(path)) //Checker om BoligData mappen existere.
                    {
                        using (TextWriter tw = new StreamWriter(path + "\\AlleHuseTilSalg.txt"))
                        {
                            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                            {
                                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                                {
                                    tw.Write($"{dataGridView1.Rows[i].Cells[j].Value.ToString()}");

                                    if (j != dataGridView1.Columns.Count - 1)
                                    {
                                        tw.Write("  :  ");
                                    }
                                }
                                tw.WriteLine();
                            }
                        }
                    }

                    //Hvis BoligData ikke eksistere, så laves den her før .txt filen laves.
                    else
                    {
                        DirectoryInfo di = Directory.CreateDirectory(path);
                        using (TextWriter tw = new StreamWriter(path + "\\AlleHuseTilSalg.txt"))
                        {
                            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                            {
                                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                                {
                                    tw.Write($"{dataGridView1.Rows[i].Cells[j].Value.ToString()}");

                                    if (j != dataGridView1.Columns.Count - 1)
                                    {
                                        tw.Write("  :  ");
                                    }
                                }
                                tw.WriteLine();
                            }
                        }
                    }
                }

                catch (Exception exc)
                {
                    MessageBox.Show("ERROR: \n\n" + exc.ToString());
                }
            }

            //Metode til anden halvdel af opg. 3.2. Udskriver data omkring alle huse i et bestemt område, til en .txt fil
            private void BtnUdskrivData_Click(object sender, EventArgs e)
            {
                //Denne metode gør det samme som BtnUdprintHuseTilSalg_Click, men her er det baseret på område
                SqlConnection conn = new SqlConnection(ConnString.getConnStr());

                try
                {
                    conn.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Bolig WHERE Område LIKE '%" + tbOmråde.Text + "%'", conn);
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }

                catch (Exception exc)
                {
                    MessageBox.Show("ERROR: \n\n" + exc.ToString());

                }

                string userName = Environment.UserName;
                string path = $@"C:\Users\{userName}\Documents\BoligData";

                try
                {
                    if (Directory.Exists(path))
                    {
                        using (TextWriter tw = new StreamWriter(path + "\\AlleHuseIOmråde.txt"))
                        {
                            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                            {
                                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                                {
                                    tw.Write($"{dataGridView1.Rows[i].Cells[j].Value.ToString()}");

                                    if (j != dataGridView1.Columns.Count - 1)
                                    {
                                        tw.Write("  :  ");
                                    }
                                }
                                tw.WriteLine();
                            }
                        }
                    }

                    else
                    {
                        DirectoryInfo di = Directory.CreateDirectory(path);
                        using (TextWriter tw = new StreamWriter(path + "\\AlleHuseIOmråde.txt"))
                        {
                            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                            {
                                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                                {
                                    tw.Write($"{dataGridView1.Rows[i].Cells[j].Value.ToString()}");

                                    if (j != dataGridView1.Columns.Count - 1)
                                    {
                                        tw.Write("  :  ");
                                    }
                                }
                                tw.WriteLine();
                            }
                        }
                    }
                }

                catch (Exception exc)
                {
                    MessageBox.Show("ERROR: \n\n" + exc.ToString());
                }
            }
        #endregion

        #region Metoder der er med til at opfylde anden del af opgave 3.2.
        //Metoderne autofiltrer dataGridView mens der skrives og refresher den, når "Område" tekstboksen er tom
            private void tbOmråde_TextChanged(object sender, EventArgs e)
            {
                if (tbOmråde.Text != "")
                {
                    DisplayDataOmråde();
                }

                else
                {
                    RefreshDGV();
                }
            }

            public void RefreshDGV()
            {
                SqlConnection conn = new SqlConnection(ConnString.getConnStr());

                try
                {
                    conn.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Bolig", conn);
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }

                catch (Exception exc)
                {
                    MessageBox.Show("ERROR: \n\n" + exc.ToString());
                    tbOmråde.Text = "";
                }
            }
        #endregion

        #region Metoder der som minimum opfylder opgave 3.3
            
        //Metode der tager højde for de forskellige kombinationer med solgte boliger + startdato og/eller minimumspris
            public void SolgtChecked()
            {
                //Sætter connection objekt
                SqlConnection conn = new SqlConnection(ConnString.getConnStr());
                
                //Definere fra pris tekstboksen
                string SalgsPris = textFraPris.Text;
                
                //Tager dato og tid for dagen i dag og kører substring på outputtet, så datoen er i et format som databasen acceptere
                DateTime idag = DateTime.Now;
                string Sidag = Convert.ToString(idag);
                string S2idag = $"{Sidag.Substring(6, 4)}-{Sidag.Substring(3, 2)}-{Sidag.Substring(0, 2)}";
                
                //Hvis FraPris tekstboksen er tom.
                if (textFraDato.Text != "" && textFraPris.Text == "")
                {
                    string SalgsDato = textFraDato.Text;
                    string SalgsDato2 = $"{SalgsDato.Substring(4, 4)}-{SalgsDato.Substring(2, 2)}-{SalgsDato.Substring(0, 2)}";
                    conn.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapt = new SqlDataAdapter($"SELECT BiD, KiD, Adresse, SalgsPris, SalgsDato, Solgt FROM Bolig WHERE (SalgsDato BETWEEN '{SalgsDato2}' AND '{S2idag}') AND Solgt = 1", conn);
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }

                //Hvis FraDato tekstboksen er tom
                else if (textFraDato.Text == "" && textFraPris.Text != "")
                {
                    conn.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapt = new SqlDataAdapter($"SELECT BiD, KiD, Adresse, SalgsPris, SalgsDato, Solgt FROM Bolig WHERE SalgsPris >= {SalgsPris} AND Solgt = 1", conn);
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }

                //Hvis hverken af tekstboksene er tomme
                else if (textFraDato.Text != "" && textFraPris.Text != "")
                {
                    string SalgsDato = textFraDato.Text;
                    string SalgsDato2 = $"{SalgsDato.Substring(4, 4)}-{SalgsDato.Substring(2, 2)}-{SalgsDato.Substring(0, 2)}";
                    conn.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapt = new SqlDataAdapter($"SELECT BiD, KiD, Adresse, SalgsPris, SalgsDato, Solgt FROM Bolig WHERE (SalgsDato BETWEEN '{SalgsDato2}' AND '{S2idag}') AND SalgsPris >= {SalgsPris} AND Solgt = 1", conn);
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }

                //Hvis begge tekstbokse er tomme
                else if (textFraDato.Text == "" && textFraPris.Text == "")
                {
                    conn.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapt = new SqlDataAdapter($"SELECT BiD, KiD, Adresse, SalgsPris, SalgsDato, Solgt FROM Bolig WHERE Solgt = 1", conn);
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }

            }

        //Metode der tager højde for de forskellige kombinationer med til salg boliger + startdato og/eller minimumspris
            public void TilSalgChecked()
            {
                //Samme som SolgtChecked(), men nu med boliger til salg i stedet for
                SqlConnection conn = new SqlConnection(ConnString.getConnStr());

                string SalgsPris = textFraPris.Text;

                DateTime idag = DateTime.Now;
                string Sidag = Convert.ToString(idag);
                string S2idag = $"{Sidag.Substring(6, 4)}-{Sidag.Substring(3, 2)}-{Sidag.Substring(0, 2)}";

                if (textFraDato.Text != "" && textFraPris.Text == "")
                {
                    string SalgsDato = textFraDato.Text;
                    string SalgsDato2 = $"{SalgsDato.Substring(4, 4)}-{SalgsDato.Substring(2, 2)}-{SalgsDato.Substring(0, 2)}";
                    conn.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapt = new SqlDataAdapter($"SELECT BiD, KiD, Adresse, SalgsPris, SalgsDato, Solgt FROM Bolig WHERE (SalgsDato BETWEEN '{SalgsDato2}' AND '{S2idag}') AND Solgt = 0", conn);
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }

                else if (textFraDato.Text == "" && textFraPris.Text != "")
                {
                    conn.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapt = new SqlDataAdapter($"SELECT BiD, KiD, Adresse, SalgsPris, SalgsDato, Solgt FROM Bolig WHERE SalgsPris >= {SalgsPris} AND Solgt = 0", conn);
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }

                else if (textFraDato.Text != "" && textFraPris.Text != "")
                {
                    string SalgsDato = textFraDato.Text;
                    string SalgsDato2 = $"{SalgsDato.Substring(4, 4)}-{SalgsDato.Substring(2, 2)}-{SalgsDato.Substring(0, 2)}";
                    conn.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapt = new SqlDataAdapter($"SELECT BiD, KiD, Adresse, SalgsPris, SalgsDato, Solgt FROM Bolig WHERE (SalgsDato BETWEEN '{SalgsDato2}' AND '{S2idag}') AND SalgsPris >= {SalgsPris} AND Solgt = 0", conn);
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }

                else if (textFraDato.Text == "" && textFraPris.Text == "")
                {
                    conn.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapt = new SqlDataAdapter($"SELECT BiD, KiD, Adresse, SalgsPris, SalgsDato, Solgt FROM Bolig WHERE Solgt = 0", conn);
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
            }

        //Metode der tager højde for de forskellige kombinationer med alle boliger +  startdato og/eller minimumspris
            public void AllChecked()
            {
                //Samme som SolgtChecked(), men nu også med boliger til salg
                SqlConnection conn = new SqlConnection(ConnString.getConnStr());

                string SalgsPris = textFraPris.Text;

                DateTime idag = DateTime.Now;
                string Sidag = Convert.ToString(idag);
                string S2idag = $"{Sidag.Substring(6, 4)}-{Sidag.Substring(3, 2)}-{Sidag.Substring(0, 2)}";

                if (textFraDato.Text != "" && textFraPris.Text == "")
                {
                    string SalgsDato = textFraDato.Text;
                    string SalgsDato2 = $"{SalgsDato.Substring(4, 4)}-{SalgsDato.Substring(2, 2)}-{SalgsDato.Substring(0, 2)}";
                    conn.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapt = new SqlDataAdapter($"SELECT BiD, KiD, Adresse, SalgsPris, SalgsDato, Solgt FROM Bolig WHERE (SalgsDato BETWEEN '{SalgsDato2}' AND '{S2idag}')", conn);
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }

                else if (textFraDato.Text == "" && textFraPris.Text != "")
                {
                    conn.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapt = new SqlDataAdapter($"SELECT BiD, KiD, Adresse, SalgsPris, SalgsDato, Solgt FROM Bolig WHERE SalgsPris >= {SalgsPris}", conn);
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }

                else if (textFraDato.Text != "" && textFraPris.Text != "")
                {
                    string SalgsDato = textFraDato.Text;
                    string SalgsDato2 = $"{SalgsDato.Substring(4, 4)}-{SalgsDato.Substring(2, 2)}-{SalgsDato.Substring(0, 2)}";
                    conn.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapt = new SqlDataAdapter($"SELECT BiD, KiD, Adresse, SalgsPris, SalgsDato, Solgt FROM Bolig WHERE (SalgsDato BETWEEN '{SalgsDato2}' AND '{S2idag}') AND SalgsPris >= {SalgsPris}", conn);
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }

                else if (textFraDato.Text == "" && textFraPris.Text == "")
                {
                    conn.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapt = new SqlDataAdapter($"SELECT BiD, KiD, Adresse, SalgsPris, SalgsDato, Solgt FROM Bolig", conn);
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
            }
        #endregion

        //MouseHover event der fortæller brugeren hvad de skal gøre
        private void btnIndlæsBolig_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Indtast et postnummer", btnIndlæsBolig);
        }
    }
}
