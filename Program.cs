using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınıf_listesi_1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ogrencisayısı = 0;
            string[,] ogrenciler = new string[20, 3];
            bool tekrarsec = false;
            int boşluksayısı = 15;
            do
            {
                Console.WriteLine(" YENİ ÖGRENCİ İÇİN  1 , MEVCUT LİSTEYİ 2 , ÖGRENCİ BULMAK İÇİN  3 ");
                string secim = Console.ReadLine();
                if (secim == "1")
                {
                    for (int i = 0; i < ogrenciler.Length; i++)
                    {
                        Console.Write(i + 1 + "-ögrencinin ismini giriniz : ");
                        ogrenciler[i, 0] = Console.ReadLine().ToUpper();
                        int isimuzunlugu = ogrenciler[i, 0].Length;
                        Console.Write(i + 1 + "-ögrencinin soyadını  giriniz : ");
                        ogrenciler[i, 1] = Console.ReadLine().ToUpper();
                        int soyaduzunlugu = ogrenciler[i, 1].Length;
                        Console.Write(i + 1 + "-ögrencinin numarasını giriniz : ");
                        ogrenciler[i, 2] = Console.ReadLine().ToUpper();
                        ogrencisayısı++;

                        if (ogrencisayısı == ogrenciler.Length)
                        {
                            Console.WriteLine("maksimum kaydetme sınırına ulaştınız daha fazla ögrenci ekleyemessiniz ");
                            Console.WriteLine("Başka işlem yapmak istermisiniz e/h");
                            string tekrarsecınput = Console.ReadLine().ToLower();
                            tekrarsec = (tekrarsecınput == "e");
                            break;
                        }
                        Console.WriteLine("ögrenci eklemeye devam etmek istermisiniz (e/h) : ");
                        string cevap = Console.ReadLine().ToLower();
                        if (cevap == "h")
                        {
                            Console.Write("Başka işlem yapmak istermisiniz e/h : ");
                            string tekrarsecınput = Console.ReadLine().ToLower();
                            tekrarsec = (tekrarsecınput == "e");
                            break;
                        }
                    }
                }
                else if (secim == "2")
                {

                    for (int i = 0; i < ogrenciler.Length; i++)
                    {
                        int kalanbosluk1 = boşluksayısı - ogrenciler[i, 0].Length;
                        int kalanbosluk2 = boşluksayısı - ogrenciler[i, 1].Length;
                        string sonuc1 = new string(' ', kalanbosluk1);
                        string sonuc2 = new string(' ', kalanbosluk2);
                        Console.WriteLine(i + 1 + "-ÖGRENCİ İSİM : " + ogrenciler[i, 0] + sonuc1 + "SOYAD : " + ogrenciler[i, 1] + sonuc2 + "NUMARA : " + ogrenciler[i, 2]);
                    }
                    Console.WriteLine("Başka bir işlem yapmak ister misiniz? (e/h): ");
                    string devamSecim = Console.ReadLine().ToLower();
                    tekrarsec = devamSecim == "e";

                }
                else
                {
                    if (secim == "3")
                    {
                        bool bulundu = false;
                        Console.WriteLine("ARAMAK İSTEDİGİNİZ ÖGRENCİNİ İSİM , SOYAD VEYA NUMARASINI GİRİNİZ ");
                        String aramakriteri = Console.ReadLine().ToUpper();
                        for (int i = 0; i < ogrenciler.GetLength(0); i++)
                        {
                            if (ogrenciler[i, 0] == aramakriteri || ogrenciler[i, 1] == aramakriteri || ogrenciler[i, 2] == aramakriteri)
                            {
                                Console.WriteLine("ögrenci bulundu ");
                                Console.WriteLine("İSİM : " + ogrenciler[i, 0] + " SOYAD : " + ogrenciler[i, 1] + " NUMARASI : " + ogrenciler[i, 2]);
                                bulundu = true;
                                if (bulundu == true)
                                {
                                    string secim2;
                                    Console.WriteLine("ögrenci bilgilerini güncellemek için 1 - ögrenciyi silmek için 2");
                                    secim2 = Console.ReadLine().ToUpper();

                                    if (secim2 == "1")
                                    {
                                        Console.WriteLine("hangi bilgiyi güncellemek istersiniz isim - 1 , soyad - 2 , numara-3 için basınız ");
                                        string isim = Console.ReadLine().ToUpper();
                                        string soyad = Console.ReadLine().ToUpper();
                                        string numara = Console.ReadLine().ToUpper();
                                    }

                                }

                            }
                            else if (!bulundu)
                            {
                                Console.WriteLine("aramak istediniz ögrenci listeye yok veya yanlış girdiniz tekrar deneyiniz ");
                                bulundu = (false);

                            }
                    }
                }
            } while (tekrarsec);
        }
    }
}
