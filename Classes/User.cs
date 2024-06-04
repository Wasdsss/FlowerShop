using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.CLasses
{
    internal class User
    {
        public static int UserId { get; set; }
        public static int UserRoleId { get; set; }
        public static string UserSurname { get; set; }
        public static string UserName { get; set; }
        public static string UserPatronymic { get; set; }

        public static void InitializeUser(SqlDataReader reader)
        {
            UserId = reader.GetInt32(0);
            UserRoleId = reader.GetInt32(1);
            UserSurname = reader.GetString(2);
            UserName = reader.GetString(3);
            UserPatronymic = reader.GetString(4);
        }
    }
}
