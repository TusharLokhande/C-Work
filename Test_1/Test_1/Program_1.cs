using System;

namespace HelloWorld {
    class Program
    {
       

        static void convertIntoWeeksYear(int days)
        {
            int years = days / 365;
            int weeks = (days % 365) / 7;
            days = days - ((years * 365) + (weeks * 7));
            Console.Write("Years: {0} ,", years);
            Console.Write("Weeks: {0} ,", weeks);
            Console.WriteLine("Days: {0}", days);
        }

        public  static int AreaOfRectangle(int x, int y)
        {
            return x * y;
        }

        static int AreaOfSquare(int x)
        {
            return (int)Math.Pow(x, 2);
        }

        static float AreaOfCirlce(int radius)
        {
            return (float)Math.PI * radius;
        }

        static void ASCII(string s)
        {
            foreach (char c in s)
            {
                Console.WriteLine(c * 1);
            }
        }

        static void Size(){
            Console.WriteLine("Size of Characther    : {0}", sizeof(char));
            Console.WriteLine("Size of Bytes    : {0}", sizeof(byte));
            Console.WriteLine("Size of Float    : {0}", sizeof(float));
            Console.WriteLine("Size of Integer     : {0}", sizeof(int));
            Console.WriteLine("Size of Boolean    : {0}", sizeof(bool));
            Console.WriteLine("Size of Long   : {0}", sizeof(long));
        }

        static float fahrenheitIntoCelsius(float f)
        {
            return (float)(5 * (f - 32) / 9);
        }

        static float celsiusIntoFahrenheit(float celsius)
        {
            return  (float)(9.0 / 5.0) * celsius + 32;
        }

        static float feetIntoMeters(float feet)
        {
            return (float)(feet * 0.3048);
        }
        

        static void Arithmetic(int x, int  y)
        { 
            Console.WriteLine("Addition: "+(x + y));
            Console.WriteLine("Subraction: "+(x-y));
            Console.WriteLine("Multiplication: ", (x*y));
            Console.WriteLine("Division: "+(x/y));
            Console.WriteLine("Modulus: "+(x%y));
        }

        static float Mul(float x, float y)
        {
            return x * y;
        }

        static void Swap<T>(ref T x, ref T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
        }

       

        static int Add(int x, int y)
        {
            return x + y;
        }

    }
}

