using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationApp.Interfaces.Generics
{
    public interface InterfaceGenericApp<T> where T : class
    {
        Task Add(T objeto);

        Task Update(T objeto);

        Task Delete(T objeto);

        Task<T> GetEntityById(int Id);

        Task<List<T>> List();
    }
}
