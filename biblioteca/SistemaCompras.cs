using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public static class SistemaCompras
    {
        private static Queue<CompraUsuario> compras = new Queue<CompraUsuario> ();


        static SistemaCompras()
        {
            ComprasUsuario();
        }
        /// <summary>
        /// hardcodeo de compras
        /// </summary>
        public static void ComprasUsuario() 
        {
            User user = Sistema.getUsuario("joaco", "joaco");
            Componente comp = SistemaComp.GetComponente(TipoDeComponente.PlacaDeVideo, "rx 6600x", "Radeon");
            compras.Enqueue(new(comp, 1, DateTime.Now, user));
            compras.Enqueue(new(comp, 2, DateTime.Now, user));
            compras.Enqueue(new(comp, 3, DateTime.Now, user));
            compras.Enqueue(new(SistemaComp.GetComponente(TipoDeComponente.PlacaDeVideo, "rx 6600x", "Radeon"), 2, DateTime.Now, new User("perroMalvado", "123", false)));
        }
        /// <summary>
        /// agrega una compra a la queue
        /// </summary>
        /// <param name="compraUsuario"></param>
        public static void AgregarCompraUsuario(CompraUsuario compraUsuario)
        {
            compras.Enqueue(compraUsuario);
        } 
        /// <summary>
        /// Se fija el historial de compras de un usuario x
        /// </summary>
        /// <param name="user"></param>
        /// <returns>una queue con el historial de compras</returns>
        public static Queue<CompraUsuario> VerHistorialComprasUser(User user)
        {
            Queue<CompraUsuario> historialComprasUsuario = new Queue<CompraUsuario>();

            foreach (CompraUsuario compraUser in compras)
            {
                if (compraUser.Usuario == user)
                {
                    historialComprasUsuario.Enqueue(compraUser);
                }
            }
            return historialComprasUsuario;
        }
        /// <summary>
        /// devuelve la queue entera de compras
        /// </summary>
        /// <returns></returns>
        public static Queue<CompraUsuario> VerHistorial() 
        {
            return compras;
        }

        /// <summary>
        /// Se calcula todas las ventas
        /// </summary>
        /// <returns>retorna todo el dinero ganado</returns>
        public static float RetornarGananciasBrutas()
        {
            float acumulador = 0;

            foreach (CompraUsuario item in compras) 
            {
                acumulador += item.Componente.Precio * item.Cantidad;
            }
            return acumulador;
        }



    }
}
