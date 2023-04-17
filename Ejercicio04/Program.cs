using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int tamanio = 0, contador = 0;
        string[] datos = new string[0];
        string dato = "";
        double num = 0.0;
        bool esEntero = false;

        try
        {
            Console.WriteLine("Indique cuantos datos va a introducir.");
            esEntero = int.TryParse(Console.ReadLine(), out tamanio);
            while(!esEntero || tamanio <= 0)
            {
                Console.WriteLine("Por favor indique un numero entero mayor que 0.");
                Console.WriteLine("Indique cuantos datos va a introducir.");
                esEntero = int.TryParse(Console.ReadLine(), out tamanio);
            }
            datos = new string[tamanio];
        }
        catch(Exception ex)
        {
            Console.WriteLine("Ha ocurrido un error: " +ex.Message);
        }
        //Solicitamos los datos y los agregamos al array mediante un bucle que comprueba si hemos introducido un numero.
        do
        {
            Console.WriteLine($"Introduzca el dato {contador + 1}: ");
            dato = Console.ReadLine();
            if (double.TryParse(dato, out num))
            {
                datos[contador] = dato.ToString();
                contador++;
            }
            else
            {
                Console.WriteLine("El valor introducido no es válido.");
            }

        } while (contador < tamanio);
        //Pedimos un número al usuario y comprobamos si está presente o no en el array mediante un bucle While.
        //El bucle termina cuando el usuario introduce "fin"
        while (dato != "fin")
        {
            Console.WriteLine("Introduzca un número para comprobar si está en la lista de datos, escribe fin para salir.");
            dato = Console.ReadLine();
            if (datos.Contains(dato))
            {
                Console.WriteLine("El dato está presente en la lista");
            }
            else
            {
                Console.WriteLine("El dato no está presente en la lista");
            }
        }
    }
}


