using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBibliotheque.model
{
    public class Bibliotheque
    {
        public List<Livre> m_livres = new List<Livre>();

        public Bibliotheque(List<Livre> Livre)
        {
            m_livres = Livre;
        }

        public void addBook(string title, string author, int isbn)
        {
            bool isDuplicate = m_livres.Any(livre => livre.m_titre == title && livre.m_auteur == author && livre.m_isbn == isbn);

            if (!isDuplicate)
            {
                Livre newLivre = new Livre(title, author, isbn);
                m_livres.Add(newLivre);
                Console.WriteLine("Livre ajouté avec succès.");
            }
            else
            {
                throw new ArgumentException("Un livre avec le même titre, auteur et ISBN existe déjà.");
            }
        }

        public void deleteBook(int isbn)
        {
            int removedCount = m_livres.RemoveAll(element => element.m_isbn == isbn);

            if (removedCount > 0)
            {
                Console.WriteLine("Le livre a été supprimé.");
            }
            else
            {
                throw new KeyNotFoundException("Aucun livre trouvé avec cet ISBN.");
            }
        }

        public List<Livre> searchBook(int userChoice, string request)
        {
            List<Livre> searchedBooks = new List<Livre>();

            if (userChoice == 1)
            {
                searchedBooks = m_livres.FindAll(element => element.m_titre == request);
            }
            else if (userChoice == 2)
            {
                searchedBooks = m_livres.FindAll(element => element.m_auteur == request);
            }

            if (searchedBooks.Any())
            {
                Console.WriteLine("Livre(s) trouvé(s) :");
                foreach (Livre livre in searchedBooks)
                {
                    Console.WriteLine($"Titre: {livre.m_titre}, Auteur: {livre.m_auteur}, ISBN: {livre.m_isbn}");
                }
            } else
            {
                Console.WriteLine("Aucun livre trouvé");
            }

            return searchedBooks;
        }

    }
}
