using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public static class SistemaComp
    {
        public static List<Componente> listaComponentes = new List<Componente>();

        public static List<String> historialCompras = new List<String>();

        static SistemaComp()
        {
            Componentes();
        }
        /// <summary>
        /// hardcodeo de componentes
        /// </summary>
        private static void Componentes()
        {   // placa de video
            listaComponentes.Add(new Componente(TipoDeComponente.PlacaDeVideo, "rx 6600x", "Radeon", false, 120000, "8 gb Gddr6", 15, Color.Negro));
            listaComponentes.Add(new Componente(TipoDeComponente.PlacaDeVideo, "Gtx 1050ti", "Nvidia", false, 45000, "4 gb Gddr5", 12, Color.Negro));
            listaComponentes.Add(new Componente(TipoDeComponente.PlacaDeVideo, "Rtx 3080ti", "Nvidia", false, 350000, "12 gb Gddr6", 6, Color.Negro));
            listaComponentes.Add(new Componente(TipoDeComponente.PlacaDeVideo, "gtx 1030ti", "Nvidia", false, 13000, "2 gb Gddr4", 5, Color.Blanco));
            // placa madre
            listaComponentes.Add(new Componente(TipoDeComponente.PlacaMadre, "PRO A320M-R", "Asus", false, 120000, "AM4,DDR4,M-ATX", 6, Color.Negro));
            listaComponentes.Add(new Componente(TipoDeComponente.PlacaMadre, "B450 Steel Legend", "Asrock", true, 120000, "AM4,DDR4,ATX", 6, Color.Azul));
            listaComponentes.Add(new Componente(TipoDeComponente.PlacaMadre, "H610M-HVS", "Asrock", false, 75000, "AM4,DDR4,M-ATX", 3, Color.Blanco));
            listaComponentes.Add(new Componente(TipoDeComponente.PlacaMadre, "PRIME B560-PLUS", "Asus", true, 80000, "AM4,DDR4,M-ATX", 12, Color.Negro));
            // procesadores
            listaComponentes.Add(new Componente(TipoDeComponente.Procesador, "ryzen 5 3600x", "Amd", false, 50000, "AM4,6 nucleos", 12, Color.Gris));
            listaComponentes.Add(new Componente(TipoDeComponente.Procesador, "ryzen 7 3700x", "Amd", true, 75821, "AM4,8 nucleos", 7, Color.Gris));
            listaComponentes.Add(new Componente(TipoDeComponente.Procesador, "i5 104000f", "Intel", false, 92000, "AM4,4 nucleos", 3, Color.Gris));
            listaComponentes.Add(new Componente(TipoDeComponente.Procesador, "i9 9900k", "Amd", true, 230000, "AM4,8 nucleos", 15, Color.Gris));
            // Memoria Ram
            listaComponentes.Add(new Componente(TipoDeComponente.MemoriaRam, "Fury", "Kingston", true, 12500, "8gb,2666mhz", 32, Color.Negro));
            listaComponentes.Add(new Componente(TipoDeComponente.MemoriaRam, "Sativa", "Hyperx", false, 8000, "8gb,2666mhz", 32, Color.Blanco));
            listaComponentes.Add(new Componente(TipoDeComponente.MemoriaRam, "Pro", "Asus", true, 7600, "4gb,3666mhz", 32, Color.Negro));
            listaComponentes.Add(new Componente(TipoDeComponente.MemoriaRam, "Rage", "Corsair", true, 12500, "8gb,2666mhz", 32, Color.Blanco));
            // Discos duro
            listaComponentes.Add(new Componente(TipoDeComponente.Disco, "Barracuda", "Seagate", false, 3500, "673mb/s,Rigido,1TB", 15, Color.Gris));
            listaComponentes.Add(new Componente(TipoDeComponente.Disco, "SU360", "Adata", false, 4000, "2500/s,Rigido,240gb", 18, Color.Gris));
            listaComponentes.Add(new Componente(TipoDeComponente.Disco, "DT01", "Toshiba", false, 4250, "500/s,Rigido,1TB", 52, Color.Gris));
            // Fuentes de alimentacion
            listaComponentes.Add(new Componente(TipoDeComponente.FuenteDeAlimentacion, "titan x", "asus", true, 48200, "1000wats,PlatinoPlus", 32, Color.Gris));
            listaComponentes.Add(new Componente(TipoDeComponente.FuenteDeAlimentacion, "Titan extremus", "asus", true, 65990, "1500wats,PlatinoPlus", 32, Color.Gris));
            listaComponentes.Add(new Componente(TipoDeComponente.FuenteDeAlimentacion, "Pro", "NogaNet", false, 6500, "800wats,Sin certificar", 32, Color.Blanco));
            // Gabinetes
            listaComponentes.Add(new Componente(TipoDeComponente.Gabinete, "Centinel X", "Asus", true, 12500, "ATX", 32, Color.Negro));
            listaComponentes.Add(new Componente(TipoDeComponente.Gabinete, "Pro model", "HyperX", true, 22500, "M-ATX", 32, Color.Negro));
            listaComponentes.Add(new Componente(TipoDeComponente.Gabinete, "Basic Tower", "HyperX", false, 9500, "ATX", 32, Color.Azul));
            listaComponentes.Add(new Componente(TipoDeComponente.Gabinete, "Engine", "HyperX", true, 19500, "M-ATX", 32, Color.Gris));
        }
        /// <summary>
        /// retorna la lista
        /// </summary>
        /// <returns></returns>
        public static List<Componente> GetLista()
        {
            return listaComponentes;
        }
        /// <summary>
        /// Agrega un componente a la lista 
        /// </summary>
        /// <param name="componente"></param>
        /// <returns>true si pudo, false si no</returns>
        public static bool AgregarComponente(Componente componente)
        {
            bool result = false;
            if (!EstaEnLaLista(componente))
            {
                listaComponentes.Add(componente);
                result = true;
            }
            return result;
        }
        /// <summary>
        /// se fija si el componente esta en la lista
        /// </summary>
        /// <param name="componente"></param>
        /// <returns>true si pudo false si no</returns>
        public static bool EstaEnLaLista(Componente componente)
        {
            bool result = false;

            foreach (Componente obj in listaComponentes)
            {
                if (obj == componente)
                {
                    result = true;
                }
            }
            return result;
        }
        /// <summary>
        /// busca un componente en la lista
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="nombre"></param>
        /// <param name="marca"></param>
        /// <returns>si encuentra el objeto lo retorna, de lo contrario devuelve null</returns>
        public static Componente GetComponente(TipoDeComponente tipo, string nombre, string marca)
        {
            Componente obj = null;

            foreach (Componente item in listaComponentes)
            {
                if (item.TipoProducto == tipo && item.Nombre == nombre && item.Marca == marca)
                {
                    obj = item;
                    break;
                }
            }
            return obj;
        }

        /// <summary>
        /// recibe un componente si lo encuentra lo saca de la lista
        /// </summary>
        /// <param name="item"></param>
        /// <returns>true si pudo false si no</returns>
        public static bool EliminarComponente(Componente item)
        {
            bool result = false;

            foreach (Componente objeto in listaComponentes)
            {
                if (objeto == item)
                {
                    result = listaComponentes.Remove(objeto);
                    break;
                }
            }
            return result;
        }
        /// <summary>
        /// recibe un componente y el stock a modificar
        /// </summary>
        /// <param name="componente"></param>
        /// <param name="stockAEliminar"></param>
        /// <returns> true si se pudo modificar false si no</returns>
        public static bool EditarStock(Componente componente, int stockAEliminar)
        {
            bool result = false;

            foreach (Componente obj in listaComponentes)
            {
                if (obj == componente)
                {
                    obj.Stock -= stockAEliminar;
                    result = true;
                }
            }
            return result;
        }
        /// <summary>
        /// devuelve una lista con los componentes que tengan bajo stocks
        /// </summary>
        /// <returns></returns>
        public static List<Componente> ComponentesEnBajoStock() 
        {
            List<Componente> lista = new List<Componente>();

            foreach (Componente item in listaComponentes)
            {
                if (item.Stock <= 5) 
                {
                    lista.Add(item);
                }
            }
        return lista;
        }

    }
}
