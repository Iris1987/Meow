

using MeowBand_project.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeowBand_project.Services
{
    public class CompositiongenreService:IGenericService<t_compositiongenre>
    {
        private readonly IGenericService<t_compositiongenre> repository;

        public CompositiongenreService(IGenericService<t_compositiongenre> repository)
        {
            this.repository = repository;
        }

        public void Create(t_compositiongenre item)
        {
            repository.Create(item);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public IEnumerable<t_compositiongenre> GetByCompoID(int id)
        {
            return repository.GetAll().Where(x => x.t_composition.id_composition.Equals(id));
        }

        public IEnumerable<t_compositiongenre> GetByGenreID(int id)
        {
            return repository.GetAll().Where(x => x.t_genre.id_genre.Equals(id));
        }
       


        public IEnumerable<t_compositiongenre> GetAll()
        {
            return repository.GetAll();
        }

        public t_compositiongenre GetByID(int id)
        {
            return repository.GetByID(id);
        }

        public void Update(t_compositiongenre item)
        {
            repository.Update(item);
        }
    }
}
