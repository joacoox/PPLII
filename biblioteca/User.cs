using System.Data.Common;
using System.Diagnostics.CodeAnalysis;

namespace biblioteca
{
    public class User
    {
        public string nombre;
        string contraseña;
        public bool admin;
        private DatosParaPagar datos;

        public User(string nombre, string contraseña, bool admin)
        {
            this.nombre = nombre;
            this.contraseña = contraseña;
            this.admin = admin;
        }
        public User(DatosParaPagar data, string nombre, string contra, bool admin) : this(nombre, contra,admin)
        {
           this.datos = data;
        }
        public DatosParaPagar Datos { get => datos; set => datos = value; }
        public string GetContra()
        {
            return this.contraseña;
        }
      /// <summary>
      ///  compara dos usuarios
      /// </summary>
      /// <param name="a"></param>
      /// <param name="b"></param>
      /// <returns>si son iguales retorna true, de lo contrario false</returns>
        public static bool operator == (User a, User b)
        {           
            return a.nombre == b.nombre && a.contraseña == b.contraseña;
        }
        /// <summary>
        ///  compara dos usuarios
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>si son iguales retorna false, de lo contrario true</returns>
        public static bool operator != (User a, User b)
        {
            return !(a == b);
        }
    }
}