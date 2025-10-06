using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Parking.DataLayer.Repositories;

namespace Parking.DataLayer.Services
{
    public class GenericRepository<TEntity> where TEntity:class
    {
        private Parking_DBEntities3 _db;
        private DbSet<TEntity> _dbSet;

        public GenericRepository(Parking_DBEntities3 db)
        {
            _db = db;
            _dbSet = db.Set<TEntity>();
        }
        
        public List<GeneralInformation> GetAllInfo()
        {
            return _db.GeneralInformations.ToList();
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity,bool>> where = null)
        {
            IQueryable<TEntity> query = _dbSet;
            if (where != null)
            {
                query = query.Where(where);
            }
            return query.ToList();
        }
        public virtual void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }
        public virtual TEntity GetByNumberPlate(object NumberPlate)
        {
            return _dbSet.Find(NumberPlate);
        }

        public virtual void Update(TEntity entity)
        {

            _db.Entry(entity).State = EntityState.Modified;
        }

        public virtual void DeleteCar(TEntity entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }

        public virtual void DeleteCar(object NumberPlate)
        {
            var entity = GetByNumberPlate(NumberPlate);
            DeleteCar(entity);
        }
        
}
}
