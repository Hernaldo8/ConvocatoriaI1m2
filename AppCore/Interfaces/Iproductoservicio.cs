using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Interfaces
{
    public interface Iproductoservicio : Iservicios<Productos>
    {
        int GetLastId();
       
        List<Productos> GetProductoById(int id);
        
    }
}
