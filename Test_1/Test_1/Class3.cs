using System;

namespace Test_1
{
     class Class3
    {
        public static void Main(string [] args)
        {
            DaysInMonth(4);
        }


        static void DaysInMonth(int x )
        {
            if(x == 2)
            {
                Console.WriteLine("28 Days");
                return;
            }
            if(x==1 || x == 3|| x==5|| x==7 || x==8|| x==10 || x== 12)
            {
                Console.WriteLine("31 Days");
                return;
            }

            else if(x == 4  || x==6 || x==9 || x == 11)
            {
                Console.WriteLine("30 Days");
            }

            else
            {
                Console.WriteLine("Plzz enter month between 1 - 12");
            }
        }

        static void studentScore(int x, int y, int z, int a)
        {
          
            float  per = (x + y + z + a)/ 4;
            Console.WriteLine(per);
         }

        static void EngAdd(int p, int c, int m)
        {
            if(p>64 && c > 64 && m > 64)
            {
                Console.WriteLine("You are Eligible" );
                return;
            }
            Console.WriteLine("Sry, Not Eligible");
        }

        static bool CheckAge(int x)
        {
            return(x>=18);
        }

        static bool CheckEqual(int x, int y)
        {
            return (x == y);
        }

        static void NameOfWeek(int week)
        {
            if (week == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (week == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (week == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (week == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (week == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (week == 6)
            {
                Console.WriteLine("Saturday");
            }
            else if (week == 7)
            {
                Console.WriteLine("Sunday");
            }
            else
            {
                Console.WriteLine("Invalid Input! Please enter week in between 1-7.");
            }
        }

        static void PositiveNegative(int x)
        {
            if(x < 0)
            {
                Console.WriteLine("Negative");
                return;
            }
            Console.WriteLine("Positive");
        }
        
        static void leapYear(int x)
        {
            if( ( (x%4==0) && (x!=100) ) || (x%400==0) )
            {
                Console.WriteLine("Leap Year"); 
            }
            else
            {
                Console.WriteLine("Not Leap Year");
            }
        }

        static void Largest(int x, int y, int z)
        {
            if(x > y && x > z)
            {
                Console.WriteLine(x);
                return;
            }
            if(y > x && y > z)
            {
                Console.WriteLine(y);
                return;
            }
            else
            {
                Console.WriteLine(z);
            }
        }

        static void evenOdd(int x)
        {
            if ((x&1) == 1)
            {
                Console.WriteLine("Odd");
            }
            else
            {
                Console.WriteLine("Even");
            }
        }
    }

   
}
