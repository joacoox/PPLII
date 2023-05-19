using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class CompraUsuario : Compra
    {
        private User usuario;
        private Componente componente;
        public CompraUsuario(Componente componente, int cantidad,DateTime tiempo ,User usuario) : base(cantidad,tiempo) 
        {
            Usuario = usuario;
            this.Componente = componente;
        }

        public User Usuario { get => usuario; set => usuario = value; }
        public Componente Componente { get => componente; set => componente = value; }
    }
}
