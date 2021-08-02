using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    
    public class Users
    {
        public string UserID { get; set; }
        public string UserName { get; set; }
        public int DeptID { get; set; }
        public string Password { get; set; }
        public string Cellphone { get; set; }
        public int UserType { get; set; }
    }
}
