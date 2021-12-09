using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface Irepositorio<T>
    {
        void Create(T t);
        ICollection<T> GetAll();

    }
}
