using System;
namespace practico2
{
    public class Cliente
    {
        private string nombre;
        private int tipo;
        private string direccion;
        string[] compras;
        
        public Cliente(string nombre, int tipo, string direccion)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.direccion = direccion;
        }

        public string getInfo()
        {
            return $"{nombre}"; //{tipo} {direccion}";
        }
        public string getTipo()
        {
            return $" {tipo} ";
        }

        public string getInfo2()
        {
            return $"{direccion}"; //{tipo} {direccion}";
        }

        public void setCompras(string ordenDeCompras)
        {
            compras[0]= ordenDeCompras;
        }

        public string getCompras()
        {
            return compras[0];
        }

    }
}

