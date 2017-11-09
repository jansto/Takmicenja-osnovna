using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kupovina
{
    class Program
    {
        //Општинско такмичење из програмирања за ученике основних школа 4. март 2017.

        static void Main(string[] args)
        {
            #region 2 zadatak KUPOVINA PATIKA 5. razred 2017.

            ////Odrediti koje patike su najskuplje

            //Console.WriteLine("Unesite cenu I patika");
            //string cipele1 = "";
            //cipele1 = Console.ReadLine();

            //Console.WriteLine("Unesite cenu II patika");
            //string cipele2 = "";
            //cipele2 = Console.ReadLine();

            //Console.WriteLine("Unesite cenu III patika");
            //string cipele3 = "";
            //cipele3 = Console.ReadLine();

            //int cipele1_int = int.Parse(cipele1);
            //int cipele2_int = int.Parse(cipele2);
            //int cipele3_int = int.Parse(cipele3);

            //int[] array1 = { cipele1_int, cipele2_int, cipele3_int };

            //int Najvecacena = array1.Max(element => Math.Abs(element));
            //array1 = array1.Where(val => val != Najvecacena).ToArray();

            //int srednjacena = array1.Max(element => Math.Abs(element));
            //array1 = array1.Where(val => val != srednjacena).ToArray();

            //int Najmanje = array1[0];

            //int[] Poredjanecene = { Najvecacena, srednjacena, Najmanje };

            //string izlaz = $"Cena najskupljih {Najvecacena.ToString()} cena srednjih je {srednjacena} i cena najjeftinijih cipela je {Najmanje}";
            //Console.WriteLine(izlaz);
            //Console.ReadLine();

            //Console.WriteLine("Press any key to exit");

            #endregion

            #region 3 zadatak TROUGAO 8. razred 2017.

            ////Napisati stepene, minute i sekunde 2 ugla trougla.
            ////Program treba da odredi treci i napise koji ugao je najveci

            //Console.WriteLine("Ugao 1");
            //string stepeni1 = "";
            //stepeni1 = Console.ReadLine();

            //string minuti1 = "";
            //minuti1 = Console.ReadLine();

            //string sekunde1 = "";
            //sekunde1 = Console.ReadLine();

            //Console.WriteLine("Ugao 2");
            //string stepeni2 = "";
            //stepeni2 = Console.ReadLine();

            //string minuti2 = "";
            //minuti2 = Console.ReadLine();

            //string sekunde2 = "";
            //sekunde2 = Console.ReadLine();

            //int stepeni1_int = int.Parse(stepeni1);
            //int minuti1_int = int.Parse(minuti1);
            //int sekunde1_int = int.Parse(sekunde1);

            //int stepeni2_int = int.Parse(stepeni2);
            //int minuti2_int = int.Parse(minuti2);
            //int sekunde2_int = int.Parse(sekunde2);



            //int Ugao1 = stepeni1_int * 3600 + minuti1_int * 60 + sekunde1_int;
            //int Ugao2 = stepeni2_int * 3600 + minuti2_int * 60 + sekunde2_int;
            //int Ugao1i2 = Ugao1 + Ugao2;

            //if (Ugao1i2 > 648000)
            //{
            //    Console.WriteLine("Ovakav trougao" +
            //        " ne postoji");
            //    Console.ReadKey();
            //}

            //int Ugao3 = 648000 - Ugao1i2;

            //int[] niz = { Ugao1, Ugao2, Ugao3 };

            //int NajveciUgao = niz.Max(element => Math.Abs(element));
            //niz = niz.Where(val => val != NajveciUgao).ToArray();

            //int sekN = NajveciUgao % 60;
            //int minN = (NajveciUgao / 60) % 60;
            //int stepN = (NajveciUgao / (60 * 60));

            //if (Ugao3 > Ugao2 && Ugao3 > Ugao1)
            //{
            //    Console.WriteLine("Treci Ugao je najveci");
            //    Console.WriteLine(stepN.ToString() + " " + minN.ToString() + " " + sekN.ToString());

            //    Console.ReadKey();
            //}

            //if (Ugao2 > Ugao1 && Ugao2 > Ugao3)
            //{
            //    Console.WriteLine("Drugi Ugao je najveci");
            //    Console.WriteLine(stepN.ToString() + " " + minN.ToString() + " " + sekN.ToString());

            //    Console.ReadKey();
            //}

            //if (Ugao1 > Ugao2 && Ugao1 > Ugao3)
            //{
            //    Console.WriteLine("Prvi ugao je najeci");
            //    Console.WriteLine(stepN.ToString() + " " + minN.ToString() + " " + sekN.ToString());

            //    Console.ReadKey();
            //}

            //Console.ReadKey();
            #endregion

            #region 4 zadatak TRKA 8. razred 2017

            ////Napisati brzinu prvog i drugom igraca i duzinu staze.
            ////Odrediti kada ce brzi igrac biti za jedan krug veci od sporijeg

            //Console.WriteLine("Upisite duzinu staze");
            //string duzina = "";
            //duzina = Console.ReadLine();

            //Console.WriteLine("Upisite brzinu prvog igraca");
            //string igrac1 = "";
            //igrac1 = Console.ReadLine();

            //Console.WriteLine("Upisite brzinu drugog igraca");
            //string igrac2 = "";
            //igrac2 = Console.ReadLine();

            //double duzina_int = double.Parse(duzina);
            //double igrac1_int = double.Parse(igrac1);
            //double igrac2_int = double.Parse(igrac2);

            //double vreme = duzina_int / (igrac2_int - igrac1_int);

            //double sati = vreme % 60;
            //double minuti = (vreme / 60) % 60;
            //double sekunde = (vreme / (60 * 60));

            //Console.WriteLine(sati.ToString());
            //Console.WriteLine(minuti.ToString());
            //Console.WriteLine(sekunde.ToString());

            //Console.ReadKey();
            #endregion

            #region 5 zadatak UGAO U SATE 5.razred 2017.

            ////Napisati stepen satnice i odrediti koliko je sati

            //Console.WriteLine("Upisite ugao satnice");
            //string Ugao = "";
            //Ugao = Console.ReadLine();

            //int Ugao_int = int.Parse(Ugao);

            //int minuti = Ugao_int * 2;

            //double minuti2 = minuti % 60;
            //double sati = (minuti / 60) % 60;

            //Console.WriteLine(sati.ToString() + ":" + minuti2);

            //Console.ReadKey();

            #endregion

            #region 6 zadatak SATI U UGAO 6. razred 2017.

            ////Ugao izmendju satnice i minutare

            //Console.WriteLine("Upisite sate");
            //string sati = "";
            //sati = Console.ReadLine();

            //Console.WriteLine("Upisite minute");
            //string minuti = "";
            //minuti = Console.ReadLine();

            //int sati_int = int.Parse(sati);
            //int minuti_int = int.Parse(minuti);

            //int ugaoMS = sati_int * 30 * 60 + minuti_int * 30;
            //if (sati_int >=12)
            //{
            //    ugaoMS = sati_int * 30 * 60 - minuti_int * 30;
            //}

            //int ugaoMM = minuti_int * 360;

            //int RazlikaM = Math.Abs(ugaoMS - ugaoMM);

            //int s = RazlikaM / 60;
            //int m = RazlikaM % 60;

            //Console.WriteLine(s.ToString() + ":" + m.ToString());

            //Console.ReadKey();

            #endregion

            #region 7 zadatak RAZLOMCI U MESOVITE BROJEVE 5. razred 2017.

            ////Pretvoriti razlomak u mesovit broj

            //Console.WriteLine("Upisi imenilac razlomka");
            //string imenilac = "";
            //imenilac = Console.ReadLine();

            //Console.WriteLine("Upisi brojilac razlomka");
            //string brojilac = "";
            //brojilac = Console.ReadLine();

            //int imenilac_int = int.Parse(imenilac);
            //int brojilac_int = int.Parse(brojilac);

            //if(imenilac_int <= brojilac_int)
            //{
            //    Console.WriteLine("Ne umem to da resim");
            //    Console.ReadKey();
            //}

            //int imenilac2 = imenilac_int % brojilac_int;
            //int ceobroj = imenilac_int / brojilac_int;

            //Console.WriteLine(ceobroj.ToString() + " " + imenilac2.ToString() + "/" + brojilac_int.ToString());

            //Console.ReadKey();


            #endregion

            #region 8 zadatak SKOLARINA 8. razred 2017.

            //// Odrediti cenu skolarine sa popustom ako su dati : pocetni iznos, prosek skole i nagrade

            //Console.WriteLine("Upisi iznos skolarine");
            //string skolarina = "";
            //skolarina = Console.ReadLine();

            //Console.WriteLine("Upisi uspeh ucenika");
            //string uspeh = "";
            //uspeh = Console.ReadLine();

            //Console.WriteLine("Upisi ako ucenik ima nagradu");
            //string nagrada = "";
            //nagrada = Console.ReadLine();

            //double skolarina_double = double.Parse(skolarina);
            //double uspeh_double = double.Parse(uspeh);
            //double nagrada_double = double.Parse(nagrada);

            //double nagrada1 = 0;

            //if (nagrada_double >= 1)
            //{
            //     nagrada1 = 0.7;
            //}
            //if (nagrada_double < 1)
            //{
            //    nagrada1 = 1.00;
            //}

            //double popust = 0;

            //if (uspeh_double >= 4.5)
            //{
            //    popust = 0.6;
            //}

            //if (uspeh_double >= 3.5 && uspeh_double < 4.5)
            //{
            //    popust = 0.8;
            //}

            //if (uspeh_double >= 2.5 && uspeh_double < 3.5)
            //{
            //    popust = 0.9;
            //}

            //if (uspeh_double < 2.5)
            //{
            //    popust = 1;
            //}

            //double cena = 0;

            //if (popust > nagrada1)
            //{
            //    cena = skolarina_double * nagrada1;

            //    Console.WriteLine(Math.Round(cena));
            //    Console.ReadKey();
            //}
            //if (popust < nagrada1)
            //{
            //  cena = skolarina_double * popust;

            //    Console.WriteLine(Math.Round(cena));
            //    Console.ReadKey();
            //}

            #endregion

            #region 9 zadatak KONCERT II kategorija 2016.

            ////Napisati pocetak koncerta, broj pauza od po 5 min.
            ////Program treba da ispise kada se koncert zavrsava

            //Console.WriteLine("sat minut sekunda trajanje brojPauza");
            //string niz_string = Console.ReadLine();
            //string[] niz = niz_string.Split(' ');

            //string sat = niz[0];

            //string minut = niz[1];

            //string sekunda = niz[2];

            //string trajanje = niz[3];

            //string BP = niz[4];

            //int sat_int = int.Parse(sat);
            //int minut_int = int.Parse(minut);
            //int sekunda_int = int.Parse(sekunda);
            //int trajanje_int = int.Parse(trajanje);
            //int BP_int = int.Parse(BP);

            //int SekundeU = sat_int * 3600 + minut_int * 60 + sekunda_int + trajanje_int * 60 + BP_int * 5 * 60;
            //int sati = SekundeU / 3600 % 24;
            //int minuti = (SekundeU % 3600)/60;
            //int sekunde = SekundeU % 60;

            //Console.WriteLine(sati.ToString() + ":" + minuti.ToString() + ":" + sekunde.ToString());

            //Console.ReadKey();

            #endregion

            #region 10 zadatak Akvarijum I kategorija 2015.

            ////Proveriti da li ima dovoljno vode za sve ribice.
            ////Ako nema napisati koliko njih treba izbaciti

            //Console.WriteLine("Litar Ribice");
            //string RibeILitri = Console.ReadLine();
            //string[] niz = RibeILitri.Split(' ');

            //string litri = niz[0];
            //string ribe = niz[1];

            //int litri_int = int.Parse(litri);
            //int ribe_int = int.Parse(ribe);

            //int LK = litri_int / 3;

            //if (LK < ribe_int)
            //{
            //    int R = ribe_int - LK;
            //    Console.WriteLine("DA" + " " + R.ToString());
            //    Console.ReadKey();
            //}
            //if (LK > ribe_int)
            //{
            //    Console.WriteLine("NE");
            //    Console.ReadKey();
            //}
            #endregion

            #region 11 zadatak KONVERZIJA  I kategorija 2016.

            ////Proveriti da li ima dovoljno mesta na hard discu

            //Console.WriteLine("U jednom redu upisite MINUTE (RAZMAK) SEKUNDE (RAZMAK) SLOBODAN PROSTOR(U MB)");
            //string MSP = Console.ReadLine();
            //string[] niz = MSP.Split(' ');

            //string Min = niz[0];
            //string Sec = niz[1];
            //string Mem = niz[2];

            //int MIN = int.Parse(Min);
            //int SEC = int.Parse(Sec);
            //int MEM = int.Parse(Mem);

            //double RezultatMB = 0;
            //RezultatMB = MEM - ((SEC + 60 * MIN) * 16) / 1024;

            //double RezultatKB = 0;
            //RezultatKB = RezultatMB * 1024;

            //if (RezultatMB < 0)
            //{
            //    Console.WriteLine("Pufna nema dovoljno memorije");
            //    Console.ReadKey();
            //}


            //Console.WriteLine("Preostala memorija u MB iznosi " + RezultatMB.ToString() + " a u KB iznosi " + RezultatKB.ToString());
            //Console.ReadKey();

            #endregion

            #region 12 zadatak BROTHERS 6. razred 2017.

            ////Upisati godine 3 brata i naci koji je najveci

            //Console.WriteLine("Unesite godine Jovana");
            //string Jovan = "";
            //Jovan = Console.ReadLine();

            //Console.WriteLine("Unesite godine Pere");
            //string Pera = "";
            //Pera = Console.ReadLine();

            //Console.WriteLine("Unesite godine Luke");
            //string Luka = "";
            //Luka = Console.ReadLine();

            //int P_int = int.Parse(Pera);
            //int L_int = int.Parse(Luka);
            //int J_int = int.Parse(Jovan);

            //int[] array1 = { L_int, P_int, J_int };
            //int NajvecagodinaToRemove = array1.Max(element => Math.Abs(element));
            //array1 = array1.Where(val => val != NajvecagodinaToRemove).ToArray();

            //int srednjeGodine = array1.Max(element => Math.Abs(element));
            //array1 = array1.Where(val => val != srednjeGodine).ToArray();

            //int najmanjeGodine = array1[0];

            //int[] poredjaneGodine = { NajvecagodinaToRemove, srednjeGodine, najmanjeGodine };

            //Console.WriteLine("Najstariji brat ima " + poredjaneGodine[0] + " godina. Srednji brat ima " + poredjaneGodine[1] + " godina. Najmladji brat ima " + poredjaneGodine[2] + " godina");

            //Console.WriteLine("Press any key to exit");
            //Console.ReadKey();

            #endregion

            #region 13 zadatak DOMINE I kategorija 2014.

            //// Upisati dve domine od po 2 broja i naci im najvecu kombinaciju

            //Console.WriteLine("Upisite 2 domine sa jednim razmakom");
            //string Domine = Console.ReadLine();
            //string[] niz = Domine.Split(' ');

            //string[] niz1 = { niz[0], niz[1] };

            //int niz1_0 = int.Parse(niz[0]);
            //int niz1_1 = int.Parse(niz[1]);

            //int[] niz1_int = { niz1_0, niz1_1 };


            //int VecaDomina = niz1_int.Max(element => Math.Abs(element));
            //niz1_int = niz1_int.Where(val => val != VecaDomina).ToArray();

            //int ManjaDomina = niz1_int[0];


            //string[] niz2 = { niz[2], niz[3] };

            //int niz2_0 = int.Parse(niz[2]);
            //int niz2_1 = int.Parse(niz[3]);

            //int[] niz2_int = { niz2_0, niz2_1 };

            //int VecaDomina2 = niz2_int.Max(element => Math.Abs(element));
            //niz2_int = niz2_int.Where(val => val != VecaDomina2).ToArray();

            //int ManjaDomina2 = niz2_int[0];


            //Console.WriteLine(VecaDomina.ToString() + ManjaDomina.ToString() + VecaDomina2.ToString() + ManjaDomina2.ToString());
            //Console.ReadKey();

            #endregion

            #region 14 zadatak Pravougaonik Opstinsko I kategorija 2014.

            ////Upisati obim i stranicu 1 i program treba da izracuna 2. stranicu

            //    Console.WriteLine("U jednom redu unesite Povrsinu razmak druga stranica(prim. 20 2)");
            //    string ObimRazmakStranica = Console.ReadLine();
            //    string[] niz = ObimRazmakStranica.Split(' ');

            //    string Obim = niz[0];
            //    string Stranica = niz[1];

            //    int Obim_int = int.Parse(Obim);
            //    int Stranica_int = int.Parse(Stranica);

            //    int Stranica2_int = 0;

            //    Stranica2_int = (Obim_int / 2) - Stranica_int;

            //    if (Stranica2_int < 0)
            //    {
            //        Console.WriteLine("Stranica ne moze da bude negativna zar ne znas to???");
            //        Console.ReadKey();
            //    }
            //    if (Stranica2_int == 0)
            //    {
            //        Console.WriteLine("Stranica ne moze da bude 0 kod pravougaonika. To onda pravi duz a ne pravougaonika");
            //        Console.ReadKey();
            //    }

            //    else
            //    {
            //        Console.WriteLine("Druga stranica je duga " + Stranica2_int.ToString() + "cm");
            //        Console.ReadKey();
            //    }

            #endregion

            #region 15 zadatak MikaIPera 8.razred 2017.

            ////Upisati vreme dva decaka i odrediti ko ce pre da stigne

            //Console.WriteLine("Unesite sate Mike");
            //string satiM = "";
            //satiM = Console.ReadLine();
            //Console.WriteLine("Unesite minute Mike");
            //string minutiM = "";
            //minutiM = Console.ReadLine();
            //Console.WriteLine("Unesite sekunde Mike");
            //string sekundeM = "";
            //sekundeM = Console.ReadLine();

            //Console.WriteLine("Unesite sate Pere");
            //string satiP = "";
            //satiP = Console.ReadLine();
            //Console.WriteLine("Unesite minute Pere");
            //string minutiP = "";
            //minutiP = Console.ReadLine();
            //Console.WriteLine("Unesite sekunde Pere");
            //string sekundeP = "";
            //sekundeP = Console.ReadLine();

            //int Pera = 0;
            //int Mika = 0;

            //int SM = int.Parse(satiM);
            //int MM = int.Parse(minutiM);
            //int SekM = int.Parse(sekundeM);

            //int SP = int.Parse(satiP);
            //int MP = int.Parse(minutiP);
            //int SekP = int.Parse(sekundeP);

            //Mika = SM * 3600 + MM * 60 + SekM;
            //Pera = SP * 3600 + MP * 60 + SekP;

            //if (Mika > Pera)
            //{
            //    Console.WriteLine("Pera je stigao prvi");
            //    Console.ReadKey();
            //}

            //if (Pera > Mika)
            //{
            //    Console.WriteLine("Mika je stigao prvi");
            //    Console.ReadKey();
            //}

            //if (Pera == Mika)
            //{
            //    Console.WriteLine("Mika i Pera su stigli u isto vreme");
            //    Console.ReadKey();
            //}


            #endregion

            #region 16 zadatak Pekara 5. razred 2017.

            ////Odredti da li decak moze da kupi uzinu

            //Console.WriteLine("Unesite broj S");
            //string s = "";
            //s = Console.ReadLine();

            //Console.WriteLine("Unesite Perin dzeparac");
            //string dzeparac = "";
            //dzeparac = Console.ReadLine();

            //int kroasan = 0;

            //int s_int = int.Parse(s);
            //int dzeparac_int = int.Parse(dzeparac);

            //kroasan = (dzeparac_int - s_int) / 4;

            //if (kroasan > 0)
            //{
            //    Console.Write("Moze da kupi");
            //    Console.ReadKey();
            //}
            //else
            //{
            //    Console.Write("Ne moze da kupi");
            //    Console.ReadKey();
            //}

            #endregion

            #region 17 zadatak Praksa 5 razred 2017.

            ////Odrediti cenu skolarine

            //Console.WriteLine("Unesite broj meseci rada");
            //string MeseciR = "";
            //MeseciR = Console.ReadLine();
            //Console.WriteLine("Unesite pocetnu platu");
            //string pocetnaP = "";
            //pocetnaP = Console.ReadLine();
            //Console.WriteLine("Unesite povecanje plate");
            //string plataU = "";
            //plataU = Console.ReadLine();

            //int zadnjaP = 0;

            //int meseciRada_int = int.Parse(MeseciR);
            //int pocetnaPlata_int = int.Parse(pocetnaP);
            //int plataUvecanje_int = int.Parse(plataU);

            //zadnjaP = pocetnaPlata_int + (meseciRada_int - 1) * plataUvecanje_int;
            //Console.WriteLine("Markova plata je " + zadnjaP.ToString());

            //Console.ReadKey();

            #endregion

            #region 18 zadatak Ukras 5. razred 2017.

            ////Naci obim pravougaonika

            //Console.WriteLine("Stranica a");
            //string str1 = "";
            //str1 = Console.ReadLine();

            //Console.WriteLine("Stranica b");
            //string str2 = "";
            //str2 = Console.ReadLine();

            //int str1_int = int.Parse(str1);
            //int str2_int = int.Parse(str2);

            //Console.WriteLine(2 * (str2_int + str1_int));
            //Console.ReadKey();

            #endregion

            #region 19 zadatak PESMA I kategorija 2015

            ////Odrediti da li ima dovoljno memorije na hard disc - u

            //Console.WriteLine("Minut Sekunda SlobodanProstor");
            //string MSS = Console.ReadLine();
            //string[] niz = MSS.Split(' ');

            //string minut = niz[0];
            //string sekunda = niz[1];
            //string SP = niz[2];

            //int minut_int = int.Parse(minut);
            //int sekunda_int = int.Parse(sekunda);
            //int SP_int = int.Parse(SP);

            //string DN = "Da";

            //int Racunanje = SP_int * 1024 - (minut_int * 60 * 16 + sekunda_int * 16);

            //if (Racunanje < 0)
            //{
            //    DN = "NE";
            //    Console.WriteLine(DN + " " + Math.Abs(Racunanje).ToString());
            //    Console.ReadKey();
            //}
            //else
            //{
            //    Console.WriteLine(DN);
            //    Console.ReadKey();
            //}
            #endregion

            #region 20 zadatak OTKRIVANJE II kategorija 2014.

            ////Upisati zbir i razliku dva broja pa naci ta dva broja

            //Console.WriteLine(" Zbir Razlika");
            //string ZbirRazlika = Console.ReadLine();
            //string[] niz = ZbirRazlika.Split(' ');

            //string Zbir = niz[0];
            //string Razlika = niz[1];

            //int Zbir_int = int.Parse(Zbir);
            //int Razlika_int = int.Parse(Razlika);

            //int x = (Zbir_int + Razlika_int) / 2;
            //int y = Zbir_int - x;

            //if (x < 0 || y < 0)
            //{
            //    Console.WriteLine("GRESKA");
            //    Console.ReadKey();
            //}
            //else
            //{
            //    Console.WriteLine(x.ToString() + " " + y.ToString());
            //    Console.ReadKey();
            //}

            #endregion

            #region 21 zadatak Seckanje   

            ////Pronaci koliko puta moze da se isece neki pravougaonik

            //Console.WriteLine("Stranica1 Stranica2");
            //string AiB = Console.ReadLine();
            //string[] AIB = AiB.Split(' ');

            //string A = AIB[0];
            //string B = AIB[1];

            //int A_int = int.Parse(A);
            //int B_int = int.Parse(B);
            //int C_int = 1;

            //while(A_int != B_int)
            //{
            //    if(A_int > B_int)
            //    {
            //        A_int -= B_int;
            //    }
            //    else
            //    {
            //        B_int -= A_int;
            //    }

            //    C_int++;
            //}

            //Console.WriteLine(C_int);
            //Console.ReadKey();

            #endregion

            #region 22 zadatak SEMAFOR Opstinsko 6. razred 2016.

            ////Upisati vreme i naci da li na semaforu pise STANI PRODJI ILI KRENI


            //Console.WriteLine("SAT MINUT SEKUNDA");
            //string SMS = Console.ReadLine();
            //string[] niz = SMS.Split(' ');

            //string Sat = niz[0];
            //string Minut = niz[1];
            //string Sekunda = niz[2];

            //int Sat_int = int.Parse(Sat);
            //int Minut_int = int.Parse(Minut);
            //int Sekunda_int = int.Parse(Sekunda);

            //int sekunde = Sat_int * 3600 + Minut_int * 60 + Sekunda_int;
            //sekunde += 3600 * 16;
            //int Ostatak = sekunde % 108;

            //if (Ostatak < 60 && Ostatak >= 0)
            //{
            //    Console.WriteLine("Kreni");
            //    Console.ReadKey();
            //}
            //if ((Ostatak >= 60 && Ostatak < 64) || (Ostatak >= 104 && Ostatak < 108))
            //{
            //    Console.WriteLine("Priprema");
            //    Console.ReadKey();
            //}
            //if (Ostatak >= 64 && Ostatak < 104)
            //{
            //    Console.WriteLine("Stani");
            //    Console.ReadKey();
            //}
            #endregion

            #region 23 zadatak MAXIZRAZ Opstinsko 6. razred 2014.

            ////Rastaviti trocifren broj na cinioce i 
            //// naci najveci rezultat sa jednim mnozenjem i jednim sabiranjem 

            //Console.WriteLine("Trocifren broj");
            //string TB = "";
            //TB = Console.ReadLine(); 
            //char[] cifre = TB.ToCharArray();

            //int prva = int.Parse(cifre[0].ToString());
            //int druga = int.Parse(cifre[1].ToString());
            //int treca = int.Parse(cifre[2].ToString());

            //int[] niz = { prva, druga, treca };

            //int najveca =  niz.Max(element => Math.Abs(element));
            //niz = niz.Where(val => val != najveca).ToArray();

            //int srednja = niz.Max(element => Math.Abs(element));
            //niz = niz.Where(val => val != srednja).ToArray();

            //int najmanja = niz.Max(element => Math.Abs(element));
            //niz = niz.Where(val => val != najmanja).ToArray();

            //int Reziltat = najveca * srednja + najmanja;

            //Console.WriteLine(Reziltat);
            //Console.ReadKey();

            #endregion

            #region 24 zadatak MATURA Okruzno 5. razred 2017.



            //Console.WriteLine("Aleksa");
            //string Aleksa = "";
            //Aleksa = Console.ReadLine();

            //Console.WriteLine("Bane");
            //string Bane = "";
            //Bane = Console.ReadLine();

            //Console.WriteLine("Vojin");
            //string Vojin = "";
            //Vojin = Console.ReadLine();

            //int Aleksa_int = int.Parse(Aleksa);
            //int Bane_int = int.Parse(Bane);
            //int Vojin_int = int.Parse(Vojin);

            //int[] niz = { Aleksa_int, Bane_int, Vojin_int };
            //int Najveci = niz.Max(element => Math.Abs(element));
            //niz = niz.Where(val => val != Najveci).ToArray();

            //int Srednji = niz.Max(element => Math.Abs(element));
            //niz = niz.Where(val => val != Srednji).ToArray();

            //int Najmanji = niz[0];

            //int[] niz2 = { Najveci, Srednji, Najmanji };

            //Console.WriteLine(Najveci);
            //Console.WriteLine(Srednji);
            //Console.WriteLine(Najmanji);
            //Console.ReadKey(); 

            #endregion

            #region 25 zadatak Dzeparac Okruzno 6. razred 2017.

            ////Napisati koliko para je dobijeno od pon do pet
            ////i naci dan kada je dobijen naveci dzeparac


            //Console.WriteLine("Pon");
            //string Pon = "";
            //Pon = Console.ReadLine();

            //Console.WriteLine("Uto");
            //string Uto = "";
            //Uto = Console.ReadLine();

            //Console.WriteLine("Sre");
            //string Sre = "";
            //Sre = Console.ReadLine();

            //Console.WriteLine("Cet");
            //string Cet = "";
            //Cet = Console.ReadLine();

            //Console.WriteLine("Pet");
            //string Pet = "";
            //Pet = Console.ReadLine();


            //int Pon_int = int.Parse(Pon);
            //int Uto_int = int.Parse(Uto);
            //int Sre_int = int.Parse(Sre);
            //int Cet_int = int.Parse(Cet);
            //int Pet_int = int.Parse(Pet);

            //int[] niz = { Pon_int, Uto_int, Sre_int, Cet_int, Pet_int };

            //int NajveciDz = niz.Max(element => Math.Abs(element));
            //niz = niz.Where(val => val != NajveciDz).ToArray();
            //string Dan = "";


            //if (NajveciDz == Pon_int)
            //{
            //    Dan = "Pon";
            //}
            //if (NajveciDz == Uto_int)
            //{
            //    Dan = "Uto";
            //}
            //if (NajveciDz == Sre_int)
            //{
            //    Dan = "Sre";
            //}
            //if (NajveciDz == Cet_int)
            //{
            //    Dan = "Cet";
            //}
            //if (NajveciDz == Pon_int)
            //{
            //    Dan = "Pet";
            //}
            //Console.WriteLine(Dan + " " + NajveciDz.ToString());
            //Console.ReadKey();

            #endregion

            #region 26 zadatak Zbir Okruzno 5. razred 2017.

            ////Razdvojiti trocifren broj na cifre i naci
            ////najveci broj sa jednim mnozenjem i sabiranjem

            //Console.WriteLine("Broj");
            //string broj = "";
            //broj = Console.ReadLine();
            //char[] cifre = broj.ToCharArray();

            //int zbir = 0;

            //foreach (char cifra in cifre)
            //{
            //    int broj1 = int.Parse(cifra.ToString());
            //    int provera = broj1 % 2;
            //    if (provera > 0)
            //    {
            //        zbir += broj1 * broj1;
            //    }

            //}

            //Console.WriteLine(zbir);
            //Console.ReadKey();

            #endregion

            #region 27 zadatak Delioci Okruzno 5. razred 2017.

            ////Upisati prirodan broj i naci
            ////kardinalni broj njegovih delioca 

            //Console.WriteLine("Broj");
            //string broj = "";
            //broj = Console.ReadLine();

            //int broj_int = int.Parse(broj);
            //int n = 0;
            //int y = 0;
            //int z = 1;


            //while (n < broj_int)
            //{
            //    int provera = broj_int % z;
            //    if (provera == 0)
            //    {
            //        y++ ;
            //    }
            //    n++;
            //    z++;
            //} 

            //Console.WriteLine(y.ToString());
            //Console.ReadKey();

            #endregion

            #region 28 zadatak Sredina II kategorija 2014.


            ////Naci aritmeticku sredinu zbira delioca nekog broja 
            ////i zaokruziti na 2 decimale

            //Console.WriteLine("Broj");
            //string broj = "";
            //broj = Console.ReadLine();

            //int broj_int = int.Parse(broj);

            //int n = 0;
            //int y = 0;
            //int k = 0;
            //int z = 1;


            //while (n < broj_int)
            //{
            //    int provera = broj_int % z;
            //    if (provera == 0)
            //    {
            //        y += z ;
            //        k++;
            //    }
            //    n++;
            //    z++;
            //}

            //int Sredina = y / k;
            //double vOut = Convert.ToDouble(Sredina);
            //Math.Round(vOut, 2);

            //Console.WriteLine(vOut.ToString());
            //Console.ReadKey();
            #endregion

            #region 29 zadatak Obuka Okruzno 5. razred 2017.

            //// Napisati od kada do kada traje prva i druga grupa 
            ////i odrediti im zajednicko vreme

            //Console.WriteLine("Sat pocetka prve grupe");
            //string grupa1P = "";
            //grupa1P = Console.ReadLine();

            //Console.WriteLine("Sat zavrsetka druge grupe");
            //string grupa1K = "";
            //grupa1K = Console.ReadLine();

            //Console.WriteLine("Sat pocetka druge grupe");
            //string grupa2P = "";
            //grupa2P = Console.ReadLine();

            //Console.WriteLine("Sat zavrsetka druge grupe");
            //string grupa2K = "";
            //grupa2K = Console.ReadLine();

            //int grupa1P_int = int.Parse(grupa1P);
            //int grupa1K_int = int.Parse(grupa1K);
            //int grupa2P_int = int.Parse(grupa2P);
            //int grupa2K_int = int.Parse(grupa2K);

            //int Racunanje = 0;

            //if (grupa1K_int <= grupa2P_int)
            //{
            //    Console.WriteLine(Racunanje.ToString());
            //    Console.ReadKey();
            //}

            //if (grupa1K_int > grupa2K_int)
            //{
            //    Racunanje = grupa1K_int - grupa2P_int - (grupa1K_int - grupa2K_int);
            //    Console.WriteLine(Racunanje.ToString());
            //    Console.ReadKey();
            //}

            //if (grupa1K_int <= grupa2K_int)
            //{
            //    Racunanje = grupa1K_int - grupa2P_int;
            //    Console.WriteLine(Racunanje.ToString());
            //    Console.ReadKey();
            //}



            #endregion

            #region 30 zadatak Delioci V2 Okruzno 5. razred 2017.

            //Console.WriteLine("Pocetan broj");
            //string broj1 = "";
            //broj1 = Console.ReadLine();

            //Console.WriteLine("Zavrsan broj");
            //string broj2 = "";
            //broj2 = Console.ReadLine();

            //int broj1_int = int.Parse(broj1);
            //int broj2_int = int.Parse(broj2);

            //int n = 0;
            //int k = 0;
            //int z = 1;


            //while (n  < broj1_int)
            //{
            //    int provera = broj1_int % z;
            //    if (provera == 0)
            //    {
            //        broj1 += z;

            //    }
            //    n++;
            //    z++;
            //}

            //Console.WriteLine(broj1_int);
            //Console.ReadKey();

            #endregion

            #region 31 zadatak Kusur Opstinsko II kategorija 2014.

            //Console.WriteLine("Cena IznosKojiJeKupacDaoKasirki");
            //string cene = Console.ReadLine();
            //string[] ceneNiz = cene.Split(' ');

            //int Cena = int.Parse(ceneNiz[0]);
            //int Pare = int.Parse(ceneNiz[1]);

            //int n = 1;
            //int kusur = Pare - Cena;


            //while(kusur > 0)
            //{

            //    if (kusur >= 10)
            //    {
            //        kusur -= 10;
            //    }

            //    if (kusur >= 5 && kusur < 10)
            //    {
            //        kusur -= 5;
            //    }

            //    if (kusur >= 2 && kusur < 5)
            //    {
            //        kusur -= 2;
            //    }

            //    if (kusur >= 1 && kusur < 2)
            //    {
            //        kusur -= 1;
            //    }
            //    n++;

            //}

            //Console.WriteLine(n.ToString());
            //Console.ReadKey();

            #endregion

            #region 32 zadatak Stolovi Opstinsko I kategorija 2011.

            //Console.WriteLine("Povrsina");
            //string P = "";
            //P = Console.ReadLine();

            //Console.WriteLine("Broj stolova za 4 osobe");
            //string sto4 = "";
            //sto4 = Console.ReadLine();

            //Console.WriteLine("Broj stolova za 6 osoba");
            //string sto6 = "";
            //sto6 = Console.ReadLine();

            //Console.WriteLine("Broj izvodjaca benda");
            //string brojI = "";
            //brojI = Console.ReadLine();

            //int P_int = int.Parse(P);
            //int sto4_int = int.Parse(sto4);
            //int sto6_int = int.Parse(sto6);
            //int brojI_int = int.Parse(brojI);


            //int Ostatak = (P_int - sto6_int * 7 - sto4_int * 5 - brojI_int) / 2;

            //Console.WriteLine(Ostatak);
            //Console.ReadKey();
            #endregion

            #region 33 zadatak Jelo Opstinsko I kategorija 2011.

            //Console.WriteLine("Broj pilica");
            //string Pilici = "";
            //Pilici = Console.ReadLine();

            //Console.WriteLine("Broj zaba");
            //string Zabe = "";
            //Zabe = Console.ReadLine();

            //int Pilici_int = int.Parse(Pilici);
            //int Zabe_int = int.Parse(Zabe);

            //int Krilca = (Pilici_int * 2) * 8 / 10;
            //int Bataci = Zabe_int * 2;

            //int y = Bataci / 3;
            //int x = Krilca / 2;

            //if (x > y)
            //{
            //    Console.WriteLine(y);
            //}

            //if (y > x)
            //{
            //    Console.WriteLine(x);
            //}           

            //Console.ReadKey();

            #endregion

            #region 34 zadatak Karta Opstinsko I kategorija 2011. NEDOVRSEN

            //Console.WriteLine("Smer1 Vrednost1");
            //string SV1 = Console.ReadLine();
            //string[] niz1 = SV1.Split(' ');

            //Console.WriteLine("Smer2 Vrednost2");
            //string SV2 = Console.ReadLine();
            //string[] niz2 = SV2.Split(' ');

            //Console.WriteLine("Smer3 Vrednost3");
            //string SV3 = Console.ReadLine();
            //string[] niz3 = SV3.Split(' ');

            //int Smer1 = int.Parse(niz1[0]);
            //int Vrednost1 = int.Parse(niz1[1]);

            //int Smer2 = int.Parse(niz2[0]);
            //int Vrednost2 = int.Parse(niz2[1]);

            //int Smer3 = int.Parse(niz3[0]);
            //int Vrednost3 = int.Parse(niz3[1]);

            //int SmerSI = 1;
            //int SmerJZ = -1;

            //if (Smer1 == 1)
            //{
            //    Smer1 *= SmerSI;
            //}

            //if (Smer1 == 2)
            //{
            //    Smer1 *= SmerJZ;
            //}

            //if (Smer1 == 3)
            //{
            //    Smer1 *= SmerSI;
            //}

            //if (Smer1 == 4)
            //{
            //    Smer1 = SmerJZ;
            //}


            //if (Smer2 == 1)
            //{
            //    Smer2 *= SmerSI;
            //}

            //if (Smer2 == 2)
            //{
            //    Smer2 *= SmerJZ;
            //}

            //if (Smer2 == 3)
            //{
            //    Smer2 *= SmerSI;
            //}

            //if (Smer2 == 4)
            //{
            //    Smer2 = SmerJZ;
            //}


            //if (Smer3 == 1)
            //{
            //    Smer3 *= SmerSI;
            //}

            //if (Smer3 == 2)
            //{
            //    Smer3 *= SmerJZ;
            //}

            //if (Smer3 == 3)
            //{
            //    Smer3 *= SmerSI;
            //}

            //if (Smer3 == 4)
            //{
            //    Smer3 = SmerJZ;
            //}




            #endregion

            #region 35 zadatak Most 5. razred II kategorija 2009.

            //Console.WriteLine("Sirina Ploce");
            //string sirina = "";
            //sirina = Console.ReadLine();

            //Console.WriteLine("Duzina ploce");
            //string duzina = "";
            //duzina = Console.ReadLine();

            //Console.WriteLine("Broj ploca");
            //string broj = "";
            //broj = Console.ReadLine();

            //int duzina_int = int.Parse(duzina);
            //int sirina_int = int.Parse(sirina);
            //int broj_int = int.Parse(broj);

            //int Stranica1 = duzina_int * broj_int;
            //int brojPloca = Stranica1 * 2 + 4 + sirina_int * 2;

            //Console.WriteLine(brojPloca);
            //Console.ReadKey();
            #endregion

            #region 36 zadatak Kocke II kategorija 2009.

            //Console.WriteLine("Sirina puta");
            //string sirina = "";
            //sirina = Console.ReadLine();

            //Console.WriteLine("Duzina puta");
            //string duzina = "";
            //duzina = Console.ReadLine();

            //Console.WriteLine("Duzina ivice kocke1");
            //string kocka1 = "";
            //kocka1 = Console.ReadLine();

            //Console.WriteLine("Duzina ivice kocke2");
            //string kocka2 = "";
            //kocka2 = Console.ReadLine();

            //int sirina_int = int.Parse(sirina);
            //int duzina_int = int.Parse(duzina);
            //int kocka1_int = int.Parse(kocka1);
            //int kocka2_int = int.Parse(kocka2);
            //int P = sirina_int * duzina_int;

            //int[] niz = { kocka1_int, kocka2_int };
            //int kockaV = niz.Max(element => Math.Abs(element));
            //niz = niz.Where(val => val != kockaV).ToArray();
            //int kockaM = niz[0];

            //int ProveraV = P % kockaV;
            //int ProveraM = P % kockaM;
            //int n = 0;

            //while (P >= 0)
            //{
            //    if (ProveraV == 0)
            //    {
            //        P -= kockaV;
            //    }
            //    if (ProveraM == 0)
            //    {
            //        P -= kockaM;
            //    }
            //    if (ProveraM == 0 && ProveraV == 0)
            //    {
            //        P -= kockaV;
            //    }

            //    n++;
            //}


            //Console.WriteLine(n);
            //Console.ReadKey();

            #endregion

            #region 37 zadatak Cvorovi I kategorija 2009

            //Console.WriteLine("Broj Trouglova");
            //string broj = "";
            //broj = Console.ReadLine();

            //int broj_int = int.Parse(broj);
            //int Cvorovi = broj_int + 2;

            //Console.WriteLine(Cvorovi);
            //Console.ReadLine();

            #endregion

            #region 38 zadatak Polazak I kategorija 2009

            //Console.WriteLine("Vreme kome je takmicaru potrbno stigne do mosta");
            //string vreme = "";
            //vreme = Console.ReadLine();

            //Console.WriteLine("Vreme posle koga most krece da se podize");
            //string dizanje = "";
            //dizanje = Console.ReadLine();

            //Console.WriteLine("Vreme cekanja");
            //string cekanje = "";
            //cekanje = Console.ReadLine();

            //int vreme_int = int.Parse(vreme);
            //int dizanje_int = int.Parse(cekanje);
            //int cekanje_int = int.Parse(dizanje);

            //int Razlika1 = vreme_int - dizanje_int;
            //int Razlika = cekanje_int - Razlika1;

            //if (Razlika1 <= 0)
            //{
            //    Razlika = 0;
            //}

            //Console.WriteLine(Razlika);
            //Console.ReadKey();

            #endregion

            #region 39 zadatak Pogadjanje I kategorija 2009

            //Console.WriteLine("Zute");
            //string Zute = "";
            //Zute = Console.ReadLine();

            //Console.WriteLine("Namdzaraste");
            //string Namdzaraste = "";
            //Namdzaraste = Console.ReadLine();

            //Console.WriteLine("Crvene");
            //string Crevene = "";
            //Crevene = Console.ReadLine();

            //Console.WriteLine("Broj ljudi");
            //string broj1 = "";
            //broj1 = Console.ReadLine();

            //int Zute_int = int.Parse(Zute);
            //int Namdzaraste_int = int.Parse(Namdzaraste);
            //int Crvene_int = int.Parse(Crevene);
            //int broj_int = int.Parse(broj1);
            //int rezultat = 0;
            //int broj = Zute_int + Namdzaraste_int + Crvene_int;
            //int Provera = broj % broj_int;


            //if (broj < broj_int)
            //{
            //    broj += 100;
            //}

            //if (Provera >= 0 && Provera < Namdzaraste_int)
            //{
            //    rezultat = 2;
            //}
            //if (Provera >= Namdzaraste_int && Provera < Crvene_int)
            //{
            //    rezultat = 10;
            //}
            //if (Provera >= Crvene_int && Provera < broj)
            //{
            //    rezultat = 7;
            //}

            //Console.WriteLine(rezultat);
            //Console.ReadKey();

            #endregion



        }

    }
}
