
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
    public class compositiongenreRepo:IGeneric<t_compositiongenre>
    {
        private MeowEntities db;

        public compositiongenreRepo(MeowEntities context)
        {
            this.db = context;
        }

        public async void Create(t_compositiongenre item)
        {

            db.t_compositiongenre.Add(item);
            await db.SaveChangesAsync();
        }

        public async void Delete(int id)
        {
            t_compositiongenre compositiongenre = db.t_compositiongenre.Find(id);
            if (compositiongenre != null)
                db.t_compositiongenre.Remove(compositiongenre);
            await db.SaveChangesAsync();
        }

        public IEnumerable<t_compositiongenre> GetAll()
        {
            return db.t_compositiongenre
                //.Include(x => x.t_composition.id_composition)
                //.Include(x => x.t_genre.id_genre)
                .ToList();
        }

        public t_compositiongenre GetById(int id)
        {
            return db.t_compositiongenre.FirstOrDefault(x => x.id_composgenre == id);
        }


        public async void Update(t_compositiongenre item)
        {
            db.Entry(item).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public IEnumerable<compositiongenreRepo> Find(Expression<Func<compositiongenreRepo, bool>> predicate)
        {
            return db.Set<compositiongenreRepo>().Where(predicate);
        }
    }
}
