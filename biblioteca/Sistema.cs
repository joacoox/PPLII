using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace biblioteca
{
    public static class Sistema
    {
        public static List<User> listaUsuarios = new List<User>();

        static Sistema()
        {
            Usuarios();
        }
        /// <summary>
        /// Hardcodeo usuarios a la lista
        /// </summary>
        private static void Usuarios()
        {
            listaUsuarios.Add(new User("a", "a", true));
            listaUsuarios.Add(new User("admin", "admin", true));
            listaUsuarios.Add(new User("joaco", "joaco", false));
            listaUsuarios.Add(new User("perroMalvado", "123", false));
        }
    /// <summary>
    /// Verifica si un usuario esta en la lista
    /// </summary>
    /// <param name="nombreUsuario"></param>
    /// <param name="contra"></param>
    /// <returns>true si esta en la lista, false si no</returns>
        public static bool EstaRegistado(string nombreUsuario, string contra)
        {
            bool result = false;

            foreach (User usuario in listaUsuarios)
            {
                if (usuario.nombre == nombreUsuario && usuario.GetContra() == contra)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
        /// <summary>
        /// Intenta agregar un usuario a la lista si es que ya no esta incluido
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="contra"></param>
        /// <param name="esAdmin"></param>
        /// <returns>true si pudo false si no</returns>
        public static bool Registrar(string nombreUsuario, string contra, bool esAdmin)
        {
            bool result = false;
            if (!EstaRegistado(nombreUsuario, contra))
            {
                listaUsuarios.Add(new User(nombreUsuario, contra, esAdmin));
                result = true;
            }
            return result;
        }
        /// <summary>
        ///  Intenta agregar un usuario a la lista si es que ya no esta incluido
        /// </summary>
        /// <param name="user"></param>
        /// <returns>true si pudo false si no</returns>
        public static bool Registrar(User user) 
        {
            bool result = false;
            if (!EstaRegistado(user))
            {
                listaUsuarios.Add(user);              
                result = true;
            }
            return result;
        }
        /// <summary>
        /// Verifica si un usuario esta en la lista
        /// </summary>
        /// <param name="user"></param>
        /// <returns>true si esta en la lista, false si no</returns>
        public static bool EstaRegistado(User user) 
        {
            bool result = false;

            foreach (User usuario in listaUsuarios)
            {
                if (usuario == user)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        /// <summary>
        /// Busca un usuario en la lista con x nombre e y contra
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="contra"></param>
        /// <returns>un usuario que cumla con los parametros</returns>
        public static User getUsuario(string nombreUsuario, string contra) 
        {
            User user = null;

            foreach (User usuario in listaUsuarios)
            {
                if (usuario.nombre == nombreUsuario && usuario.GetContra() == contra)
                {
                    user = usuario;
                    user.Datos = usuario.Datos;
                    break;
                }
            }
         
            return user;
        }
        /// <summary>
        /// retorna la lista
        /// </summary>
        /// <returns>retorna la lista</returns>
        public static List<User> GetLista() 
        {
            return listaUsuarios;
        }
        /// <summary>
        /// recibe un usuario y si es igual lo elimina
        /// </summary>
        /// <param name="user"></param>
        /// <returns>true si pudo false si no</returns>
        public static bool EliminarUser(User user) 
        {
            bool result = false;

            foreach (User usuario in listaUsuarios) 
            {
                if(usuario == user)
                {
                    result = listaUsuarios.Remove(usuario);
                    break;
                }
            }
            return result;
        }
        /// <summary>
        /// recibe una cadena y verifica si es apta para el nombre la contra del user
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns>true si es valida, false de lo contrario</returns>
        public static bool IsValidNameOrPassword(string cadena)
        {
            bool result = false;
            if (!string.IsNullOrEmpty(cadena))
            {
                if (cadena.Length >= 5)
                {
                    result = true;
                }
                
            }  
            return result;
        }
        /// <summary>
        /// si el numero de la tarjeta de credito es valido
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>true si es valida, false de lo contrario</returns>
        public static bool IsValidCreditCardNumber(float numero) 
        {
            bool result = false;
            if (numero > 1000000000000000) 
            {
                result = true;
            }
            return result;
        }
        /// <summary>
        /// si el numero de seguridad es valido
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>true si es valida, false de lo contrario</returns>
        public static bool IsValidSecurityNumber(int numero)
        {
            bool result = false;
            if (numero >= 100 && numero <= 999)
            {
                result = true;
            }
            return result;
        }
        /// <summary>
        /// devuelve la cantidad de usuarios o admins, dependiendo de lo q reciba
        /// </summary>
        /// <param name="admin"></param>
        /// <returns> un entero con la cantidad de users o admins  </returns>
        public static int DevolverCantidadPorParametros(bool admin) 
        {
            int contador = 0;
            foreach (User usuario in listaUsuarios)
            {
                if (usuario.admin == admin) 
                {
                    contador++;
                }
            }

            return contador;
        }
    }
}
