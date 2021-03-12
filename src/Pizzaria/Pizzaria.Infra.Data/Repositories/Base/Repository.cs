using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Pizzaria.Infra.Data.Data.Context;
using Pizzaria.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Pizzaria.Core.Domain.Entities;

namespace Pizzaria.Infra.Data.Data.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        protected PizzariaContext Db;
        protected DbSet<T> DbSet;
        public Repository([FromServices] PizzariaContext context)
        {
            Db = context;
            DbSet = Db.Set<T>();
        }

        public EntityEntry<T> Adicionar(T obj)
        {
            var returnObj = DbSet.Add(obj);
            return returnObj;
        }

        public T Atualizar(T obj)
        {
            var entry = Db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;

            return obj;
        }      
        public virtual T ObterPorId(int id)
        {
            var returnObj = DbSet.Find(id);

            if (returnObj != null)
                Db.Entry(returnObj).State = EntityState.Detached;

            return returnObj;
        }

        public IEnumerable<T> ObterTodos()
        {
            return DbSet.ToList();
        }

        public IEnumerable<T> Procurar(Expression<Func<T, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public void Remover(int id)
        {
            var entity = ObterPorId(id);
            entity.Ativo = false;
            DbSet.Update(entity);
        }

        public int Salvar()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

    }
}
