namespace CaptainFlip
{
    public class WszystkiePlytki
    {
        private readonly List<Plytka> plytki;
        private readonly Random los;
        public int PlytkiCount => plytki.Count;

        public WszystkiePlytki()
        {
            plytki = UtworzeniePlytek();
            los = new Random();
        }
        private static List<Plytka> UtworzeniePlytek()
        {
            var wynik = new List<Plytka>();
            Marynarze[] marynarze = (Marynarze[])Enum.GetValues(typeof(Marynarze));
            Array.Sort(marynarze, (x, y) => x.ToString().CompareTo(y.ToString()));
            for (int i = 0; i < marynarze.Length; i++)
            {
                for (int j = i + 1; j < marynarze.Length; j++)
                {
                    wynik.Add(new Plytka(marynarze[i], marynarze[j]));
                    wynik.Add(new Plytka(marynarze[i], marynarze[j]));
                }
            }
            return wynik;
        }
        public Plytka LosujPlytke()
        {
            int index = los.Next(plytki.Count);
            Plytka wylosowanaPlytka = plytki[index];
            plytki.RemoveAt(index);
            return wylosowanaPlytka;
        }
        public Marynarze WyswietlonaStrona(Plytka plytka)
        {
            return los.Next(2) == 0 ? plytka.Awers : plytka.Rewers;
        }
    }
}
