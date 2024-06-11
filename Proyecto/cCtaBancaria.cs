using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCtaBancaria
{
    public class cCtaBancaria
    {
       

        protected string aNroCta;
        protected string aRazonSocial;
        protected string aDireccion;

        

        public cCtaBancaria(string nroCuenta, string razonSocial, string direccion)
        {
            this.aNroCta = nroCuenta; 
            this.aRazonSocial = razonSocial;
            this.aDireccion = direccion;
        }

        public string NroCuenta
        {
            get { return aNroCta; }
        }

        public string RazonSocial
        {
            get { return aRazonSocial; }
        }

        public string Direccion
        {
            get { return aDireccion; }
        }



        public virtual void Leer()
        {
            Console.Write("Ingrese el número de cuenta: ");
            aNroCta = Console.ReadLine();
            Console.Write("Ingrese la razón social: ");
            aRazonSocial = Console.ReadLine();
            Console.Write("Ingrese la dirección: ");
            aDireccion = Console.ReadLine();
        }


        public virtual void Mostrar()
        {
            Console.WriteLine("Nro Cuenta: {0}", aNroCta);
            Console.WriteLine("Razon Social: {0}", aRazonSocial);
            Console.WriteLine("Direccion: {0}", aDireccion);
        }

        
    }


}
