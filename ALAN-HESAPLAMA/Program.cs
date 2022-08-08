using System;

namespace ALAN_HESAPLAMA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string menu;
            string hesaplama;
                ANAMENU:
                Console.Clear();
                Console.WriteLine("***** ALAN HESAPLAMA PROGRAMI *****");
                Console.WriteLine("1 HESAPLAMA");
                Console.WriteLine("2 ÇIKIŞ");
                menu = Console.ReadLine();
                switch (menu)
                {
                    case "1":
                        //etiket
                        hesap:
                        hesaplama = "";
                        Console.Clear();
                    Console.WriteLine("***** İŞLEM TÜRÜ SEÇİMİ *****");
                    Console.WriteLine("1 ALAN");
                        Console.WriteLine("2 ÇEVRE");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                hesaplama = "ALAN";
                                break;
                            case "2":
                                hesaplama = "ÇEVRE";
                                break;
                            default:
                                Console.WriteLine("Geçersiz hesaplama tipi secimi");
                                goto hesap;
                        }
                        secim:
                        Console.Clear();
                    Console.WriteLine("***** İŞLEM SEÇİMİ *****");
                    Console.WriteLine("1- Ucgen");
                        Console.WriteLine("2- Kare");
                        Console.WriteLine("3- Dikdörtgen");
                        Console.WriteLine("4- Daire");


                        switch (Console.ReadLine())
                        {
                            case "1":
                                Ucgen sekil;
                                ucgentipi:
                                Console.Clear();
                                Console.WriteLine("***** ÜÇGEN TİPİ SEÇİMİ *****");
                                Console.WriteLine("1- EŞKENAR ÜÇGEN");
                                Console.WriteLine("2- İKİZKENAR ÜÇGEN");
                                Console.WriteLine("3- Çeşitkenar Üçgen");
                                switch (Console.ReadLine())
                                {
                                    case "1":
                                        eskenar:
                                        Console.Clear();
                                        Console.WriteLine("Eşkenar üçgen kenar uzunluğunu girin :");
                                        double tmp;
                                        if (!double.TryParse(Console.ReadLine(), out tmp))
                                        {
                                            Console.WriteLine("Sayı değeri girin :");
                                            goto eskenar;
                                        }
                                        if (tmp <= 0)
                                        {
                                            Console.WriteLine("Girilen sayı değeri 0 dan kücük ve 0 olamaz");
                                            goto eskenar;
                                        }
                                        sekil = new Ucgen(tmp, tmp, tmp);
                                        if (hesaplama.Equals("alan"))
                                        {
                                            Console.WriteLine("Eşkenar ücgenin alanı : " + sekil.alanHesö lş lşçççççapla());
                                        }
                                        else
                                            Console.WriteLine("Eşkenar ücgenin cevresi : " + sekil.cevreHesapla());
                                    break;
                                    
                                case "2":
                                        double kenar1, kenar2;
                                        kenarAlma1:
                                        Console.WriteLine("İkizkenar üçgenin eşit kenar uzunluklarını girin");
                                        if (!double.TryParse(Console.ReadLine(), out kenar1))
                                        {
                                            Console.WriteLine("Sayı değeri girin : ");
                                            goto kenarAlma1;
                                        }
                                        if (kenar1 <= 0)
                                        {
                                            Console.WriteLine("Girilen sayı değeri 0 dan kücük ve 0 olamaz");
                                            goto kenarAlma1;
                                        }
                                        
                                        kenarAlma2:
                                        Console.WriteLine("İkizkenar üçgenin eşit olmayan kenar uzunlugunu girin");
                                        if (!double.TryParse(Console.ReadLine(), out kenar2))
                                        {
                                            Console.WriteLine("Sayı değeri girin");
                                            goto kenarAlma2;
                                        }
                                        if (kenar2 <= 0)
                                        {
                                            Console.WriteLine("Girilen sayı değeri 0 dan kücük ve 0 olamaz");
                                            goto kenarAlma2;
                                        }
                                        if (kenar1 * 2 <= kenar2)
                                        {
                                            Console.WriteLine("Geçersiz üçgen!  tekrar girin :");
                                            goto kenarAlma1;
                                        }
                                        sekil = new Ucgen(kenar1, kenar1, kenar2);
                                        if (hesaplama.Equals("alan"))
                                        {
                                            Console.WriteLine("İkizkenar ücgenin alanı : " + sekil.alanHesapla());
                                        }
                                        else
                                            Console.WriteLine("ikizkenar ücgenin cevresi : " + sekil.cevreHesapla());
                                        break;
                                        
                                        case "3":
                                        double ceskenar1, ceskenar2, ceskenar3;
                                        ceskenarAlma1:
                                        Console.WriteLine("Çeşitkenar ucgenin 1. kenar uzunluğunu girin");
                                        if (!double.TryParse(Console.ReadLine(), out ceskenar1))
                                        {
                                            Console.WriteLine("Sayı değeri girin");
                                            goto ceskenarAlma1;
                                        }
                                        if (ceskenar1 <= 0)
                                        {
                                            Console.WriteLine("Girilen sayı değeri 0 dan kücük ve 0 olamaz");
                                            goto ceskenarAlma1;
                                        }
                                        ceskenarAlma2:
                                        Console.WriteLine("Çeşitkenar üçgenin 2. kenar uzunlugunu girin");
                                        if (!double.TryParse(Console.ReadLine(), out ceskenar2))
                                        {
                                            Console.WriteLine("Sayı değeri girin");
                                            goto ceskenarAlma2;
                                        }
                                        if (ceskenar2 <= 0)
                                        {
                                            Console.WriteLine("Girilen sayı değeri 0 dan kücük ve 0 olamaz");
                                            goto ceskenarAlma2;
                                        }
                                        ceskenarAlma3:
                                        Console.WriteLine("Çeşitkenar üçgenin 3. kenar uzunlugunu girin");
                                        if (!double.TryParse(Console.ReadLine(), out ceskenar3))
                                        {
                                            Console.WriteLine("Sayı değeri girin");
                                            goto ceskenarAlma3;
                                        }
                                        if (ceskenar3 <= 0)
                                        {
                                            Console.WriteLine("Girilen sayı değeri 0 dan kücük ve 0 olamaz");
                                            goto ceskenarAlma3;
                                        }
                                        if (ceskenar1 + ceskenar2 <= ceskenar3 || ceskenar1 + ceskenar3 <= ceskenar2 || ceskenar2 + ceskenar3 <= ceskenar1)
                                        {
                                            Console.WriteLine("Geçersiz üçgen!  tekrar girin");
                                            goto ceskenarAlma1;
                                        }
                                        else
                                            sekil = new Ucgen(ceskenar1, ceskenar1, ceskenar2);
                                        if (hesaplama.Equals("alan"))
                                        {
                                            Console.WriteLine("Çeşitkenar ücgenin alanı : " + sekil.alanHesapla());
                                        }
                                        else
                                            Console.WriteLine("Çeşitkenar ücgenin cevresi : " + sekil.cevreHesapla());
                                        break;
                                    default:
                                        Console.WriteLine("Geçersiz üçgen tipi secimi");
                                        goto ucgentipi;
                                }
                                break;
                            case "2":
                                double karekenar;
                                kareKenar:
                                Console.WriteLine("Karenin kenar uzunlugu girin :");
                                if (!double.TryParse(Console.ReadLine(), out karekenar))
                                {
                                    Console.WriteLine("Sayı değeri girin");
                                    goto kareKenar;
                                }
                                if (karekenar <= 0)
                                {
                                    Console.WriteLine("Girilen sayı değeri 0 dan kücük ve 0 olamaz!");
                                    goto kareKenar;
                                }
                                Kare kar = new Kare(karekenar);
                                if (hesaplama.Equals("alan"))
                                {
                                    Console.WriteLine("Karenin alanı : " + kar.alanHesapla());
                                }
                                else
                                    Console.WriteLine("Karenin cevresi : " + kar.cevreHesapla());
                                break;
                            case "3":
                                double dikkenar1, dikkenar2;
                                
                                dikKenar1:
                                Console.WriteLine("Dikdörtgenin 1. kenar uzunlugu girin: ");
                                if (!double.TryParse(Console.ReadLine(), out dikkenar1))
                                {
                                    Console.WriteLine("Sayı değeri girin");
                                    goto dikKenar1;
                                }
                                if (dikkenar1 <= 0)
                                {
                                    Console.WriteLine("Girilen sayı değeri 0 dan küçük ve 0 olamaz");
                                    goto dikKenar1;
                                }

                                dikKenar2:
                                Console.WriteLine("Dikdörtgenin 2. kenar uzunlugu girin");
                                if (!double.TryParse(Console.ReadLine(), out dikkenar2))
                                {
                                    Console.WriteLine("Sayı değeri girin");
                                    goto dikKenar2;
                                }
                                if (dikkenar2 <= 0)
                                {
                                    Console.WriteLine("Girilen sayı değeri 0 dan küçük ve 0 olamaz");
                                    goto dikKenar2;
                                }
                                Dikdortgen dort = new Dikdortgen(dikkenar1, dikkenar2);
                                if (hesaplama.Equals("alan"))
                                {
                                    Console.WriteLine("Dikdortgenin alanı : " + dort.alanHesapla());
                                }
                                else
                                    Console.WriteLine("Dikdortgenin cevresi : " + dort.cevreHesapla());
                                break;
                                
                                case "4":
                                double yariCap;
                                
                                yariCap:
                                Console.WriteLine("dairenin yariCap uzunlugu girin");
                                if (!double.TryParse(Console.ReadLine(), out yariCap))
                                {
                                    Console.WriteLine("Sayı değeri girin");
                                    goto yariCap;
                                }
                                if (yariCap <= 0)
                                {
                                    Console.WriteLine("Girilen sayı değeri 0 dan kücük ve 0 olamaz");
                                    goto yariCap;
                                }
                                Daire dar = new Daire(yariCap);
                                if (hesaplama.Equals("alan"))
                                {
                                    Console.WriteLine("Dairenin alanı : " + dar.alanHesapla());
                                }
                                else
                                    Console.WriteLine("Dairenin cevresi : " + dar.cevreHesapla());
                                break;
                            default:
                                Console.WriteLine("Geçersiz çokgen secimi");
                                goto secim;
                        }
                        break;
                    case "2":
                        //Console.WriteLine("Programdan çıkış yapıldı.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Geçersiz ana menu girişi lütfen geçerli seçimlerden giriniz.");
                        goto ANAMENU;
                        break;
                }


            
        }

        public interface Hesapla
        {
            public double alanHesapla();
            public double cevreHesapla();

        }

        public class Dikdortgen : Hesapla
        {
            public double kenar1 { get; set; }
            public double kenar2 { get; set; }

            public Dikdortgen(double kenar1, double kenar2)
            {
                this.kenar1 = kenar1;
                this.kenar2 = kenar2;
            }

            public double alanHesapla() => kenar1 * kenar2;

            public double cevreHesapla() => ((kenar1 * 2) + (kenar2 * 2));

        }

        public class Kare : Hesapla
        {
            public double kenar1 { get; set; }

            public Kare(double kenar1)
            {
                this.kenar1 = kenar1;
            }

            public double alanHesapla() => kenar1 * kenar1;

            public double cevreHesapla() => kenar1 * 4;

        }
        public class Daire : Hesapla
        {
            public double yariCap { get; set; }

            public Daire(double yariCap)
            {
                this.yariCap = yariCap;
            }

            public double alanHesapla() => Math.PI * yariCap * yariCap;

            public double cevreHesapla() => 2 * Math.PI * yariCap;


        }


        public class Ucgen : Hesapla
        {
            public double kenar1 { get; set; }
            public double kenar2 { get; set; }
            public double kenar3 { get; set; }

            public Ucgen(double kenar1, double kenar2, double kenar3)
            {
                this.kenar1 = kenar1;
                this.kenar2 = kenar2;
                this.kenar3 = kenar3;
            }

            public double alanHesapla() => Math.Sqrt((cevreHesapla() / 2) * ((cevreHesapla() / 2) - kenar1) * ((cevreHesapla() / 2) - kenar2) * ((cevreHesapla() / 2) - kenar3));

            public double cevreHesapla() => kenar1 + kenar2 + kenar3;



        }

    }
}
