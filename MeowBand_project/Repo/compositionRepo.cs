
using MeowBand_project.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MeowBand_project.Repo
{
    public class compositionRepo:IGeneric<t_composition>
    {
        private MeowEntities db;

        public compositionRepo(MeowEntities context)
        {
            this.db = context;
        }

        public async void Create(t_composition item)
        {

            db.t_composition.Add(item);
            await db.SaveChangesAsync();
        }

        public async void Delete(int id)
        {
            t_composition composition = db.t_composition.Find(id);
            if (composition != null)
                db.t_composition.Remove(composition);
            await db.SaveChangesAsync();
        }

        public IEnumerable<t_composition> GetAll()
        {
            return db.t_composition
                //.Include(x=>x.t_compositiongenre)
                .ToList();
        }

        public t_composition GetById(int id)
        {
            return db.t_composition.FirstOrDefault(x => x.id_composition == id);
        }

        

        public async void Update(t_composition item)
        {
            db.Entry(item).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public IEnumerable<compositionRepo> Find(Expression<Func<compositionRepo, bool>> predicate)
        {
            return db.Set<compositionRepo>().Where(predicate);
        }
    }
}
