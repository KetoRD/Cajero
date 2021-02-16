using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            //billetes
            var b1 = 18.000;
            var b2 = 9.500;
            var b3 = 4.600;
            var b4 = 5.000;
            
            Console.WriteLine("Bienvenido/a al cajero automático");
            Console.WriteLine("Seleccione su banco:");
            Console.WriteLine("1. FDP INVERSMENTS");
            int b = 0;

            do
            {
                b = Convert.ToInt32(Console.ReadLine());
                if (b != 1)
                {
                    Console.WriteLine("Esa no es una opción existente, intentelo de nuevo.");
                    Console.WriteLine("Seleccione su banco: ");
                    Console.WriteLine("1. FDP INVERSMENTS");
                }

            } while (b != 1);
            
            int ha = 0;

            do
            {
                Console.WriteLine("¿Qué desea hacer?");
                Console.WriteLine("1. Hacer un retiro");
                Console.WriteLine("2. Hacer una transcción");

                ha = Convert.ToInt32(Console.ReadLine());

                if (ha != 1 && ha != 2)
                {
                    Console.WriteLine("Esa no es una opción disponible, intentelo de nuevo");
                }
            }   while (ha != 1 && ha != 2);



            if (ha == 1)
            {
                int r = 1;
                do
                {
                    Console.WriteLine("¿Cuánto desea retirar?  (El limite de retiro es 20.000)");
                    Console.WriteLine("1. 100.00");
                    Console.WriteLine("2. 200.00");
                    Console.WriteLine("3. 500.00");
                    Console.WriteLine("4. 1.000");
                    Console.WriteLine("5. Otro");
                    r = Convert.ToInt32(Console.ReadLine());

                    if (r != 1 && r != 2 && r != 3 && r != 4 && r != 5)
                    {
                        Console.WriteLine("Esa no es una opción disponible, intentelo de nuevo");
                    }
                }   while (r != 1 && r != 2 && r != 3 && r != 4 && r != 5);
                

                if (r == 1)
                {
                    Console.WriteLine("Usted a seleccionado retirar 100.00");
                    Console.WriteLine("Por favor, retire su dinero");
                    Console.WriteLine("Gracias por utilizar nuestro servicio de cajeros automaticos!");

                }
                else if (r == 2)
                {
                    Console.WriteLine("Usted a seleccionado retirar 200.00");
                    Console.WriteLine("Por favor, retire su dinero");
                    Console.WriteLine("Gracias por utilizar nuestro servicio de cajeros automaticos!");
                }
                else if (r == 3)
                {
                    Console.WriteLine("Usted a seleccionado retirar 500.00");
                    Console.WriteLine("Por favor, retire su dinero");
                    Console.WriteLine("Gracias por utilizar nuestro servicio de cajeros automaticos!");
                }
                else if (r == 4)
                {
                    Console.WriteLine("Usted a seleccionado retirar 1.000");
                    Console.WriteLine("Por favor, retire su dinero");
                    Console.WriteLine("Gracias por utilizar nuestro servicio de cajeros automaticos!");
                }
                else if (r == 5)
                {
                    
                    
                        Console.WriteLine("Especifique el monto a retirar");
                        var v = 0;
                        v = Convert.ToInt32(Console.ReadLine());

                    do
                    {
                        if (v > 20.000)
                        {
                            Console.WriteLine("Este monto excede el limite permitido, intentelo de nuevo");
                            Console.WriteLine("Especifique el monto a retirar");
                            v = Convert.ToInt32(Console.ReadLine());
                        }
                        else if (v <= 99)
                        {
                            Console.WriteLine("Este monto no está disponible. Debe especificar un número entre 100 y 20.000");
                            Console.WriteLine("Especifique un monto a retirar");
                            v = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Usted a especificado retirar: " + v);
                            Console.WriteLine("Por favor, retire su dinero");
                            Console.WriteLine("Gracias por utilizar nuestro servicio de cajeros automaticos!");
                        }


                    } while (v > 20.000 && v <= 99);





                }
            }
            else if (ha == 2)
            {
                int trans = 0;
                do
                {
                    Console.WriteLine("Especifique el nombre de la persona a quien hará esta transacción");
                    string name = Console.ReadLine();
                    Console.WriteLine("Especifique el número de cuenta de " + name);
                    int account = int.Parse(Console.ReadLine());
                    Console.WriteLine("Especifique el monto que desea transferir   (El monto máximo en transferencias es de 10.000");
                    trans = int.Parse(Console.ReadLine());

                    if (trans > 10000)
                    {
                        Console.WriteLine("Este monto excede el limite permitido, intentelo de nuevo");
                        Console.WriteLine("Especifique el monto que desea transferir   (El monto máximo en transferencias es de 10.000");
                        trans = int.Parse(Console.ReadLine());
                    }
                    else if (trans < 10000 )
                    {
                        Console.WriteLine(" Su transacción de " + trans + " a " + name + " al número de cuenta " + account + " ha sido exitosa ");
                    }

                        
                } while (trans > 10000);

                
                
                
            }
                
        }
    }
}
