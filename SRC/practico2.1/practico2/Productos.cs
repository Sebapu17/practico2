using System;
namespace practico2
{
    public class Productos
    {
        private string nombre;
        private int precio;

        public Productos(string nombre,int precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public string getInfo()
        {
            return $"{nombre}";
        }
        public int getPrecio()
        {
            return precio;
        }

    }
}

