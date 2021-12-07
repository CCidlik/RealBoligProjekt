using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealBolig
{
    public static class ConnString
    {
        public static string getConnStr()
        {
            return "Data Source=mssql2.unoeuro.com;Initial Catalog=kaspermark_dk_db_realbolig;Persist Security Info=True;User ID=kaspermark_dk;Password=69qom3u9PW; Encrypt = False";
        }
    }
}
