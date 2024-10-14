using Sesion17G3.Modelos;
using Sesion17G3.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion17G3.Formularios
{
    public partial class ProductoFrm : Form
    {
        ProductoServicio productos ;

        public ProductoFrm()
        {
            InitializeComponent();
            productos = new ProductoServicio();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            prod.ID = int.Parse(TbID.Text);
            prod.Nombre = TbNombre.Text;
            prod.Descripcion = TbDescripcion.Text;
            prod.Precio = double.Parse(TbPrecio.Text);
            productos.AgregarProducto(prod);
            MostrarRegistros();
        }

        private void MostrarRegistros()
        {
            DgvRegistros.DataSource = null;
            DgvRegistros.DataSource = productos.Productos();
        }
    }
}
