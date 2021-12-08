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
    public partial class CreateMægler : Form
    {
        public CreateMægler()
        {
            InitializeComponent();
        }

        private void CreateMægler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kaspermark_dk_db_realboligDataSet5.Ejendomsmægler' table. You can move, or remove it, as needed.
            this.ejendomsmæglerTableAdapter.Fill(this.kaspermark_dk_db_realboligDataSet5.Ejendomsmægler);

        }
    }
}
