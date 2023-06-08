using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    internal class Arithmatic
    {
        public void findMaxinumberArray()
        {
            int[] num= new int[10];
            Console.WriteLine("please enter 10 numbers");
            for (int i = 0;i<10;i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = num[0];
            for(int i = 1;i<10; i++)
            {
                if (max < num[i])
                {
                    max = num[i];
                }
            }
            Console.WriteLine("The maximumnum= + max");
            
        }

    }
}
