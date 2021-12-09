using AppCore.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Services
{
    public class productoservicio : baseservicio<Productos>, Iproductoservicio
    {
        private iproductosrepositor repository1;
        public productoservicio(iproductosrepositor repository) : base(repository)
        {
            this.repository1 = repository;
        }

        public int GetLastId()
        {
            return repository1.GetLastId();
        }

        public List<Productos> GetProductoById(int id)
        {
            return repository1.GetProductoById(id);
        }

    }
}
