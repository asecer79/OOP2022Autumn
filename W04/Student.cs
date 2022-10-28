using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W04
{
    //class definition  for a student entity
    public class Student //pascal case notation
    {
        #region 01-constructor method members

        //default constructor
        public Student()
        {
            Console.WriteLine("Default Constructor Executed");
        }

        //overloaded constructor method members
        public Student(int id)
        {
            Id=id;
            Console.WriteLine("Student(int id) Constructor Executed");
        }

        public Student(int id, string fullName)
        {
            Id = id;
            FullName=fullName;

            Console.WriteLine("Student(int id, string fullName) Constructor Executed");
        }

        public Student(int id, string fullName,int age)
        {
            Id = id;
            FullName = fullName;
            Age=age;

            Console.WriteLine("Student(int id, string fullName) Constructor Executed");
        }

        #endregion

        #region 02-field members- stores informations of classes
        //public int id;//camel case
        //public string fullName; //camel case
        //public string departmentNameForStudent;//camel case notation
        //public StudentInfo studentInfo; //camel case

        #endregion

        #region 03-property members- stores informations of classes and permit us reaching and modifying them
        public int Id { get; set; } //pascal case
        public string FullName { get; set; }
        public StudentInfo StudentInfoData { get; set; }
        public int Age { get; set; }
        #endregion

        #region 04-method members - doing many different logic for class - Pascal Case

        public void WhatIsYourName()
        {
            Console.WriteLine(FullName);
        }
        public int HowOldAreYou()
        {
            return Age;
        }
        //......

        #endregion


    }
}
