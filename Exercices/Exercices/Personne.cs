using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    internal class Personne
    {
        public string nom { get; private set; }
        public string prenom { get; private set; }
        public int age { get; private set; }

        public Personne(string nom, string prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
        }

        public void ChangerNom(string nom)
        {
            this.nom = nom;
        }

        public override string ToString()
        {
            return String.Format("Nom: {0}, Prenom: {1}, Age: {2}", nom, prenom, age);
        }
    }
}
