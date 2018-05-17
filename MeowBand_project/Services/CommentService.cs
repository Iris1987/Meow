
using MeowBand_project.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeowBand_project.Services
{
    public class CommentService : IGenericService<t_comment>
    {
        private readonly IGenericService<t_comment> repository;

        public CommentService(IGenericService<t_comment> repository)
        {
            this.repository = repository;
        }

        public void Create(t_comment item)
        {
            repository.Create(item);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public IEnumerable<t_comment> GetByCompoID(int id)
        {
            return repository.GetAll().Where(x => x.t_composition.id_composition.Equals(id));
        }

        public IEnumerable<t_comment> GetAll()
        {
            return repository.GetAll();
        }

        public t_comment GetByID(int id)
        {
            return repository.GetByID(id);
        }

        public void Update(t_comment item)
        {
            repository.Update(item);
        }
    }
}
