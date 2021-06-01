using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatBaze.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public bool Delete(object id)
        {
            using (var db = new Model1Container1())
            {
                try
                {
                    DbSet<TEntity> dbSet = db.Set<TEntity>();
                    TEntity entityToDelete = db.Set<TEntity>().Find(id);
                    db.Entry(entityToDelete).State = EntityState.Deleted;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Message:\n" + e.Message + "\n\nTrace:\n" + e.StackTrace + "\n\nInner:\n" + e.InnerException);
                    return false;
                }

            }
        }

        public TEntity FindById(object id)
        {
            using (var db = new Model1Container1())
            
            {
                return db.Set<TEntity>().Find(id);
            }
        }

        public List<TEntity> GetAll()
        {
            using (var db = new Model1Container1())
            {
                return db.Set<TEntity>().ToList();
            }
        }

        public bool Insert(TEntity entity)
        {
            using (var db = new Model1Container1())
            {
                try
                {
                    db.Set<TEntity>().Add(entity);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Message:\n" + e.Message + "\n\nTrace:\n" + e.StackTrace + "\n\nInner:\n" + e.InnerException);
                    return false;
                }

            }
        }

        public bool Update(TEntity entityToUpdate)
        {
            using (var db = new Model1Container1())
            {
                try
                {
                    db.Set<TEntity>().Attach(entityToUpdate);
                    db.Entry(entityToUpdate).State = EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Message:\n" + e.Message + "\n\nTrace:\n" + e.StackTrace + "\n\nInner:\n" + e.InnerException);
                    return false;
                }

            }
        }
    }
}