using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CentiSoft.DAL {
    public interface IRepository<TEntity> {
        Func<IDbConnection> Connection { get; set; }

        TEntity Create(string name, string email);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Insert(TEntity entity);
        bool Update(int id, string name, string email);
        int Delete(int id);
        void Save();
    }
}
