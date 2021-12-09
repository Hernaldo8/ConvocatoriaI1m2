using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Productos
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripción { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Existencia { get; set; }
        public DateTime Vencimiento { get; set; }

        public Categoria Categoria { get; set; }
    }
}
