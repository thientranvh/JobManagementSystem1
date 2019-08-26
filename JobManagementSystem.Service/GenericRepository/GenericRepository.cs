using JobManagementSystem.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace JobManagementSystem.Service.GenericRepository
{
    /// <summary>
    /// Generic
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        #region Properties
            /// <summary>
            /// Declare datacontext
            /// </summary>
        private readonly JobSystemDbContext _jobSytemDbContext;

        /// <summary>
        /// Declare Dbset EntityFrameworkCore
        /// </summary>
        private readonly DbSet<T> _dbSet;

        #endregion
        public GenericRepository(JobSystemDbContext jobSytemDbContext)
        {

            _jobSytemDbContext = jobSytemDbContext;
            _dbSet = _jobSytemDbContext.Set<T>();
            ObjectContext = _dbSet;
        }
        public IQueryable<T> ObjectContext { get; set; }
        #region Implementation        
        /// <summary>
        /// Get all entities
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> GetAll()
        {
            var listEntities = _dbSet.AsEnumerable();
            return listEntities;
        }

        /// <summary>
        /// Method get one Object with condition
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public T Get(Expression<Func<T, bool>> where)
        {
            try
            {
                return _dbSet.Where(where).FirstOrDefault();
            }
            catch (Exception e)
            {
                Log.Error(e, "Get Generic Throw Exception");
                return null;
            }
        }

        /// <summary>
        /// Get many T entity by condition
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public IEnumerable<T> GetMany(Func<T, bool> where)
        {
            var listEntities = _dbSet.AsEnumerable().Where(where);
            return listEntities;
        }

        /// <summary>
        /// Get an entity by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetById(object id)
        {
            var entitiesByid = _dbSet.Find(id);
            return entitiesByid;
        }

        /// <summary>
        /// Create T entity
        /// </summary>
        /// <param name="entity"></param>
        public T Create(T entity)
        {
            _dbSet.Add(entity);
            return entity;
        }

        /// <summary>
        /// Update T entity
        /// </summary>
        /// <param name="entity"></param>
        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _jobSytemDbContext.Entry(entity).State = EntityState.Modified;
        }

        /// <summary>
        /// Remove T entity by id
        /// </summary>
        /// <param name="id"></param>
        public void Delete(object id)
        {
            var entity = _dbSet.Find(id);
            _dbSet.Remove(entity);
        }

        /// <summary>
        /// Remove a list entities
        /// </summary>
        /// <param name="entities"></param>
        public void DeleteRange(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public void Save()
        {
            _jobSytemDbContext.SaveChanges();
        }

        #endregion
    }
}
