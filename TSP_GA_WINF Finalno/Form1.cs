using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSP_GA_WINF
{
    public partial class Form1 : Form
    {

        Random NasumicanBR = new Random();

        Kordinate ListaGradovaSaKord = new Kordinate();

        List<int> Lista = new List<int>();

        List<int> VrednostXgrafik = new List<int>();
        List<int> VrednostYgrafik = new List<int>();

        // unosne vred

        int velicinaPop = 0; //velicina unete pop

        int DuzinaHrom = 0; // duzina niza

        int ProcenatMutacije = 0;

        int UkBrojCiklusa = 0;



        // izlazne vred
        int BrojacGen = 1;
        int[] KordinateNajPutanje;
        double DuzinaNajkraceDistance = 0;
        int BrojNajGen;

        //varijable kljuca 
        int brojacukupnevred ;
        double[] ukupnevred ;
        int[] pozicije ;
        public Form1()
        {
            InitializeComponent();
      
            btnObrisi.Enabled = false;
        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        // Metoda za ispisvanje generisanih kordinata u txtbox
        private void IspisivanjeKordinata (int listaGradovaSaKord, int [,] gradoviSaKord) 
        {
            for (int i = 0; i < listaGradovaSaKord; i++)
            {
                txtboxKordinate.Text += gradoviSaKord[0, i].ToString() + ": ";
                txtboxKordinate.Text += "X: " + gradoviSaKord[1, i].ToString() + " ";
                txtboxKordinate.Text += "Y: " + gradoviSaKord[2, i].ToString() + " " + "\r\n";

            }
        }
       
       
        private void btnPokreni_Click(object sender, EventArgs e)
        {
            btnObrisi.Enabled = true;
            chart1.Visible = true;
            //async
            var worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerAsync();


            btnPokreni.Enabled = false;
            
            
        }
        // async
        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            //Glorious time-consuming code that no longer blocks!
            // Odredjujemo koliko ukupno ima redova
            // +1 je zbog pocetne tacke
            ListaGradovaSaKord.DuzinaNiza = int.Parse(txtboxBrojKlijenata.Text) + 1;

            // Matrica sa tackama i njhivoim kordinatama
            ListaGradovaSaKord.InicijalizacijaKordinati();

            // Ispisujemo tacke i njhove vrednosti u txtBox
            IspisivanjeKordinata(ListaGradovaSaKord.DuzinaNiza, ListaGradovaSaKord.TackeSaKordinatama);


            velicinaPop = int.Parse(txtboxPopulacija.Text);

            if (velicinaPop % 2 == 1)
            {
                velicinaPop++;
            }

            DuzinaHrom = int.Parse(txtboxBrojKlijenata.Text);

            ProcenatMutacije = int.Parse(txtboxProcenatMutacije.Text);

            UkBrojCiklusa = int.Parse(txtboxBrojCiklusa.Text);
            //
            KordinateNajPutanje = new int[DuzinaHrom + 2];
            KordinateNajPutanje[0] = 0;
            KordinateNajPutanje[KordinateNajPutanje.Length - 1] = 0;
            //
            int[,] PrvaGenHrom = PrvaGeneracijaHromozoma();

            Razmnozavanje(PrvaGenHrom);

            txtboxDuzinaPutanje.Text = DuzinaNajkraceDistance.ToString();
            txtboxNajGen.Text = BrojNajGen.ToString();


            for (int i = 0; i < KordinateNajPutanje.Length; i++)
            {
                txtboxRezKord.Text += KordinateNajPutanje[i] + ", ";

            }


            Crtanje();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            //dugme
            btnPokreni.Enabled = true;

            //
            ListaGradovaSaKord = new Kordinate();

            Lista = new List<int>();

            // unosne vred

            velicinaPop = 0; //velicina unete pop

            DuzinaHrom = 0; // duzina niza

            ProcenatMutacije = 0;

            UkBrojCiklusa = 0;

            NasumicanBR = new Random();

            // izlazne vred
            BrojacGen = 1;
            KordinateNajPutanje = new int[0];
            DuzinaNajkraceDistance = 0;
            BrojNajGen = 0;

            VrednostXgrafik.Clear();
            VrednostYgrafik.Clear();
  
            //
            this.Controls.Clear();
            this.InitializeComponent();



        }

        //crtanje grafika
        public void Crtanje()
        {
            for (int i = 0; i < KordinateNajPutanje.Length; i++)
            {
                VrednostXgrafik.Add(ListaGradovaSaKord.TackeSaKordinatama[1, KordinateNajPutanje[i]]);
                VrednostYgrafik.Add(ListaGradovaSaKord.TackeSaKordinatama[2, KordinateNajPutanje[i]]);

            }
            chart1.Series["Putanja"].Points.DataBindXY(VrednostXgrafik, VrednostYgrafik);


        }

        //
        // deo za genetiku

        public int[,] PrvaGeneracijaHromozoma()
        {

            int[,] PrvaGenHrom = new int[velicinaPop, DuzinaHrom];

            for (int i = 1; i <= DuzinaHrom; i++)
            {
                Lista.Add(i);

            }

            for (int i = 0; i < velicinaPop; i++)
            {
                var KopijaListe = new List<int>(Lista);

                for (int k = 0; k < DuzinaHrom; k++)
                {
                    int nasumicanIndeks = NasumicanBR.Next(0, KopijaListe.Count);
                    PrvaGenHrom[i, k] = KopijaListe.ElementAt(nasumicanIndeks);
                    KopijaListe.RemoveAt(nasumicanIndeks);
                }
            }

            //for (int i = 0; i < velicinaPop; i++)
            //{
            //    textBox2.Text += " Pocetak stare: ";
            //    for (int ik = 0; ik < DuzinaHrom; ik++)
            //    {
            //        textBox2.Text += PrvaGenHrom[i, ik].ToString();
            //    }
            //    textBox2.Text += " Kraj stare: \r\n";

            //}

            return PrvaGenHrom;
        }

        public void Razmnozavanje(int [,] roditeljGen)
        {

        Pocetak:
            //razmnozavanje
            int[,] NovaGen = new int[velicinaPop, DuzinaHrom];
            // racunanje kljuca
            brojacukupnevred = 0;
            ukupnevred = new double[velicinaPop * 2];
            pozicije = new int[velicinaPop * 2];
            for (int i = 0; i < pozicije.Length; i++)
            {
                pozicije[i] = i;
            }
            //
            var NasumBirLista = new List<int>();
            //
            for (int i = 0; i < velicinaPop; i++)
            {
                NasumBirLista.Add(i);
            }
            for (int i = 0; i < velicinaPop; i+=2)
            {
                
                int NasumicanIndeksZamene1 = NasumicanBR.Next(0, NasumBirLista.Count);
                NasumBirLista.RemoveAt(NasumicanIndeksZamene1);
                int NasumicanIndeksZamene2 = NasumicanBR.Next(0, NasumBirLista.Count);
                NasumBirLista.RemoveAt(NasumicanIndeksZamene2);
                int nasumicanPresek = NasumicanBR.Next(0, DuzinaHrom);
                int NasumicanIndeksDodeljivanja = NasumicanBR.Next(0, DuzinaHrom - nasumicanPresek);
                //
                var lisred1 = new List<int>();
                var lisred2 = new List<int>();
                //var kopijaListe = new List<int>(Lista);
                //var kopijaListe2 = new List<int>(Lista);
                for (int z = 0; z < DuzinaHrom; z++)
                {
                    //falbak kod
                    lisred1.Add(roditeljGen[NasumicanIndeksZamene2, z]);
                    lisred2.Add(roditeljGen[NasumicanIndeksZamene1, z]);

                    //int nasumicanIndeks1 = NasumicanBR.Next(0, kopijaListe.Count);
                    //int nasumicanIndeks2 = NasumicanBR.Next(0, kopijaListe2.Count);
                    //lisred1.Add(kopijaListe.ElementAt(nasumicanIndeks1));
                    //lisred2.Add(kopijaListe2.ElementAt(nasumicanIndeks2));
                    //kopijaListe.RemoveAt(nasumicanIndeks1);
                    //kopijaListe2.RemoveAt(nasumicanIndeks2);
                }
                int putovanje = nasumicanPresek + NasumicanIndeksDodeljivanja;
                for (int z = NasumicanIndeksDodeljivanja; z <putovanje ; z++)
                {
                    NovaGen[i, z] = roditeljGen[NasumicanIndeksZamene1, NasumicanIndeksDodeljivanja];
                    lisred1.Remove(NovaGen[i, z]);
                    NovaGen[i+1, z] = roditeljGen[NasumicanIndeksZamene2, NasumicanIndeksDodeljivanja];
                    lisred2.Remove(NovaGen[i+1, z]);
                    NasumicanIndeksDodeljivanja++;
                }
                int brojacLis = 0;
                for (int z = 0; z < DuzinaHrom; z++)
                {
                    if (NovaGen[i,z] == 0)
                    {
                        NovaGen[i, z] = lisred1[brojacLis];
                        NovaGen[i + 1, z] = lisred2[brojacLis];
                        brojacLis++;
                    }
                }
                
                //racunanje distance

                //dete1
                int[] nizFitnes = new int[DuzinaHrom + 2];
                nizFitnes[0] = 0;
                nizFitnes[nizFitnes.Length - 1] = 0;
                //dete2
                int[] nizFitnes2 = new int[DuzinaHrom + 2];
                nizFitnes2[0] = 0;
                nizFitnes2[nizFitnes2.Length - 1] = 0;
                
                // punjenje dece i rodt
                for (int z = 0; z < DuzinaHrom; z++)
                {
                    nizFitnes[z + 1] = NovaGen[i, z];
                    nizFitnes2[z + 1] = NovaGen[i+1, z];
                    
                }
                Vrednostdistance(nizFitnes);
                Vrednostdistance(nizFitnes2);

            }
            //
            for (int i = 0; i < velicinaPop; i+=2)
            {
                //rod1
                int[] nizFitnes3 = new int[DuzinaHrom + 2];
                nizFitnes3[0] = 0;
                nizFitnes3[nizFitnes3.Length - 1] = 0;
                //rod2
                int[] nizFitnes4 = new int[DuzinaHrom + 2];
                nizFitnes4[0] = 0;
                nizFitnes4[nizFitnes4.Length - 1] = 0;
                for (int m = 0; m < DuzinaHrom; m++)
                {
                    nizFitnes3[m + 1] = roditeljGen[i, m];
                    nizFitnes4[m + 1] = roditeljGen[i + 1, m];
                }
                Vrednostdistance(nizFitnes3);
                Vrednostdistance(nizFitnes4);
            }
            //fitnes (elitizam)
            //raspodeljivanje fit u tabelu
            for (int i = 0; i < ukupnevred.Length; i++)
            {
                for (int m = 0; m < ukupnevred.Length; m++)
                {
                    if (ukupnevred[i] > ukupnevred[m])
                    {
                        double priv = ukupnevred[i];
                        ukupnevred[i] = ukupnevred[m];
                        ukupnevred[m] = priv;
                        int priv2 = pozicije[i];
                        pozicije[i] = pozicije[m];
                        pozicije[m] = priv2;
                    }
                }
            }
            int[,] ModGen = new int[velicinaPop, DuzinaHrom];
            int brojacnajboljih = pozicije.Length - 1;
            for (int i = 0; i < velicinaPop; i++)
            {
                int pozicija = pozicije[brojacnajboljih];
                if (pozicija >= velicinaPop)
                {
                    pozicija = pozicija - velicinaPop;
                    for (int m = 0; m < DuzinaHrom; m++)
                    {
                        ModGen[i, m] = roditeljGen[pozicija, m];
                    }
                }
                else
                {
                    for (int m = 0; m < DuzinaHrom; m++)
                    {
                        ModGen[i, m] = NovaGen[pozicija, m];
                    }
                }
                // mutiranje
                if (Mutacija() == true)
                {

                    int nasumicanIndeksMutiranja1 = NasumicanBR.Next(0, DuzinaHrom);
                    int nasumicanIndeksMutiranja2 = NasumicanBR.Next(0, DuzinaHrom);
                    while (nasumicanIndeksMutiranja1 == nasumicanIndeksMutiranja2)
                    {
                        nasumicanIndeksMutiranja2 = NasumicanBR.Next(0, DuzinaHrom);
                    }
                    int priv;
                    priv = ModGen[i, nasumicanIndeksMutiranja1];
                    ModGen[i, nasumicanIndeksMutiranja1] = ModGen[i, nasumicanIndeksMutiranja2];
                    ModGen[i, nasumicanIndeksMutiranja2] = priv;
                }
                brojacnajboljih--;
            }

           
            //trenutna generacija
            lblBrojacGen.Text = BrojacGen.ToString();
           
            //zavrsetak razmnozavanje i ipisivanje poslednje gen
            if (UkBrojCiklusa == BrojacGen)
            {
                //for (int i = 0; i < velicinaPop; i++)
                //{
                //    textBox1.Text += " Pocetak nove: ";
                //    for (int ik = 0; ik < DuzinaHrom; ik++)
                //    {
                //        textBox1.Text += ModGen[i, ik].ToString();
                //    }
                //    textBox1.Text += " Kraj nove: \r\n";

                //}
                return;
            }
            BrojacGen++;
            roditeljGen = ModGen;
            goto Pocetak;
            
        }

        public void Vrednostdistance (int [] niz)
        {
            int vredX1 = 0;
            int vredY1 = 0;
            int vredX2 = 0;
            int vredY2 = 0;
            double ukvred = 0;
            for (int i = 0; i < niz.Length-1; i++)
            {
                for (int j = 0; j < DuzinaHrom+1; j++)
                {
                    if (ListaGradovaSaKord.TackeSaKordinatama[0,j] == niz[i])
                    {
                        vredX1 = ListaGradovaSaKord.TackeSaKordinatama[1, j];
                        vredY1 = ListaGradovaSaKord.TackeSaKordinatama[2, j];

                    }
                    else if (ListaGradovaSaKord.TackeSaKordinatama[0, j] == niz[i + 1])
                    {
                        vredX2 = ListaGradovaSaKord.TackeSaKordinatama[1, j];
                        vredY2 = ListaGradovaSaKord.TackeSaKordinatama[2, j];
                    }
                }
                double a = Math.Pow(vredX1 - vredX2, 2);

                double b = Math.Pow(vredY1 - vredY2, 2);

                double c = Math.Sqrt(a + b);
                c = Math.Round(c, 2);
                ukvred += c;
            }
            ukupnevred[brojacukupnevred] = ukvred;
            brojacukupnevred++;
            if (ukvred<DuzinaNajkraceDistance || DuzinaNajkraceDistance == 0)
            {
                DuzinaNajkraceDistance = ukvred;
                Array.Copy(niz, KordinateNajPutanje, niz.Length);
                BrojNajGen = BrojacGen;


            }
        }

        public bool Mutacija()
        {
            bool mutiraj = false;
            int okidac = NasumicanBR.Next(0, 100);
            if (okidac<ProcenatMutacije && ProcenatMutacije!=0)
            {
                mutiraj = true;
            }
            return mutiraj;
        }

      
    }
}
