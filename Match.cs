using System;
using System.Collections.Generic;
using TMG_Test3.Language;

namespace TMG_Test3
{
    public class Match
    {
        private int _index;
        private string[][] _result;
        private List<Russian> _rusArr;
        private List<English> _engArr;
        public Match(string[] rusArr, string[] engArr)
        {
            this._index = 0;
            this._rusArr = new List<Russian>();
            this._engArr = new List<English>();
            this._result = new string[2][];
            foreach (var item in rusArr)
                _rusArr.Add(new Russian(item));
            foreach (var item in engArr)
                _engArr.Add(new English(item));
        }
        private void Resize(bool Flag)
        {
            if (Flag)
            {
                Array.Resize(ref this._result[0], this._result[0].Length * 2);
                Array.Resize(ref this._result[1], this._result[1].Length * 2);
            }
        }
        public void Add(string currentRus, string currentEng)
        {
            this.Resize(_index >= this._result.GetLength(0));
            this._result[_index][0] = currentRus;
            this._result[_index][1] = currentEng;
            this._index++;
        }
        public string[][] Matching()
        {
            foreach(var item in _rusArr)
            {
                var _findArr = _engArr.FindAll(e => e.indexSum == item.index);
                foreach (var finditem in _findArr)
                    Add(item.text, finditem.text);
            }
            return _result;
        }
    }
}
