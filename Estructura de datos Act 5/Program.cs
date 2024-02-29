//Actividad 5 Estrucrura de datos Programación orientada a objetos
using System;

//Aquí se define una clase llamada Empleado. Las clases son plantillas para crear objetos, en este caso, la clase Empleado representa a un empleado
//con dos miembros de datos (nombre y número de empleado) y dos funciones miembro (para leer y mostrar datos).
public class Empleado
{
    //Estas líneas declaran dos variables privadas dentro de la clase Empleado. nombre es de tipo string (cadena de caracteres) y numeroEmpleado es de tipo int (entero).
    //Miembros de datos
    private string nombre;
    private int numeroEmpleado;

    //Funciones miembro
    //Aquí se define una función miembro pública llamada LeerDatos(), esta función se encarga de leer el nombre y el número de empleado desde
    //la entrada estándar (teclado) y asignarlos a las variables nombre y numeroEmpleado.
    public void LeerDatos()
    //Esta línea muestra un mensaje en la consola para solicitar al usuario que ingrese el nombre del empleado.
    {
        Console.WriteLine("Introduzca el nombre del empleado ");

        //Lee una línea de texto ingresada por el usuario y la asigna a la variable nombre.
        nombre = Console.ReadLine();

        //Esta línea muestra un mensaje en la consola para solicitar al usuario que ingrese la cantidad de empleados.
        Console.WriteLine("Intoduzca el número de empleados ");
        //Lee una línea de texto ingresada por el usuario, la convierte a un entero y la asigna a la variable numeroEmpleado.
        numeroEmpleado = int.Parse(Console.ReadLine());
    }
    //Aquí se define otra función miembro pública llamada VerDatos(). Esta función muestra en la consola el nombre y el número de empleado almacenados en las variables.
    public void VerDatos()
    {
        //Muestra el nombre del empleado utilizando una cadena de formato. El {0} se reemplaza por el valor de nombre.
        Console.WriteLine("Nombre:{0}", nombre);

        //Muestra el número de empleado.
        Console.WriteLine("Número de empleado: {0}", numeroEmpleado);
    }
    //Aquí se define otra clase llamada Program. Esta es la clase principal que contiene el método Main(), que es el punto de entrada de la aplicación.
    class Program
    {
        //El método Main() es el punto de inicio de la ejecución del programa. Recibe argumentos desde la línea de comandos y es donde se inicia la lógica del programa.
        static void Main(string[] args)
        {
            //Crear un array con capacidad de de 50 empleados
            Empleado[] empleados = new Empleado[3];

            //Llenar el array con datos
            //Este bucle recorre el arreglo empleados y crea un nuevo objeto Empleado en cada iteración.
            for (int i = 0; i < empleados.Length; i++)
            {
                //Crea una instancia de la clase Empleado y la asigna al elemento i del arreglo.
                empleados[i] = new Empleado();

                //Llama al método LeerDatos() para ingresar los datos del empleado.
                empleados[i] .LeerDatos();
            }
            //Mostar los datos de todos los empleados
            //Muestra un encabezado para los datos de los empleados.
            Console.WriteLine("**\n**Datos de los empleados**\n");

            //Este bucle recorre el arreglo empleados y crea un nuevo objeto Empleado en cada iteración.
            for (int i = 0; i < empleados.Length; i++)
            {
                //Llama al método VerDatos() para mostrar los datos del empleado.
                empleados[i].VerDatos();

                //Muestra los datos en pantalla.
                Console.WriteLine();
            }
        }
    }
}


