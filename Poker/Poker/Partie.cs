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
        Joueur[] joueurs = new Joueur[4];
        int indiceJoueurCourant =0;
        Paquet lePaquet;
        int tour;

        public Partie(Joueur[] joueurs, Paquet lePaquet)
        {
            this.joueurs = joueurs;
            this.lePaquet = lePaquet;
            
        }
        public void JouerTour()
        {
            this.tour = 0;
            bool verif;
            int choix;
            for (int i = 0; i < this.joueurs.Count(); i++)
            {
                do
                {
                    Console.Clear();
                    AfficherJeu();
                    Console.WriteLine("Que voulez-vous faire " + this.joueurs[i].nom);
                    Console.WriteLine("1: Miser");
                    Console.WriteLine("2: Check");
                    Console.WriteLine("3: Call");
                    Console.WriteLine("4: Raise");
                    Console.WriteLine("5: Coucher");
                    verif = int.TryParse(Console.ReadLine(), out choix);
                }
                while (verif == false && choix < 5 || 0 > choix);
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
            Carte[] river = new Carte[5];

            for (int i = 0; i < river.Length; i++)
            {
                river[i] = this.lePaquet.GetTopCarte();
            }


            ///table de jeux
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(15, 13);
            Console.WriteLine("------------------------------------------------------------------------------------");
            for (int i = 0; i < 11; i++)
            {
                Console.SetCursorPosition(15, 14 + i);
                Console.WriteLine("|                                                                                  |");
            }
            Console.SetCursorPosition(15, 25);
            Console.WriteLine("------------------------------------------------------------------------------------");
            //-------------------------------------------------------

            if (this.tour == 1)
            {
                river[0].Retoruner();
                river[1].Retoruner();
                river[2].Retoruner();
            }
            if (this.tour == 2)
            {
                river[3].Retoruner();
            }
            if (this.tour == 3)
            {
                river[4].Retoruner();
            }

            //carte1
            if (river[0].visible == false)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(20, 16);
                Console.WriteLine("----------");
                for (int i = 0; i < 5; i++)
                {
                    Console.SetCursorPosition(20, 17 + i);
                    Console.WriteLine("|        |");
                }
                Console.SetCursorPosition(20, 22);
                Console.WriteLine("----------");
            }

            else
            {
                CouleurAffichage(river[0]);
                Console.SetCursorPosition(20, 16);
                Console.WriteLine(nombreCarte(river[0]) + "" + FormeCarte(river[0]));
                Console.SetCursorPosition(28, 22);
                Console.WriteLine(nombreCarte(river[0]) + "" + FormeCarte(river[0]));

                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(20, 16);
                Console.WriteLine("----------");
                for (int i = 0; i < 5; i++)
                {
                    Console.SetCursorPosition(20, 17 + i);
                    Console.WriteLine("|        |");
                }
                Console.SetCursorPosition(20, 22);
                Console.WriteLine("----------");
            }

            //carte2
            if (river[1].visible == false)
            {
                Console.SetCursorPosition(36, 16);
                Console.WriteLine("----------");
                for (int i = 0; i < 5; i++)
                {
                    Console.SetCursorPosition(36, 17 + i);
                    Console.WriteLine("|        |");
                }
                Console.SetCursorPosition(36, 22);
                Console.WriteLine("----------");
            }
            else
            {
                CouleurAffichage(river[1]);
                Console.SetCursorPosition(36, 16);
                Console.WriteLine(nombreCarte(river[1]) + "" + FormeCarte(river[1]));
                Console.SetCursorPosition(44, 22);
                Console.WriteLine(nombreCarte(river[1]) + "" + FormeCarte(river[1]));

                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(36, 16);
                Console.WriteLine("----------");
                for (int i = 0; i < 5; i++)
                {
                    Console.SetCursorPosition(36, 17 + i);
                    Console.WriteLine("|        |");
                }
                Console.SetCursorPosition(36, 22);
                Console.WriteLine("----------");
            }


            //carte3
            if (river[2].visible == false)
            {
                Console.SetCursorPosition(52, 16);
                Console.WriteLine("----------");
                for (int i = 0; i < 5; i++)
                {
                    Console.SetCursorPosition(52, 17 + i);
                    Console.WriteLine("|        |");
                }
                Console.SetCursorPosition(52, 22);
                Console.WriteLine("----------");
            }
            else
            {
                CouleurAffichage(river[2]);
                Console.SetCursorPosition(52, 16);
                Console.WriteLine(nombreCarte(river[2]) + "" + FormeCarte(river[2]));
                Console.SetCursorPosition(60, 22);
                Console.WriteLine(nombreCarte(river[2]) + "" + FormeCarte(river[2]));

                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(52, 16);
                Console.WriteLine("----------");
                for (int i = 0; i < 5; i++)
                {
                    Console.SetCursorPosition(52, 17 + i);
                    Console.WriteLine("|        |");
                }
                Console.SetCursorPosition(52, 22);
                Console.WriteLine("----------");
            }


            //carte4
            if (river[3].visible == false)
            {
                Console.SetCursorPosition(68, 16);
                Console.WriteLine("----------");
                for (int i = 0; i < 5; i++)
                {
                    Console.SetCursorPosition(68, 17 + i);
                    Console.WriteLine("|        |");
                }
                Console.SetCursorPosition(68, 22);
                Console.WriteLine("----------");
            }
            else
            {
                CouleurAffichage(river[3]);
                Console.SetCursorPosition(68, 16);
                Console.WriteLine(nombreCarte(river[3]) + "" + FormeCarte(river[3]));
                Console.SetCursorPosition(76, 22);
                Console.WriteLine(nombreCarte(river[3]) + "" + FormeCarte(river[3]));

                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(68, 16);
                Console.WriteLine("----------");
                for (int i = 0; i < 5; i++)
                {
                    Console.SetCursorPosition(68, 17 + i);
                    Console.WriteLine("|        |");
                }
                Console.SetCursorPosition(68, 22);
                Console.WriteLine("----------");
            }


            //carte5
            if (river[4].visible == false)
            {
                Console.SetCursorPosition(84, 16);
                Console.WriteLine("----------");
                for (int i = 0; i < 5; i++)
                {
                    Console.SetCursorPosition(84, 17 + i);
                    Console.WriteLine("|        |");
                }
                Console.SetCursorPosition(84, 22);
                Console.WriteLine("----------");
            }
            else
            {
                CouleurAffichage(river[4]);
                Console.SetCursorPosition(84, 16);
                Console.WriteLine(nombreCarte(river[4]) + "" + FormeCarte(river[4]));
                Console.SetCursorPosition(92, 22);
                Console.WriteLine(nombreCarte(river[4]) + "" + FormeCarte(river[4]));

                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(84, 16);
                Console.WriteLine("----------");
                for (int i = 0; i < 5; i++)
                {
                    Console.SetCursorPosition(84, 17 + i);
                    Console.WriteLine("|        |");
                }
                Console.SetCursorPosition(84, 22);
                Console.WriteLine("----------");
            }

            //-------------------------



            //nom joueur 1
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(20, 1);
            Console.WriteLine(this.joueurs[0].pseudo);

            //montent joueur 1

            Console.SetCursorPosition(36, 1);
            Console.WriteLine(this.joueurs[0].argent);

            //premier carte joueur 1


            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(20, 3);
            Console.WriteLine("----------");
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(20, 4 + i);
                Console.WriteLine("|        |");
            }
            Console.SetCursorPosition(20, 9);
            Console.WriteLine("----------");

            CouleurAffichage(this.joueurs[0].maMain.cartes.Item1);
            Console.SetCursorPosition(20, 3);
            Console.WriteLine(nombreCarte(this.joueurs[0].maMain.cartes.Item1) + " " + FormeCarte(this.joueurs[0].maMain.cartes.Item1));
            Console.SetCursorPosition(28, 9);
            Console.WriteLine(nombreCarte(this.joueurs[0].maMain.cartes.Item1) + " " + FormeCarte(this.joueurs[0].maMain.cartes.Item1));
            //this.joueurs[0].cart1

            //deuxiem carete joueur 1

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(36, 3);
            Console.WriteLine("----------");
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(36, 4 + i);
                Console.WriteLine("|        |");
            }
            Console.SetCursorPosition(36, 9);
            Console.WriteLine("----------");

            CouleurAffichage(this.joueurs[0].maMain.cartes.Item2);
            Console.SetCursorPosition(36, 3);
            Console.WriteLine(nombreCarte(this.joueurs[0].maMain.cartes.Item2) + " " + FormeCarte(this.joueurs[0].maMain.cartes.Item2));
            Console.SetCursorPosition(44, 9);
            Console.WriteLine(nombreCarte(this.joueurs[0].maMain.cartes.Item2) + " " + FormeCarte(this.joueurs[0].maMain.cartes.Item2));
            //this.joueurs[0].cart1
            //-------------------------------

            //nom joueur 2
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(68, 1);
            Console.WriteLine(this.joueurs[1].pseudo);

            //montent joueur 2

            Console.SetCursorPosition(84, 1);
            Console.WriteLine(this.joueurs[1].argent);

            //premier carte joueur 2

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(68, 3);
            Console.WriteLine("----------");
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(68, 4 + i);
                Console.WriteLine("|        |");
            }
            Console.SetCursorPosition(68, 9);
            Console.WriteLine("----------");

            CouleurAffichage(this.joueurs[1].maMain.cartes.Item1);
            Console.SetCursorPosition(68, 3);
            Console.WriteLine(nombreCarte(this.joueurs[1].maMain.cartes.Item1) + " " + FormeCarte(this.joueurs[1].maMain.cartes.Item1));
            Console.SetCursorPosition(76, 9);
            Console.WriteLine(nombreCarte(this.joueurs[1].maMain.cartes.Item1) + " " + FormeCarte(this.joueurs[1].maMain.cartes.Item1));
            //this.joueurs[1].cart1

            //deuxiem carete joueur 2

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(84, 3);
            Console.WriteLine("----------");
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(84, 4 + i);
                Console.WriteLine("|        |");
            }
            Console.SetCursorPosition(84, 9);
            Console.WriteLine("----------");

            CouleurAffichage(this.joueurs[1].maMain.cartes.Item2);
            Console.SetCursorPosition(84, 3);
            Console.WriteLine(nombreCarte(this.joueurs[1].maMain.cartes.Item2) + " " + FormeCarte(this.joueurs[1].maMain.cartes.Item2));
            Console.SetCursorPosition(92, 9);
            Console.WriteLine(nombreCarte(this.joueurs[1].maMain.cartes.Item2) + " " + FormeCarte(this.joueurs[1].maMain.cartes.Item2));
            //this.joueurs[1].cart1
            //------------------------------------

            //nom joueur 3
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(20, 38);
            Console.WriteLine(this.joueurs[2].argent);

            //montent joueur 3

            Console.SetCursorPosition(36, 38);
            Console.WriteLine(this.joueurs[2].pseudo);

            //premier carte joueur 3

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(20, 30);
            Console.WriteLine("----------");
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(20, 31 + i);
                Console.WriteLine("|        |");
            }
            Console.SetCursorPosition(20, 36);
            Console.WriteLine("----------");

            CouleurAffichage(this.joueurs[2].maMain.cartes.Item1);
            Console.SetCursorPosition(20, 30);
            Console.WriteLine(nombreCarte(this.joueurs[2].maMain.cartes.Item1) + " " + FormeCarte(this.joueurs[2].maMain.cartes.Item1));
            Console.SetCursorPosition(28, 30);
            Console.WriteLine(nombreCarte(this.joueurs[2].maMain.cartes.Item1) + " " + FormeCarte(this.joueurs[2].maMain.cartes.Item1));


            //deuxiem carete joueur 3

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(36, 30);
            Console.WriteLine("----------");
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(36, 31 + i);
                Console.WriteLine("|        |");
            }
            Console.SetCursorPosition(36, 36);
            Console.WriteLine("----------");

            CouleurAffichage(this.joueurs[2].maMain.cartes.Item2);
            Console.SetCursorPosition(36, 30);
            Console.WriteLine(nombreCarte(this.joueurs[2].maMain.cartes.Item2) + " " + FormeCarte(this.joueurs[2].maMain.cartes.Item2));
            Console.SetCursorPosition(44, 30);
            Console.WriteLine(nombreCarte(this.joueurs[2].maMain.cartes.Item2) + " " + FormeCarte(this.joueurs[2].maMain.cartes.Item2));
            //-------------------------------
            //this.joueurs[2].cart1

            //nom joueur 4
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(68, 38);
            Console.WriteLine(this.joueurs[3].pseudo);

            //montent joueur 4

            Console.SetCursorPosition(84, 38);
            Console.WriteLine(this.joueurs[3].argent);

            //premier carte joueur 4

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(68, 30);
            Console.WriteLine("----------");
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(68, 31 + i);
                Console.WriteLine("|        |");
            }
            Console.SetCursorPosition(68, 36);
            Console.WriteLine("----------");

            CouleurAffichage(this.joueurs[3].maMain.cartes.Item1);
            Console.SetCursorPosition(68, 30);
            Console.WriteLine(nombreCarte(this.joueurs[3].maMain.cartes.Item1) + " " + FormeCarte(this.joueurs[3].maMain.cartes.Item1));
            Console.SetCursorPosition(74, 30);
            Console.WriteLine(nombreCarte(this.joueurs[3].maMain.cartes.Item1) + " " + FormeCarte(this.joueurs[3].maMain.cartes.Item1));
            //this.joueurs[3].cart1

            //deuxiem carete joueur 4

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(84, 30);
            Console.WriteLine("----------");
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(84, 31 + i);
                Console.WriteLine("|        |");
            }
            Console.SetCursorPosition(84, 36);
            Console.WriteLine("----------");

            CouleurAffichage(this.joueurs[3].maMain.cartes.Item1);
            Console.SetCursorPosition(84, 30);
            Console.WriteLine(nombreCarte(this.joueurs[3].maMain.cartes.Item2) + " " + FormeCarte(this.joueurs[3].maMain.cartes.Item2));
            Console.SetCursorPosition(92, 30);
            Console.WriteLine(nombreCarte(this.joueurs[3].maMain.cartes.Item2) + " " + FormeCarte(this.joueurs[3].maMain.cartes.Item2));

            //------------------------------------

            //dealer
            Console.BackgroundColor = ConsoleColor.Black;
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
        public void CouleurAffichage(Carte laCarte)
        {
            switch (laCarte.maCouleur)
            {
                case Couleur.Coueur:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    }
                case Couleur.Carreau:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;

                    }

                case Couleur.Pique:
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    }

                case Couleur.Treffle:
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    }

                default:
                    break;
            }
        }
        public char FormeCarte(Carte laCarte)
        {
            char caractere;
            switch (laCarte.maCouleur)
            {
                case Couleur.Coueur:
                    {
                        caractere = ('\u2665');
                        break;
                    }
                case Couleur.Carreau:
                    {
                        caractere = ('\u2666'); ;
                        break;

                    }

                case Couleur.Pique:
                    {
                        caractere = ('\u2660');
                        break;
                    }

                case Couleur.Treffle:
                    {
                        caractere = ('\u2663');
                        break;
                    }

                default:
                    {
                        caractere = ('a');
                        break;
                    }


            }
            return caractere;
        }
        public string nombreCarte(Carte laCarte)
        {
            string nombre;
            switch (laCarte.maValeur)
            {
                case Valeur.Deux:
                    {
                        nombre = "2";
                        break;
                    }
                case Valeur.Trois:
                    {
                        nombre = "3";
                        break;
                    }
                case Valeur.Quatre:
                    {
                        nombre = "4";
                        break;
                    }
                case Valeur.Cinq:
                    {
                        nombre = "5";
                        break;
                    }
                case Valeur.Six:
                    {
                        nombre = "6";
                        break;
                    }
                case Valeur.Sept:
                    {
                        nombre = "7";
                        break;
                    }
                case Valeur.Huit:
                    {
                        nombre = "8";
                        break;
                    }
                case Valeur.Neuf:
                    {
                        nombre = "9";
                        break;
                    }
                case Valeur.Dix:
                    {
                        nombre = "10";
                        break;
                    }
                case Valeur.Valet:
                    {
                        nombre = "J";
                        break;
                    }
                case Valeur.reine:
                    {
                        nombre = "Q";
                        break;
                    }
                case Valeur.Roi:
                    {
                        nombre = "R";
                        break;
                    }
                case Valeur.As:
                    {
                        nombre = "A";
                        break;
                    }
                default:
                    {
                        nombre = "";
                        break;
                    }
            }
            return nombre;
        }
    }
}
