
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
    public class userlikesRepo:IGeneric<t_userlikes>
    {
        private MeowEntities db;

        public userlikesRepo(MeowEntities context)
        {
            this.db = context;
        }

        public async void Create(t_userlikes item)
        {

            db.t_userlikes.Add(item);
            await db.SaveChangesAsync();
        }

        public async void Delete(int id)
        {
            t_userlikes userlikes = db.t_userlikes.Find(id);
            if (userlikes != null)
                db.t_userlikes.Remove(userlikes);
            await db.SaveChangesAsync();
        }

        public IEnumerable<t_userlikes> GetAll()
        {
            return db.t_userlikes.ToList();
        }

        public t_userlikes GetById(int id)
        {
            return db.t_userlikes.FirstOrDefault(x => x.id_user == id);
        }



        public async void Update(t_userlikes item)
        {
            db.Entry(item).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public IEnumerable<userlikesRepo> Find(Expression<Func<userlikesRepo, bool>> predicate)
        {
            return db.Set<userlikesRepo>().Where(predicate);
        }
    }
}
