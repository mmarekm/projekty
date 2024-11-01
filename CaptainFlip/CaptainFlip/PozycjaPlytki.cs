namespace CaptainFlip
{
    public class PozycjaPlytki
    {
        public Plytka Plytka { get; set; }
        public bool CzyOdwrocona { get; set; }
        public PozycjaPlytki(Plytka plytka, bool czyOdwrocona)
        {
            Plytka = plytka;
            CzyOdwrocona = czyOdwrocona;
        }
        public Marynarze WyswietlonyMarynarz => CzyOdwrocona ? Plytka.Rewers : Plytka.Awers;
    }
}
