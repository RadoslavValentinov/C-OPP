using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random rnd;
        private List<string> listy = new List<string>();

        public RandomList()
        {
            rnd = new Random();
        }
        public string RandomString()
        {
            int index = rnd.Next(0, listy.Count);
            string str = listy[index].ToString();
            return str;
        }


        public void Add(string item)
        {
            listy.Add(item);
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(string item)
        {
            return listy.Contains(item);
        }

        public void CopyTo(string[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(string item)
        {
            return listy.Remove(item);
        }

        public int Count => listy.Count;
    }
}
