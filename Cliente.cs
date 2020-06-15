using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Sistema_Para_Taller
{
    class Cliente
    {
        //RFC, Nombre, Domicilio, Teléfono y Correo 

        private string _rfc;
        private string _nombre;
        private string _domicilio;
        private string _telefono;
        private string _correo;

        public Cliente(string rfc, string nombre)
        {
            _rfc = rfc;
            _nombre = nombre;
        }

        public string Rfc { get { return _rfc; } }
        public string Nombre { get { return _nombre; } }
        public string Domicilio { set { _domicilio = value; }
            get { return _domicilio; }
        }

        public string Telefono { set { _telefono = value; }
            get { return _telefono; }
        }

        public string Correo { set { _correo = value; }
            get { return _correo; } 
        }


        public override string ToString()
        {
            return "Rfc " + _rfc + "Nombre " + _nombre;
        }
    } 
}

