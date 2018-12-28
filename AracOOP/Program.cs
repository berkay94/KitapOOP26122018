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
   public enum AracTipi
    {
        Kara=1,
        Deniz=2,
        Hava=3
    }
    public enum YakitTuru
    {
        Benzin=1,
        Mazot=2,
        Elektrik=3,
        Lpg=4,
        Nukleer=5,
        Ruzgar=6,
        Diger=7

    }
    public enum KasaTipi
    {
        Sedan=1,
        HatchBack=2,
        Station=3,
        Cabrio=4,
        Cupe=5
    }
   public enum UcakTuru
    {
        Yolcu=1,
        Savaş=2,
        Eğitim=3,
        Kargo=4
    }
}
