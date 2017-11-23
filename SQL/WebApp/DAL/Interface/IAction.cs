using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.DAL.Interface
{
    public interface IAction<T,Key>
    {
        IEnumerable<T> GetList();

        T GetByID(Key id);

        bool Add(T obj);

        bool Update(T obj);

        bool Delete(Key id);
    }
}
