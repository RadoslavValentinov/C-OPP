using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Formula1.Models.Contracts;
using Formula1.Repositories.Contracts;

namespace Formula1.Repositories
{
    public class PilotRepository:IRepository<IPilot>
    {
        private ICollection<IPilot> _models;

        public PilotRepository()
        {
            _models = new List<IPilot>();
        }
        public IReadOnlyCollection<IPilot> Models => (IReadOnlyCollection<IPilot>)_models;

        public void Add(IPilot model)
            => _models.Add(model);

        public bool Remove(IPilot model)
            => _models.Remove(model);

        public IPilot FindByName(string name)
            => _models.FirstOrDefault(x => x.FullName == name);
    }
}
