using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Robots:IWhoIAm
    {
        private string model;
        private string id;

        public Robots(string model, string id)
        {
            this.Name = model;
            this.Id = id;
        }
        public string Name
        {
            get => model;
            set => model=value;
        }

        public string Id
        {
            get => id;
            set => id=value;
        }
    }
}
