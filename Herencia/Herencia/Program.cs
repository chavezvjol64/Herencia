using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objetos de la clase
            clsClientesVentas Cliente;
            //Creando instancia
            Cliente = new clsClientesVentas();

            Cliente.IdcCliente = 123;
            Cliente.Apellidos = "Pon Atencion";
            Cliente.Nombres = "jose Luis";
            Cliente.RFC = "DSNMFSDF";
            Cliente.Direccion = "Inserte aqui la direccion de CESCA";
            Cliente.Municipio = "Tijuana es un municipio? :/";
            Cliente.EsCredito = false;

            Console.WriteLine(Cliente.IdcCliente + " " + Cliente.Apellidos + " " + Cliente.Nombres);
            Console.WriteLine(Cliente.Direccion + " " + Cliente.Municipio);

            if (Cliente.EsCredito)
                Console.WriteLine("El cliente tiene credito");
            else
                Console.WriteLine("El cliente no tiene credito");
            Console.ReadKey();

        }
    }
}
