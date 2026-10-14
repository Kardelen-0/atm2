using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm2
{
    class Program
    {
        static void Main(string[] args)
        {
           
                double bakiye = 10000;
                double toplamYatirilan = 0;
                double toplamCekilen = 0;
                int basariliCekmeSayisi = 0;

                for (int islemSayisi = 0; islemSayisi < 5; islemSayisi++)
                {
                    Console.WriteLine("\n---------- ATM MENÜSÜ ----------");
                    Console.WriteLine("1 - Para Yatırma");
                    Console.WriteLine("2 - Para Çekme");
                    Console.WriteLine("3 - Bakiye Sorgulama");
                    Console.WriteLine("4 - Çıkış");
                    Console.WriteLine("--------------------------------");
                    Console.Write("Seçiminiz: ");

                    int secim = Convert.ToInt32(Console.ReadLine());

                    switch (secim)
                    {
                        case 1:
                            Console.Write("Yatırmak istediğiniz para miktarı: ");
                            double yatirilan = Convert.ToDouble(Console.ReadLine());

                            if (yatirilan < 0)
                            {
                                Console.WriteLine("Geçersiz miktar!");
                            }
                            else
                            {
                                bakiye += yatirilan;
                                toplamYatirilan += yatirilan;

                                Console.WriteLine("Para yatırma işlemi başarılı.");
                                Console.WriteLine("Güncel bakiye: " + bakiye + " TL");
                            }
                            break;

                        case 2:
                            Console.Write("Çekmek istediğiniz para miktarı: ");
                            double cekilen = Convert.ToDouble(Console.ReadLine());

                            if (cekilen < 0)
                            {
                                Console.WriteLine("Geçersiz miktar!");
                            }
                            else if (cekilen > bakiye)
                            {
                                Console.WriteLine("Yetersiz bakiye!");
                            }
                            else
                            {
                                bakiye -= cekilen;
                                toplamCekilen += cekilen;
                                basariliCekmeSayisi++;

                                Console.WriteLine("Para çekme işlemi başarılı.");
                                Console.WriteLine("Güncel bakiye: " + bakiye + " TL");
                            }
                            break;

                        case 3:
                            Console.WriteLine("Mevcut bakiyeniz: " + bakiye + " TL");
                            break;

                        case 4:
                            Console.WriteLine("Program sonlandırılıyor...");
                            islemSayisi = 5;
                            break;

                        default:
                            Console.WriteLine("Geçersiz işlem!");
                            break;
                    }
                }

                Console.WriteLine("\n---------- İŞLEM ÖZETİ ----------");
                Console.WriteLine("Son Bakiye: " + bakiye + " TL");
                Console.WriteLine("Toplam Yatırılan Para: " + toplamYatirilan + " TL");
                Console.WriteLine("Toplam Çekilen Para: " + toplamCekilen + " TL");
                Console.WriteLine("Başarılı Para Çekme Sayısı: " + basariliCekmeSayisi);
                Console.WriteLine("---------------------------------");
            }
        }
    }

