using System;

namespace proekt
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static void Anketa()
        {
            Console.WriteLine("What's your last name?");
            string lastname = Console.ReadLine();

            Console.WriteLine("What's your first name?");
            string firstname = Console.ReadLine();

            Console.WriteLine("What's your age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What's your weight in kg?");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("What's your height in meters?");
            double height = double.Parse(Console.ReadLine());

            double bodyMassindex = weight / (height * height);

            string profile =
                      $"Your profile:{Environment.NewLine}"
                    + $"Full Name: {lastname} {firstname}{Environment.NewLine}"
                    + $"Age: {age}{Environment.NewLine}"
                    + $"Weight: {weight}{Environment.NewLine}"
                    + $"Height: {height}{Environment.NewLine}"
                    + $"Body Mass Index: {bodyMassindex}";

            Console.WriteLine(profile);
        }
        static void dz()
        {
            Console.WriteLine("Enter an integer");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"The number of digits:{number.ToString().Length}");



            Console.ReadLine();


            Console.WriteLine("Enter an integer");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter an integer");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"a={a}, b={b}");

            int c = a;
            a = b;
            b = c;

            Console.WriteLine($"a={a}, b={b}");

            Console.ReadLine();


            Console.WriteLine("what's your name?");

            string name = Console.ReadLine();

            Console.WriteLine($"hello,{name}");
        }
        static void QuertyingString()
        {
            string name = "onroabra";
            bool containsA = name.Contains('a');
            bool containsE = name.Contains('E');

            Console.WriteLine(containsA);
            Console.WriteLine(containsE);

            bool endswithAbra = name.EndsWith("abra");
            Console.WriteLine(endswithAbra);

            bool startsWithAbra = name.StartsWith("abra");
            Console.WriteLine(startsWithAbra);

            int index0fA = name.IndexOf('a', 1);
            Console.WriteLine(index0fA);

            int lastindex0fR = name.LastIndexOf('r');
            Console.WriteLine(lastindex0fR);

            Console.WriteLine(name.Length);

            string substrFrom5 = name.Substring(5);
            string substFromTo = name.Substring(0, 3);

            Console.WriteLine(substrFrom5);
            Console.WriteLine(substFromTo);
        }
        static void staticAndInstanceMembers()
        {
            string name = "mojna";
            bool containsA = name.Contains('a');
            bool containsE = name.Contains('E');

            Console.WriteLine(containsA);
            Console.WriteLine(containsE);

            string abc = string.Concat("a", "b", "c");
            Console.WriteLine(abc);

            Console.WriteLine(int.MinValue);

            int x = 1;
            string xStr = x.ToString();
            Console.WriteLine(xStr);
            Console.WriteLine(x);
        }
        static void Sravnenie()
        {
            int x = 1;
            int y = 2;

            bool areEqual = x == y;
            Console.WriteLine(areEqual);

            bool result = x > y;
            Console.WriteLine(result);

            result = x >= y;
            Console.WriteLine(result);

            result = x < y;
            Console.WriteLine(result);

            result = x <= y;
            Console.WriteLine(result);

            result = x != y;
            Console.WriteLine(result);
        }
        static void MathOperations()
        {
            int x = 1;
            int y = 2;

            int z = x + y;
            int k = x - y;
            int a = z + k - y;

            Console.WriteLine(z);
            Console.WriteLine(k);
            Console.WriteLine(a);

            int b = z * 2;
            int c = k / 2;
            Console.WriteLine(b);
            Console.WriteLine(c);


            a = 4 % 2;
            b = 5 % 2;
            Console.WriteLine(a);
            Console.WriteLine(b);

            a = 3;
            a = a * a;
            Console.WriteLine(a);

            a = 2 + 2 * 2;
            Console.WriteLine(a);
            a *= 2;
            // a = a * 2
            a /= 2;
            // a = a / 2
            Console.WriteLine(a);
        }
        static void incrementDecrementDemo()
        {
            int x = 1;
            x = x + 1;

            Console.WriteLine(x);

            x++;

            Console.WriteLine(x);

            ++x;
            Console.WriteLine(x);

            x = x - 1;
            x--;
            --x;
            Console.WriteLine(x);

            Console.WriteLine("Learn about increments");
            Console.WriteLine($"Last x state is {x}");

            int j = x++;
            Console.WriteLine(j);
            Console.WriteLine(x);

            j = ++x;
            Console.WriteLine(j);
            Console.WriteLine(x);

            x += 2;
            // x = x + 2
            Console.WriteLine(x);

            j -= 2;
            //j = j-2

            Console.WriteLine(j);
        }
        static void OverFlow()
        {
            
                checked
                {
                    uint x = uint.MaxValue;
                    Console.WriteLine(x);

                    x = x + 1;

                    Console.WriteLine(x);

                    x = x - 1;
                    Console.WriteLine(x);
                }

            
        }
        static void VariablesScope()
        {
            var a = 1;
            {
                var b = 2;
                {
                    var c = 3;

                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                }
                Console.WriteLine(a);
                Console.WriteLine(b);
                //Console.WriteLine(c);
            }
            Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);

        }
        static void Literals()
        {
            int x = 0b11;
            int y = 0b1001;
            int k = 0b10001001;
            int m = 0b1000_1001;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(k);
            Console.WriteLine(m);

            x = 0x1f;
            y = 0xff0D;
            k = 0x1fAB30EF;
            m = 0x1FAB_30EF;

            Console.WriteLine();

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(k);
            Console.WriteLine(m);

            Console.WriteLine();

            Console.WriteLine(4.5e2);
            Console.WriteLine(3.1E-1);

            Console.WriteLine();

            Console.WriteLine('\x78');
            Console.WriteLine('\x5A');

            Console.WriteLine('\u0420');
            Console.WriteLine('\u0421');


        }
        static void Variables()
        {
            int x = -1;

            int y;
            y = 2;

            //int32 x1 = -1;

            float f = 1.1f;

            double d = 2.3;

            int x2 = 0;
            int x3 = new int();

            int a = 1;
            var b = 1.2;

            //Dictionary<int, string> dict = new Dictionary<int, string>;
            //var dict = new Dictionary<int, string>();

            //var v;

            decimal money = 3.0m;

            char character = 'A';
            string name = "John";

            bool canDrive = true;


            object obj1 = 1;
            object obj2 = "obj2";

            Console.WriteLine(a);
            Console.WriteLine(name);




        }
    }
}
