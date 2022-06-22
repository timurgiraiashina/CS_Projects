using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1= 2147483647;
            long number2 = 9223372036854775807;
            short number3 = 32767;
            byte number4 = 255;
            bool degil = false;
            char number5 = 'a';
            double number6 = 1.7e+308;
            decimal number7 = 7.9m+28;
            var degisken = 10;//eğer object ile degisken kelimesini kullansaydık birden fazla değer tutabilirdi
            //degisken = "degisken"; //hata verir çünkü var ile sadece 1 atama yapılabilir

            Console.WriteLine("long veri tipi max pozitif sayı {0}", number2);

            Console.WriteLine("Integer veri tipi pozitif max sayı {0}",number1);
            Console.ReadLine();
        }
    }
    enum gunler {
        Pazartesi,Salı,Çarşamba,Perşembe,Cuma,Cumartesi,Pazar
    
    }
}
