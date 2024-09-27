using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__ödev_geliştirme_vol2
{
    internal class Odev_ilks_soru
    {
        static void Main(string[] args)
        {
/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					Yaz Okulu  DÖNEMİ
****************************************************************************/


            while (true)
            {
                int indeks1;
                int indeks2;
                int z;
                int indeks_buyuk_toplam = 0;
                int indeks_kucuk_toplam = 0;
                int indek_arası_toplam = 0;
                Console.WriteLine("Ödevin ilk sorusuna hoşgeldiniz :)");
                Console.WriteLine("İlk sorudan çıkmak için lütfen 'q' ya basınız.");
                Console.WriteLine("Devam etmek için lütfen herhangi bir tuşa basınız ve ardından enter tuşuna basınız.");
                Console.WriteLine("Yada sadece enter tuşuna basınız.");
                string secim= Console.ReadLine();
                if (secim == "q")
                {
                    break;
                    //Burda kullanıcı çıkış yapması için oluşturulan if bloğu
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine("Dizinin boyutu maksimum 45 olmalıdır");
                        Console.WriteLine("Dizinin boyutunu giriniz:");
                        int dizi_boyut = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("************************");
                        if (dizi_boyut <= 45 && 0 < dizi_boyut)
                        {
                            //Burda kullanıcının girdiği dizi boyutu kadar dizi oluşturuyorum ve Random sınıfından nesne oluşturuyorum.
                            int[] dizi = new int[dizi_boyut];
                            Random random = new Random();
                            for (int i = 0; i < dizi_boyut; i++)
                            {
                                //Burda oluşturduğum nesneyi kullanarak diziye rastgele sayılar atıyorum ve ardından bunları indeks
                                //sayılarına göre konsolda yazdırıyorum.
                                int sayı = random.Next(0, 100);
                                dizi[i] = sayı;
                                Console.WriteLine(i + ". indeks:" + sayı);
                            }
                            while (true)
                            {
                                Console.WriteLine("************************");
                                Console.WriteLine("1.indeksinizi giriniz:");
                                indeks1 = Convert.ToInt32(Console.ReadLine());
                                if (indeks1 < dizi_boyut && 0 <= indeks1)
                                {
                                    //Eğer kullanıcı istenilen veriyi doğru girmezse if bloğu dışındaki yazanları konsola yazdırıyorum.
                                    break;
                                }
                                
                                Console.WriteLine("Lütfen geçerli bir indeks girin!!!");
                                Console.WriteLine("************************");
                                Console.WriteLine("************************");
                            }
                            while (true)
                            {
                                Console.WriteLine("2.indeksinizi giriniz:");
                                indeks2 = Convert.ToInt32(Console.ReadLine());
                                if (indeks2 < dizi_boyut && 0 <= indeks2)
                                {
                                    //Yukarda ilk indeks sayısına yaptığın işlemi burda ikinci indekse yapıyorum.
                                    if (indeks1 < indeks2)
                                    {
                                        //Ben programımda ikinci girilen indeks değerini büyük olarak kabul etmek istiyorum.
                                    }
                                    else
                                    {
                                        z = indeks2; indeks2 = indeks1; indeks1 = z;
                                        /*Burda kullanıcı olurda indeks1'i indeks2'ye göre büyük
                                        girerse diye else bloğunda indeks2 ve indeks1'in sayısal
                                        değerlerini yer değiştirdim.*/
                                    }
                                    break;
                                    
                                }
                                Console.WriteLine("Lütfen geçerli bir indeks girin!!!");
                                Console.WriteLine("************************");
                                Console.WriteLine("************************");
                            }
                            for (int i = 0; i < dizi.Length; i++)
                            {
                                //Bu if else bloklarında indeksler arasını indeks sonrasını ve indeks öncesini toplatıyorum.

                                if (indeks1 <= i && i <= indeks2)
                                {
                                    indek_arası_toplam += dizi[i];
                                }

                                else if (i < indeks1)
                                {
                                    indeks_kucuk_toplam += dizi[i];
                                }

                                else if (indeks2 < i)
                                {
                                    indeks_buyuk_toplam += dizi[i];
                                }

                            }
                            //Burda konsola yazdırma işlemi yapıyorum.
                            Console.WriteLine("************************");
                            Console.WriteLine("************************");
                            Console.WriteLine("İndeksler arası toplam:" + indek_arası_toplam);
                            Console.WriteLine("indeksten sonraki toplam:" + indeks_buyuk_toplam);
                            Console.WriteLine("indeksten önceki toplam:" + indeks_kucuk_toplam);
                            Console.WriteLine("************************");
                            Console.WriteLine("************************");
                            break;
                        }
                        else
                        {
                            //Bu blokta kullanıcı dizi boyutunu istenilenden fazla veya 0 dan küçük girerse diye oluşturdum.
                            Console.WriteLine("Lütfen geçerli bir liste boyutu giriniz!!!");
                            Console.WriteLine("************************");
                            Console.WriteLine("************************");
                        }
                    }
                    

                }
    
            }
        }
    }

}
