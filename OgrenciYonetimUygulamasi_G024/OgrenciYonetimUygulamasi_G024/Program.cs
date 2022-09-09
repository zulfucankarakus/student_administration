using System;
using System.Collections.Generic;

namespace OgrenciYonetimUygulamasi_G024
{
    class Program
    {
        static List<Ogrenci> Ogrenciler = new List<Ogrenci>();
        static void Main(string[] args)
        {
            SahteVeriEkle();

            Uygulama();
        }
        static void Test()
        {
            Ogrenci o1 = new Ogrenci();
            o1.Ad = "Zülfücan";
            o1.Soyad = "Karakuş";
            o1.No = 34;
            o1.Sube = "A";
            o1.MatNotu = 100;
            o1.TurkceNotu = 45;
            o1.FenNotu = 80;
            o1.SosyalNotu = 20;

            Ogrenci o2 = new Ogrenci("Furkan","Yaraşır",56);
            //o2.Ad = "Furkan";
            //o2.Soyad = "Yaraşır";
            //o2.No = 56;
            o2.Sube = "B";
            o2.MatNotu = 73;
            o2.TurkceNotu = 94;
            o2.FenNotu = 56;
            o2.SosyalNotu = 93;

            Ogrenci o3 = new Ogrenci();
            o3.Ad = "Halil";
            o3.Soyad = "Malatyalı";
            o3.No = 74;
            o3.Sube = "C";
            o3.MatNotu = 59;
            o3.TurkceNotu = 74;
            o3.FenNotu = 75;
            o3.SosyalNotu = 48;

            float ort1 = o1.OrtalamaGetir("sayısal");
            float ort2 = o2.OrtalamaGetir("sozel");
            float ort3 = o3.OrtalamaGetir();

            Console.WriteLine("Sınıf ortalaması: " + (ort1 + ort2 + ort3) / 3);
        }



        static string ılkharfbuyuk(string veri)
        {
            veri = veri.Substring(0, 1).ToUpper() + veri.Substring(1).ToLower();
            return veri;
        }
        static void Uygulama()
        {
            int sayac = 0;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Seçiniz");
                string secim = Console.ReadLine().ToUpper();
                sayac++;
                Menu();

                switch (secim)
                {
                    case "E":
                    case "1":
                        OgrenciEkle();
                        break;
                    case "L":
                    case "2":
                        OgrenciListele();
                        break;
                    case "S":
                    case "3":
                        OgrenciSil();
                        break;
                    case "X":
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Hatalı giriş yapıldı");
                        break;
                }
                if (sayac == 10)
                {
                    Console.WriteLine();
                    Console.WriteLine("Üzgünüm sizi anlayaıyorum.Program sonlandırılıyor...");
                }

            } while (sayac != 10);
            

        }

        static string SecimAl()
        {
            
            Console.Write("Seçiminiz: ");
            string giris = Console.ReadLine().ToUpper();
            //
            return giris;
        }



        static void Menu()
        {
            Console.WriteLine("Öğrenci Yönetim Uygulaması");
            Console.WriteLine("1 - Öğrenci Ekle(E)       ");
            Console.WriteLine("2 - Öğrenci Listele(L)    ");
            Console.WriteLine("3 - Öğrenci Sil(S)        ");
            Console.WriteLine("4 - Çıkış(X)              ");
        }

        static void OgrenciSil()
        {
            if (Ogrenciler.Count == 0)
            {
                Console.WriteLine("listede silinecek öğrenci yok");
                return;
            }
            Console.WriteLine("3- Öğrenci Sil--------");
            Console.WriteLine("Silmek istediğiniz öğrencinin");
            Console.Write("No: ");
            int no = int.Parse(Console.ReadLine());
            Ogrenci ogr = null;
            foreach (Ogrenci x in Ogrenciler)
            {
                if (x.No == no)
                {
                    ogr = x;
                    break;
                }
            }
            if (ogr != null)
            {
                Console.WriteLine("Adı: " + ogr.Ad);
                Console.WriteLine("Soyadı: " + ogr.Soyad);
                Console.WriteLine("Şubesi: " + ogr.Sube);
                Console.WriteLine("Öğrenciyi silmek istediğinize emin misiniz? (E/H)");
                string secim = Console.ReadLine();
                if (secim.ToUpper() == "E")
                {
                    Ogrenciler.Remove(ogr);
                    Console.WriteLine("Öğrenci silindi.");
                }
                else
                {
                    Console.WriteLine("Öğrenci silinmedi.");
                }
            }
            if(Ogrenciler.Count != 0)
            {
                if (ogr == null)
                {
                    Console.WriteLine("Listede böyle bir öğrenci yok");
                }
            }
        }



        static void SahteVeriEkle()
        {
            Ogrenci o1 = new Ogrenci();
            o1.Ad = "Zülfücan";
            o1.Soyad = "Karakuş";
            o1.No = 34;
            o1.Sube = "A";
            Ogrenci o2 = new Ogrenci();
            o2.Ad = "Furkan";
            o2.Soyad = "Yaraşır";
            o2.No = 56;
            o2.Sube = "B";
            Ogrenci o3 = new Ogrenci();
            o3.Ad = "Halil";
            o3.Soyad = "Malatyalı";
            o3.No = 74;
            o3.Sube = "B";
            Ogrenciler.Add(o1);
            Ogrenciler.Add(o3);
            Ogrenciler.Add(o2);
        }
        static void OgrenciListele()
        {
            if (Ogrenciler.Count == 0)
            {
                Console.WriteLine("listede görüntülenecek öğrenci yok");
                return;
            }
            Console.WriteLine("2- Öğrenci Listele-----------");
            Console.WriteLine();
            string str=("Şube   No    Ad Soyad");
            Console.WriteLine(str.PadLeft(23));
            Console.WriteLine("--------------------------------");

            foreach (Ogrenci x in Ogrenciler)
            {
                Console.WriteLine(ılkharfbuyuk(x.Sube).PadLeft(4) + "      " + x.No + "    " + ılkharfbuyuk(x.Ad) + " " + ılkharfbuyuk(x.Soyad));
            }
        }

        static void OgrenciEkle()
        {
            Ogrenci o = new Ogrenci();
            int aranandeger;
            Console.WriteLine("1- Öğrenci Ekle--------");
            Console.WriteLine((Ogrenciler.Count+1)+". Öğrencinin");
            Console.Write("No: ");
            o.No = int.Parse(Console.ReadLine());
            foreach(Ogrenci x in Ogrenciler)
            {
                while (x.No == o.No)
                {
                    Console.WriteLine("Tekrar no giriniz");
                    o.No = int.Parse(Console.ReadLine());
                    if(x.No != o.No)
                    {
                        break;
                    }
                }
            }
            Console.Write("Adı: ");
            o.Ad = Console.ReadLine();
            Console.Write("Soyadı: ");
            o.Soyad = Console.ReadLine();
            Console.Write("Şubesi: ");
            o.Sube = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Öğrenciyi kaydetmek istediğinize emin misiniz? (E/H)");
            string secim = Console.ReadLine();

            if (secim.ToUpper() == "E")
            {
                Ogrenciler.Add(o);
                Console.WriteLine("Öğrenci eklendi.");
            }
            else
            {
                Console.WriteLine("Öğrenci eklenmedi.");
            }
            

        }


    }

}
