using System;

class Tp2
{
    static void Main(string[] args)
    {
        // Variables : stockent des valeurs de differents types
        int age = 20;
        double prix = 19.99;
        bool actif = true;
        char alphaChar = 'A';
        char lettre = 'A';
        string name = "Alexandre";

        Console.WriteLine(age);
        Console.WriteLine(prix);
        Console.WriteLine(actif);
        Console.WriteLine(lettre);
        Console.WriteLine(name);

        // var : C# devine le type de la variable a partir de la valeur
        var city = "Paris";
        Console.WriteLine(city);

        // Operateurs : font des calculs ou des comparaisons
        int a = 10;
        int b = 5;
        Console.WriteLine(a + b);
        Console.WriteLine(a - b);
        Console.WriteLine(a * b);
        Console.WriteLine(a / b);
        Console.WriteLine(a % b);
        Console.WriteLine(a > b);
        Console.WriteLine(a == b);

        // if : teste une condition
        if (age >= 18)
        {
            Console.WriteLine("Majeur");
        }
        else
        {
            Console.WriteLine("Mineur");
        }

        // switch : choisit un cas parmi plusieurs possibles
        int note = 15;
        switch (note)
        {
            case 10:
                Console.WriteLine("Passable");
                break;
            case 15:
                Console.WriteLine("Bien");
                break;
            default:
                Console.WriteLine("Autre note");
                break;
        }

        // for : repete un nombre connu de fois
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(i);
        }

        // while : repete tant que la condition est vraie
        int j = 0;
        while (j < 3)
        {
            Console.WriteLine(j);
            j++;
        }

        // foreach : parcourt tout tableau ou liste sans se soucier de l'index
        string[] names = { "Alice", "Bob", "Charlie" };
        foreach (string person in names)
        {
            Console.WriteLine(person);
        }

        // Methode : evite de repeter du code utilise plusieurs fois
        int resultat = Addition(5, 3);
        Console.WriteLine(resultat);

        // ref : modifie la variable d'origine
        int compteur = 1;
        Increment(ref compteur);
        Console.WriteLine(compteur);
    }

    static int Addition(int x, int y)
    {
        return x + y;
    }

    static void Increment(ref int x)
    {
        x++;
    }
}
