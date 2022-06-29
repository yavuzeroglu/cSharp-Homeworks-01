using System;

namespace Odev_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cumleninizi giriniz");
            string cumle = Console.ReadLine();
            int harfSayisi=0;
            int kelimesayisi=0;

            String[] kelimeler = cumle.Split(" ");
            kelimesayisi = kelimeler.Length;
            Console.WriteLine("Cümlede {0} adet kelime vardır.",kelimesayisi);

            char[] harflerDizisi = cumle.ToCharArray();
            foreach(var i in harflerDizisi){
                if(char.IsLetter(i)){
                    harfSayisi++;
                }
            }
            Console.WriteLine("Harf sayisi :{0}",harfSayisi);


        }
    }
}