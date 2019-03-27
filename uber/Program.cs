using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBER_ÜCRET_HESAPLAMA
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                float[] costPerMile = { 1.1f, 1.8f, 2.3f, 3.5f };
                float[] costPerMinute = { 0.2f, 0.35f, 0.4f, 0.45f };
                bool durum;
                float[] sonuc = new float[4];
                int rideDist=0;
                int rideTime = 0;
                while (durum=true)
                { 
                Console.WriteLine("Mesafeyi giriniz.");
                rideDist = Convert.ToInt32(Console.ReadLine());

                if (rideDist >= 5 && rideDist <= 20)
                {
                    durum = true;
                        break;
                }
                else
                {
                    Console.WriteLine("Geçerli mesafe girilmedi.");
                    durum = false;
                }
                }
                while(durum=true)
                { 
                Console.WriteLine("Yolculuk süresini giriniz.");
                rideTime = Convert.ToInt32(Console.ReadLine());
                if (rideTime >= 10 && rideTime <= 50)
                {
                    durum = true;
                        break;
                }
                else
                {
                    Console.WriteLine("Geçerli süre girilmedi.");

                    durum = false;
                }
                }


                if (durum == true)
                {

                    
                    for (int i = 0; i < costPerMile.Length; i++)
                    {
                        sonuc[i] = (costPerMile[i] * rideDist) + (costPerMinute[i] * rideTime);
                    }

                    for (int i = 0; i < sonuc.Length; i++)
                    {
                        Console.Write("{0}   ", sonuc[i]);
                    }
                }
                Console.ReadKey();
            }
        }
    }
}

