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
        public Gracz(string nazwa)
        {
            Nazwa = nazwa;
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
    }
}
