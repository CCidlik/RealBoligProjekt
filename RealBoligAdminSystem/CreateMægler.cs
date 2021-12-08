using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RealBolig.DAL.Operations;
using RealBolig.DAL.Entities;

namespace RealBolig
{
    public partial class CreateMægler : Form
    {
        public CreateMægler()
        {
            InitializeComponent();
        }

        private void CreateMægler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kaspermark_dk_db_realboligDataSet3.Ejendomsmægler' table. You can move, or remove it, as needed.
            this.ejendomsmæglerTableAdapter.Fill(this.kaspermark_dk_db_realboligDataSet3.Ejendomsmægler);

        }

       /* private void btnOpretMægler_Click(object sender, EventArgs e)
        {
            string FuldeNavn = mFnavnTextBox.Text;
            string Tlf = mTlfTextBox.Text;
            string Mail = mMailTextBox.Text;

            EMælger mæ = new EMælger(FuldeNavn, Tlf, Mail);
            OMælger mæOP = new OMælger();

            mæOP.Insert(mæ);

            mFnavnTextBox.Text = "";
            mTlfTextBox.Text = "";
            mMailTextBox.Text = "";

        }*/

        private void btnOpretMægler_Click_1(object sender, EventArgs e)
        {
            string FuldeNavn = mFnavnTextBox.Text;
            string Tlf = mTlfTextBox.Text;
            string Mail = mMailTextBox.Text;

            EMælger mæ = new EMælger(FuldeNavn, Tlf, Mail);
            OMælger mæOP = new OMælger();

            mæOP.Insert(mæ);

            mFnavnTextBox.Text = "";
            mTlfTextBox.Text = "";
            mMailTextBox.Text = "";

            UpdateData.updateGridView("Select * FROM Ejendomsmægler", dataGridView1);

        }
    }
}
