using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracOOP
{
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
}
