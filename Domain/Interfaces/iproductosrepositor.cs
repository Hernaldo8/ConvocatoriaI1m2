using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface iproductosrepositor:Irepositorio<Productos>
    {
        int GetLastId();
      
        List<Productos> GetProductoById(int id);
    
    }
}
