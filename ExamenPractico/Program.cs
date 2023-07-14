
using ExamenPractico;



//MAYOR DE EDAD
//int personas = 5;

//int[] edades = new int[personas];


//for (int i = 0; i < personas; i++) 
//{
//    Console.WriteLine($"Usuario {i + 1} ingrese su edad:");
//    //edades[i] = int.Parse(Console.ReadLine());
//    edades[i] = int.Parse(Console.ReadLine());
//    string validar = MayoriaEdad.MayorDeEdad(edades[i]);
//    Console.WriteLine($"El usuario {i + 1} {validar}");

    
//}

//------------------------------------ Empleado ---------------------------------------------------

Empleados empleado1= new Empleados();


empleado1.nombre = "Jacobo";
empleado1.apellido = "Agami";
empleado1.sueldoDiario = 500;


Empleados empleado2 = new Empleados();

empleado2.nombre = "Alvaro";
empleado2.apellido = "González";
empleado2.sueldoDiario = 400;


Empleados empleado3 = new Empleados();
empleado3.nombre = "Mario";
empleado3.apellido = "Ramón";
empleado3.sueldoDiario = 300;

Console.WriteLine( empleado1.CalcularSueldo(500));
Console.WriteLine(empleado1.CalcularSueldo(400));
Console.WriteLine(empleado1.CalcularSueldo(300));




