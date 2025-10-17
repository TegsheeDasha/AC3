internal class Program
{
    static void Main(string[] args)
    {
        // ejercicio 1

        int numero;

        System.Console.WriteLine(" un número :");
        numero = int.Parse(Console.ReadLine());

        if (numero > 0)
        {
            Console.WriteLine("numero positivo");
        }
        else (numero < 0)
         {
            Console.WriteLine("El número és negative o zore");
        }


        // ejercicio 2
        int numero;
        int numero2;

        System.Console.Write("numero ");
        numero = int.Parse(Console.ReadLine());

        Console.Write("numero2 ");
        numero2 = int.Parse(Console.ReadLine());

        if (numero < numero2)
        {
            System.Console.WriteLine("el numero es menor");
        }
        else if (numero < numero2)
        {
            Console.WriteLine("el numero es mayor");
        }
        else
        {
            Console.WriteLine(" son iguales.");



            // ejercicio 3
            int edad;


            System.Console.Write(" edad: ");
            edad = int.Parse(Console.ReadLine());

            if (edad <= 13)
                System.Console.WriteLine("Niño");
            else if ((edad > 13) && (edad <= 17))
                System.Console.WriteLine("Adolescente");
            else if ((edad > 17) && (edad <= 64))
                System.Console.WriteLine("Adulto");
            else
                Console.WriteLine("Mayor"); */


              // ejercicio 4 

              Console.Write("Introduce el nombre de usuario: ");
            string usuario = Console.ReadLine() ?? string.Empty;


            Console.Write("Introduce la contraseña: ");
            string contrasena = Console.ReadLine() ?? string.Empty;

            if (usuario == "admin")
            {
                if (contrasena == "1234")
                {
                    Console.WriteLine("Acceso permitido");
                }
                else
                {
                    Console.WriteLine("Contraseña incorrecta");
                }
            }
            else
            {
                Console.WriteLine("Usuario no reconocido");
            }


            // ejercicio 5  
            int año;

            Console.Write("Introduce un año: ");
            int año = Convert.ToInt32(Console.ReadLine());

            string resultado = (año % 400 == 0)
                ? "El año es bisiesto."
                : "El año no es bisiesto.";

            Console.WriteLine(resultado);
        }

    }

