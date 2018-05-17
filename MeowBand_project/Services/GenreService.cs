
using MeowBand_project.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeowBand_project.Services
{
    public class GenreService:IGenericService<t_genre>
    {
        private readonly IGenericService<t_genre> repository;

        public GenreService(IGenericService<t_genre> repository)
        {
            this.repository = repository;
        }

        public void Create(t_genre item)
        {
            repository.Create(item);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public IEnumerable<t_genre> Find(string word)
        {
            return repository.GetAll().Where(x => x.name.Contains(word));
        }

        public List<t_genre> GetByCompoID(int id)
        {
            return repository.GetAll().Where(x => x.t_compositiongenre.Any(y => y.t_composition.id_composition == id)).ToList();
        }

        public IEnumerable<t_genre> GetAll()
        {
            return repository.GetAll();
        }

        public t_genre GetByID(int id)
        {
            return repository.GetByID(id);
        }

        public void Update(t_genre item)
        {
            repository.Update(item);
        }
    }
}
