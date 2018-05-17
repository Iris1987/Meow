using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeowBand_project.Interfaces
{
    public interface IGeneric<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();//IEnumerable or Queriyable
        TEntity GetById(int id);
        void Create(TEntity item);
        void Update(TEntity item);
        void Delete(int id);
       // IEnumerable<TEntity> Find();
       
    }
}
