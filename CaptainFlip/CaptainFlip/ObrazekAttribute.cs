namespace CaptainFlip
{
    public class ObrazekAttribute : Attribute
    {
        public string Sciezka { get; }
        public ObrazekAttribute(string sciezka)
        {
            Sciezka = sciezka;
        }
    }
}
