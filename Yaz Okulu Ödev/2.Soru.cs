using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ödev2_Soru
{
    internal class Odev2_Soru
    {
        static void Main(string[] args)
        {

/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					Yaz Okulu DÖNEMİ
**	
****************************************************************************/




            while (true)
            {
                Console.WriteLine("     Menü   ");
                Console.WriteLine("1-String bir değişkende,string değer substring kullanmadan ara");
                Console.WriteLine("2-String bir değişkende,string değeri substring olarak ara");
                Console.WriteLine("3-Alfabenin karakterlerini bir string de ara kaç adet geçiyorbul ve çiz.");
                Console.WriteLine("4-Çıkmak için 'q' ya basınız.");
                string secim = Console.ReadLine();
                Console.WriteLine("Seçiminiz:"+secim);

                if (secim == "q")
                {
                    Console.WriteLine("Çıkış yapılıyor.");
                    break;
                }

                string kelime_Kontrol = "";
                int indeks1 = -1;  
                char[] alfabe = { 'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g', 'ğ', 'h', 'ı', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z' };
                if (secim == "1")
                {
                    //Kullanıcı 2. seçimi seçerse
                    Console.WriteLine("Dizinizi giriniz.");
                    string dizi = (Console.ReadLine()).ToLower();
                    Console.WriteLine("Aratmak istediğiniz kelimeyi giriniz:");
                    string kelime =Console.ReadLine().ToLower();
                    //Kullanıcıdan diziyi ve aratmak istedii kelimeyi aldım
                    
                    int IlkHarfinEşit=0;
                    //İlk harfin eşit olduğu yerdeki indeksi tutmak için değişken yazdım.
                    for (int i = 0; i < dizi.Length; i++)
                    {
                        //Bu döngü ile diziyi baştan sona döndürmesini istedim.
                        if (kelime == kelime_Kontrol )
                        {
                            //Eğer kelime eşitese konsolda bunun gözükmesini istedim
                            Console.WriteLine("kelime:" + " " + kelime_Kontrol + " " + "indis:" + indeks1);
                        }
                        //Burdaki indeks değeride kelimeyi bulursam başladığı indeks değerini bulmam için
                        indeks1++;
                        //İsteilen kelimeyi bulup bulmadığımı anlamam için bu değişkeni oluşturdum.
                        kelime_Kontrol = "";
                        //Eğer kelimenin ilk harfinin eşiti bulursam bunu ilkHarfineşit değişkenine atmasını istedim.
                        IlkHarfinEşit = i;
                        if (kelime[0] == dizi[IlkHarfinEşit])
                        {
                            //Burda kelimenin ilk harfi ve dizede bu harfe eşit olduğu indeksi buldum.
                             IlkHarfinEşit = i;

                            for (int j = 0; j < kelime.Length; j++)
                            {
                                //Burda döngüyü kelime boyutu kadar döndürdüm

                                if (kelime[j] != dizi[IlkHarfinEşit])
                                {   
                                    //Burda kelimenin ilk indeksinden başlayarak son indeksine kadar 
                                    //kontorl etmesini istedim.Eğer dizideki uyuşmazsa döngüyü durdurdum.
                                    break;
                                }
                                kelime_Kontrol= kelime_Kontrol + dizi[IlkHarfinEşit];
                                //Burda boş stringe yukardaki şartı sağlayabildiği kadar indeksteki kelimeleri attım.
                                IlkHarfinEşit++;
                                //Burdada ilk harfin eşit olduğu indeksi büyüterek diğer harflerin eşitliğine baktım.
                            }
                        }
                    }
                    Console.WriteLine("--------------------");
                    Console.WriteLine("--------------------");

                }
                else if (secim == "3")
                {   //Kullanıcı 3.seçimi yaparsa
                    Console.WriteLine("Dizinizi giriniz.");
                    string dizi = (Console.ReadLine()).ToLower();
                    //Diziyi kullanıcıdan aldım.
                    foreach (char g in alfabe)
                    {   // bu döngü g ile alfabeyi geziyor.
                        int Tekrar_sayısı = 0;

                        foreach (char i in dizi)
                        {
                            //Bu döngü i ile diziyi geziyor.
                            if (g == i)
                            {
                                //Burda g için bütün dizinin elemanlarına bakıyor ve eşit olan varsa tekrar sayısını arttırıyor.
                                Tekrar_sayısı++;
                                
                            }

                        }
                        Console.Write(g.ToString().ToUpper() + " sayısı:" + Tekrar_sayısı);
                        Console.Write(" ");
                        //Burda harfi ve tekrar sayısını yazdırıyor.

                        for (int i=0; i<Tekrar_sayısı; i++)
                        {
                            //Bu döngüde Tekrarsayısı kadar harfin yanına yıldız yazıyor ve sonrasında satır atlıyor.
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    //Konsolun düzgün gözükmesi için yazdım.
                    Console.WriteLine("--------------------");
                    Console.WriteLine("--------------------");

                }
                else if(secim == "2") 
                {
                    // Kullanıcı 2. seçmi yaparsa
                    Console.WriteLine("Dizinizi giriniz.");
                    string dizi = (Console.ReadLine()).ToLower();
                    Console.WriteLine("Aratmak istediğiniz kelimeyi giriniz:");
                    string kelime = Console.ReadLine().ToLower();
                    // Dizi vermesini ve aratamak istediği kelimeyi istedim burda.
                    for (int j=0; j < dizi.Length-kelime.Length+1; j++)
                    {
                        //Burda substring kullanacağım için ve j dizenenin son hanesine kadar giderse out of indeks hatası
                       // alırdım çünkü substring j indeksinden kelime boyutu kadar gidiyor.Bu yüzden dizi boyutunundan kelime
                       //boyutunu çıkartıp yazdım.
                        
                        if(dizi.Substring(j,kelime.Length) == kelime)
                        {
                            //Aranılan kelime bulunuyor ve yazılıyor.
                            Console.WriteLine("kelime:" + " " + kelime + " " + "indis:" + j);
                        }
                    }
                    //Konsolun düzgün gözükmesi yazdım.
                    Console.WriteLine("--------------------");
                    Console.WriteLine("--------------------");
                }
                else
                {
                    //Kullanıcı seçimini düzgün yapmazsa diye yazdım.
                    Console.WriteLine("Lütfen geçerli bir ifade girin.");
                }
            }
        }
    }   
}
