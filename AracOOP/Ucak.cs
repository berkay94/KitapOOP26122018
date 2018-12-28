using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracOOP
{
     public class Ucak : Arac
    {
        int yolcuSayisi;
        UcakTuru ucakTuru;
        int motorSayisi;
        int hiz;
        int uzunluk;
        int kanatAcikligi;
        public int kapasite;



        public Ucak(UcakTuru ucakTuru)
        {
            UcakTuru = ucakTuru;
            YolcuSayisi = yolcuSayisi;
            MotorSayisi = motorSayisi;
            Hiz = hiz;
            Uzunluk = uzunluk;
            KanatAcikligi = kanatAcikligi;
            Kapasite = kapasite;
        }
        public Ucak()
        {

        }



        public int Kapasite
        {
            get
            {
                return kapasite;
            }
            set
            {
                if (value > 0 && value <= 20000)
                {
                    kapasite = value;
                }
                else
                {
                    Console.WriteLine("Kapasite 20000 dir");
                }
            }
        }

        public UcakTuru UcakTuru
        {
            get
            {
                return ucakTuru;
            }
            set
            {
                ucakTuru = value;

            }
        }
        public int YolcuSayisi
        {
            get
            {
                return yolcuSayisi;
            }
            set
            {
                yolcuSayisi = value;
            }
        }
        public int MotorSayisi
        {
            get
            {
                return motorSayisi;
            }
            set
            {
                motorSayisi = value;
            }
        }
        public int Hiz
        {
            get
            {
                return hiz;
            }
            set
            {
                hiz = value;
            }
        }
        public int Uzunluk
        {
            get
            {
                return uzunluk;
            }
            set
            {
                uzunluk = value;
            }
        }
        public int KanatAcikligi
        {
            get
            {
                return kanatAcikligi;
            }
            set
            {
                kanatAcikligi = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Temel Özellikler");
            sb.AppendLine("---------------");
            sb.AppendLine($"Ucak Turu: {UcakTuru}");
            sb.AppendLine($"Yolcu Sayisi: {YolcuSayisi}");
            sb.AppendLine($"Motor Sayisi: {MotorSayisi}");
            sb.AppendLine($"YakitTuru: {YakitTuru}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Kapasite: {Kapasite}");
            sb.AppendLine($"Hiz: {Hiz}" + " " + "km");
            sb.AppendLine($"Mensei: {Mensei}");
            sb.AppendLine($"Uzunluk: {Uzunluk}" + " " + "metre");
            sb.AppendLine($"Kanat Acikligi: {KanatAcikligi}" + " " + "metre");
            sb.AppendLine("----------------");

            return sb.ToString();
        }

    }
}
