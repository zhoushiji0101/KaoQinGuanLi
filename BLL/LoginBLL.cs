using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoginBLL
    {
        LoginDAL l = new LoginDAL();
        public int login(string username, string userpwd)
        {
            return l.login(username, userpwd);
        }
    }
}
