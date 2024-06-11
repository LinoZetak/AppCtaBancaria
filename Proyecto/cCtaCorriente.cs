using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCtaBancaria
{
    public class cCtaCorriente : cCtaBancaria
    {
        private int aCostoMantenimiento;

        // Constructor de la clase
        public cCtaCorriente(string nroCuenta, string razonSocial, string direccion, int costoMantenimiento)
            : base(nroCuenta, razonSocial, direccion)
        {
            this.aCostoMantenimiento = costoMantenimiento;
        }

        // Método para leer datos de la cuenta corriente
        public override void Leer()
        {
            // Leer datos generales de la cuenta bancaria
            base.Leer();

            // Leer datos específicos de la cuenta corriente
            Console.Write("Ingrese el costo de mantenimiento: ");
            if (int.TryParse(Console.ReadLine(), out int costoMantenimiento))
            {
                aCostoMantenimiento = costoMantenimiento;
            }
            else
            {
                Console.WriteLine("Costo de mantenimiento no válido. Se establecerá en 0.");
                aCostoMantenimiento = 0;
            }
        }

        // Método para mostrar los datos de la cuenta corriente
        public override void Mostrar()
        {
            // Mostrar datos generales de la cuenta bancaria
            base.Mostrar();

            // Mostrar datos específicos de la cuenta corriente
            Console.WriteLine("Costo de Mantenimiento: {0:C}", aCostoMantenimiento);
        }
    }
}
