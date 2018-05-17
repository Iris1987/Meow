
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
    public class genreRepo:IGeneric<t_genre>
    {
        private MeowEntities db;

        public genreRepo(MeowEntities context)
        {
            this.db = context;
        }

        public async void Create(t_genre item)
        {

            db.t_genre.Add(item);
            await db.SaveChangesAsync();
        }

        public async void Delete(int id)
        {
            t_genre genre = db.t_genre.Find(id);
            if (genre != null)
                db.t_genre.Remove(genre);
            await db.SaveChangesAsync();
        }

        public IEnumerable<t_genre> GetAll()
        {
            return db.t_genre.ToList();
        }

        public t_genre GetById(int id)
        {
            return db.t_genre.FirstOrDefault(x => x.id_genre== id);
        }

        //public t_genre GetByCompositionId(int id)
        //{
        //    return db.t_comment.FirstOrDefault(x => x.id_composition == id);
        //}

        public async void Update(t_genre item)
        {
            db.Entry(item).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public IEnumerable<genreRepo> Find(Expression<Func<genreRepo, bool>> predicate)
        {
            return db.Set<genreRepo>().Where(predicate);
        }
    }
}
