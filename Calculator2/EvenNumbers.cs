using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    public class EvenNumbers
    {
        public  void OutputEven()
        {


            Console.WriteLine("Enter Your Number");
            int number = int.Parse(Console.ReadLine());
            
            if (number == 8)
            {
               Console.WriteLine(5);
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(3);
            }
            
        }
    }
}

//% used for modulus, either divisible or not divisible by 2