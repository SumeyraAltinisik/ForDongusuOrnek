using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDongusuOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            int baslangic, bitis;
            Console.WriteLine("Başlangıç noktasını belirleyiniz.");
            baslangic = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitiş noktasını belirleyiniz.");
            bitis =int.Parse(Console.ReadLine());


            if (baslangic < bitis)
            {
                for (int sayac = baslangic; sayac <= bitis; sayac++)
                {
                    if (sayac % 2 == 0)
                    {
                        Console.WriteLine(sayac);
                    }
                }
            }
            else if (baslangic > bitis)
            {
                for (int i = baslangic; i > bitis; i--)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
                Console.WriteLine("Başlangıç ve bitiş noktası eşit.");

            Console.ReadKey();
           
        }
    }
}
