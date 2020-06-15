using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Para_Taller
{
    class Auto
    {
        //Placa, marca, modelo y color

        private string _placa;
        private string _marca;
        private string _modelo;
        private string _color;


        public Auto(string placa, string marca, string modelo )
        {
            _placa = placa;
            _marca = marca;
            _modelo = modelo;
        }

        public string Placa { get { return _placa; } }

        public string Marca { get { return _marca; } }

        public string Modelo { get { return _modelo; } }

        public string Color
        {
            set { _color = value; }
            get { return _color; }
        }

        
        public override string ToString()
        {
            return "Color" + _color; 
        }






    }
}
