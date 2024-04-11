using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using Formula1.Models.Contracts;

namespace Formula1.Models
{
    public class Pilot : IPilot
    {
        private string _fullName;
        private IFormulaOneCar _car;
        private int _numberOfWins;
        private bool _canRace=false;
       

        public Pilot(string fullName)
        {
            this.FullName = fullName;
        }


        public string FullName
        {
            get => _fullName;
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException($"Invalid pilot name: {value}.");
                }
                _fullName = value;
            }
        }

        public IFormulaOneCar Car
        {
            get => _car;
            private set
            {
                if (value==null)
                {
                    throw new NullReferenceException("Pilot car can not be null.");
                }
            }
        }

        public int NumberOfWins
        {
            get => _numberOfWins;
            private set
            {
                _numberOfWins = value;
            }
        }

        public bool CanRace
        {
            get => _canRace;
            private set
            {
                _canRace = value;
            }
        }

        public void AddCar(IFormulaOneCar car)
        {
            if (car.GetType().Name== "Williams")
            {
                this._car = new Williams(car.Model, car.Horsepower, car.EngineDisplacement);
            }
            else if (car.GetType().Name== "Ferrari")
            {
                this._car = new Ferrari(car.Model, car.Horsepower, car.EngineDisplacement);
            }
            this.CanRace = true;
        }

        public void WinRace()
        {
            this.NumberOfWins += 1;
        }

        public override string ToString()
        {
            return $"Pilot {this.FullName} has {this.NumberOfWins} wins.";
        }
    }
}
