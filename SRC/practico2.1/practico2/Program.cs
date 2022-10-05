using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;

namespace practico2
{
    class Program
    {
        static void Main(string[] args)
        {

            int posicion = 3;//sirve para poder agregarle cosas articulos al catalogo "hacerlo dinamico"
            int posicionCiente = 2;// sirve para poder agregarle clientes a la lista de clientes, "hacerlo dinamico
            string nuevoProductoNombre; //variable para ingresar el nombre del producto
            int nuevoProductoPrecio; // variable para ingresar el precio del producto
            string nuevoClienteNombre;
            string nuevoClienteDireccion;
            int nuevoClienteTipo;
            string nombreCliente;
            //string datos;
            int cliente; //opcion 0 o 1 si es cliente
            bool coincidencia = false;
            int vp; //cantidad de productos
            int op; //opcion del switch
            int totalCompra = 0;
            Carrito[] nuevoCarrito = new Carrito[1000];
            Productos[] catalogo = new Productos[1000];
            Cliente[] pedidos = new Cliente[100];
            catalogo[0] = new Productos("Perifar", 70);
            catalogo[1] = new Productos("Cafeina", 80);
            catalogo[2] = new Productos("Ibuprofeno", 90);


            Cliente[] listaClientes = new Cliente[1000];
            listaClientes[0] = new Cliente("Seba", 0, "Maldonado");
            listaClientes[1] = new Cliente("Diego", 1, "Maldonado");
            do
            {
                Console.WriteLine("Ingrese una opcion\n" +
                    "1. Ver catalogo\n" +
                    "2. Venta\n" +
                    "3. Agregar producto al catalogo\n" +
                    "4. Agregar cliente");
                op = Int32.Parse(Console.ReadLine());
                Console.Clear();

                switch (op)
                {
                    case 1:
                        Console.WriteLine("*************CATALOGO DE PRODUCTOS*************");


                        for (int i = 0; i < posicion; i++)
                        {
                            Console.WriteLine(catalogo[i].getInfo());
                        }
                        Console.WriteLine("***********************************************");

                        break;

                    case 2:

                        for (int i = 0; i < posicion; i++)
                        {
                            Console.WriteLine("Ingrese la cantidad de:");
                            Console.WriteLine(catalogo[i].getInfo());
                            vp = Int32.Parse(Console.ReadLine());
                            nuevoCarrito[i] = new Carrito(catalogo[i].getInfo(), vp, catalogo[i].getPrecio());

                            Console.WriteLine(nuevoCarrito[i].getProducto());
                        }


                        for (int i = 0; i < posicion; i++)
                        {
                            Console.WriteLine(nuevoCarrito[i].getPrecio());
                            totalCompra = totalCompra + nuevoCarrito[i].getPrecio();
                        }
                        Console.WriteLine("El total de su compra es: $" + totalCompra);

                        Console.WriteLine("ingrese 1 si es cliente o 0 si no lo es , para registrarse");
                        cliente = Int32.Parse(Console.ReadLine());
                        if (cliente == 1)
                        {

                            while (coincidencia == false)
                            {
                                Console.WriteLine("Ingrese el nombre del cliente: ");
                                nombreCliente = Console.ReadLine();

                                for (int j = 0; j < posicionCiente; j++)
                                {
                                    if (listaClientes[j].getInfo() == (nombreCliente))
                                    {
                                        nuevoCarrito[0].setFacturaCompra(nombreCliente, listaClientes[j].getInfo2(), totalCompra);

                                        coincidencia = true;
                                    
                                    }
                                }
                            }


                        }
                        if (cliente == 0)
                        {


                            // primer paso registro cliente en el caso de no serlo

                            Console.WriteLine("Ingrese su nombre");
                            nuevoClienteNombre = Console.ReadLine();

                            Console.WriteLine("Ingrese su direccion:");
                            nuevoClienteDireccion = Console.ReadLine();

                            Console.WriteLine("Ingrese 1 si es una empresa o 0 si es un particular :");
                            nuevoClienteTipo = Int32.Parse(Console.ReadLine());

                            listaClientes[posicionCiente] = new Cliente(nuevoClienteNombre, nuevoClienteTipo, nuevoClienteDireccion);

                            Console.WriteLine("Su registro fue completado con éxito!");
                          

                            posicionCiente = posicionCiente + 1;

                           nuevoCarrito[0].setFacturaCompra(nuevoClienteNombre, nuevoClienteDireccion, totalCompra);

                        }


                        Console.WriteLine(nuevoCarrito[0].getFacturaCompra());
                        Console.WriteLine(nuevoCarrito[0].envio());

                        break;

                    case 3:


                        Console.WriteLine("Agregar productos al catalogo");

                        Console.WriteLine("Ingrese el nombre del producto:");
                        nuevoProductoNombre = Console.ReadLine();

                        Console.WriteLine("Ingrese el precio del producto:");
                        nuevoProductoPrecio = Int32.Parse(Console.ReadLine());

                        catalogo[posicion] = new Productos(nuevoProductoNombre, nuevoProductoPrecio);

                        Console.WriteLine("El articulo fue agregado con exito!");
                   

                        posicion = posicion + 1;


                        break;
                    case 4:
                        Console.WriteLine("Agregar cliente");

                        Console.WriteLine("Ingrese su nombre");
                        nuevoClienteNombre = Console.ReadLine();

                        Console.WriteLine("Ingrese su direccion:");
                        nuevoClienteDireccion = Console.ReadLine();

                        Console.WriteLine("Ingrese 1 si es una empresa o 0 si es un particular: ");
                        nuevoClienteTipo = Int32.Parse(Console.ReadLine());


                        listaClientes[posicionCiente] = new Cliente(nuevoClienteNombre, nuevoClienteTipo, nuevoClienteDireccion);

                        Console.WriteLine("Su registro fue completado con exito!");
                      
                        posicionCiente = posicionCiente + 1;



                        break;
                    default:
                        Console.WriteLine("Ingrese un numero valido");
                        break;
                }

            } while (op != 2);


        }
    }
}

