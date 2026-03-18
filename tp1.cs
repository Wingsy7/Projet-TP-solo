using System;
using System.Collections.Generic;

namespace ProjetTpSolo;

class Program
{
    static void Main(string[] args)
    {
        List<LearningCard> cards = BuildCoursePartOneSummary();

        Console.WriteLine("TP solo - Synthese de la partie 1 du cours C#");


    static List<LearningCard> BuildCoursePartOneSummary()
    {
        List<LearningCard> cards = new List<LearningCard>();

        cards.Add(new LearningCard(
            "C#",
            "C# est un langage de programmation oriente objet, fortement type et compile.",
            new List<string>
            {
                "Il permet de creer des applications console, desktop, web et backend.",
                "Il aide a detecter des erreurs avant l'execution.",
                "Il est utilise dans l'ecosysteme .NET."
            }));

        cards.Add(new LearningCard(
            ".NET",
            ".NET est la plateforme dans laquelle un programme C# s'execute.",
            new List<string>
            {
                "Elle fournit des bibliotheques utiles.",
                "Elle permet a plusieurs langages de fonctionner ensemble.",
                "Elle apporte un cadre commun d'execution."
            }));

        cards.Add(new LearningCard(
            "CLR",
            "Le CLR est le moteur d'execution de .NET.",
            new List<string>
            {
                "Il gere la memoire.",
                "Il gere les exceptions.",
                "Il execute le programme compile."
            }));

        cards.Add(new LearningCard(
            "IL et JIT",
            "Le programme C# est compile en IL, puis le JIT le transforme en code machine.",
            new List<string>
            {
                "Le IL est un langage intermediaire.",
                "Le JIT travaille au moment de l'execution.",
                "Cette etape permet une execution adaptee a la machine."
            }));

        cards.Add(new LearningCard(
            "Ce que je retiens",
            "C# est un bon compromis entre structure, securite et productivite.",
            new List<string>
            {
                "Il est plus encadre que C++ pour la memoire.",
                "Il est bien integre a la plateforme .NET.",
                "Il permet de produire rapidement un premier increment."
            }));

        return cards;
    }

    static void PrintCard(LearningCard card)
    {
        Console.WriteLine(card.Title);
        Console.WriteLine(card.Definition);

        foreach (string idea in card.KeyIdeas)
        {
            Console.WriteLine("- " + idea);
        }

        Console.WriteLine();
    }
}

class LearningCard
{
    public string Title { get; set; }
    public string Definition { get; set; }
    public List<string> KeyIdeas { get; set; }

    public LearningCard(string title, string definition, List<string> keyIdeas)
    {
        Title = title;
        Definition = definition;
        KeyIdeas = keyIdeas;
    }
}
