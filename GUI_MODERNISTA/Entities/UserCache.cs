using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_PONTO.Entities
{
    public static class UserCache
    {
        //Usuario logado 
        public static int DBUserID { get; set; }
        public static string DBName { get; set; }
        public static string DBRe { get; set; }
        public static string DBPassword { get; set; }
        public static DateTime DBCreated { get; set; }
        public static int DBRoleID { get; set; }
        public static string DBroleName { get; set; }

    }
}
