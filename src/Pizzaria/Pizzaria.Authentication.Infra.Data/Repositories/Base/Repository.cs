using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Pizzaria.Authentication.Infra.Data.Context;
using Pizzaria.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Pizzaria.Authentication.Infra.Data.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected AutenticacaoContext Db;
        protected DbSet<T> DbSet;
        public Repository([FromServices] AutenticacaoContext context)
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
        public T ObterPorId(int id)
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
            DbSet.Remove(DbSet.Find(id));
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
