using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCtaBancaria
{
    public class cCtaAhorros : cCtaBancaria
    {
        // Atributos específicos de la cuenta de ahorros
        protected string aTipoAhorro;
        protected double aTasaInteres;

        // Constructor de la clase
        public cCtaAhorros(string nroCuenta, string razonSocial, string direccion, string tipoAhorro, double tasaInteres)
            : base(nroCuenta, razonSocial, direccion)
        {
            this.aTipoAhorro = tipoAhorro;
            this.aTasaInteres = tasaInteres;
        }

        // Propiedad para el tipo de ahorro
        public string TipoAhorro
        {
            get { return aTipoAhorro; }
        }

        // Método para leer datos de la cuenta de ahorros
        public override void Leer()
        {
            // Leer datos generales de la cuenta bancaria
            base.Leer();

            // Leer datos específicos de la cuenta de ahorros
            Console.Write("Ingrese el tipo de ahorro: ");
            aTipoAhorro = Console.ReadLine();
            Console.Write("Ingrese la tasa de interés: ");
            if (double.TryParse(Console.ReadLine(), out double tasaInteres))
            {
                aTasaInteres = tasaInteres;
            }
            else
            {
                Console.WriteLine("Tasa de interés no válida. Se establecerá en 0.");
                aTasaInteres = 0;
            }
        }

        // Método para mostrar los datos de la cuenta de ahorros
        public override void Mostrar()
        {
            // Mostrar datos generales de la cuenta bancaria
            base.Mostrar();

            // Mostrar datos específicos de la cuenta de ahorros
            Console.WriteLine("Tipo Ahorro: {0}", aTipoAhorro);
            Console.WriteLine("Tasa Interes: {0}%", aTasaInteres);
        }

    }
}