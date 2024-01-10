namespace GestionBibliothequeTests;
using GestionBibliotheque.model;

[TestClass]
public class BibliothequesTests
{
    [TestClass]
    public class BibliothequeTests
    {
        [TestMethod]
        public void AddBook_Does_Not_Allow_Duplicates()
        {
            // Arrange
            var initialBooks = new List<Livre>
            {
                new Livre("Titre1", "Auteur1", 123),
                new Livre("Titre2", "Auteur2", 456)
            };
            var bibliotheque = new Bibliotheque(initialBooks);

            // Act & Asserts
            try
            {
                bibliotheque.addBook("Titre1", "Auteur1", 123);
                Assert.Fail("Aucune exception n'a été levée pour un doublon.");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Un livre avec le même titre, auteur et ISBN existe déjà.", ex.Message);
            }
            catch (Exception)
            {
                Assert.Fail("Une exception inattendue a été levée.");
            }
        }

        [TestMethod]
        public void DeleteBook_Removes_Book_When_Exists()
        {
            // Arrange
            var initialBooks = new List<Livre>
            {
                new Livre("Titre1", "Auteur1", 123),
                new Livre("Titre2", "Auteur2", 456)
            };

            var bibliotheque = new Bibliotheque(initialBooks);
            int isbnToDelete = 123;

            // Act
            bibliotheque.deleteBook(isbnToDelete);

            // Assert
            Assert.IsFalse(bibliotheque.m_livres.Any(book => book.m_isbn == isbnToDelete), "Le livre n'a pas été correctement supprimé.");
        }

        [TestMethod]
        public void SearchBook_Finds_Books_By_Title()
        {
            // Arrange
            var initialBooks = new List<Livre>
            {
                new Livre("Titre1", "Auteur1", 123),
                new Livre("Titre2", "Auteur2", 456),
                new Livre("Titre1", "Auteur3", 789)
            };

            var bibliotheque = new Bibliotheque(initialBooks);
            string titleToSearch = "Titre1";

            // Act
            var result = bibliotheque.searchBook(1, titleToSearch);

            // Assert
            Assert.AreEqual(2, result.Count, "Le nombre de livres trouvés par titre est incorrect.");
            Assert.IsTrue(result.All(book => book.m_titre == titleToSearch), "Tous les livres trouvés doivent avoir le titre recherché.");
        }

        [TestMethod]
        public void SearchBook_Finds_Books_By_Author()
        {
            // Arrange
            var initialBooks = new List<Livre>
            {
                new Livre("Titre1", "Auteur1", 123),
                new Livre("Titre2", "Auteur2", 456),
                new Livre("Titre3", "Auteur1", 789)
            };
            var bibliotheque = new Bibliotheque(initialBooks);
            string authorToSearch = "Auteur1";

            // Act
            var result = bibliotheque.searchBook(2, authorToSearch);

            // Assert
            Assert.AreEqual(2, result.Count, "Le nombre de livres trouvés par auteur est incorrect.");
            Assert.IsTrue(result.All(book => book.m_auteur == authorToSearch), "Tous les livres trouvés doivent avoir l'auteur recherché.");
        }
    }
}
