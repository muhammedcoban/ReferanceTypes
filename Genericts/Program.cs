using System;
using System.Collections.Generic;

namespace Genericts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("sff");
            sehirler.Add("sff");
            sehirler.Add("sff");
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2 = new Genericts.MyList<string>();
            sehirler2.Add("asdara");
            sehirler2.Add("asdara");
            Console.WriteLine(sehirler2.Count);
        }
    }
    class MyList<T>
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i <_tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }
        private int _count;

        public int Count
        {
            get { return _array.Length; }
        }

    }
}
