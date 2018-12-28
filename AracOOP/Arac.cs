using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracOOP
{
   public class Arac : IArac, IKapasite
    {
        AracTipi aracTipi;
        string model;
        int yil;
        string mensei;
        int beygirGucu;
        YakitTuru yakitTuru;
        KasaTipi kasaTipi;
        UcakTuru ucakTur;

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
        public int Yil
        {
            get
            {
                return yil;
            }
            set
            {
                if (value >= 1908 && value <= DateTime.Now.Year)
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
        public int Kapasitesi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int YolcuAdedi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int MotorAdedi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public UcakTuru UcakTuru
        {
            get
            {
                return ucakTur;
            }
            set
            {
                ucakTur = value;
            }
        }

        

        public void KapasiteYaz()
        {
            Console.WriteLine($"Yolcu Sayisi{YolcuAdedi}\nMotor Sayisi: {MotorAdedi}\nKapasite: {Kapasitesi}");
        }

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
}
