using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infraestructure.Repository
{
    public class productorepository:baserepositorio<Productos>,iproductosrepositor
    {
        public int GetLastId()
        {
            return registro.Count == 0 ? 0 : registro.Last().Id;
        }

        public List<Productos> GetProductoById(int id)
        {
            List<Productos> notas = registro.Where(x => x.Id == id).ToList();
            return notas;
        }

       
    }
}
