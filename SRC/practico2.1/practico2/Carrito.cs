using System;
namespace practico2
{
    public class Carrito
    {
        string producto;
        int cantidad;
        int precioU;
        int precioT;
        string nombre;
        string direccion;
        int totalCompra;

        public Carrito(string producto, int cantidad, int precioU)
        {
            this.producto = producto;
            this.cantidad = cantidad;
            this.precioU = precioU;
        }


        public int getPrecio()
        {
            return precioT;
        }

        public string getProducto()
        {
            precioT = precioU * cantidad;
            return $"{cantidad} {producto} ${precioT}.";
        }

        public void setFacturaCompra(string nombre, string direccion, int totalCompra)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.totalCompra = totalCompra;
        }

        public string getFacturaCompra()
        {
            return $"Factura: {nombre} {direccion} {totalCompra}";
        }

        public string envio()
        {
            return $"Direccion de envio: {direccion}\n" +
                $"Titular del envio: {nombre}\n" +
                $"" +
                $"" +
                $"El total de su compra es: {totalCompra}\n" +
                $"ENVIADO POR EMPRESA EXTERNA";
        }
    }
}

