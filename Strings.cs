using System;
using System.Linq;

namespace TMG_Test3
{
    public class Strings
    {
        public readonly string text;
        public readonly double index;
        public Strings(string text)
        {
            this.text = text;
            this.index = CalcIndex(text);
        }
        protected static double CalcIndex(string _text)
        {
            var onlyLetters = new String(_text.Where(c => Char.IsLetter(c)).ToArray());
            double indexletter = 0.5;
            double indexstr = 0;
            for (int i = 0; i < onlyLetters.Length; i++)
            {
                indexstr += indexletter;
                indexletter += 1;
            }
            return indexstr * onlyLetters.Length;
        }
    }
}
