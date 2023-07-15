using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yil;
            Console.WriteLine("Doğum yılınızı girin:");
            yil=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Şu an {0} yaşındasınız",DateTime.Now.Year - yil);
            Console.ReadKey();
        
        }
    }
}
