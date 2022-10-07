namespace W01
{
    //as a default coding style is camelCase for variables 
    //as default coding style for class and method names are pascal
    //syntax styles for java, c# or python etc are different

    internal class Program
    {
        //camel case syntax
        private static void Main(string[] args)//Main pascal case
        {

            //primitive types /value types
            
            byte b1 = 200;//0--255;
            int i1 = 1232656265;
            long l1 = 2656232645626565656;

            double d1 = 262545616564561654684598464561565465465416546541656.256454;
            //Console.WriteLine(d1);
            float f1 = 2021526165461564615645651.98f;
            decimal de1 = 1.9m;
            
            bool bo1 = true; //true or false 
            char c1 = (char)65535; //0 - 65535,  256*256 char

            for (int i = 0; i < 65535; i++)
            {
                Console.Write((char)i);
            }


            Console.WriteLine("byte: "  +sizeof(byte));
            Console.WriteLine("int: " + sizeof(int));
            Console.WriteLine("long: " + sizeof(long));
            Console.WriteLine("float: " + sizeof(float));
            Console.WriteLine("double: " + sizeof(double));
            Console.WriteLine("decimal: " + sizeof(decimal));
            Console.WriteLine("char: " + sizeof(char)); 

            //1 byte = 01010101  2^8 = 256 different characters
            //2 byte = 0101010101101010  2^16 = 65536 different characters

            Console.WriteLine(b1.GetType());


            var v1 = 265; //implicit variable definition
            Console.WriteLine(v1.GetType());
            var v2 = 56.98m;
            Console.WriteLine(v2.GetType());

            //v1 = "23.6"; //error

            dynamic dy1 = 1235;
            Console.WriteLine(dy1.GetType());
            dy1 = "dsfsdf";
            Console.WriteLine(dy1.GetType());
            dy1 = true;
            Console.WriteLine(dy1.GetType());


            //const int ageValueForPeople = 1;
            //Console.WriteLine("Hello, World!" + ageValueForPeople);
        }
    }
}



