using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W04
{
    //static and instance members
    public class WebSiteUserInfo
    {

        //instance members
        public string UserName { get; set; } //this info can be seen only current logged user
        public string[] UserRights { get; set; } //this info can be seen only current logged user

        //static members
        public static int OnlineUsers { get; set; } = 0; //this info can be seen to everyone

        public void LogIn()
        {
            Console.WriteLine($"User {UserName} logged in...");
            OnlineUsers++;
            Console.WriteLine($"Total online Users now: {OnlineUsers}");

        }

        public void LogOut()
        {
            Console.WriteLine($"User {UserName} logged out...");
            OnlineUsers--;
            Console.WriteLine($"Total online Users now: {OnlineUsers}");

        }
    }
}
