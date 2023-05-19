using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class Compra
    {
        int id;
        public int cantidad;
        DateTime fecha;
      
        public Compra(int cantidad, DateTime fecha)
        {
            Id = RegistrarCompra();
            Cantidad = cantidad;
            Fecha = fecha;
        }
        private static int siguienteIdCompra = 1;
        /// <summary>
        /// Registra el id de cada compra realizada
        /// </summary>
        /// <returns> el id de la compra </returns>
        public int RegistrarCompra()
        {
            int i = siguienteIdCompra;

            siguienteIdCompra++;

            return i;   
        }

        public int Cantidad { get => cantidad; set => cantidad = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Id { get => id; set => id = value; }
    }
}
