using TeamGOGOGO;

var lab22 = new Laboratorio("lab22" , "3er piso" , 1);

var dell = new ModeloPC("dell" , "OptiPex 3060" , 8000 , "intel Core i5 12400KF");

Console.Write("ingrese nombre de la computadora : ");
string nombre = Console.ReadLine();

Console.Write("ingrese sistema operativo : ");
string sistemaOperativo = Console.ReadLine();

Console.WriteLine("ingrese el id");
int idComputadora=int.Parse(Console.ReadLine());
Computadora computadora = new Computadora(idComputadora, nombre, sistemaOperativo, lab22, dell);


