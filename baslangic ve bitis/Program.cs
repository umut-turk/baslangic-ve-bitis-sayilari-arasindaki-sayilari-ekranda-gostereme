using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baslangic_ve_bitis
{
    internal class Program
    {
        static void Main(string[] args)
        {




            Console.WriteLine("başlangıc  degerı   gırın");




            try
            {
                  int baslanic = int.Parse(Console.ReadLine());

                Console.WriteLine("bitiş  degerı   gırın");
                  int bitis = int.Parse(Console.ReadLine());

                for (int i = baslanic; i <= bitis; i++)
                {
                    Console.WriteLine(i);
                }

            }
            catch (FormatException ex)
            {

                Console.WriteLine("yanliş  deger"  + "   "  + "hata  kodu" +"    "  +ex.Message);

            }
            

          

          

            Console.ReadLine();

        }
    }
}
