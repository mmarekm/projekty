namespace CaptainFlip
{
    public class Plytka
    {
        public Plytka() { }
        public Marynarze Awers { get; }
        public Marynarze Rewers { get; }
        public Marynarze MarynarzTyp { get; set; }
        public Plytka(Marynarze awers, Marynarze rewers)
        {
            Awers = awers;
            Rewers = rewers;
        }
    }
}
