


static void matriz ()
{
    String[] nombre = new string []
    {
        "Anderson", "Brandon", "Yeimi", "Fatima", "Vivian"
    };

    //for (int i = 0; i < nombre.Length; i++)
    //{
    //    Console.WriteLine("Elemento: " + nombre[i]);
    //}   
   // otra manera :
        foreach (String n in nombre)
{
        Console.WriteLine("nombre: " + n);
 
}

    int[] notas = new int[]
    {
        51,80,96,76,61

    };
    int promedio = 0;
    foreach (int n in notas)
    {
        promedio = promedio + n;
    }
    promedio = promedio / notas.Length;
    Console.WriteLine("El promedio es: " + promedio);

    int mayor = notas.Length;
    int nom = 0;

    for (int j = 0; j < notas.Length; j ++)
    {
        if (notas[j] > mayor)
        {
            mayor = notas[j];
            nom = j;
        }
      
    }

    Console.WriteLine("La nota mayor es de: " + mayor);
    Console.WriteLine("La nota es de: " + nombre[nom]);


}

matriz(); 


//Desarrollar codigio que busque la nota mas alta e imprime a quien corresponda junto a su nota

// Buscar la nota minima