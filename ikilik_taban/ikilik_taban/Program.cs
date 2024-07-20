using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikilik_taban
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            ArrayList bit = new ArrayList();
            Console.Write("İkilik tabana dönüştürülecek sayı :");
            sayi = Convert.ToInt32(Console.ReadLine());

             
            while (sayi != 1 && sayi!=0 )
            {
                int kalan, sonuc;
                sonuc = sayi / 2;
                kalan = sayi - (sonuc * 2);
                bit.Add(kalan);
                sayi = sonuc;
            } 
            bit.Add(sayi);
            ArrayList onluk = new ArrayList();
            for(int i = (bit.Count-1);i>=0;i--)
            {
                onluk.Add ( Convert.ToInt32(bit[i]) * Math.Pow(2,i));
            }

            bit.Reverse();
            Console.Write("Sayının ikilik tabanda gösterimi = ");
            for(int i = 0;i<bit.Count;i++)
            {
                Console.Write(bit[i]);
            }

            Console.ReadLine();
        }
    }
}
