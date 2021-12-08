using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealBolig.DAL.Operations;

namespace RealBolig.DAL.Entities
{
    class EMælger
    {

        public int KiD { get; set; }
        public string FuldeNavn { get; set; }
        public string Tlf { get; set; }
        public string Mail { get; set; }


        public EMælger(string FuldeNavn, string Tlf, string Mail)
        {

            this.FuldeNavn = FuldeNavn;
            this.Tlf = Tlf;
            this.Mail = Mail;

        }
    }
}
