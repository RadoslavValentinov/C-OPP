using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Formula1.Models.Contracts;
using Formula1.Repositories.Contracts;

namespace Formula1.Repositories
{
    public class RaceRepository:IRepository<IRace>
    {
        private ICollection<IRace> _models;

        public RaceRepository()
        {
            _models = new List<IRace>();
        }
        public IReadOnlyCollection<IRace> Models => (IReadOnlyCollection<IRace>)_models;

        public void Add(IRace model)
            => _models.Add(model);

        public bool Remove(IRace model)
            => _models.Remove(model);

        public IRace FindByName(string name)
            => _models.FirstOrDefault(x => x.RaceName == name);
    }
}
