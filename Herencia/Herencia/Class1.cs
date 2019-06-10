using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class clsClientes
    {
        private int _IdcCliente;
        public int IdcCliente { get => _IdcCliente; set => _IdcCliente = value; }

        private string _Nombres;

        public string Nombres { get => _Nombres; set => _Nombres = value; }

        private string _Apellidos;

        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
    }
}
