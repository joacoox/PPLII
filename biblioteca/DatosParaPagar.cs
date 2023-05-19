using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class DatosParaPagar
    {
        string numeroTarjeta;
        int codigoSeguridad;
        string fechaVencimiento;
        Banco banco;
        int saldo;

        public DatosParaPagar(string numeroTarjeta, int codigoSeguridad, string fechaVencimiento, Banco banco, int saldo)
        {
            this.NumeroTarjeta = numeroTarjeta;
            this.CodigoSeguridad = codigoSeguridad;
            this.FechaVencimiento = fechaVencimiento;
            this.Banco = banco;
            this.Saldo = saldo;
        }

        
        public int CodigoSeguridad { get => codigoSeguridad; set => codigoSeguridad = value; }
        public string FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
        public Banco Banco { get => banco; set => banco = value; }
        public int Saldo { get => saldo; set => saldo = value; }
        public string NumeroTarjeta { get => numeroTarjeta; set => numeroTarjeta = value; }

        public bool Depositar(int dinero) 
        {
            bool retorno = false;
            if (dinero > 0 && dinero <= 500000)
            {
                Saldo += dinero;
                retorno = true;
            }
            return retorno;
        }

        public bool Pagar(int dinero) 
        {
            bool result = false;
            if (Saldo >= dinero) 
            { 
            Saldo -= dinero;
                result = true;
            }
            return result;
        }
    }
}
