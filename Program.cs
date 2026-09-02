//en un curso con estudiantes que aun se matriculan
//se ha realizado dos examenes de entrada
//se necesita ingresar dichas notas de todo los estudiantes
System.Console.WriteLine("Ingreso de notas de curso");
int x=0;
while(x==0)
{
    for(int i=0;i<2;i++)
    {
        System.Console.WriteLine("Ingrese nota");
        int nota = int.Parse(Console.ReadLine());
    }

    System.Console.WriteLine("Necesitas ingresar nuevo estudiante(s/n)");
    char estudiante = char.Parse(Console.ReadLine());

    if (estudiante == 's') x= 0;
    else x = 1;



}

