using System;

namespace Odev_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,m,temp;
            Console.Write("Kaç adet sayı girileceğini belirtiniz :");
            n=Convert.ToInt32(Console.ReadLine());
            Console.Write("Aranacak sayiyi giriniz :");
            m=Convert.ToInt32(Console.ReadLine());
            int[] sayilar=new int[n];
            for(int i=1; i<=n; i++){
                
                Console.Write("{0}. sayiyi giriniz ",i);
                temp = Convert.ToInt32(Console.ReadLine());
                sayilar[i-1] = temp;
                
            }
            Console.Write(m+" sayisina tam bölünenlerin listesi");
            foreach (var item in sayilar)
            {
                if(m%item==0){

                Console.Write(" "+item+" ");
                }
            }
            


        }
    }
}