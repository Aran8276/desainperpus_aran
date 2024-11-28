using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desainperpus_aran
{
    internal class Koneksi
    {
        public static string conn = "" +
            "Data Source = ARAN\\SQLEXPRESS; " +
            "Initial Catalog = aran_demo_perpusdb; " +
            "Integrated Security = True; " +
            "TrustServerCertificate = True; ";
    }

    public class Model
    {
        public static string name { get; set; }

        public static string id { get; set; }
    }
}
