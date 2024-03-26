using System;
using System.Collections.Generic;
using System.Text;
using BorderControl;

namespace BirthdayCelebrations
{
    public class Pet: IWhoIAm,IBirthsDay
    {
        private string name;
        private string birthdaydate;

        public Pet(string name, string birthdaydate)
        {
            this.Name = name;
            this.Birthday = birthdaydate;
        }
        public string Name
        {
            get => name;
            set => name=value;
        }

        public string Id
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public string Birthday
        {
            get => birthdaydate;
            set => birthdaydate=value;
        }
    }
}
