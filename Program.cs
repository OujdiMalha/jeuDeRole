using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeuDeRole
{
    class programm
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Jouer(Personnage monPerso)
        {
            Monstre monstre = new Monstre("Loup enragé");
            bool victoire = true;
            bool suivant = false;

            while (!monstre.EstMort())
            {
                // tour du monstre
                Console.ForegroundColor = ConsoleColor.Red;
                monstre.Attaquer(monPerso);
                Console.WriteLine();
                Console.ReadKey(true);

                if (monstre.EstMort())
                {
                    victoire = false;
                    break;
                }

                // tour du personnage
                Console.ForegroundColor = ConsoleColor.Green;
                monstre.Attaquer(monstre);
                Console.WriteLine();
                Console.ReadKey(true);

                if(victoire)
                {
                    monPerso.gagnerExperience(5);

                    Console.ForegroundColor= ConsoleColor.Blue;
                    Console.WriteLine();
                    Console.ReadKey(true);
                    Console.WriteLine(monPerso.Caracteristiques());

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine();

                    while (!suivant)
                    {
                        Console.WriteLine("Salle suivante ? (O/N)");
                        string saisie = Console.ReadLine().ToUpper();
                        if(saisie == "O")
                        {
                            suivant = true;
                            Jouer(monPerso);
                        }
                        else if(saisie == "N")
                        {
                            Environment.Exit(0);
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine();
                    Console.WriteLine("C'est perdu ....");
                    Console.ReadKey();
                }
            }
        }
        static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Le jeu");
            Console.WriteLine();
            Console.WriteLine("Coisis ta classe :");
            Console.WriteLine("1. Guerrier");
            Console.WriteLine("2. Sorcier");
            Console.WriteLine("3. Archer");
            Console.WriteLine("4. Quitter");
            Console.WriteLine();


            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Vous avez choisis Guerrier !");
                    Console.WriteLine();
                    Jouer(new Guerrier("Pentiminax"));
                    break;

                    case "2":
                    Console.WriteLine("Vous avez choisis Sorcier !");
                    Console.WriteLine();
                    Jouer(new Sorcier("Pentiminax"));
                    break;

                case "3":
                    Console.WriteLine("Vous avez choisis Archer !");
                    Console.WriteLine();
                    Jouer(new Archer("Pentiminax"));
                    break;

                    case "4":
                    break;

            }
        }
        
    }
}
