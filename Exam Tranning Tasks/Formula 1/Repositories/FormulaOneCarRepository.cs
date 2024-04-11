using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Formula1.Models.Contracts;
using Formula1.Repositories.Contracts;

namespace Formula1.Repositories
{
    public class FormulaOneCarRepository:IRepository<IFormulaOneCar>
    {
        private ICollection<IFormulaOneCar> _models;

        public FormulaOneCarRepository()
        {
            _models = new List<IFormulaOneCar>();
        }
        public IReadOnlyCollection<IFormulaOneCar> Models => (IReadOnlyCollection<IFormulaOneCar>)_models;

        public void Add(IFormulaOneCar model)
            => _models.Add(model);

        public bool Remove(IFormulaOneCar model)
            => _models.Remove(model);

        public IFormulaOneCar FindByName(string name)
            => _models.FirstOrDefault(x => x.Model == name);
    }
}
