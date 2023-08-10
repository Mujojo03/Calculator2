using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{


    public class OddNumbers
    {
        public void OutputOdd()
        {
            Console.WriteLine("Enter Your Number");
            int number = int.Parse(Console.ReadLine());
            {
                if (number % 2 != 0)
                {
                    Console.WriteLine(3);
                }
            }
        }
    }
}

// != not equal to
