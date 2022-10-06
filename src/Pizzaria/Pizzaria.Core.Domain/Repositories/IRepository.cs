using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Pizzaria.Core.Domain
{
    public interface IRepository<T> : IDisposable where T : class
    {
        T Adicionar(T obj);
        T ObterPorId(int id);
        IEnumerable<T> ObterTodos();
        T Atualizar(T obj);
        void Remover(int id);
        IEnumerable<T> Procurar(Expression<Func<T, bool>> predicate);
        int Salvar();
    }
}
