using AppCore.Interfaces;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoExamen.Formularios
{
    public partial class FrmAgrega : Form
    {
        public Iproductoservicio notasService { get; set; }
        
        public List<Productos> productos = new List<Productos>();
        public FrmAgrega()
        {
            InitializeComponent();
        }

       

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
            
                Productos producto = new Productos()
                {
                    Id = notasService.GetLastId() + 1,
                    Nombre = txtNombre.Text,
                    Descripción = txtDescripcion.Text,
                    Cantidad = nudCantidad.Value,
                    Precio = nudPrecio.Value,
                    Existencia = nudExistencia.Value,
                    Vencimiento= dtpVencimiento.Value,
                    Categoria=(Categoria)cmbCategoria.SelectedIndex,
                };
                productos.Add(producto);

            

        }

        private void FrmEstudiante_Load(object sender, EventArgs e)
        {

        }
    }
}
