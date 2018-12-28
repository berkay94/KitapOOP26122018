using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Otomobil o = new Otomobil(AracTipi.Kara, YakitTuru.Benzin,KasaTipi.Sedan,"Ford",2017,"Amerika",120);

            //Console.WriteLine(o.ToString());
            //o.DepoDoldur = 20;
            //o.DepoDoldur = 30;

            //o.Calistir();
            //o.Calistir();
            //o.ToString();

            Ucak u = new Ucak();
            u.UcakTuru = UcakTuru.Yolcu;
            u.MotorSayisi = 5;
            u.Uzunluk = 40;
            u.YakitTuru = YakitTuru.Diger;
            u.Model = "Boeing";
            u.KanatAcikligi = 10;
            u.Hiz = 500;
            u.Mensei = "USA";
            u.Kapasite = 20000;
            u.YolcuSayisi = 150;
           
            
            Console.WriteLine(u.ToString());
            
            Console.ReadLine();
            
        }
    }

    class Arac:IArac
    {
        AracTipi aracTipi;
        string model;
        int yil;
        string mensei;
        int beygirGucu;
        YakitTuru yakitTuru;
        KasaTipi kasaTipi;

        public int BeygirGucu
        {
            get
            {
                return beygirGucu;
            }
            set
            {
                if (value > 0 && value <= 1000)
                {
                    beygirGucu = value;
                }
                else
                {
                    Console.WriteLine("Beygir Gucu 0 ile 1000 arasinda olmali");
                }
            }
        }
        public string Mensei
        {
            get
            {
                return mensei;
            }
            set
            {
                mensei = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public YakitTuru YakitTuru
        {
            get
            {
                return yakitTuru;
            }
                
            set
            {
                yakitTuru = value;
            }
        }
        public int Yil {
            get
            {
                return yil;
            }
            set
            {
                if(value>=1908 && value<=DateTime.Now.Year)
                {
                    yil = value;
                }
                else
                {
                    Console.WriteLine($"Arac uretim yili 1908 yilindan kucuk ve bulundugu yildan buyuk olamaz");
                }
            }
        }
        public AracTipi AracTipi
        {
            get
            {
                return aracTipi;
            }
            set
            {
                aracTipi = value;
            }
        }
        public KasaTipi KasaTipi
        {
            get
            {
                return kasaTipi;
            }
            set
            {
                kasaTipi = value;
            }
        }

        
        public YakitTuru YakitTur { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Yili { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int BeygirGuccu { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public AracTipi AracTipleri { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Temel Özellikler");
            sb.AppendLine("---------------");
            sb.AppendLine($"Araç Modeli: {Model}");
            sb.AppendLine($"Arac Yili: {Yil}");
            sb.AppendLine($"Mensei: {Mensei}");
            sb.AppendLine($"AracTipi: {AracTipi}");
            sb.AppendLine($"BeygirGucu: {BeygirGucu}");
            sb.AppendLine($"YakitTuru: {YakitTuru}");
            sb.AppendLine("----------------");
                
            
            return sb.ToString();
        }

        public void Yaz()
        {
            Console.WriteLine(this.ToString());
        }
    }
    class Otomobil:Arac
    {
        bool calistimi;
        string renk;
        int kapiSayisi;
        int vitesTuru;
        int kasaTipi;
        int depo;
        int hiz;

        public int DepoDoldur
        {
            set
            {
                int temp = value + depo;
                if (temp <= 80 && temp >= 0)
                {
                    depo += value;
                    Console.WriteLine($"Depo şu anda {depo} lt oldu. {value} lt yakit alindi");
                }
                else
                {
                    Console.WriteLine("Alinan yakit depo hacminden fazladir");
                }
            }
        }


        public bool Calistir()
        {
            if (depo > 0)
            {
                calistimi = true;
                Console.WriteLine("Araç Calisti");
                
            }
            else
            {
                Console.WriteLine("Depo Bos Yakit Alin");
            }

            return calistimi;

            
        }

        public bool Durdur()
        {
            if (calistimi == true)
            {
                calistimi = false;
                hiz = 0;
            }
            return calistimi;
        }
        public int hiziArttir()
        {
            if(calistimi==true)
               hiz += 10;
            else
            {
                Console.WriteLine("Arac Calısmıyor");
            }


            return hiz;
        }

        public void Durum()
        {
            string c = calistimi ? "Calisiyor" : "Calismiyor";
            Console.WriteLine($"Arac şu anda {c} ve hizi {hiz} km Depoda {depo} litre yakit var");

            
        }
        public override string ToString()
        {
            string str;
            str = base.ToString();
            str += $"Renk:{renk} \nKasaTipi:{KasaTipi}";
            return str;
        }

        public Otomobil(AracTipi aracTipi, YakitTuru yakit,KasaTipi kasaTipi,string model,int yil,string mensei,int beygirGucu,string Renk="Beyaz")
        {
            AracTipi = aracTipi;
            Model = model;
            Yil = yil;
            Mensei = mensei;
            BeygirGucu = beygirGucu;
            renk = Renk;
            YakitTuru = yakit;
            KasaTipi = kasaTipi;
        }
        public Otomobil()
        {

        }

    }

    class Ucak:Arac
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



        public  int Kapasite
        {
            get
            {
                return kapasite;
            }
            set
            {
                if (value>0 && value<=20000)
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
            sb.AppendLine($"Hiz: {Hiz}"+" "+"km");
            sb.AppendLine($"Mensei: {Mensei}");
            sb.AppendLine($"Uzunluk: {Uzunluk}"+" "+"metre");
            sb.AppendLine($"Kanat Acikligi: {KanatAcikligi}"+" "+"metre");
            sb.AppendLine("----------------");

            return sb.ToString();
        }

    }

    interface IArac
    {
       
        string Model { get; set; }
        string Mensei { get; set; }
        YakitTuru YakitTur { get; set; }
        int Yili { get; set; }
        int BeygirGuccu{ get; set; }
        AracTipi AracTipleri { get; set; }

        void Yaz();
    }

    interface IKapasite
    {
        int  Kapasitesi{ get; set; }
        int YolcuAdedi { get; set; }
        int MotorAdedi { get; set; }

        void KapasiteYaz();

    }
    enum AracTipi
    {
        Kara=1,
        Deniz=2,
        Hava=3
    }
    enum YakitTuru
    {
        Benzin=1,
        Mazot=2,
        Elektrik=3,
        Lpg=4,
        Nukleer=5,
        Ruzgar=6,
        Diger=7

    }
    enum KasaTipi
    {
        Sedan=1,
        HatchBack=2,
        Station=3,
        Cabrio=4,
        Cupe=5
    }
    enum UcakTuru
    {
        Yolcu=1,
        Savaş=2,
        Eğitim=3,
        Kargo=4
    }
}
