using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Repository
{
    public abstract class baserepositorio<T>:Irepositorio<T>
    {
        protected List<T> registro;
        public baserepositorio()
        {
            registro = new List<T>();
        }

        public void Create(T t)
        {
            if (t == null)
            {
                throw new ArgumentNullException(nameof(t));
            }
            registro.Add(t);
        }

       
        public ICollection<T> GetAll()
        {
            return registro;
        }
    }
}
