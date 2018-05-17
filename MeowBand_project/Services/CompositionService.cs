
using MeowBand_project.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Repo;


namespace MeowBand_project.Services
{
    public class CompositionService: IGenericService<t_composition>
    {
        private readonly IGenericService<t_composition> repository;

        public CompositionService(IGenericService<t_composition> repository)
        {
            this.repository = repository;
        }

        public void Create(t_composition item)
        {
            repository.Create(item);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public IEnumerable<t_composition> Find(string word)
        {
            return repository.GetAll().Where(x => x.name.Contains(word));
        }

        public IEnumerable<t_composition> GetByUserID(int id)
        {
            return repository.GetAll().Where(x => x.t_user.id_user.Equals(id));
        }       
        public IEnumerable<t_composition> GetByGenreID(int id)
        {
            return repository.GetAll().Where(x => x.t_compositiongenre.Any(y => y.t_genre.id_genre == id));
        }

        public IEnumerable<t_composition> GetAll()
        {
            return repository.GetAll();
        }

        public t_composition GetByID(int id)
        {
            return repository.GetByID(id);
        }

        public void Update(t_composition item)
        {
            repository.Update(item);
        }
    }
}
