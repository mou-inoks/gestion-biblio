using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBibliotheque.model
{
    public class Livre
    {
        public string m_titre { get; set; }
        public string m_auteur { get; set; }
        public int m_isbn { get; set; }

        public Livre(string Titre, string Auteur, int ISBN)
        {
            m_titre = Titre;
            m_auteur = Auteur;
            m_isbn = ISBN;
        }
    }
}
