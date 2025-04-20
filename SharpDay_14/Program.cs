namespace DefaultNamespace;

public class Program
{

    public static void Main(string[] args)
    {
        Livre monLivre = new Livre();

        monLivre.Titre = "60 Days of Progress";
        monLivre.Auteur = "Randall Clark";
        monLivre.NombreDePages = 250;
        
        Console.WriteLine("Le titre du livre est " + monLivre.Titre);
        Console.WriteLine("Son auteur est " + monLivre.Auteur);
        Console.WriteLine("Il compte " + monLivre.NombreDePages);
    }
    ﻿
    // TODO, étape 1 : instancier un objet de la classe Livre et affecter cet objet à une variable nommée monLivre
    // // TODO, étape 2 : affecter une valeur aux champs titre, auteur et nombre de pages de votre objet
    // // Afficher le contenu des champs de cet objet 

}