using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W04
{
    public class UserAccount:User
    {
        private string userName;
        internal int userId;


        protected int Roles  { get; set; }


        private void LogIn()
        {
            userName = "";
            Method1();
            Method2();
        }
        protected internal void LogLogOut()
        {
            userName = "asd";
            
        }


    }

    public class User
    {
        internal  string applicationName;

        protected void Method1()
        {

        }

        protected internal void Method2()
        {

        }
    }
}
