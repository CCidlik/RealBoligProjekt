using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace RealBolig
{
    public static class UpdateData
    {
        public static void updateGridView(string sql, DataGridView dg) {
            SqlConnection conn = new SqlConnection(ConnString.getConnStr());


            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(sql, conn);
            adapt.Fill(dt);
            dg.DataSource = dt;
            conn.Close();
        }
    }
}
