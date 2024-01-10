using GestionBibliotheque.model;
using System.Collections.Generic;

Livre testLivre = new Livre("test", "test2", 333);
List<Livre> livre = new List<Livre> { testLivre };
Bibliotheque bibliotheque = new Bibliotheque(livre);        

bool running = true;

while (running)
{
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Gestion bibliotheque");
    Console.WriteLine("Que voulez vous faire ?");
    Console.WriteLine("1. Ajouter livre");
    Console.WriteLine("2. Supprimer livre");
    Console.WriteLine("3. Rechercher livre");
    Console.WriteLine("4. Quitter le programme");

    int userChoice = Convert.ToInt32(Console.ReadLine());

    if (userChoice == 1)
    {
        string title;
        string author;
        int isbn;

        Console.WriteLine("Ajout de livre");
        Console.WriteLine();
        Console.WriteLine("Merci de saisir le titre du livre :");
        title = Console.ReadLine();
        Console.WriteLine("Merci de saisir l'auteur :");
        author = Console.ReadLine();
        Console.WriteLine("Merci de saisir l'isbn :");
        isbn = Convert.ToInt32(Console.ReadLine());
        bibliotheque.addBook(title, author, isbn);
    }
    else if (userChoice == 2)
    {
        Console.WriteLine("Suppression de livre");
        Console.WriteLine();
        Console.WriteLine("Merci de saisir L'ISBN du livre à supprimer :");
        int isbn = Convert.ToInt32(Console.ReadLine());
        bibliotheque.deleteBook(isbn);
    }
    else if (userChoice == 3)
    {
        int userChoiceSearch;
        string userRequest;
        Console.WriteLine("Rechercher de livre");
        Console.WriteLine("1. Rechercher par titre");
        Console.WriteLine("2. Rechercher par auteur");
        userChoiceSearch = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Merci d'entrer la requete de la recherche :");
        userRequest = Console.ReadLine();
        bibliotheque.searchBook(userChoiceSearch, userRequest);
    }
    else if (userChoice == 4)
    {
        running = false;
    }
}

Environment.Exit(0);
