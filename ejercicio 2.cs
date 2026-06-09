//Contar cuantas personas son mayores de edad
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Datos Academicos \n Nombre: Alex Calderon" +
            "\n Grado: IV C" +
            "Clave:4");

        int[] edadPersonas = new int[7];
        int CantidadPersonasMayores = 0;
        int CantidadPersonasMenores = 0;
        int i;
        

        //Lenar el arreglo
        for (i = 0; i <edadPersonas.Length; i++) ;
        {
            Console.Write("Ingrese la edad de la persona: ", +(i+1)+  ":");
            edadPersonas[1]=Convert.ToInt32(Console.ReadLine());
            if (edadPersonas[i] >= 18)
            {
                CantidadPersonasMayores++;
            }
            else
            {

                CantidadPersonasMenores++;
            }

        }
        Console.WriteLine();
        Console.WriteLine("Contidad e personas mayores de edad: " + 
            CantidadPersonasMayores);
        Console.WriteLine("Contidad e personas menores de edad: " +
    CantidadPersonasMenores);
        Console.WriteLine("Totale de personas" +i);

    }
}
