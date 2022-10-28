
//namespace
namespace W04
{

    //class
    class Program
    {
        //field members
        private static int a = 1;

        //method member
        static void Main(string[] args)
        {


            #region Creating object/instance from a class

            //datatype   objectName/objectReference/instance     object/instance creator keyword        datatype    defaultConstructor method
            //Student    student                                 = new                                  Student            ()                  ;

            //Student student = new Student();  creating an object/creating an instance
            //Student student = new();

            //Student student = new();
            //var student = new Student();

            //Student student;
            //Student student = new Student();
            #endregion

            #region Reaching and modifying class members from the object

            //var student = new Student();

            ////modifying/setting class property members/set operations
            //student.Id = 1;
            //student.FullName = "Aydın";
            //student.Age = 40;

            ////reading class members/ get operations
            //Console.WriteLine($"{student.Id} {student.FullName} {student.Age}");


            ////direct initialization of an object from the class
            //var student2 = new Student()
            //{
            //    Id = 1,
            //    FullName = "Ahmet",
            //    Age = 36,
            //    StudentInfoData = new StudentInfo(),
            //};



            #endregion

            #region Constructor methods
            ////overloaded constructors
            //var student0 = new Student();//default
            //var student1 = new Student(2);//overloaded
            //var student2 = new Student(2, fullName: "Aydın");//overloaded
            //var student3 = new Student(2, fullName: "Aydın", 40);//overloaded
            #endregion

            #region Static and instance members

            //var user1 = new WebSiteUserInfo()
            //{
            //    UserName = "Ahmet",
            //    UserRights =new [] {"Admin","Write","Read"},

            //};
            //user1.LogIn();

            //var user2 = new WebSiteUserInfo()
            //{
            //    UserName = "Ayşe",
            //    UserRights = new[] { "Admin", "Write", "Read" },

            //};
            //user2.LogIn();

            //var user3 = new WebSiteUserInfo()
            //{
            //    UserName = "Ayşe",
            //    UserRights = new[] { "Admin", "Write", "Read" },

            //};
            //user3.LogIn();

            //user1.LogOut();




            #endregion

            #region Puclic Access Modifiers

            var userAccount = new UserAccount();
            userAccount.userId = 1;
            userAccount.applicationName = "22";
            userAccount.userName = "asd";
            userAccount.LogIn();
            userAccount.Roles = 1;
            userAccount.Method2();
            userAccount.LogLogOut();

            //userAccount.applicationName = "wdwqe";
            //userAccount.Method1();

            #endregion

        }
    }

    //keyword  class name/Camel Case syntax
    public class StudentInfo
    {

    }
}



