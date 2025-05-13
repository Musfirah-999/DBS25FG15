using DB_finalproject.DL;
using DB_finalproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_finalproject.BL
{
    class UserBL
    {
        private UserDL userDL = new UserDL();
        public bool Login(UserModel user)
        {
            return userDL.Login(user);
        }
    }
}
