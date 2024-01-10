namespace GestionBibliothequeTests;
using GestionBibliotheque.model;

[TestClass]
public class LivresTests
{
    [TestClass]
    public class LivreTests
    {
        [TestMethod]
        public void Livre_Propertie_Title_Are_Correctly_Initialized()
        {
            // Arrange
            var title = "Test";
            var author = "Theo";
            var isbn = 123456;

            // Act
            var livre = new Livre(title, author, isbn);

            // Assert
            Assert.AreEqual(title, livre.m_titre, "Le titre n'est pas correctement initialisé.");
        }

        [TestMethod]
        public void Livre_Propertie_Author_Are_Correctly_Initialized()
        {
            // Arrange
            var title = "Test";
            var author = "Theo";
            var isbn = 123456;

            // Act
            var livre = new Livre(title, author, isbn);

            // Assert
            Assert.AreEqual(author, livre.m_auteur, "L'auteur n'est pas correctement initialisé.");
        }

        [TestMethod]
        public void Livre_Propertie_ISBN_Are_Correctly_Initialized()
        {
            // Arrange
            var title = "Test";
            var author = "Theo";
            var isbn = 123456;

            // Act
            var livre = new Livre(title, author, isbn);

            // Assert
            Assert.AreEqual(isbn, livre.m_isbn, "L'ISBN n'est pas correctement initialisé.");
        }
    }
}
