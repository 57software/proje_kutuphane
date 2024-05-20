using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace proje_kutuphane
{
    public class Baglan
    {
        // Veritabanına bağlan
        public static string Bag
        {
            get
            {
                return "Server=localhost;Database=kutuphane;Uid=root;Pwd='';";
            }
        }
    }
}
