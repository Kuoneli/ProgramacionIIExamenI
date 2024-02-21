

//Paciente debe poder agregar numero de cedula y la busqueda tiene que ser por numero de cedula

//Informacion del paciente
using System.Xml;

string[] nombre = new string[20], direccion = new string[20], tipoSangre = new string[20], fechaNacimiento = new string[20];
int[] cedula = new int[20], telefono = new int[20];

//Variables para medicamentos.
int[] codigoMed = new int[20], cantidadMed = new int[20];
string[] nombreMed = new string[20];


//Asignaciones de tratamiento
string[] medicamentosRecetados = new string[20];
int[] cantidadMedRecetado = new int[20];

//todas las demas variables
int menu = 0, seleccion = 0, contador = 0, contadorMed = 0, edad = 0, contadorTrat = 0, busqueda = 0, indice= 0;
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
} while (menu != 5);

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

        do
        {
            try
            {
                Console.WriteLine("Ingrese la fecha de nacimiento en formato (Año-mes-dia");
                fechaNacimiento[contador] = Console.ReadLine();

                DateTime fecha = DateTime.Parse(fechaNacimiento[contador]);
                edad = DateTime.MinValue.AddDays(DateTime.Now.Subtract(fecha).TotalHours / 24 - 1).Year - 1;
                Console.WriteLine($"Su edad edad es: {edad}");
                error = false;
            }
            catch (Exception)
            {
                Console.WriteLine("Favor no utilizar letras\n");
                error = true;
            }
        } while (error == true);
        contador++;
    }
}

void AsignarTratamiento()
{

    if (contadorMed == 0)
    {
        Console.WriteLine("No hay medicamentos en el sistema para asignar.\n Ingrese medicamentos en la base de datos.");
    }
    else
    {
        busqueda = int.Parse("Ingrese el numero de cedula del paciente al que desea asignar tratamiento");
        for (int i = 0; i < contador; i++)
        {
            if (busqueda == cedula[i])
            {
            
                Console.WriteLine($"Asignando tratamiento a {nombre[i]}");
                Console.WriteLine("Que medicamento quiere agregar");
                HashSet<string> set = new HashSet<string>(medicamentosRecetados);
                string[] lista = new string[set.Count];
                set.CopyTo(lista);
                foreach (string item in lista)
                { Console.WriteLine(item); }
                medicamentosRecetados[i] = Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Numero de Cedula no concuerda con ningun paciente");
            }

        }
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
        nombreMed[contador].ToUpper();


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
        contadorMed++;
    }
}

void Consultas()
{
    do
    {
        try
        {
            Console.WriteLine("Seleccione de las siguientes opcines de Reportes\n1-Cantidad de pacientes registrados\n2-Lista de Medicamentos Recetados\n3-Cantidad de pacientes agrupados por edad.\n4-Pacientes ordenados por nombre.\n6-Salir");
            menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Console.WriteLine($"Cantidad de pacientes ingresados es: {contador + 1}");

                    break;
                case 2:
                    Console.WriteLine("Lista de Medicamentos Recetados");
                    HashSet<string> set = new HashSet<string>(medicamentosRecetados);
                    string[] lista = new string[set.Count]; 
                    set.CopyTo(lista);
                    foreach (string item in lista)
                    { Console.WriteLine(item); }
                    break;
                case 3:
                    break;
                case 4:
                    break;
                    //Tuve que usar opcion 6 porque 5 concordaba con el menu principal y entonces lo sacaba total del sistema, con 6 lo devuelve al menu principal
                case 6:
                    Console.WriteLine("Saliendo del Sistema");
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("No se admiten letras\nIntente de nuevo\n");
        }
    } while (menu != 6);
}