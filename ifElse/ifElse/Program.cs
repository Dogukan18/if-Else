using System;

namespace ifElse
{
    class Program
    {
        static void Main(string[] args)
        {

          //if-else:kontrol mekanizmasıdır doğru ya da yanlış mantığıyla hareket eder.

          //isim mehmet ise doğru değilse yanlış uyarısı veren uygulama.

            /*   string isim;
                isim = "mehmet";
                if (isim=="mehmet")
                {
                    Console.WriteLine("Doğru İsim Girişi");
                }
                else
                {
                    Console.WriteLine("Hatalı İsim Girişi");
                }

                Console.ReadKey(); */

            //-------------------------------------------------------------------------------------------------

            //Klavyeden girilen ismin doğru mu yanlış mı olduğunu söyleyen uygulama

            /*    string isim;
               Console.Write("İsmi Giriniz: ");
               isim = Console.ReadLine();
               Console.WriteLine();

               if (isim == "doğukan") 
               {
                   Console.WriteLine("Doğru Giriş");
               }

               else
               {
                   Console.WriteLine("Hatalı Giriş!!");
               }

               Console.ReadLine(); */

            //-----------------------------------------------------------------------------------------------

            //Klavyeden girilen şehrin başkent olup olmadığını bilen uygulama

            /*   string sehir;

                Console.Write("Türkiye'nin Başkenti: ");
                sehir = Console.ReadLine();

                if (sehir == "Ankara") 
                {
                    Console.WriteLine("Doğru");
                }

                else
                {
                    Console.WriteLine("Yanlış");
                }

                Console.ReadKey(); */

            //------------------------------------------------------------------------------------------------

            //Klavyeden girilen sayının pozitif mi negatif mi olduğunu bilen uygulama

            /*   int sayi;

               Console.Write("Sayı Giriniz: ");
               sayi = Convert.ToInt32(Console.ReadLine());

               if (sayi < 0) 
               {
                   Console.WriteLine("Negatif Sayı");
               }

               else
               {
                   Console.WriteLine("Pozitif Sayı");
               }

               Console.ReadKey(); */

            //-----------------------------------------------------------------------------------------------

            //Klavyeden girilen sınav sonuçları ile ortalamayı bulup geçip kaldığını bulan uygulama

            /*  int sinav1, sinav2,sinav3,ort;

              Console.Write("1.Sınav: ");
              sinav1 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine();

              Console.Write("2.Sınav: ");
              sinav2 = Convert.ToInt32(Console.ReadLine());

              Console.WriteLine();

             Console.Write("3.Sınav: ");
             sinav3 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine();

             ort = (sinav1 + sinav2 + sinav3) / 3;
             Console.Write("Ortalamanız: " +ort );
              Console.WriteLine();
              Console.WriteLine();


              if (ort >= 50)

              {
                  Console.WriteLine("Tebrikler Dersi Geçtiniz");
              }

              else
              {
                  Console.WriteLine("Üzgünüz Dersi Geçemediniz");
              }

              Console.ReadKey(); */


            //-----------------------------------------------------------------------------------------

            //Vki hesaplama;

            /*   double boy, kilo ;
               double ort;

               Console.Write("Kilonuzu Giriniz: ");
               kilo = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine();
               Console.Write("Boyunuzu Giriniz: ");
               boy = Convert.ToInt32(Console.ReadLine());
               boy = boy / 100;
               Console.WriteLine();

               ort = kilo / (boy * boy);

               Console.Write("Vücut Kitle İndeksiniz: " + ort);
               Console.WriteLine();
               Console.WriteLine();


               if (ort<=18.49)
               {
                   Console.WriteLine("İdeal Kilonun Altı");
               }

              else if (ort>=18.5 && ort<=24.99)
              {
                  Console.WriteLine("İdeal Kilo");
              }

               else if(ort>=25 && ort<=29.99)
              {
                  Console.WriteLine("İdeal Kilonun Üzeri");
              }

              else if (ort>=30)
              {
                  Console.WriteLine("İdeal Kilonun Çok Üzeri");
              }

             Console.ReadLine();  */


            //------------------------------------------------------------------------------------

            // Öğrencinin ortalamasına göre  başarı durumunu gösteren uygulama

            /*  int sinav1, sinav2, proje, ort;
               Console.Write("1.Sınav: ");
               sinav1 = Convert.ToInt32(Console.ReadLine());
               Console.Write("2.Sınav: ");
               sinav2 = Convert.ToInt32(Console.ReadLine());
               Console.Write("Proje Notu: ");
               proje = Convert.ToInt32(Console.ReadLine());

               ort = (sinav1 + sinav2 + proje) / 3;
               Console.Write("Ortalamanız: " + ort);

               Console.WriteLine();
               Console.WriteLine();


               if (ort>=1 && ort<=49)
               {
                   Console.WriteLine("Başarı Durumunuz: Çok Kötü");
               }

               else if (ort>=50 && ort<=69)
               {
                   Console.WriteLine("Başarı Durumunuz: Orta");
               }

               else if (ort>=70 && ort<=84)
               {
                   Console.WriteLine("Başarı Durumunuz: İyi");
               }

               else if (ort>=85 && ort<=100)
               {
                   Console.WriteLine("Başarı Durumunuz: Çok İyi");
               }

               else if (ort>=101 )
               {
                   Console.WriteLine("Hata: Yanlış Not Girişi");
               }

             else if (ort==0)
             {
                 Console.WriteLine("Hata:Yanlış Not Girişi");
             }

               Console.ReadKey();  */

            //--------------------------------------------------------------------------------------

            // Klavyeden Girilen Sayının Tek mi Çift mi olduğunu bulan uygulama

            /*   int sayi;

               Console.Write("Sayı Giriniz: ");
               sayi = Convert.ToInt32(Console.ReadLine());

               if (sayi%2 == 0 )
               {
                   Console.WriteLine("Girdiğiniz sayı:{0}" , sayi);
                   Console.WriteLine("{0} Sayısı Çifttir", sayi);
               }

               else
               {
                   Console.WriteLine("Girdiğiniz Sayı: {0}" , sayi);
                   Console.WriteLine("{0} Sayısı Tektir", sayi);
               }


               Console.ReadKey(); */

            //--------------------------------------------------------------------------------------------------

            //klavyeden girilen sayının 5'e tam bölünüp bölünmediğini bulan uygulama

            /*   int sayi;
                Console.Write("Sayı Giriniz: ");
                sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi % 5 == 0 )
                {
                    Console.WriteLine("{0} Sayısı 5 ile Tam Bölünebilmektedir", sayi);
                }

                else
                {
                    Console.WriteLine("{0} Sayısı 5 ile Tam Bölünemez",sayi);
                }


                Console.ReadKey(); */

            //--------------------------------------------------------------------------------------------------

            //Klavyeden mevsimi girince ayları sıralayan uygulama

            /*   string mevsim;
               Console.Write("Mevsim Giriniz: ");
               mevsim = Console.ReadLine();

               if (mevsim=="kış" || mevsim=="Kış")
               {
                   Console.Write("Kış Ayları:Aralık,Ocak,Şubat");
               }

               else if (mevsim=="ilkbahar" || mevsim == "İlkbahar")
               {
                   Console.Write("İlkbahar Ayları:Mart,Nisan,Mayıs");
               }

               else if (mevsim=="yaz" || mevsim == "Yaz")
               {
                   Console.Write("Yaz Ayları:Haziran,Temmuz,Ağustos");
               }

               else if (mevsim=="Sonbahar" || mevsim == "Sonbahar")
               {
                   Console.Write("Sonbahar Ayları:Eylül,Ekim,Kasım");
               }
               Console.ReadKey(); */

            //--------------------------------------------------------------------------------------------------
            //Alışveriş tutarına göre indirim yapan uygulama

          /*  int tutar, indirim, odenecek;

            
            Console.Write("Alışveriş Tutarı: ");
            tutar = Convert.ToInt32(Console.ReadLine());

            if (tutar<=100)
            {
                indirim = (tutar * 10) / 100;
                odenecek = tutar - indirim;
                Console.Write("İndirim Miktarı: {0} TL " , indirim);
                Console.WriteLine();
                Console.Write("İndirimli Fiyatı: {0} TL " , odenecek);

            }

            else if (tutar>100 && tutar<=150)
            {
                indirim = (tutar * 15) / 100;
                odenecek = tutar - indirim;
                Console.Write("İndirim Miktarı: {0} TL " ,indirim);
                Console.WriteLine();
                Console.Write("İndirimli Fiyatı: {0} TL ", odenecek);
            }

            else if (tutar>=151 && tutar<=200)
            {indirim = (tutar * 20) / 100;
                odenecek = tutar - indirim;
                Console.Write("İndirim Miktarı: {0} TL " , indirim);
                Console.WriteLine();
                Console.Write("İndirimli Fiyatı: {0} TL " , odenecek);
             }

            Console.Read(); */


        }
    }
}
