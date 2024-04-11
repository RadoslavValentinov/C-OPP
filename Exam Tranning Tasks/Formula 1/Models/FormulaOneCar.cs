using System;
using System.Collections.Generic;
using System.Text;
using Formula1.Models.Contracts;

namespace Formula1.Models
{
    public abstract class FormulaOneCar : IFormulaOneCar
    {
        private string _model;
        private int _horsepower;
        private double _engineDisplacement;

        protected FormulaOneCar(string model, int horsepower, double engineDisplacement)
        {
            this.Model = model;
            this.Horsepower = horsepower;
            this.EngineDisplacement = engineDisplacement;
        }

        public string Model
        {
            get => _model;
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException($"Invalid car model: {value}.");
                }
                _model = value;
            }
        }

        public int Horsepower
        {
            get => _horsepower;
            private set
            {
                if (value < 900 || value > 1050)
                {
                    throw new ArgumentException($"Invalid car horsepower: {value}.");
                }
                _horsepower = value;
            }
        }

        public double EngineDisplacement
        {
            get => _engineDisplacement;
            private set
            {
                if (value < 1.6 || value > 2.00)
                {
                    throw new ArgumentException($"Invalid car engine displacement: {value}.");
                }
                _engineDisplacement = value;
            }
        }

        public double RaceScoreCalculator(int laps)
        {
            //engine displacement / horsepower * laps
            return this.EngineDisplacement / this.Horsepower * laps;
        }
    }
}
