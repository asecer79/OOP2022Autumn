
using System.Collections;
using System.Runtime.Intrinsics.Arm;


namespace W09
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Student> students = new List<Student>();
            //students.Add(new Student { Id = 1, FullName = "Ayşe Kara", SchoolAverageGrade = 87 });
            //students.Add(new Student { Id = 2, FullName = "Ahmet Kızıl", SchoolAverageGrade = 35 });
            //students.Add(new Student { Id = 3, FullName = "Melike Kuzu", SchoolAverageGrade = 98 });
            //students.Add(new Student { Id = 4, FullName = "Muhammet Kırmızı", SchoolAverageGrade = 65 });
            //students.Add(new Student { Id = 5, FullName = "Mehmet Zeki", SchoolAverageGrade = 75 });


            ////Array.Sort(students.ToArray());

            //students.Sort();

            //foreach (var student in students)
            //{
            //    Console.WriteLine($"{student.Id}-{student.FullName}-{student.SchoolAverageGrade}");
            //}

            Student ahmet = new Student() { Id = 1, FullName = "Ahmet", SchoolAverageGrade = 56 };

            ahmet.TakeCourse(new Course() { Id = 1, Name = "OOP", Credit = 3 });
            ahmet.TakeCourse(new Course() { Id = 2, Name = "Web Programming", Credit = 3 });
            ahmet.TakeCourse(new Course() { Id = 3, Name = "Mobile Programming", Credit = 3 });

            ahmet.TakeCourse(new Course() { Id = 1, Name = "OOP", Credit = 3 });


            //foreach (var course in ahmet.courses)
            //{
            //    Console.WriteLine(course.Name);
            //}

            //Student ahmet1 = new Student() { Id = 1, FullName = "Ahmet", SchoolAverageGrade = 65 };

            //Console.WriteLine(ahmet.Equals(ahmet1));


            //foreach (var course in ahmet)
            //{

            //}


            //Console.WriteLine(ahmet.Current.Id);

            //while (ahmet.MoveNext())
            //{
            //    Console.WriteLine(ahmet.Current.Id);
            //}


            //foreach (var course in ahmet)
            //{
            //    Console.WriteLine(course.Id);
            //}


            List<string> list1 = new List<string>();
            list1.Add("Ali");

            //Stack<Student> students = new Stack<Student>();

            //students.Push(ahmet);
            //students.Pop();
            //students.Peek();

            //Queue<Student> students = new Queue<Student>();
            //students.Enqueue(ahmet);
            //students.Dequeue();

            Student ayse = new Student() { Id = 2, FullName = "Aysşe", SchoolAverageGrade = 56 };

            ayse.TakeCourse(new Course() { Id = 1, Name = "OOP", Credit = 3 });
            ayse.TakeCourse(new Course() { Id = 2, Name = "Web Programming", Credit = 3 });
            ayse.TakeCourse(new Course() { Id = 3, Name = "Mobile Programming", Credit = 3 });




            //Dictionary<string,Student> stdDictionary = new Dictionary<string,Student>();

            //stdDictionary.Add("ahmet",ahmet);
            //stdDictionary["ayse"] = ayse;

            //Console.WriteLine(stdDictionary["ahmet"].Id);



            //foreach (var item in stdDictionary)
            //{
            //    Console.WriteLine(item.Key + " "+ item.Value.Id);
            //}


            //LinkedList<Student> linkedList = new LinkedList<Student>();

            //linkedList.AddFirst(ahmet);
            //var node = new LinkedListNode<Student>(ahmet);
            //linkedList.AddAfter(node, ayse);


            //StudentTree root = new StudentTree();
            //root.Student = ahmet;
            //root.LeftNode = new StudentTree() { Student = new Student() { Id = 2 } };
            //root.RightNode = new StudentTree() { Student = new Student() { Id = 3 } };

            ////MyList<int> mylist1 = new MyList<int>();
            ////mylist1.Add(1);

            //MyList<Student> mylist2 = new MyList<Student>();
            //mylist2.Add(ahmet);
            //mylist2.SendToDb(new Student(){Id = 1,FullName = "ayşe",SchoolAverageGrade = 69});



            Calculate<string>("Aydın", "Ahmet");
            Calculate<int>(1, 2);

        }


        static T Calculate<T>(T elm1, T elm2)
        {
            if (elm1 is int)
            {
                Console.WriteLine(Convert.ToInt32(elm1) + Convert.ToInt32(elm2));
            }

            else if (elm1 is string)
            {
                Console.WriteLine(elm1.ToString() + elm2.ToString());
            }
            else
            {
                return elm1;
            }

            return default(T);
        }

    }


    class MyList<T> where T: class, new()
    {
        public List<T> Elements { get; set; }

        public void Add(T element)
        {
            Elements.Add(element);
        }
        public void Remove(T element)
        {
            Elements.Remove(element);
        }

        public void SendToDb(T element)
        {
            //some logic
        }

        public T Get(int index)
        {
            return Elements[index];
        }
    }




    //class Student:IComparable
    //{
    //    public int Id { get; set; }
    //    public string FullName { get; set; }
    //    public double SchoolAverageGrade { get; set; }

    //    public int CompareTo(object? obj)
    //    {
    //        var other = (Student)obj;
    //        return this.SchoolAverageGrade.GetHashCode().CompareTo(other.SchoolAverageGrade.GetHashCode());
    //    }
    //}

    class Student : IComparable<Student>, IComparer<Course>, IEnumerator<Course>, IEnumerable<Course>, ICollection<Course>
    {
        private List<Course> courses = new List<Course>();



        public int Id { get; set; }
        public string FullName { get; set; }
        public double SchoolAverageGrade { get; set; }

        public void TakeCourse(Course course)
        {
            bool isTaken = false;
            foreach (var courseAlreadyTaken in courses)
            {
                int flag = this.Compare(courseAlreadyTaken, course);
                if (flag == 0)
                {
                    isTaken = true;
                    break;
                }
            }

            if (!isTaken)
            {
                courses.Add(course);
                Console.WriteLine("New course has been added");
            }
            else
            {
                Console.WriteLine("This course has already been added");
            }

        }


        public int CompareTo(Student? other)
        {
            return this.SchoolAverageGrade.GetHashCode().CompareTo(other.SchoolAverageGrade.GetHashCode());

        }

        public int Compare(Course? course0, Course? course1)
        {
            return course0.Id.GetHashCode().CompareTo(course1.Id.GetHashCode());
        }

        public bool Equals(Student? other)
        {
            return this.Id.GetHashCode() == other.Id.GetHashCode();
        }

        private int counter = 0;
        public bool MoveNext()
        {
            if (counter < courses.Count - 1)
            {
                counter++;
                return true;

            }

            return false;

        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public Course Current => courses[counter];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Course> GetEnumerator()
        {
            foreach (var course in courses)
            {
                yield return course;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(Course item)
        {
            courses.Add(item);
        }

        public void Clear()
        {
            courses.Clear();
        }

        public bool Contains(Course item)
        {
            return courses.Any(p => p.Name.Contains(item.Name));
        }

        public void CopyTo(Course[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Course item)
        {
            courses.Remove(item);
            return true;
        }

        public int Count { get; }
        public bool IsReadOnly { get; }
    }


    class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Credit { get; set; }

    }



    class StudentTree
    {
        public Student Student { get; set; }

        public StudentTree LeftNode { get; set; }

        public StudentTree RightNode { get; set; }

    }


}




