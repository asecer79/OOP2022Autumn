
namespace W04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(1);

            //Person person = new Person("Aydın", "Manager");

            //Programmer programmer = new Programmer("Ahmet","Team leader");
            //programmer.Eat();
            //programmer.Walk();
            //programmer.WriteProgram();

            //Dancer dancer = new Dancer("Arzu","First dancer");
            //dancer.Eat();
            //dancer.Walk();
            //dancer.Dance();

            //Singer singer = new Singer("Ali","Group leader",25);
            //singer.Eat();
            //singer.Walk();
            //singer.PlayGuitar();
            //singer.Sing();

            //Programmer programmer1 = new Programmer();
            //Programmer programmer2 = new Programmer("ayşegül", "Manager");
            //Programmer programmer3 = new Programmer("şaziye", "Manager",56);


            //Person person = new Person();
            //Console.WriteLine("************************************");

            //Programmer programmer = new Programmer();
            //Console.WriteLine("************************************");

            //Dancer dancer = new Dancer();
            //Console.WriteLine("************************************");

            //Singer singer = new Singer();
            //Console.WriteLine("************************************");

            //Singer singer2 = new Singer("Ayşegül","singer",25);
            //Console.WriteLine("************************************");


            //Professor professor = new Professor();

            //abstract classes can not be instantiated, we cannot create by new keyword....
            // MathOperations mathOperations = new MathOperations();

            Rectangle myMath = new Rectangle();
           myMath.Sum(1,4);

           Square square = new Square()
           {
               A = 5,
               B = 6,
           };
           square.GetArea();

        }
    }

    #region Inheritance

    //looks like gene inheritance in biology
    class Person
    {

        public Person()
        {
            Console.WriteLine("Person() constructor has been executed");
        }

        //overloaded 
        public Person(string name, string position)
        {
            Console.WriteLine("Person(string name, string position) constructor has been executed");

            Name = name;
            Position = position;
        }

        public Person(string name, string position, int age)
        {
            Console.WriteLine("Person(string name, string position, int age) constructor has been executed");
            Name = name;
            Position = position;
            Age = age;
        }

        public string Name { get; set; }
        public string Position { get; set; }
        public int Age { get; set; }

        //to support polymorphism : virtual
        public virtual void Walk()
        {
            Console.WriteLine("Person is walking...");
        }

        public virtual void Talk()
        {
            Console.WriteLine("Person is talking...");
        }

        public virtual void Eat()
        {
            Console.WriteLine("Person is eating...");
        }
    }

          //c# = derived:base,  java= child extends super
    class Programmer: Person//single inheritance
    {
        public Programmer()
        {
            this.Walk();
            base.Walk();
            Console.WriteLine("Programmer() constructor has been executed");
        }
        //pass mandatory constructor parameter to base constructor
        public Programmer(string name,string position):base(name,position)
        {
            Console.WriteLine("Programmer(string name,string position):base(name,position) constructor has been executed");
        }
        public Programmer(string name, string position,int age) : base(name, position,age)
        {
            Console.WriteLine("Programmer(string name, string position,int age) : base(name, position,age) constructor has been executed");
        }

        public string Company { get; set; }

        //completely discard inherited method/hides info comes from base class
        //not desired usage/ but possible to use it
        //public new void Walk()
        //{
        //    Console.WriteLine("Programmer is slowly walking...");
        //}

       // mutation / change of inherited props/ desired approach inherited props.
       //to support polymorphism : override
        public override void Walk()
        {
            Console.WriteLine("Programmer is slowly walking...");
        }

        public void WriteProgram()
        {
            Console.WriteLine("Programmer is writing code...");
        }
    }

    class Dancer:Person  //single inheritance
    {
        public Dancer()
        {
            Console.WriteLine("Dancer() constructor has been executed");
        }
        public Dancer(string name, string position) : base(name, position)
        {
            Console.WriteLine("Dancer(string name, string position) : base(name, position) constructor has been executed");
        }
        public Dancer(string name, string position, int age) : base(name, position, age)
        {
            Console.WriteLine("(string name, string position, int age) : base(name, position, age) constructor has been executed");
        }
        public string Group { get; set; }

        public void Dance()
        {
            Console.WriteLine("Dancer is dancing...");
        }
    }

    class Singer: Person//single inheritance
    {
        public Singer()
        {
            Console.WriteLine("Singer() constructor has been executed");
        }

        public Singer(string name, string position) : base(name, position)
        {
            Console.WriteLine("Singer(string name, string position) : base(name, position) constructor has been executed");
        }
        public Singer(string name, string position, int age) : base(name, position, age)
        {
            Console.WriteLine("Singer(string name, string position, int age) : base(name, position, age) constructor has been executed");
        }
        public string BandName { get; set; }

        public void Sing()
        {
            Console.WriteLine("Singer is singing...");
        }

        public void PlayGuitar()
        {
            Console.WriteLine("Singer is playing guitar...");
        }
    }

    class Academician:Person //single inheritance
    {
        public Academician()
        {
            Console.WriteLine("Academician() constructor has been executed");
        }
        public string Title { get; set; }
        public string Department { get; set; }

        public void Teach()
        {
            Console.WriteLine("Academician is teaching");
        }
    }

    class Professor:Academician // multi level inheritance
    {
        public Professor()
        {
            Console.WriteLine("Professor() constructor has been executed");
        }
    }

    class Lecturer : Academician // multi level inheritance
    {
        public Lecturer()
        {
            Console.WriteLine("Lecturer() constructor has been executed");
        }
    }


    class TopClass
    {

    }

    class A:TopClass
    {
        

    }

    class B:TopClass
    {
        
    }

    //does not support multiple inheritance
    //class C:A,B
    //{
    //    //
    //}
    #endregion

    #region Abstraction

    #region Abstract Classes

    //abstract class
    abstract class MathOperations
    {
        public double PI { get; set; } = 3.14;

        //abstract method/ is not concrete/ does not has body
        public abstract void GetArea();

        public abstract void Circumference();

        //concrete methods /that have their full body
        public void Sum(double a, double b)
        {
            //logic
            Console.WriteLine(a+b);
        }

        public void Divide(double a, double b)
        {
            Console.WriteLine(a/ b);
        }

    }
    //inheritance
    class Rectangle:MathOperations
    {
        public double A { get; set; }
        public double B { get; set; }

        //sealed freezes method overloading anymore in children classes
        public sealed override void GetArea()
        {
            Console.WriteLine(A*B);
        }

        public override void Circumference()
        {
            Console.WriteLine(2*(A+B));
        }
    }

    class Square:Rectangle
    {
        //cannot be overriden/ it is sealed
        //public override void GetArea()
        //{
        //    Console.WriteLine(A *A);
        //}

    }

    //math is concrete class
    //class MyMath:MathOperations
    //{
    //    public override void GetArea()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    #endregion

    #region Interfaces
    //is not a class// only contains contract

    //interface inheritance//supports multiple inheritance
    interface IMathOperations:IExtraOp1,IExtraOp2
    {
        public double PI { get; set; }

        public  void GetArea();

        public  void Circumference();

        public void Sum(double a, double b);

        public void Divide(double a, double b);
    }

    interface IExtraOp1
    {
        public void Op1();
        public int Op2();
    }

    interface IExtraOp2
    {
        public void M1();
        public int M2();
    }


    class TestClass
    {
        
    }
    //this is not inheritance interface can only be implemented
    //implement operation
    class MyMath2: TestClass,IExtraOp1, IExtraOp2
    {
        public double PI { get; set; }
        public void GetArea()
        {
            //logic
            throw new NotImplementedException();
        }

        public void Circumference()
        {
            throw new NotImplementedException();
        }

        public void Sum(double a, double b)
        {
            throw new NotImplementedException();
        }

        public void Divide(double a, double b)
        {
            throw new NotImplementedException();
        }

        public void Op1()
        {
            throw new NotImplementedException();
        }

        public int Op2()
        {
            throw new NotImplementedException();
        }

        public void M1()
        {
            throw new NotImplementedException();
        }

        public int M2()
        {
            throw new NotImplementedException();
        }
    }
    //.....

    #endregion

    #endregion
}

