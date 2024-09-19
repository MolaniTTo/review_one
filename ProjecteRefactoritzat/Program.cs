using System;

class Program
{
    static void Main(string[] args)
    {

        int[] notes = new int[3];
        int suma = 0;
        

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Introdueix la qualificació " + (i + 1));
            notes[i] = Convert.ToInt32(Console.ReadLine());
            suma += notes[i];
        }

        float promig = suma / notes.Length; 

        Console.WriteLine("El promig de les notes es: " + promig);

        if (promig > 6)
        {
            Console.WriteLine("Aprovat");
        }
        else
        {
            Console.WriteLine("Suspès");
        }

        //Diccionari amb ciutats i codis postals

        string ciutat = "";
        int codiPostal =0;
        Dictionary<string, int> ciutats = new Dictionary<string, int>();
        string sortida = "";


        while(sortida != "fi")
        {
            Console.WriteLine("Introdueix una ciutat (o escriu 'fi' per acabar)");
            ciutat = Console.ReadLine();

            if(ciutat != "fi")
            {
                Console.WriteLine("Introdueix el codi postal de " + ciutat);
                codiPostal = Convert.ToInt32(Console.ReadLine());
                ciutats.Add(ciutat, codiPostal);
            }
            else
            {
                sortida = "fi";
            }
        }

        Console.WriteLine("\nLlistat de ciutats i codis postals:\n");
        foreach(var item in ciutats)
        {
            Console.WriteLine(item.Key + " - " + item.Value);
        }
    }
    
}


