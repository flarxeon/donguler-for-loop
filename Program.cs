using System;

nameof space donguler-for-loop
{
    class Program
    {
        static void Main(string[]  args)
        {

            //Ekrandan girilen sayıya kadar olan tek sayılarını ekrana yazdır.
            Console.Write(''Lütfen Bir Sayı giriniz: '');
             int sayac = int.Parse(Console.ReadLine);
             for (int i = 0; i <= sayac i++)
             {
                if(i%2 == 1)
                   Console.WriteLine(i);
             }

             //1 ile 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdır.
             int tekToplam 
             int ciftToplam 
             for (int i = 1; i <= 1000; i++)
             {
                if (i%2 == 1)
                     tekToplam += i;  // tekToplam = tekToplam + i;
                     else
                     ciftToplam += i; // tekToplam = tekToplam + i;
             }

             Console.WriteLine(''Tek Toplam '' + tekToplam);
             Console.WriteLine(''Çift Toplam '' + ciftToplam)

             //break, continue

             for (int i = 1; i < 10; i++)
             {
                if(i==4)
                   break;
                   Console.WriteLine(i);
             }

             for (int i = 1; i < 10; i++)
             {
                if(i==4)
                     continue;
            Console.WriteLine(i);
            }
        }
    }
}

             
        
                     
                    
            
                 
    