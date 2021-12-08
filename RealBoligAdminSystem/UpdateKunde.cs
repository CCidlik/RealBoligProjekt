using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealBolig
{
    public partial class UpdateKunde : Form
    {
        public UpdateKunde()
        {
            InitializeComponent();
        }

        private void UpdateKunde_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kaspermark_dk_db_realboligDataSet2.Kunde' table. You can move, or remove it, as needed.
            this.kundeTableAdapter.Fill(this.kaspermark_dk_db_realboligDataSet2.Kunde);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelTlf_Click(object sender, EventArgs e)
        {

        }


    }
}
