using System;

namespace Test_1 {
    class Program
    {
       

        static void check(char c)
        {   
                
           
            int x = c * 1;
             if(x <=47 ||(x>=58 && x<=64) || (x>=91 && x<=96) || (x>=123 && x<=126)) {
                Console.WriteLine("Symbol");
                return;
              }

            if(x>=48 && x <= 57)
            {
                Console.WriteLine("Number");
                return;
            }
            
            if(x >=96 && x <= 122)
            {
                if (x == 97 || x == 101 || x == 105 || x == 111 || x == 117)
                {
                    Console.WriteLine("Characther is Vowel");
                    return;
                }
                else
                {
                    Console.WriteLine("Characther is Not Vowel");
                }
            }
            
        }
       
    }
}
