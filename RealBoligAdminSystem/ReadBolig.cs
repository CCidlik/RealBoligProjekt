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

        public void DisplayDataOmråde()
        {


            SqlConnection conn = new SqlConnection(ConnString.getConnStr());


            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Bolig where Område = '" + tbOmråde.Text + "'", conn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        public void DisplayDataPostnummer()
        {


            SqlConnection conn = new SqlConnection(ConnString.getConnStr());


            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Bolig where PostNR = '" + tbPostnummer.Text + "'", conn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

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

            string userName = Environment.UserName;
            string path = $@"C:\Users\{userName}\Documents\BoligData";

            try
            {
                if(Directory.Exists(path))
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

                DirectoryInfo di = Directory.CreateDirectory(path);
            }

            catch(Exception exc)
            {
                MessageBox.Show("ERROR: \n\n" + exc.ToString());
            }

            using (TextWriter tw = new StreamWriter(path+"\\AlleHuseTilSalg.txt"))
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

        private void BtnUdskrivData_Click(object sender, EventArgs e)
        {
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

                DirectoryInfo di = Directory.CreateDirectory(path);
            }

            catch (Exception exc)
            {
                MessageBox.Show("ERROR: \n\n" + exc.ToString());
            }

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

        private void tbOmråde_TextChanged(object sender, EventArgs e)
        {
            if (tbOmråde.Text != "")
            {
                DisplayOmråde();
            }

            else
            {
                RefreshDGV();
            }
        }

        public void DisplayOmråde()
        {
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
                tbOmråde.Text = "";
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

        public void SolgtChecked()
        {
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
                SqlDataAdapter adapt = new SqlDataAdapter($"SELECT BiD, KiD, Adresse, SalgsPris, SalgsDato, Solgt FROM Bolig WHERE (SalgsDato BETWEEN '{SalgsDato2}' AND '{S2idag}') AND Solgt = 1", conn);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }

            else if (textFraDato.Text == "" && textFraPris.Text != "")
            {
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter($"SELECT BiD, KiD, Adresse, SalgsPris, SalgsDato, Solgt FROM Bolig WHERE SalgsPris >= {SalgsPris} AND Solgt = 1", conn);
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
                SqlDataAdapter adapt = new SqlDataAdapter($"SELECT BiD, KiD, Adresse, SalgsPris, SalgsDato, Solgt FROM Bolig WHERE (SalgsDato BETWEEN '{SalgsDato2}' AND '{S2idag}') AND SalgsPris >= {SalgsPris} AND Solgt = 1", conn);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }

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

        public void TilSalgChecked()
        {
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

        public void AllChecked()
        {
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

        private void btnIndlæsBolig_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Indtast et postnummer", btnIndlæsBolig);
        }
    }
}
