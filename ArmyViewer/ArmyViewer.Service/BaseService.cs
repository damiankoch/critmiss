using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ArmyViewer.Data;
using ArmyViewer.Data.Interfaces;
using ArmyViewer.Service.Utilities;

namespace ArmyViewer.Service
{
    public abstract class BaseService<T> where T: class, IBattleHubEntity, new()
    {
        protected string UserId;
        protected readonly BattleHubContext Context = new BattleHubContext();
        
        protected BaseService(string userId)
        {
            UserId = userId;
        }
        protected BaseService(string userId, BattleHubContext context)
        {
            Context = context;
            UserId = userId;
        }

        public virtual T GetById(string id)
        {
            return Context.Set<T>().IsNotDeleted().FirstOrDefault(x => x.Id == id);
        }

        public virtual T Insert(T obj)
        {
            var r = Context.Set<T>().Create();

            SaveProjection(ref r, obj);

            r.CreatedBy = UserId;
            r.CreatedOn = DateTime.Now;

            r = Context.Set<T>().Add(r);
            Context.SaveChanges();

            return r;
        }

        public virtual T Update(T obj)
        {
            var r = GetById(obj.Id);

            SaveProjection(ref r, obj);

            r.ModifiedBy = UserId;
            r.ModifiedOn = DateTime.Now;

            Context.Entry(r).State = System.Data.Entity.EntityState.Modified;
            Context.SaveChanges();

            return r;
        }

        public virtual bool Delete(string id)
        {
            var r = GetById(id);
            if (r == null) return false;

            r.DeletedBy = UserId;
            r.DeletedOn = DateTime.Now;
            r.Status = 0;

            Context.Entry(r).State = System.Data.Entity.EntityState.Modified;
            Context.SaveChanges();

            return true;
        }

        public abstract void SaveProjection(ref T output, T input);

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
