
using MeowBand_project.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeowBand_project.Services
{
    public class UserService:IGenericService<t_user>
    {
        private readonly IGenericService<t_user> repository;

        public UserService(IGenericService<t_user> repository)
        {
            this.repository = repository;
        }

        public void Create(t_user item)
        {
            repository.Create(item);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public IEnumerable<t_user> Find(string word)
        {
            return null;//GetByCompositionId
        }

        public IEnumerable<t_user> GetByCompoID(int id)
        {
            return repository.GetAll().Where(x => x.t_composition.Any(y => y.id_composition == id));
        }

        public IEnumerable<t_user> GetAll()
        {
            return repository.GetAll();
        }

        public t_user GetByID(int id)
        {
            return repository.GetByID(id);
        }

        public void Update(t_user item)
        {
            repository.Update(item);
        }
    }
}
