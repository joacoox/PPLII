using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public abstract class Producto
    {
        string nombre;
        string marca;
        Color color;
        int stock;
        float precio;
        string descripcionProducto;
        public Producto(string nombre, string marca, Color color ,float precio, string descripcionProducto, int stock)
        {
            Nombre = nombre;
            Marca = marca;
            Color = color;
            Stock = stock;
            Precio = precio;
            DescripcionProducto = descripcionProducto;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Marca { get => marca; set => marca = value; }
        public Color Color { get => color; set => color = value; }
        public int Stock { get => stock; set => stock = value; }
        public float Precio { get => precio; set => precio = value; }
        public string DescripcionProducto { get => descripcionProducto; set => descripcionProducto = value; }
    }

}

