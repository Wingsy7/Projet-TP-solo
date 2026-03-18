using System;

class Tp3
{
    static void Main(string[] args)
    {
        // Classe + objet
        Router router = new Router();
        router.Name = "Cisco ISR 4331";
        router.Gamme = "Integrated Services Routers";
        router.DisplayInfo();

        Console.WriteLine();

        // Constructeur
        Switch switchCisco = new Switch("Cisco 2960", "LAN", 2);
        switchCisco.DisplayInfo();

        Console.WriteLine();

        // Encapsulation + propriete
        Compte compte = new Compte();
        compte.Deposer(200);
        Console.WriteLine("Solde du compte : " + compte.Solde);

        Console.WriteLine();

        // Heritage
        Chien chien = new Chien();
        chien.Manger();
        chien.Aboyer();

        Console.WriteLine();

        // Polymorphisme
        Firewall firewall = new Asa("Cisco ASA 5506-X");
        firewall.FilterTraffic();

        Console.WriteLine();

        // Classe abstraite
        Forme forme = new Rectangle(5, 3);
        Console.WriteLine("Aire du rectangle : " + forme.Aire());

        Console.WriteLine();

        // Interface
        DellPowerEdge serveur = new DellPowerEdge();
        serveur.HostApplication("GLPI");
        serveur.HostDatabase("MySQL");
        serveur.HostNetworkService("DHCP");
    }
}

// Une classe sert de modele
class Router
{
    public string Name;
    public string Gamme;

    public void DisplayInfo()
    {
        Console.WriteLine("Routeur : " + Name);
        Console.WriteLine("Gamme : " + Gamme);
    }
}

// Le constructeur initialise l'objet
class Switch
{
    public string Name;
    public string Use;
    public int Layer;

    public Switch(string name, string use, int layer)
    {
        Name = name;
        Use = use;
        Layer = layer;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Switch : " + Name);
        Console.WriteLine("Usage : " + Use);
        Console.WriteLine("Layer : " + Layer);
    }
}

// L'encapsulation protege la valeur de la modification directement
class Compte
{
    public double Solde { get; private set; }

    public void Deposer(double montant)
    {
        Solde += montant;
    }
}

// Heritage : Chien recupere Manger depuis Animal et ajoute Aboyer
class Animal
{
    public void Manger()
    {
        Console.WriteLine("Je mange");
    }
}

class Chien : Animal
{
    public void Aboyer()
    {
        Console.WriteLine("Wouf");
    }
}

// Polymorphisme : la methode change selon la classe concrete malgre le meme nom
class Firewall
{
    public string Name;

    public Firewall(string name)
    {
        Name = name;
    }

    public virtual void FilterTraffic()
    {
        Console.WriteLine(Name + " filtre le trafic");
    }
}

class Asa : Firewall
{
    public Asa(string name) : base(name)
    {
    }

    public override void FilterTraffic()
    {
        Console.WriteLine(Name + " filtre le trafic de facon avancee");
    }
}

// Une classe abstraite sert de base mais ne peut pas etre instantiee
abstract class Forme
{
    public abstract double Aire();
}

class Rectangle : Forme
{
    public double Largeur;
    public double Hauteur;

    public Rectangle(double largeur, double hauteur)
    {
        Largeur = largeur;
        Hauteur = hauteur;
    }

    public override double Aire()
    {
        return Largeur * Hauteur;
    }
}

// Une interface impose des methodes sans implementation, les classes qui l'implementent doivent les definir
interface IServerRack
{
    void HostApplication(string name);
    void HostDatabase(string name);
    void HostNetworkService(string name);
}

class DellPowerEdge : IServerRack
{
    public void HostApplication(string name)
    {
        Console.WriteLine("Application hebergee : " + name);
    }

    public void HostDatabase(string name)
    {
        Console.WriteLine("Base hebergee : " + name);
    }

    public void HostNetworkService(string name)
    {
        Console.WriteLine("Service reseau heberge : " + name);
    }
}
