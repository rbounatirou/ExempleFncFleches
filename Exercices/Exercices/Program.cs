namespace Exercices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // NE PAS TOUCHER AU CONTENU DE LA METHODE MAIN
            List<Personne> list = new List<Personne>();
            list.Add(new Personne("Ananas", "Louis", 18));
            list.Add(new Personne("Cerise", "Bertrand", 15));
            list.Add(new Personne("Banane", "Gilles", 23));
            list.Add(new Personne("Poire", "Marie-Helene", 16));
         
            
            RQ1(list);
            RQ2(list);
            RQ3(list);
            list.Add(new Personne("Poire", "Aurelie",16));
            RQ4(list);
            RQ5(list);
            RQ6(list);

            Console.WriteLine("Resultat attendu : false");
            Solution_RQ7(list);
            Console.WriteLine("Resultat attendu: true");
            list.Add(new Personne("POMME", "Olivier", 35));
            Solution_RQ7(list);
            Solution_RQ8(list);
            List<int> nbrs = new List<int> { 1, 5, 2, 3, 4, 8, 9 };
            RQ9(nbrs);
        }

        /*
        Trie la liste en paramètre par ordre d'age.
        Résultat attendu:

        Louis>Bertrand>Gilles>Aurelie
        */
        static void RQ1(List<Personne> p)
        {
            Console.WriteLine("--Requete 1-- Age par ordre croissant");
            // -- REQUETE ICI (1 ligne)


            // ---- FIN REQUETE
            AfficherListe(p);
        }

        
        /*
         Trie la liste par Nom par ordre alphabétique:
        Résultat attendu:
        Louis>Gilles>Bertrand>Marie-Helene
        */
        static void RQ2(List<Personne> p)
        {
            Console.WriteLine("--Requete 2-- Nom par ordre alphabetique");
            // -- REQUETE ICI (1 ligne)


            // ---- FIN REQUETE
            AfficherListe(p);
        }

        /* Selectionner uniquement les personnes majeures
         * Résultat:
         * Louis > Gilles
         */
        static void RQ3(List<Personne> p)
        {
            Console.WriteLine("--Requete 3-- Personnes majeures uniquement");
            List<Personne> personnesMajeures = new List<Personne>();
            // -- REQUETE ICI (1 ligne)
            

            // ---- FIN REQUETE
            AfficherListe(personnesMajeures);            
        }
        /* Trier les personnes par nom et en cas de nom identique par prenom
          Résultat :
            Louis>Gilles>Bertrand>Aurelie>Marie-Helene
        */
        static void RQ4(List<Personne> p)
        {
            Console.WriteLine("--Requete 4-- NOM et Prenom par ordre alphabetique ");
            // -- REQUETE ICI


            // ---- FIN REQUETE
            AfficherListe(p);
        }

        /* Passer le nom de gens tout en majuscule (UpperCase) 
         1 ligne de code seulement */
        static void RQ5(List<Personne> p)
        {
            Console.WriteLine("--Requete 5-- NOM EN MAJUSCULE ");
            // -- REQUETE ICI (1 ligne)
           

            // ---- FIN REQUETE
            AfficherListe(p);
        }

        /* Somme des ages, sans utiliser IEnumerable
         * Résultat attendu: 88
         */
        static void RQ6(List<Personne> p)
        {
            Console.WriteLine("--Requete 6-- Somme des ages ");
            long age = 0;
            // -- REQUETE ICI (1 ligne)


            // ---- FIN REQUETE
            Console.WriteLine(age);
        }



        /* Savoir si une personne de plus de 30 ans existe
         * Fonction joué deux fois 
         * False la première fois
         * True la deuxième fois */
        static void RQ7(List<Personne> p)
        {
            Console.WriteLine("-Requete 7 -- Personne plus de 30 ans existe");
            bool result=false;
            // REQUETE ICI (1 lignes)
           

            // FIN REQUETE
            Console.WriteLine(result);
        }


        /* Retire de la liste poire aurelie, 
         * la requete ne doit pas tenir compte de la casse */
        static void RQ8(List<Personne> p)
        {
            Console.WriteLine("Requete 8 -- Retier POIRE Aurelie");
            // REQUETE ICI (1 lignes)


            // FIN REQUETE
            AfficherListe(p);
        }

        static void RQ9(List<int> nb)
        {
            Console.WriteLine("-Requete -- Division par deux des nombres");

            // REQUETE ICI (2 lignes)


            // FIN REQUETE
        }


        static void AfficherListe(List<Personne> p) => AfficherListe<Personne>(p);

        static void AfficherListe<T>(List<T> p)
        {
            p.ForEach(x => Console.WriteLine(x));
        }

        #region solutions
        static void Solution_RQ1(List<Personne> p)
        {
            Console.WriteLine("--Requete 1-- Age par ordre croissant");
            // -- REQUETE ICI
            p.Sort((a, b) => a.age - b.age);

            // ---- FIN REQUETE
            AfficherListe(p);
        }

        static void Solution_RQ2(List<Personne> p)
        {
            Console.WriteLine("--Requete 2--");
            // -- REQUETE ICI
            p.Sort((a, b) => a.nom.CompareTo(b.nom));
            // ---- FIN REQUETE
            AfficherListe(p);
        }

        static void Solution_RQ3(List<Personne> p)
        {
            Console.WriteLine("--Requete 3--");
            List<Personne> personnesMajeures = new List<Personne>();
            // -- REQUETE ICI
            personnesMajeures = p.FindAll(x => x.age >= 18);
            // ---- FIN REQUETE
            AfficherListe(personnesMajeures);
        }

        static void Solution_RQ4(List<Personne> p)
        {
            Console.WriteLine("--Requete 4-- NOM et Prenom par ordre alphabetique ");
            // -- REQUETE ICI (1 ligne)
            p.Sort((a, b) => { int orderNom= a.nom.CompareTo(b.nom);
                return (orderNom != 0 ? orderNom : a.prenom.CompareTo(b.prenom));
            });
            // ---- FIN REQUETE
            AfficherListe(p);
        }
        static void Solution_RQ5(List<Personne> p)
        {
            Console.WriteLine("--Requete 5-- NOM EN MAJUSCULE ");
            // -- REQUETE ICI
            p.ForEach(x => x.ChangerNom(x.nom.ToUpper()));
            // ---- FIN REQUETE
            AfficherListe(p);
        }

        static void Solution_RQ6(List<Personne> p)
        {
            Console.WriteLine("--Requete 6-- Age total ");
            long age = 0;
            // -- REQUETE ICI
            p.ForEach(x => age += x.age);
            // ---- FIN REQUETE
            Console.WriteLine(age);
        }

        static void Solution_RQ7(List<Personne> p)
        {
            Console.WriteLine("-Requete 7 -- Personne plus de 30 ans existe");
            bool result;
            // REQUETE ICI (1 lignes)
            result = p.Exists(x => x.age > 30);

            // FIN REQUETE
            Console.WriteLine(result);
        }

        static void Solution_RQ8(List<Personne> p)
        {
            Console.WriteLine("Requete 8 -- Retier POIRE Aurelie");
            p.RemoveAll(x => x.nom.ToLower() == "poire" && x.prenom.ToLower() == "aurelie");
            AfficherListe(p);
        }

        static void Solution_RQ9(List<int> nb)
        {
            Console.WriteLine("-Requete 9-- Division par deux des nombres");

            List<double> rt = new();
            nb.ForEach(i=>rt.Add(i/2.0D));

            AfficherListe<double>(rt);
        }
        #endregion
    }
}