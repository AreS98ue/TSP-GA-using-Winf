using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP_GA_WINF
{   
    public class Kordinate
    {
        public int DuzinaNiza;
        public int[,] TackeSaKordinatama;
        Random NasumicanBroj;
        const int TackeG = 100;
        const int TackeD = 0;
        
        public Kordinate()
        {
            DuzinaNiza = 0;
            TackeSaKordinatama = new int[0, 0];
            NasumicanBroj = new Random();
        }
        public void InicijalizacijaKordinati ()
        {
            
            //pocetna tacka je 0 0 na kordinatnom sistemu
            TackeSaKordinatama = new int[3, DuzinaNiza];
            TackeSaKordinatama[0, 0] = 0;
            TackeSaKordinatama[1, 0] = 0;
            TackeSaKordinatama[2, 0] = 0;
            

            // Dodeljivanje nasumicnih vrednosti tackama
            for (int i = 1; i < DuzinaNiza; i++)
            {
                int nasumicanbrX = NasumicanBroj.Next(TackeD, TackeG);
                int nasumicanbrY = NasumicanBroj.Next(TackeD, TackeG);

                TackeSaKordinatama[0, i] = i;
                TackeSaKordinatama[1, i] = nasumicanbrX;
                TackeSaKordinatama[2, i] = nasumicanbrY;
            }

            
        }
    }
}
