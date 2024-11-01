namespace CaptainFlip
{
    public static class EnumExtensions
    {
        public static string PobierzSciezkeObrazka(this Marynarze marynarz)
        {
            var type = marynarz.GetType();
            var memberInfo = type.GetMember(marynarz.ToString());
            var attributes = memberInfo[0].GetCustomAttributes(typeof(ObrazekAttribute), false);

            return attributes.Length > 0 ? ((ObrazekAttribute)attributes[0]).Sciezka : null;
        }
    }
}
