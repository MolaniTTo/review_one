using System;

class Program
{
    static void Main(string[] args)
    {
        /*int nota1 = 0;
        int nota2 = 0;
        int nota3 = 0;*/

        //Millor fer array de notes

        int[] notes = new int[3];
        int suma = 0;

        /*Console.WriteLine("Introdueix la primera qualificació");
        nota1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introdueix la segona qualificació: ");
        nota2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introdueix la tercera qualificació: ");
        nota3 = Convert.ToInt32(Console.ReadLine());*/

        //Repetició de codi, millor fer array de notes i plenarlo amn un "for"

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Introdueix la qualificació " + (i + 1));
            notes[i] = Convert.ToInt32(Console.ReadLine());
            suma += notes[i];
        }

        //int suma = nota1 + nota2 + nota3; Ja sumem les notes al bucle

        //float promig = suma / 3; No dividim entre 3, ho fem amb la llargada de l'array com es fa abaix

        float promig = suma / notes.Length; //Dividim per la llargada de l'array de 3 notes i aixi es escalable en cas de tenir-ne més

        Console.WriteLine("El promig de les notes es: " + promig);

        if (promig > 6)
        {
            Console.WriteLine("Aprovat");
        }
        /*else if (promig < 6) //No cal posar la condició, ja que si no es aprovat, es suspès
        {
            Console.WriteLine("Suspès");
        }*/
        else
        {
            Console.WriteLine("Suspès");
        }
    }
}


