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

namespace RealBolig
{
    public partial class ReadMægler : Form
    {
        public ReadMægler()
        {
            InitializeComponent();
        }

        private void ReadMægler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kaspermark_dk_db_realboligDataSet1.Bolig_Status' table. You can move, or remove it, as needed.
            this.bolig_StatusTableAdapter.Fill(this.kaspermark_dk_db_realboligDataSet1.Bolig_Status);
            // TODO: This line of code loads data into the 'kaspermark_dk_db_realboligDataSet3.Ejendomsmægler' table. You can move, or remove it, as needed.
            this.ejendomsmæglerTableAdapter.Fill(this.kaspermark_dk_db_realboligDataSet3.Ejendomsmægler);

        }
    }
}
