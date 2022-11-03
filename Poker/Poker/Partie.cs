using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    internal class Partie
    {
        List<Joueur> joueurs;
        int indiceJoueurCourant =0;
        Paquet lePaquet;
        int tour;

        public Partie(List<Joueur> joueurs, Paquet lePaquet)
        {
            this.joueurs = joueurs;
            this.lePaquet = lePaquet;
        }
        public void JouerTour()
        {
            this.tour = 0;
            bool verif;
            int choix;
            do
            {
                Console.Clear();
                Console.WriteLine("Que voulez-vous faire");
                Console.WriteLine("1: Miser");
                Console.WriteLine("2: Check");
                Console.WriteLine("3: Call");
                Console.WriteLine("4: Raise");
                Console.WriteLine("5: Coucher");
                verif = int.TryParse(Console.ReadLine(), out choix);
            }
            while (verif == false && choix > 5 || 0 < choix);


            for (int i = 0; i < this.joueurs.Count(); i++)
            {
                switch (choix)
                {
                    case 1:
                        this.joueurs[i].Miser(this.joueurs[i].argent);
                        break;
                    case 2:
                        this.joueurs[i].Check();
                        break;
                    case 3:
                        this.joueurs[i].Call();
                        break;
                    case 4:
                        this.joueurs[i].Raise(this.joueurs[i].argent);
                        break;
                    case 5:
                        this.joueurs[i].Coucher();
                        break;
                }
            }
        }
        public int GetGagnant(List<Joueur> joueurs)
        {
            throw new NotImplementedException();
        }
        public void AfficherJeu()
        {
            //table de jeux
            Console.SetCursorPosition(15, 13);
            Console.WriteLine("------------------------------------------------------------------------------------");
            for (int i = 0; i < 11; i++)
            {
                Console.SetCursorPosition(15, 14 + i);
                Console.WriteLine("|                                                                                  |");
            }
            Console.SetCursorPosition(15, 25);
            Console.WriteLine("------------------------------------------------------------------------------------");


            //carte du millieux
            Console.SetCursorPosition(20, 16);
            Console.WriteLine("----------      ----------      ----------      ----------      ----------");
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(20, 17 + i);
                Console.WriteLine("|        |      |        |      |        |      |        |      |        |");
            }
            Console.SetCursorPosition(20, 22);
            Console.WriteLine("----------      ----------      ----------      ----------      ----------");



            //nom joueur 1

            Console.SetCursorPosition(20, 1);
            Console.WriteLine("montent jour11");

            //montent joueur 1

            Console.SetCursorPosition(36, 1);
            Console.WriteLine("nom joueur");

            //premier carte joueur 1

            Console.SetCursorPosition(20, 3);
            Console.WriteLine("----------");
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(20, 4 + i);
                Console.WriteLine("|        |");
            }
            Console.SetCursorPosition(20, 9);
            Console.WriteLine("----------");

            //deuxiem carete joueur 1

            Console.SetCursorPosition(36, 3);
            Console.WriteLine("----------");
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(36, 4 + i);
                Console.WriteLine("|        |");
            }
            Console.SetCursorPosition(36, 9);
            Console.WriteLine("----------");
            //-------------------------------

            //nom joueur 2

            Console.SetCursorPosition(68, 1);
            Console.WriteLine("nom joueur2");

            //montent joueur 1

            Console.SetCursorPosition(84, 1);
            Console.WriteLine("montent joueur2");

            //premier carte joueur 1

            Console.SetCursorPosition(68, 3);
            Console.WriteLine("----------");
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(68, 4 + i);
                Console.WriteLine("|        |");
            }
            Console.SetCursorPosition(68, 9);
            Console.WriteLine("----------");

            //deuxiem carete joueur 1

            Console.SetCursorPosition(84, 3);
            Console.WriteLine("----------");
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(84, 4 + i);
                Console.WriteLine("|        |");
            }
            Console.SetCursorPosition(84, 9);
            Console.WriteLine("----------");
            //------------------------------------

            //nom joueur 3

            Console.SetCursorPosition(20, 38);
            Console.WriteLine("montent jour11");

            //montent joueur 3

            Console.SetCursorPosition(36, 38);
            Console.WriteLine("nom joueur");

            //premier carte joueur 3

            Console.SetCursorPosition(20, 30);
            Console.WriteLine("----------");
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(20, 31 + i);
                Console.WriteLine("|        |");
            }
            Console.SetCursorPosition(20, 36);
            Console.WriteLine("----------");

            //deuxiem carete joueur 3

            Console.SetCursorPosition(36, 30);
            Console.WriteLine("----------");
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(36, 31 + i);
                Console.WriteLine("|        |");
            }
            Console.SetCursorPosition(36, 36);
            Console.WriteLine("----------");
            //-------------------------------

            //nom joueur 4

            Console.SetCursorPosition(68, 38);
            Console.WriteLine("nom joueur2");

            //montent joueur 4

            Console.SetCursorPosition(84, 38);
            Console.WriteLine("montent joueur2");

            //premier carte joueur 4

            Console.SetCursorPosition(68, 30);
            Console.WriteLine("----------");
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(68, 31 + i);
                Console.WriteLine("|        |");
            }
            Console.SetCursorPosition(68, 36);
            Console.WriteLine("----------");

            //deuxiem carete joueur 4

            Console.SetCursorPosition(84, 30);
            Console.WriteLine("----------");
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(84, 31 + i);
                Console.WriteLine("|        |");
            }
            Console.SetCursorPosition(84, 36);
            Console.WriteLine("----------");
            //------------------------------------

            //dealer
            Console.SetCursorPosition(1, 15);
            Console.WriteLine("BOB le dealer");
            Console.SetCursorPosition(5, 16);
            Console.WriteLine(" --- ");
            Console.SetCursorPosition(6, 17);
            Console.WriteLine("UwU");
            Console.SetCursorPosition(5, 17);
            Console.WriteLine("|");
            Console.SetCursorPosition(9, 17);
            Console.WriteLine("|");
            Console.SetCursorPosition(5, 18);
            Console.WriteLine(" --- ");
            Console.SetCursorPosition(7, 19);
            Console.WriteLine("|");
            Console.SetCursorPosition(7, 20);
            Console.WriteLine("|");
            Console.SetCursorPosition(8, 20);
            Console.WriteLine("/");
            Console.SetCursorPosition(9, 19);
            Console.WriteLine("/");
            Console.SetCursorPosition(10, 18);
            Console.WriteLine("/");
            Console.SetCursorPosition(7, 21);
            Console.WriteLine("|");
            Console.SetCursorPosition(6, 22);
            Console.WriteLine("/");
            Console.SetCursorPosition(8, 22);
            Console.WriteLine("|");
            Console.SetCursorPosition(5, 23);
            Console.WriteLine("/");
            Console.SetCursorPosition(8, 23);
            Console.WriteLine("|");
        }
        public void UpdateGagnant(Joueur j)
        {
            throw new NotImplementedException();
        }
        public bool FinPartie()
        {
            throw new NotImplementedException();
        }
    }
}
