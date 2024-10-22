using Sesion17G3.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion17G3.Archivos
{
    public class ProductoArchivo
    {
        public void Guardar(List<Producto> productos, string rutaArchivo)
        {
            using(FileStream archivo = new FileStream(rutaArchivo, FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter escritor = new BinaryWriter(archivo)) { 
                    foreach (Producto producto in productos)
                    {
                        escritor.Write(producto.ID);
                        escritor.Write(producto.Nombre);
                        escritor.Write(producto.Descripcion);
                        escritor.Write(producto.Precio);
                    }
                }
            }
        }

        public List<Producto> CargarProductos(string rutaArchivo) { 
            List<Producto> productos = new List<Producto>();

            if(!File.Exists(rutaArchivo)) return productos;

            using(FileStream archivo = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader lector = new BinaryReader(archivo))
                {
                    while(archivo.Position != archivo.Length)
                    {
                        Producto prod = new Producto();
                        prod.ID = lector.ReadInt32();
                        prod.Nombre = lector.ReadString();
                        prod.Descripcion = lector.ReadString();
                        prod.Precio = lector.ReadDouble();

                        productos.Add(prod);
                    }
                }
            }

            return productos;
        }
    }
}
