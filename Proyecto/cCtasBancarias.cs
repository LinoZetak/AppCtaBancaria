using AppCtaBancaria;
using System;


class cCtasBancarias
{
    private cCtaAhorros[] aCtasAhorros;
    private int NroCtas;

    public cCtasBancarias()
    {
        aCtasAhorros = new cCtaAhorros[100]; // Asumiendo un máximo de 100 cuentas
        NroCtas = 0;
    }

    private void Menu()
    {
        Console.WriteLine("Menú de opciones:");
        Console.WriteLine("1. Agregar cuenta de ahorro");
        Console.WriteLine("2. Buscar cuenta de ahorro");
        Console.WriteLine("3. Listar todas las cuentas de ahorro");
        Console.WriteLine("4. Listar cuentas de ahorro por tipo de ahorro");
        Console.WriteLine("5. Salir");
        Console.Write("Seleccione una opción: ");
    }

    private cCtaAhorros RecuperarCtaAhorros(string Cta)
    {
        foreach (var cuenta in aCtasAhorros)
        {
            if (cuenta != null && cuenta.NroCuenta == Cta)
            {
                return cuenta;
            }
        }
        return null;
    }

    private void AgregarCtaAhorros()
    {
        if (NroCtas < aCtasAhorros.Length)
        {
            Console.WriteLine("Ingrese los datos de la nueva cuenta de ahorro:");
            var nuevaCuenta = new cCtaAhorros("", "", "", "", 0);
            nuevaCuenta.Leer();
            aCtasAhorros[NroCtas++] = nuevaCuenta;
            Console.WriteLine("Cuenta de ahorro agregada exitosamente.");
        }
        else
        {
            Console.WriteLine("No se pueden agregar más cuentas. Capacidad máxima alcanzada.");
        }
    }

    private void BuscarCtaAhorros()
    {
        Console.Write("Ingrese el número de cuenta a buscar: ");
        string nroCuenta = Console.ReadLine();
        var cuenta = RecuperarCtaAhorros(nroCuenta);
        if (cuenta != null)
        {
            cuenta.Mostrar();
        }
        else
        {
            Console.WriteLine("Cuenta no encontrada.");
        }
    }

    private void ListarCtas()
    {
        Console.WriteLine("Listado de todas las cuentas de ahorro:");
        foreach (var cuenta in aCtasAhorros)
        {
            if (cuenta != null)
            {
                cuenta.Mostrar();
                Console.WriteLine();
            }
        }
    }

    private void ListarPorTipoAhorro()
    {
        Console.Write("Ingrese el tipo de ahorro a listar: ");
        string tipoAhorro = Console.ReadLine();
        Console.WriteLine($"Listado de cuentas de ahorro del tipo {tipoAhorro}:");
        foreach (var cuenta in aCtasAhorros)
        {
            if (cuenta != null && cuenta.TipoAhorro == tipoAhorro)
            {
                cuenta.Mostrar();
                Console.WriteLine();
            }
        }
    }

    public void Ejecutar()
    {
        int opcion;
        do
        {
            Menu();
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        AgregarCtaAhorros();
                        break;
                    case 2:
                        BuscarCtaAhorros();
                        break;
                    case 3:
                        ListarCtas();
                        break;
                    case 4:
                        ListarPorTipoAhorro();
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida, intente de nuevo.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida, intente de nuevo.");
            }
        } while (opcion != 5);
    }

    
}