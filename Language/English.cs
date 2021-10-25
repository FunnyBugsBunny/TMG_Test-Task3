namespace TMG_Test3.Language
{
    public class English : Strings 
    {
        private double _indexComment;
        public readonly double indexSum;
        public English(string text)
            : base(text.Split('|')[0])
        {
            _indexComment = CalcIndex(text.Split('|')[1]);
            indexSum = _indexComment + base.index;
        }
    }
}
