using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number1 = 20;
            //if (number1 == 10) Console.WriteLine("Sayı 10dur");
            ////Console.WriteLine(number1==10 ? "Sayı 10dur" : "Sayı 10 değildir" );
            //else if (number1 == 20) Console.WriteLine("Sayı 20");
            //else Console.WriteLine("Sayı 10 yada 20 değil");
            //switch (number1)
            //{
            //    case 10:/*sayı 10sa ekrana alttakini yaz*/
            //        Console.WriteLine("Sayı 10");
            //        break;
            //    case 20:/*sayı 20ise*/
            //        Console.WriteLine("Sayı 20");/*yaz*/
            //        break ;
            //    default:/*bunlardan biri değilse*/
            //        Console.WriteLine("Sayı 10 yada 20 değil");
            //        break;
            //}
            //if (number1 >= 0 && number1 <= 100)
            //{
            //    Console.WriteLine("Sayı 0-100 arasındadır"); 
            //}
            //else if(number1 > 100 && number1 <= 200) 
            //{ Console.WriteLine("Sayı 101 ile 200 arasındadır"); }
            //else if(number1>200||number1<0)
            //{
            //    Console.WriteLine("Sayı 0-200 aralığının dışındadır");

            //}
            if (number1 < 100)
            {
                if(number1>=90&&number1<100)
                {
                    Console.WriteLine("Sayı 90 ile 100 arasıdır");
                }

            }
            Console.ReadLine();
        }
    }
}
