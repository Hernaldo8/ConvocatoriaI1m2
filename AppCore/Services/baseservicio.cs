using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces;
using Domain.Interfaces;

namespace AppCore.Services
{
    public class baseservicio<T> : Iservicios<T>
    {
        public Irepositorio<T> repository;
        public baseservicio(Irepositorio<T> repository)
        {
            this.repository = repository;
        }
        public void Create(T t)
        {
            repository.Create(t);
        }

        public ICollection<T> GetAll()
        {
            return repository.GetAll();
        }
    }
}
