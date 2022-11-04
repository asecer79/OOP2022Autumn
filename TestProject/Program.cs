
using W04;

namespace TestAssembly
{

    class Program
    {
        static void Main(string[] args)
        {
            UserAccount user = new UserAccount();
            //user.userId = 1;
            //user.userName = "assa";
            //user.LogIn();
            //user.applicationName;
            //user.Roles=3;
            //user.Method1();
            //user.Method2();
            //user.LogLogOut();
        }
    }

    public class TestClass : UserAccount
    {

        public TestClass()
        {
            //base.userId = 1;
            //base.userName = "assa";
            //base.LogIn();
            base.Method1();
            base.Method2();
            base.LogLogOut();
        }
    }
}

