using System;

namespace Odev_3 {
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Metniniz kaç kelimeden oluşacak :");
            int uzunluk =Convert.ToInt32(Console.ReadLine());
            string[] metin = new string[uzunluk];

            for(int i=1; i<=uzunluk; i++){
                Console.Write("{0} giriniz :",i);
                metin[i-1] = Console.ReadLine();
            } 
            Array.Reverse(metin);
            foreach(var item in metin)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}