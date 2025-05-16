using DB_finalproject.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_finalproject.DL
{
    class UserDL
    {
        public bool Login(UserModel user)
        {
            string query = $@"
SELECT COUNT(*)
FROM (
SELECT name, password FROM pharmacist
UNION ALL
SELECT name, password FROM suppliers
UNION ALL
SELECT name, password FROM customers
) AS combined
WHERE name = '{user.Username}' AND password = '{user.Password}';
";

            int result = DatabaseHelper.Instance.Scaler(query);
            return result > 0;
        }

    }
}

