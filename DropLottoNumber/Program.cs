using System;
using System.Collections.Generic;
using System.Threading;

namespace DropLottoNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            

            for (int i = 0; i <= 5; i++)
            {
               
                Console.Write(random.Next(45) +" , ");
                
            }
           
        }
    }
}
