namespace CaptainFlip
{
    public class Gracz
    {
        public string Nazwa { get; set; }
        public int Punkty { get; set; }
        public int PunktyZPlanszy { get; set; }
        public bool PosiadaczMapy { get; set; }
        public Dictionary<(int x, int y), PozycjaPlytki> Plansza { get; set; }
        public int[,] TablicaPlansza { get; set; }
        public int Szczyty {  get; set; }
        public Gracz(string nazwa)
        {
            Nazwa = nazwa;
            Szczyty = 0;
            Punkty = 0;
            PosiadaczMapy = false;
            Plansza = new Dictionary<(int x, int y), PozycjaPlytki>
            {
                {(1,1), null}, {(1,2), null},
                {(2,1), null}, {(2,2), null}, {(2,3), null},
                {(3,1), null}, {(3,2), null}, {(3,3), null}, {(3,4), null}, {(3,5), null},
                {(4,3), null}, {(4,4), null},
                {(5,1), null}, {(5,2), null}, {(5,3), null}
            };
            TablicaPlansza = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    TablicaPlansza[i, j] = 0;
                }
            }
        }
        public int SumaKoncowych() => KoncoweBocianieGniazdo() + KoncoweCiesli() + KoncoweMajtek() + KoncowePapugi();
        public int KoncoweBocianieGniazdo()
        {
            int naBocianimGniezdzie = 0;
            if (TablicaPlansza[0, 1] == 1)
            {
                naBocianimGniezdzie++;
            }
            if (TablicaPlansza[1, 2] == 1)
            {
                naBocianimGniezdzie++;
            }
            if (TablicaPlansza[2, 4] == 1)
            {
                naBocianimGniezdzie++;
            }
            if (TablicaPlansza[3, 3] == 1)
            {
                naBocianimGniezdzie++;
            }
            if (TablicaPlansza[4, 2] == 1)
            {
                naBocianimGniezdzie++;
            }
            return 4 * naBocianimGniezdzie;
        }
        public int KoncoweCiesli()
        {
            int zliczaczCiesli = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (TablicaPlansza[i, j] == 3)
                    {
                        bool brakPirata = true;
                        for (int k = 0; k < 5; k++)
                        {
                            if (TablicaPlansza[i, k] == 2 || TablicaPlansza[k, j] == 2)
                            {
                                brakPirata = false;
                            }
                        }
                        if (brakPirata)
                        {
                            zliczaczCiesli++;
                        }
                    }
                }
            }
            return 3 * zliczaczCiesli;
        }
        public int KoncoweMajtek()
        {
            int zliczaczMajtkow = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (TablicaPlansza[i, j] == 6)
                    {
                        zliczaczMajtkow++;
                        break;
                    }
                }
            }
            return (int)Math.Pow(zliczaczMajtkow, 2);
        }
        public int KoncowePapugi()
        {
            int zliczaczPapug = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (TablicaPlansza[i, j] == 9)
                    {
                        zliczaczPapug++;
                    }
                }
            }
            return -zliczaczPapug;
        }
        public string KomentarzBombardiera() => ZaDuzoBombardierow() ? "BUUUM" : "spokój";
        public int OstatecznePunkty()
        {
            if (ZaDuzoBombardierow())
            {
                return 0;
            }
            else
            {
                return Punkty + SumaKoncowych();
            }
        }
        public bool ZaDuzoBombardierow()
        {
            bool zerowanie = false;
            int zliczaczBombardierow = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (TablicaPlansza[i, j] == 2)
                    {
                        zliczaczBombardierow++;
                    }
                }
            }
            if (zliczaczBombardierow >= 3)
            {
                zerowanie = true;
            }
            return zerowanie;
        }
        public string ZMapa => PosiadaczMapy ? "MAPA" : "";
        public string Interpunkcja => ZaDuzoBombardierow() ? "..." : "!";
    }
}
