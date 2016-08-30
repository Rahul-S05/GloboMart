using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboMart.App.Core.Repositories
{
    public interface IDataAccessRepository<T> 
    {
        bool Create(T item);
        bool Update(T item);
        bool Delete(T item);
        List<T> Select();
        T SelectById(int Id);
    }
}
