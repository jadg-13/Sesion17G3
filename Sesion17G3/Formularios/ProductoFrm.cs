using Sesion17G3.Archivos;
using Sesion17G3.Modelos;
using Sesion17G3.Servicios;

namespace Sesion17G3.Formularios
{
    public partial class ProductoFrm : Form
    {
        ProductoServicio productos;

        Producto productoSel = new Producto();

        public ProductoFrm()
        {
            InitializeComponent();
            productos = new ProductoServicio();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto prod = new Producto();
                prod.ID = int.Parse(TbID.Text);
                prod.Nombre = TbNombre.Text;
                prod.Descripcion = TbDescripcion.Text;
                prod.Precio = double.Parse(TbPrecio.Text);
                productos.AgregarProducto(prod);
                MostrarRegistros();
                Limpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void MostrarRegistros()
        {
            DgvRegistros.DataSource = null;
            DgvRegistros.DataSource = productos.Productos();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto prod = new Producto();
                prod.ID = int.Parse(TbID.Text);
                prod.Nombre = TbNombre.Text;
                prod.Descripcion = TbDescripcion.Text;
                prod.Precio = double.Parse(TbPrecio.Text);
                productos.ActualizarProducto(prod, productoSel.ID);
                MostrarRegistros();
                Limpiar();
                DesactivarBotones();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void DgvRegistros_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow index = DgvRegistros.CurrentRow;
            if (index != null)
            {
                AsignarProducto(index);
                TbID.Text = productoSel.ID.ToString();
                TbNombre.Text = productoSel.Nombre;
                TbDescripcion.Text = productoSel.Descripcion;
                TbPrecio.Text = productoSel.Precio.ToString();
                ActivarBotones();
            }
        }

        private void AsignarProducto(DataGridViewRow row)
        {
            productoSel.ID = int.Parse(row.Cells[0].Value.ToString());
            productoSel.Nombre = row.Cells[1].Value.ToString();
            productoSel.Descripcion = row.Cells[2].Value.ToString();
            productoSel.Precio = double.Parse(row.Cells[3].Value.ToString());
        }

        private void Limpiar()
        {
            TbID.Clear();
            TbNombre.Clear();
            TbDescripcion.Clear();
            TbPrecio.Clear();
            TbID.Focus();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Estás seguro que deseas eliminar este elemento?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {

                    productos.EliminarProducto(productoSel);
                    MostrarRegistros();
                    Limpiar();
                    DesactivarBotones();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActivarBotones()
        {
            BtnEditar.Enabled = true;
            BtnEliminar.Enabled = true;
            BtnGuardar.Enabled = false;
        }

        private void DesactivarBotones()
        {
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnGuardar.Enabled = true;
        }

        private void BtnGuardarArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Filter = ("Archivo DAT (*.dat)|*.dat");
                saveFileDialog1.Title = "Guardar archivo";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ProductoArchivo archivo = new ProductoArchivo();

                    archivo.Guardar(productos.Productos(), saveFileDialog1.FileName);
                    MessageBox.Show("Se ha guardado el archivo", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAbrirArchivo_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C\\";
            openFileDialog1.Filter = "Archivos DAT (*.dat)|*.dat|Todos los archivos (*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ruta = openFileDialog1.FileName;

                ProductoArchivo archivo = new ProductoArchivo();
                productos.AgregarProductos(archivo.CargarProductos(ruta));
                MostrarRegistros();
            }
            else
            {
                MessageBox.Show("No se selecciono ningún archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
