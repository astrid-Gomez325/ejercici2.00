using System;

namespace asignacion_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definir variables
            string datos = "";
            int edad = 0;
            Double altura = 0;
            int rueda1 = 1;
            int elgusanito = 2;
            int carrusel = 3;
            string nombre = "";


            // Pedir informacion
            Console.WriteLine("Ingrese su Edad ");
            datos = Console.ReadLine();
            edad = Convert.ToInt32(datos);

            if (edad >= 18)

            {
                Console.WriteLine("Ha superado el limite de edad para el parque");

            }

            if (edad < 18)


            {
                Console.WriteLine("Bienvenido al parque Maravillas");
                Console.WriteLine("¿Cual es tu nombre bellez@?");
                nombre = Console.ReadLine();
                Console.WriteLine("¿Que atraccion del parque desea entrar {0}?", nombre);
                Console.WriteLine("1= Rueda de la fortuna || 2= El gusanito || 3= El carrusel");
                datos = Console.ReadLine();
                rueda1 = Convert.ToInt32(datos);
                elgusanito = Convert.ToInt32(datos);
                carrusel = Convert.ToInt32(datos);

                if (rueda1 == 1)
                {
                    Console.WriteLine("¿Cual es tu estaltura?");
                    datos = Console.ReadLine();
                    altura = Convert.ToDouble(datos);

                    if (altura < 1.60)
                    { 
                    Console.WriteLine("Lo siento no puedes ingresar a esta atraccion");
                        }

                        if (altura >= 1.60)
                    {
                    Console.WriteLine("Disfrute la atraccion");
                         }





                    }

                if (elgusanito == 2)
                {
                    Console.WriteLine("¿Cual es tu estaltura?");
                    datos = Console.ReadLine();
                    altura = Convert.ToDouble(datos);

                    if (altura > 1.60) 
                    { 
                    Console.WriteLine("Disfrute la atraccion");
                        }
                    if (altura <= 1.60)

                    {
                        Console.WriteLine("Lo siento no puedes ingresar a esta atraccion");
                         }
                   
                    
                    }

                if (carrusel == 3)
                {

                    Console.WriteLine("Disfrute la atraccion");


                }

            }
        }
    }
}
