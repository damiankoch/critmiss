using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ArmyViewer.Data.Interfaces;

namespace ArmyViewer.Service
{
    public abstract class BaseService<T> where T: class, IBattleHubEntity, new()
    {
        protected int UserId;
        protected readonly BattleHubContext Context = new BattleHubContext();
        
        protected BaseService(int userId)
        {
            UserId = userId;
        }
        protected BaseService(int userId, BattleHubContext context)
        {
            Context = context;
            UserId = userId;
        }

        public virtual T GetById(int id)
        {
            return Context.Set<T>().IsNotDeleted().FirstOrDefault(x => x.Id == id);
        }

        public virtual T Insert(T obj)
        {
            var r = SaveProjection(Context.Set<T>().Create());
            r = Context.Set<T>().Add(r);
            Context.SaveChanges();
            return r;
        }

        public virtual T Update(T obj)
        {
            var r = SaveProjection(GetById(obj.Id));
            Context.Entry(r).State = System.Data.Entity.EntityState.Modified;
            Context.SaveChanges();
            return r;
        }

        public abstract T SaveProjection(T input);

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
