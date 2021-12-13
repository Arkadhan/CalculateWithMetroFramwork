using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    internal class Hesaplama 
    {
        public double ilkSayi;
        public char sembol;
        public double ikinciSayi;
        public double sonuc;
      

        public Hesaplama(double sayi1,double sayi2, char opt)
        {
            ilkSayi = sayi1;
            ikinciSayi = sayi2;
            sembol = opt;
        }
        public double HesapYap(double ilkSayi, double ikinciSayi, char sembol)
        {
            if (ilkSayi != 0.0 && ikinciSayi != 0.0)
            {
              switch (sembol)
                {
                    case '+':
                        sonuc = ilkSayi + ikinciSayi;
                        return sonuc;
                        break;

                    case '-':
                        sonuc = ilkSayi - ikinciSayi;
                        return sonuc;
                        break;

                    case '*':
                       sonuc = ilkSayi * ikinciSayi;
                        return sonuc;
                        break;
                    case '/':
                        sonuc = ilkSayi / ikinciSayi;
                        return sonuc;
                        break;
                    default:
                        return sonuc = 0.0;
                        break;
                }
            }
            else
            {
                ikinciSayi = 0.0;
                sonuc = 0.0;
            }
            return sonuc;
        }
    }
}
