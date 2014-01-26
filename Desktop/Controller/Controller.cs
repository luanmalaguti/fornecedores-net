using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Controller
{
    public interface Controller<T>
    {
        T Save(T t);

        void Remove(T t);

        T Find(int id);

        ICollection<T> FindAll();
    }
}
