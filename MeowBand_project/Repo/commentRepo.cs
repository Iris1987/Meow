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
    public class commentRepo : IGeneric<t_comment>
    {
        private MeowEntities db;

        public commentRepo(MeowEntities context)
        {
            this.db = context;
        }
        
        public async void Create(t_comment item)
        {

            db.t_comment.Add(item);
            await db.SaveChangesAsync();
        }

        public async void Delete(int id)
        {
            t_comment comment = db.t_comment.Find(id);
            if (comment != null)
                db.t_comment.Remove(comment);
            await db.SaveChangesAsync();
        }

        public IEnumerable<t_comment> GetAll()
        {
            return db.t_comment.ToList();

            //return db.TranslationRusEsts.Include(x => x.IdCategoryNavigation)
            //    .Include(x => x.IdPartNavigation)
            //    .Include(x => x.IdWordRusNavigation)
            //    .Include(x => x.IdWordEstNavigation)
            //    .Include(x => x.IdCategoryNavigation.IdCategoryNavigation)
            //    .ToList();
        }

        public t_comment GetById(int id)
        {
            return db.t_comment.FirstOrDefault(x => x.id_comment == id);
        }

        //public IEnumerable<t_comment> GetByCompositionId(int id)
        //{

        //    return db.t_comment.Where(x => x.id_composition == id).ToList();
        //}


        public async void Update(t_comment item)
        {
            db.Entry(item).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public IEnumerable<commentRepo> Find(Expression<Func<commentRepo, bool>> predicate)
        {
            return db.Set<commentRepo>().Where(predicate);
        }
    }
}
