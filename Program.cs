// See https://aka.ms/new-console-template for more information
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Hello, World!");
//Paciente debe poder agregar numero de cedula y la busqueda tiene que ser por numero de cedula

//Informacion del paciente
string[] nombre = new string[int.MaxValue], direccion = new string[int.MaxValue], tipoSangre = new string[int.MaxValue];
int[] cedula = new int [int.MaxValue], telefono = new int[int.MaxValue], fechaNacimiento = new int[int.MaxValue];

//Variables para medicamentos.
int[] codigoMed = new int[int.MaxValue], cantidadMed = new int[int.MaxValue];
string[] nombreMed = new string[int.MaxValue];

//Asignaciones de tratamiento
string[] tratamiento = new string[int.MaxValue];

//todas las demas variables
int menu = 0, seleccion = 0, contador = 0, contadorMed = 0;
bool error = false;

// Main
Console.WriteLine("Sistema de Gestion de Pacientes y consultas medicas");
do
{
    Console.Clear();
    try
    {
        Console.WriteLine("Selecccione de las siguientes opciones:\n1-Agregar Pacientes\n2-Agregar Medicamentos\n3-AsignarTratamientos\n4-Consultar\n5-Salir");
        menu = int.Parse(Console.ReadLine());
        switch (menu)
        {
            case 1:
                AgregarPaciente();
                break;
            case 2:
                Medicamento();   
                break;
            case 3:
                AsignarTratamiento();
                break;
            case 4:
                Consultas();
                break;
            case 5:
                Console.WriteLine("Saliendo del Sistema\nMi primera chamba!!");
                break;
            default:
                Console.WriteLine("Opcion Invalida\nIntente de nuevo\n");
                break;
        }
    }
    catch (FormatException)
    {

        Console.WriteLine("No se admiten letras\nIntente de nuevo\n");

    }
} while (menu != 7);

//Funciones
void AgregarPaciente()
{
    Console.WriteLine("Digite la cantidad de Pacientes a ingresar: ");
    seleccion = Convert.ToInt32(Console.ReadLine());
    for (int x = 0; x < seleccion; x++)
    {

        do
        {
            try
            {
                Console.WriteLine("Ingrese el numero de cedula del Paciente: ");
                cedula[contador] = Convert.ToInt32(Console.ReadLine());
                error = false;
            }
            catch (FormatException)
            {
                Console.WriteLine("Letras no son permitidas\n");
                error = true;
            }

        } while (error == true);

        Console.WriteLine("Ingrese el nombre del Paciente: ");
        nombre[contador] = Console.ReadLine();

        do
        {
            try
            {
                Console.WriteLine("Ingrese el numero de telefono del Paciente (sin guiones): ");
                telefono[contador] = Convert.ToInt32(Console.ReadLine());
                error = false;
            }
            catch (Exception)
            {
                Console.WriteLine("Favor no utilizar letras\n");
                error = true;
            }
        } while (error == true);

        Console.WriteLine("Ingrese el Tipo de Sangre del Paciente: ");
        tipoSangre[contador] = Console.ReadLine();

        Console.WriteLine("Ingrese el Tipo de Sangre del Paciente: ");
        direccion[contador] = Console.ReadLine();
        do
        {
            try
            {
                Console.WriteLine("Ingrese el numero de telefono del Paciente (sin guiones): ");
                fechaNacimiento[contador] = Convert.ToInt32(Console.ReadLine());
                error = false;
            }
            catch (Exception)
            {
                Console.WriteLine("Favor no utilizar letras\n");
                error = true;
            }
            contador++;
        } while (error == true);

    }

void Consultas()
        {
            do
            {
                try
                {
                    Console.WriteLine("Seleccione de las siguientes opcines de Reportes\n1-Estudiantes por Condiciones\n2-Todos los Datos\n3-Regresar a menu principal.");
                    menu = int.Parse(Console.ReadLine());
                    if (menu == 1)
                    {
                        Console.WriteLine("Estudiante\n1-Aprobados\n2-Reprobados\n3-Aplazados\n");

                    }
                    else if (menu == 2)
                    {
                    }
                    else if (menu == 3)
                    {
                        Console.WriteLine("Regrasando al menu principal\n");
                    }
                    else
                    {
                        Console.WriteLine("Opcion Invalida\nIntente de nuevo\n");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("No se admiten letras\nIntente de nuevo\n");
                }
            } while (menu != 3);
        }
    }

void Medicamento()
{
    Console.WriteLine("Digite la cantidad de Medicamentos a ingresar: ");
    seleccion = Convert.ToInt32(Console.ReadLine());
    for (int x = 0; x < seleccion; x++)
    {

        do
        {
            try
            {
                Console.WriteLine("Ingrese el codigo del Medicamento: ");
                codigoMed[contadorMed] = Convert.ToInt32(Console.ReadLine());
                error = false;
            }
            catch (FormatException)
            {
                Console.WriteLine("Letras no son permitidas\n");
                error = true;
            }

        } while (error == true);

        Console.WriteLine("Ingrese el nombre del Paciente: ");
        nombreMed[contadorMed] = Console.ReadLine();

        do
        {
            try
            {
                Console.WriteLine("Ingrese el numero de telefono del Paciente (sin guiones): ");
                cantidadMed[contadorMed] = Convert.ToInt32(Console.ReadLine());
                error = false;
            }
            catch (Exception)
            {
                Console.WriteLine("Favor no utilizar letras\n");
                error = true;
            }
        } while (error == true);
    }
}

void AsignarTratamiento()
{
    Console.WriteLine("Digite la cantidad de Tratamientos a ingresar: ");
    seleccion = Convert.ToInt32(Console.ReadLine());
    for (int x = 0; x < seleccion; x++)
    {

        do
        {
            try
            {
                Console.WriteLine("Ingrese el codigo del Medicamento: ");
                codigoMed[contadorMed] = Convert.ToInt32(Console.ReadLine());
                error = false;
            }
            catch (FormatException)
            {
                Console.WriteLine("Letras no son permitidas\n");
                error = true;
            }

        } while (error == true);

        Console.WriteLine("Ingrese el nombre del Paciente: ");
        nombreMed[contadorMed] = Console.ReadLine();

        do
        {
            try
            {
                Console.WriteLine("Ingrese el numero de telefono del Paciente (sin guiones): ");
                cantidadMed[contadorMed] = Convert.ToInt32(Console.ReadLine());
                error = false;
            }
            catch (Exception)
            {
                Console.WriteLine("Favor no utilizar letras\n");
                error = true;
            }
        } while (error == true);
    }

}

void Consultas()
{
    do
    {
        try
        {
            Console.WriteLine("Seleccione de las siguientes opcines de Reportes\n1-Total de paciente Ingresados\n2-Medicamentos recetados.\n3-Cantidad de Pacientes agrupados por edad.\nPacientes y consultas ordenados por nombre");
            menu = int.Parse(Console.ReadLine());
            if (menu == 1)
            {
                Console.WriteLine($"Cantidad de pacientes ingresados es: {contador+1}");

            }
            else if (menu == 2)
            {
            }
            else if (menu == 3)
            {
                Console.WriteLine("Regrasando al menu principal\n");
            }
            else
            {
                Console.WriteLine("Opcion Invalida\nIntente de nuevo\n");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("No se admiten letras\nIntente de nuevo\n");
        }
    } while (menu != 3);
}
  
