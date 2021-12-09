using AppCore.Interfaces;
using Domain.Entities;
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
    public partial class FrmPrincipal : Form
    {
        public Iproductoservicio productoservicio;
        public List<Productos> productos = new List<Productos>();
        public FrmPrincipal(Iproductoservicio ProductoService)
        {
            this.productoservicio = ProductoService;
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgrega frmAgregar = new FrmAgrega();
            frmAgregar.notasService = productoservicio;
            frmAgregar.productos = productos;
            frmAgregar.ShowDialog();

            dgvEstudiantes.DataSource = null;
            dgvEstudiantes.DataSource = productos;
        }

    

       

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
