using System;
using System.Collections.Generic;
using System.Linq;

namespace SegundoParcial2
{
    class Program
    {
        static List<Producto> Carrito = new List<Producto>();
        static List<Producto> ListProductos = new List<Producto>() { 
            new Producto(){Nombre="Emperador de Chocolate", precio=15, existencia="10/05/2021" },
            new Producto(){Nombre="Emperador de Vainilla", precio=15, existencia="10/05/2021"},
            new Producto(){Nombre="Galletas de Avena", precio=25, existencia="10/05/2021"},
            new Producto(){Nombre="Cheetos", precio=20, existencia="10/05/2021"},
            new Producto(){Nombre="Doritos", precio=20, existencia="10/05/2021"},
            new Producto(){Nombre="Doritos de queso", precio=25, existencia="10/05/2021"},
            new Producto(){Nombre="Doritos de queso", precio=25, existencia="10/05/2021"},
            new Producto(){Nombre="Doritos de queso", precio=25, existencia="10/05/2021"},
            new Producto(){Nombre="Refrezco de uva", precio=20, existencia="10/05/2021"},
            new Producto(){Nombre="Coca Cola", precio=25, existencia="10/05/2021"},
            
        };

        static void Main(string[] args)
        {

            ComprarProductos();
        }


        public static void ComprarProductos() {
            string NombreProducto;            
            Console.Clear();
             ExiteProduto:
            foreach (var item in ListProductos)
            {

                Console.WriteLine("Nombre: " +item.Nombre);
                Console.WriteLine("Precio: $" +item.precio);
                Console.WriteLine("-----------------------");

            }

            Console.WriteLine("Que Producto decea Comprar?: ");
            NombreProducto = Console.ReadLine();

            if (ListProductos.Where(x => x.Nombre == NombreProducto).Count() > 0)
            {
                foreach (var item in ListProductos)
                {
                    if (item.Nombre == NombreProducto)
                    {
                        Console.Clear();
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Nombre: "+item.Nombre);
                        Console.WriteLine("Precio: $"+item.precio);
                        Console.WriteLine("--------------------");
                        Console.WriteLine("");

                        Console.WriteLine("Total: " + item.precio);
                        Console.WriteLine("Seleccione su forma de pago:");
                        Console.WriteLine("A) Billetes");
                        Console.WriteLine("B) Monedas");
                        string formaPago = Console.ReadLine().ToUpper();

                        if (formaPago == "A")
                        {
                            Console.Clear();
                            Console.WriteLine("Solo Aceptamos Billetes de $50, $100, $200");
                            BilleteMonto:
                            Console.Write("Escriba su monto: ");
                            int monto = Convert.ToInt32(Console.ReadLine());

                            if (monto == 50 || monto == 100 || monto == 200)
                            {
                                if (monto < item.precio)
                                {
                                    Console.WriteLine("Monto Insuficiente"); goto BilleteMonto;
                                }
                                else 
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("------------------------------");
                                    Console.WriteLine("Compra con Exito!");
                                    Carrito.Add(item);
                                    ListProductos.Remove(item);
                                    int devuelta = monto - item.precio;
                                    Console.WriteLine("Su devuelta es de : $ {0}", devuelta);
                                    Console.WriteLine("------------------------------");
                                    Console.WriteLine("");

                                    Console.WriteLine("Que Desea Hacer: ");
                                    Console.WriteLine("");
                                    Console.WriteLine("A) Mostrar Informe");
                                    Console.WriteLine("B) Volver a Comprar");
                                    Console.WriteLine("C) Salir");

                                    string OpcionFinal = Console.ReadLine().ToUpper();
                                    switch (OpcionFinal)
                                    {
                                        case "A":
                                            VerDetalle();
                                            break;
                                        case "B":
                                            ComprarProductos();
                                            break;
                                        case "C":
                                            VerDetallesFinal();
                                            break;
                                    }

                                    break;
                                }
                            }
                            else {
                                Console.WriteLine("Billete no permitido");goto BilleteMonto;
                            }
                        }
                        else if (formaPago == "B") 
                        {
                            
                            Console.Clear();
                            Console.WriteLine("Solo Aceptamos Billetes de $5, $10, $25");
                            MonedaMonto:
                            Console.Write("Escriba su monto: ");
                            int monto = Convert.ToInt32(Console.ReadLine());

                            if (monto == 5 || monto == 10 || monto == 25)
                            {

                                if (monto < item.precio)
                                {
                                    Console.WriteLine("El monto es menor al precio del producto");goto MonedaMonto;
                                }
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("------------------------------");
                                    Console.WriteLine("Compra con Exito!");
                                    Carrito.Add(item);
                                    ListProductos.Remove(item);
                                    int devuelta = monto - item.precio;
                                    Console.WriteLine("Su devuelta es de : $ {0}", devuelta);
                                    Console.WriteLine("------------------------------");
                                    Console.WriteLine("");


                                    Console.WriteLine("Que Desea Hacer: ");
                                    Console.WriteLine("");
                                    Console.WriteLine("A) Mostrar Informe");
                                    Console.WriteLine("B) Volver a Comprar");
                                    Console.WriteLine("C) Salir");

                                    string OpcionFinal = Console.ReadLine().ToUpper();
                                    switch (OpcionFinal)
                                    {
                                        case "A":
                                            VerDetalle();
                                            break;
                                        case "B":
                                            ComprarProductos();
                                            break;
                                        case "C":
                                            break;
                                    }
                                }
                   
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Moneda no permitido");goto MonedaMonto;
                            }
                        }
                    }
                }
            }
            else {
                Console.Clear();
                Console.WriteLine("Este Producto no existe");
                goto ExiteProduto;
            }


        }

        private static void VerDetallesFinal()
        {
            Console.Clear();
            Console.WriteLine("Detalle de la Compra: ");
            foreach (var item in Carrito)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("Nombre: " + item.Nombre);
                Console.WriteLine("Precio: " + item.precio);
                Console.WriteLine("---------------------");
            }

            Console.WriteLine("Hasta Luego");
        }

        public static void VerDetalle()
        {
            Console.Clear();
            Console.WriteLine("Detalle de la Compra: ");
            foreach (var item in Carrito)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("Nombre: " +item.Nombre);
                Console.WriteLine("Precio: " +item.precio);
                Console.WriteLine("---------------------");
            }

            Console.WriteLine("Que Desea Hacer: ");
            Console.WriteLine("");
            Console.WriteLine("A) Volver a Comprar");
            Console.WriteLine("B) Salir");
            string OpcionFinal = Console.ReadLine().ToUpper();
            switch (OpcionFinal)
            {

                case "A":
                    ComprarProductos();
                    break;
                case "B":
                    Console.WriteLine("Hasta Luego");
                    break;
            }
        }
    }
}
