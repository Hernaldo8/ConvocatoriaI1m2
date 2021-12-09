using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Interfaces
{
    public interface Iservicios<T>
    {
        void Create(T t);
        ICollection<T> GetAll();
    }
}
