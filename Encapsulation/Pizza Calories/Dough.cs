using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories.Models
{
    public class Dough
    {
        private Dictionary<string, double> flourtypeAndWeight = new Dictionary<string, double>()
        {
            {"white",1.5},
            {"wholegrain", 1.0}
        };

        private Dictionary<string, double> bakingtechniqueAndweight = new Dictionary<string, double>()
        {
            {"crispy", 0.9},
            {"chewy" ,1.1},
            {"homemade", 1.0}
        };

        private string flourtype;
        private string bakingtechnique;
        private double weight;

        public Dough(string flourtype, string bakingtechnique, double weight)
        {
            this.FlourType = flourtype;
            this.BakingTechnique = bakingtechnique;
            this.Weight = weight;
        }
        public double Weight
        {
            get
            {
                return weight;
            }
            private set
            {
                if (value < 0 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                weight = value;
            }
        }

        public string BakingTechnique
        {
            get
            {
                return bakingtechnique;
            }
            private set
            {
                if (!bakingtechniqueAndweight.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                bakingtechnique = value;
            }
        }

        public string FlourType
        {
            get
            {
                return flourtype;
            }
            private set
            {
                if (!flourtypeAndWeight.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                flourtype = value;
            }
        }

        public double Calories => 2 * Weight * flourtypeAndWeight[this.FlourType.ToLower()]
                                  * bakingtechniqueAndweight[BakingTechnique.ToLower()];

    }
}
