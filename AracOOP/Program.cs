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
            Otomobil o = new Otomobil(1,"Ford",2017,"Amerika",120);
            
            Console.WriteLine(o.ToString());
            o.DepoDoldur = 20;
            o.DepoDoldur = 30;
           
            o.Calistir();
            o.Calistir();
            o.ToString();
            
            Console.ReadLine();
            Console.Write("fsfsdf");
        }
    }

    class Arac
    {
        int aracTipi;
        string model;
        int yil;
        string mensei;
        int beygirGucu;
        int yakitTuru;

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
                    Console.WriteLine("Beygir Gucu 0 il 1000 arasinda olmali");
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
        public int YakitTuru
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
        public int AracTipi
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

    }
    class Otomobil:Arac
    {
        bool calistimi;
        string renk;
        int kapiSayisi;
        int vitesTuru;
        string kasaTipi;
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
            str = $"Araç Modeli: {Model} \nArac Yili: {Yil} \nMensei: {Mensei} \nAracTipi: {AracTipi} \nBeygirGucu: {BeygirGucu} \nRenk:{renk}";
            return str;
        }

        public Otomobil(int aracTipi,string model,int yil,string mensei,int beygirGucu,string Renk="beyaz")
        {
            AracTipi = aracTipi;
            Model = model;
            Yil = yil;
            Mensei = mensei;
            BeygirGucu = beygirGucu;
            renk = Renk;
        }
        public Otomobil()
        {

        }

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
}
