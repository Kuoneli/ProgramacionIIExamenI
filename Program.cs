

//Paciente debe poder agregar numero de cedula y la busqueda tiene que ser por numero de cedula

//Informacion del paciente
string[] nombre = new string[20], direccion = new string[20], tipoSangre = new string[20], fechaNacimiento = new string[20];
int[] cedula = new int[20], telefono = new int[20];

//Variables para medicamentos.
int[] codigoMed = new int[20], cantidadMed = new int[20];
string[] nombreMed = new string[20];

//Asignaciones de tratamiento
string[] tratamiento = new string[20];

//todas las demas variables
int menu = 0, seleccion = 0, contador = 0, contadorMed = 0, edad = 0;
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
                Console.WriteLine("Ingrese la fecha de nacimiento");
                fechaNacimiento[contador] = Console.ReadLine();
                DateTime fecha = DateTime.Parse(fechaNacimiento[contador]);

                edad = DateTime.MinValue.AddDays(DateTime.Now.Subtract(fecha).TotalHours / 24 - 1).Year - 1;

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

void Consultas()
{
    do
    {
        try
        {
            Console.WriteLine("Seleccione de las siguientes opcines de Reportes\n1-Cantidad de pacientes registrados\n2-Lista de Medicamentos Recetados\n3-Cantidad de pacientes agrupados por edad.\n4-Pacientes ordenados por nombre.\n5-Salir");
            menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Console.WriteLine($"Cantidad de pacientes ingresados es: {contador + 1}");

                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("No se admiten letras\nIntente de nuevo\n");
        }
    } while (menu != 5);
}