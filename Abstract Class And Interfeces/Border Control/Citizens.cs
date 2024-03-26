using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizens : IWhoIAm
    {
        private string name;
        private int age;
        private string id;

        public Citizens(string name,int age,string id)
        {
            this.Name = name;
            Age = age;
            this.Id = id;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }
        public string Id
        {
            get => id;
            set => id = value;
        }
    }
}
