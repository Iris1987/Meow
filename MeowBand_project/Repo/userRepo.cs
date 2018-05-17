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
    public class userRepo : IGeneric<t_user>
    {
        private MeowEntities db;

        public userRepo(MeowEntities context)
        {
            this.db = context;
        }

        public async void Create(t_user item)
        {

            db.t_user.Add(item);
            await db.SaveChangesAsync();
        }

        public async void Delete(int id)
        {
            t_user user = db.t_user.Find(id);
            if (user != null)
                db.t_user.Remove(user);
            await db.SaveChangesAsync();
        }

        public IEnumerable<t_user> GetAll()
        {
            return db.t_user.ToList();
        }

        public t_user GetById(int id)
        {
            return db.t_user.FirstOrDefault(x => x.id_user == id);
        }



        public async void Update(t_user item)
        {
            db.Entry(item).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public IEnumerable<userRepo> Find(Expression<Func<userRepo, bool>> predicate)
        {
            return db.Set<userRepo>().Where(predicate);
        }
    }
}
