namespace TMG_Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] _russianStrings = { "" };
            string[] _englishStrings = { "" };
            Match match = new Match(_russianStrings, _englishStrings);
            var result = match.Matching();
        }
    }
}
