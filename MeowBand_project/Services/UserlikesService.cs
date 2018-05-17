
using MeowBand_project.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeowBand_project.Services
{
    public class UserlikesService:IGenericService<t_userlikes>
    {
        private readonly IGenericService<t_userlikes> repository;

        public UserlikesService(IGenericService<t_userlikes> repository)
        {
            this.repository = repository;
        }

        public void Create(t_userlikes item)
        {
            repository.Create(item);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public IEnumerable<t_userlikes> GetByUserID(int id)
        {
            return repository.GetAll().Where(x => x.id_user == id);
        }

        public IEnumerable<t_userlikes> GetByCompoID(int id)
        {
            return repository.GetAll().Where(x => x.t_composition.id_composition==id);
        }

        public IEnumerable<t_userlikes> GetAll()
        {
            return repository.GetAll();
        }

        public t_userlikes GetByID(int id)
        {
            return repository.GetByID(id);
        }

        public void Update(t_userlikes item)
        {
            repository.Update(item);
        }
    }
}
