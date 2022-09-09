using System;
using System.Collections.Generic;
using System.Text;

namespace OgrenciYonetimUygulamasi_G024
{

    class Ogrenci
    {
        public int No;
        public string Ad;
        public string Soyad;
        public string Sube;

        public int TurkceNotu;
        public int MatNotu;
        public int FenNotu;
        public int SosyalNotu;

        public Ogrenci()
        {

        }

        public Ogrenci(string ad,string soyad,int no)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;

        }

        public void OrtalamaYazdır()
        {
            int toplam = TurkceNotu + MatNotu + FenNotu + SosyalNotu;
            float ortalama = (float)toplam / 4;
            Console.WriteLine(Ad + " adlı öğrencinin ortalaması : " + ortalama);
        }

        public float OrtalamaGetir()
        {
            int toplam = TurkceNotu + MatNotu + FenNotu + SosyalNotu;
            float ortalama = (float)toplam / 4;
            return ortalama;
        }

        public float OrtalamaGetir(string tur)
        {
            if (tur == "sozel")
            {
                int toplam = TurkceNotu + MatNotu + FenNotu + SosyalNotu;
                float ortalama = (float)toplam / 2;
                return ortalama;
            }
            else if (tur == "sayısal")
            {
                int toplam = MatNotu + FenNotu;
                float ortalama = (float)toplam / 2;
                return ortalama;
            }
            else
            {
                int toplam = TurkceNotu + MatNotu + FenNotu + SosyalNotu;
                float ortalama = (float)toplam / 4;
                return ortalama;
            }
        }


    }
}
