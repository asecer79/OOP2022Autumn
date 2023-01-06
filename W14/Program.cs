using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace W14
{

    class Program
    {
        static void Main(string[] args)
        {
            //Type type= typeof(Student);

            //var fields = type.GetFields();
            //foreach (var field in fields)
            //{
            //    Console.WriteLine(field.Name);
            //}

            //var props = type.GetProperties();
            //foreach (var prop in props)
            //{
            //    Console.WriteLine(prop.Name);
            //}

            //var methods = type.GetMethods();
            //foreach (var method in methods)
            //{
            //    Console.WriteLine(method.Name);
            //}

            //var constructors = type.GetConstructors();
            //foreach (var constructor in constructors)
            //{
            //    Console.WriteLine(constructor.Name);
            //}

            //var student = Activator.CreateInstance(typeof(Student));

            var student = new Student()
            {
                FullName = "Ahmet",
                City = "Ankara",
                Id = 1,
                age = 32
            };

            foreach (var prop in student.GetType().GetProperties())
            {
                Console.WriteLine(prop.GetValue(student));
            }

            student.GetType().GetProperty("Id").SetValue(student,2);

            foreach (var prop in student.GetType().GetProperties())
            {
                Console.WriteLine(prop.GetValue(student));
            }

            //var res1 = student.GetType().GetProperty("FullName").GetValue(student);

            //Console.WriteLine(res1);



            //foreach (var member in student.GetType().GetMethods(
            //             BindingFlags.NonPublic| 
            //             BindingFlags.Instance|
            //             BindingFlags.Public

            //         ).Where(p => p.Name.StartsWith("Met")))
            //{
            //    Console.WriteLine(member.Name);
            //    //member.Invoke(member, null);
            //}

            // var m1 = student.GetType().GetMethod("Method1");
            //m1.Invoke(student,null);

        }
    }


    class Student
    {
        public Student()
        {

        }

        public Student(int id)
        {
            Id = id;
        }

        public int age;

        public int Id { get; set; }

        public string FullName { get; set; }

        public string City { get; set; }

        public string WhatIsYourName()
        {
            return FullName;

        }

        public void Method1()
        {
            Console.WriteLine("Method1");
        }

        public void Method2()
        {
            Console.WriteLine("Method2");
        }

        private void Method3()
        {
            Console.WriteLine("Method3");
        }
    }
};

