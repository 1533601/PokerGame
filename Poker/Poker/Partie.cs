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
        int indiceJoueurCourant = 3;
        Paquet lePaquet;
        public int tour { get; set; }
        Carte[] river = new Carte[5];
        public int potsTotal { get; set; }

        public Partie(Joueur[] joueurs, Paquet lePaquet)
        {
            this.joueurs = joueurs;
            this.lePaquet = lePaquet;
            for (int i = 0; i < river.Length; i++)
            {
                river[i] = this.lePaquet.GetTopCarte();
            }
            
        }
        /// <summary>
        /// Jouer un tour
        /// </summary>
        public void JouerTour()
        {
            bool verif;
            int choix;
            for (int i = 0; i < this.joueurs.Count(); i++)
            {
                if (this.joueurs[i].actif == true)
                {
                    do
                    {

                        AfficherJeu();
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(76, 8);
                        
                        Console.WriteLine(this.potsTotal + "\u0024");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.SetCursorPosition(0, 5);
                        Console.WriteLine(this.joueurs[i].pseudo +" que voulez-vous faire");
                        Console.SetCursorPosition(0, 6);
                        Console.WriteLine("1: Call");
                        Console.SetCursorPosition(0, 7);
                        Console.WriteLine("2: Raise");
                        Console.SetCursorPosition(0, 8);
                        Console.WriteLine("3: Coucher");
                        verif = int.TryParse(Console.ReadLine(), out choix);
                    }
                    while (verif == false && choix > 4 && 0 > choix);
                    switch (choix)
                    {
                        case 1:
                            this.joueurs[i].Call();
                            break;
                        case 2:
                            this.joueurs[i].Raise(this.joueurs[indiceJoueurCourant].mise);
                            break;
                        case 3:
                            this.joueurs[i].Coucher();
                            break;
                        default:
                            break;
                    }
                    this.potsTotal = this.potsTotal + this.joueurs[i].mise;
                }
                this.indiceJoueurCourant++;
                if(this.indiceJoueurCourant == 4)
                {
                    this.indiceJoueurCourant = 0;
                }
            }
        }
        public int GetGagnant(List<Joueur> joueurs)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Affichage
        /// </summary>
        private void AfficherJeu()
        {
            ///table de jeux
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(35, 13);
            Console.WriteLine("------------------------------------------------------------------------------------");
            for (int i = 0; i < 11; i++)
            {
                Console.SetCursorPosition(35, 14 + i);
                Console.WriteLine("|                                                                                  |");
            }
            Console.SetCursorPosition(35, 25);
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
                river[0].Retoruner();
                river[1].Retoruner();
                river[2].Retoruner();
                river[3].Retoruner();
            }
            if (this.tour == 3)
            {
                river[0].Retoruner();
                river[1].Retoruner();
                river[2].Retoruner();
                river[3].Retoruner();
                river[4].Retoruner();
            }

            //carte1
            if (river[0].visible == false)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(40, 16);
                Console.WriteLine("----------");
                for (int i = 0; i < 5; i++)
                {
                    Console.SetCursorPosition(40, 17 + i);
                    Console.WriteLine("|        |");
                }
                Console.SetCursorPosition(40, 22);
                Console.WriteLine("----------");
            }

            else
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(40, 16);
                Console.WriteLine("----------");
                for (int i = 0; i < 5; i++)
                {
                    Console.SetCursorPosition(40, 17 + i);
                    Console.WriteLine("|        |");
                }
                Console.SetCursorPosition(40, 22);
                Console.WriteLine("----------");
                CouleurAffichage(river[0]);
                Console.SetCursorPosition(40, 16);
                Console.WriteLine(nombreCarte(river[0]) + "" + FormeCarte(river[0]));
                Console.SetCursorPosition(47, 22);
                Console.WriteLine(nombreCarte(river[0]) + "" + FormeCarte(river[0]));
            }

            //carte2
            if (river[1].visible == false)
            {
                Console.BackgroundColor = ConsoleColor.White;
                
                Console.SetCursorPosition(56, 16);
                Console.WriteLine("----------");
                for (int i = 0; i < 5; i++)
                {
                    Console.SetCursorPosition(56, 17 + i);
                    Console.WriteLine("|        |");
                }
                Console.SetCursorPosition(56, 22);
                Console.WriteLine("----------");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.White;
 
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(56, 16);
                Console.WriteLine("----------");
                for (int i = 0; i < 5; i++)
                {
                    Console.SetCursorPosition(56, 17 + i);
                    Console.WriteLine("|        |");
                }
                Console.SetCursorPosition(56, 22);
                Console.WriteLine("----------");
                CouleurAffichage(river[1]);
                Console.SetCursorPosition(56, 16);
                Console.WriteLine(nombreCarte(river[1]) + "" + FormeCarte(river[1]));
                Console.SetCursorPosition(63, 22);
                Console.WriteLine(nombreCarte(river[1]) + "" + FormeCarte(river[1]));

            }


            //carte3
            if (river[2].visible == false)
            {
                Console.BackgroundColor = ConsoleColor.White;
                
                Console.SetCursorPosition(72, 16);
                Console.WriteLine("----------");
                for (int i = 0; i < 5; i++)
                {
                    Console.SetCursorPosition(72, 17 + i);
                    Console.WriteLine("|        |");
                }
                Console.SetCursorPosition(72, 22);
                Console.WriteLine("----------");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(72, 16);
                Console.WriteLine("----------");
                for (int i = 0; i < 5; i++)
                {
                    Console.SetCursorPosition(72, 17 + i);
                    Console.WriteLine("|        |");
                }
                Console.SetCursorPosition(72, 22);
                Console.WriteLine("----------");
                CouleurAffichage(river[2]);
                Console.SetCursorPosition(72, 16);
                Console.WriteLine(nombreCarte(river[2]) + "" + FormeCarte(river[2]));
                Console.SetCursorPosition(79, 22);
                Console.WriteLine(nombreCarte(river[2]) + "" + FormeCarte(river[2]));
            }


            //carte4
            if (river[3].visible == false)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(88, 16);
                Console.WriteLine("----------");
                for (int i = 0; i < 5; i++)
                {
                    Console.SetCursorPosition(88, 17 + i);
                    Console.WriteLine("|        |");
                }
                Console.SetCursorPosition(88, 22);
                Console.WriteLine("----------");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(88, 16);
                Console.WriteLine("----------");
                for (int i = 0; i < 5; i++)
                {
                    Console.SetCursorPosition(88, 17 + i);
                    Console.WriteLine("|        |");
                }
                Console.SetCursorPosition(88, 22);
                Console.WriteLine("----------");
                CouleurAffichage(river[3]);
                Console.SetCursorPosition(88, 16);
                Console.WriteLine(nombreCarte(river[3]) + "" + FormeCarte(river[3]));
                Console.SetCursorPosition(95, 22);
                Console.WriteLine(nombreCarte(river[3]) + "" + FormeCarte(river[3]));
            }


            //carte5
            if (river[4].visible == false)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(104, 16);
                Console.WriteLine("----------");
                for (int i = 0; i < 5; i++)
                {
                    Console.SetCursorPosition(104, 17 + i);
                    Console.WriteLine("|        |");
                }
                Console.SetCursorPosition(104, 22);
                Console.WriteLine("----------");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                

                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(104, 16);
                Console.WriteLine("----------");
                for (int i = 0; i < 5; i++)
                {
                    Console.SetCursorPosition(104, 17 + i);
                    Console.WriteLine("|        |");
                }
                Console.SetCursorPosition(104, 22);
                Console.WriteLine("----------");

                CouleurAffichage(river[4]);
                Console.SetCursorPosition(104, 16);
                Console.WriteLine(nombreCarte(river[4]) + "" + FormeCarte(river[4]));
                Console.SetCursorPosition(111, 22);
                Console.WriteLine(nombreCarte(river[4]) + "" + FormeCarte(river[4]));
            }

            //-------------------------



            //nom joueur 1
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(40, 1);
            Console.WriteLine(this.joueurs[0].pseudo);

            //montent joueur 1

            Console.SetCursorPosition(56, 1);
            Console.WriteLine(this.joueurs[0].argent + "\u0024");

            //premier carte joueur 1


            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(40, 3);
            Console.WriteLine("----------");
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(40, 4 + i);
                Console.WriteLine("|        |");
            }
            Console.SetCursorPosition(40, 9);
            Console.WriteLine("----------");

            CouleurAffichage(this.joueurs[0].maMain.cartes.Item1);
            Console.SetCursorPosition(40, 3);
            Console.WriteLine(nombreCarte(this.joueurs[0].maMain.cartes.Item1) + "" + FormeCarte(this.joueurs[0].maMain.cartes.Item1));
            Console.SetCursorPosition(47, 9);
            Console.WriteLine(nombreCarte(this.joueurs[0].maMain.cartes.Item1) + "" + FormeCarte(this.joueurs[0].maMain.cartes.Item1));
            //this.joueurs[0].cart1

            //deuxiem carete joueur 1

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(56, 3);
            Console.WriteLine("----------");
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(56, 4 + i);
                Console.WriteLine("|        |");
            }
            Console.SetCursorPosition(56, 9);
            Console.WriteLine("----------");

            CouleurAffichage(this.joueurs[0].maMain.cartes.Item2);
            Console.SetCursorPosition(56, 3);
            Console.WriteLine(nombreCarte(this.joueurs[0].maMain.cartes.Item2) + "" + FormeCarte(this.joueurs[0].maMain.cartes.Item2));
            Console.SetCursorPosition(63, 9);
            Console.WriteLine(nombreCarte(this.joueurs[0].maMain.cartes.Item2) + "" + FormeCarte(this.joueurs[0].maMain.cartes.Item2));
            //this.joueurs[0].cart1
            //-------------------------------

            //nom joueur 2
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(88, 1);
            Console.WriteLine(this.joueurs[1].pseudo);

            //montent joueur 2

            Console.SetCursorPosition(104, 1);
            Console.WriteLine(this.joueurs[1].argent + "\u0024");

            //premier carte joueur 2

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(88, 3);
            Console.WriteLine("----------");
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(88, 4 + i);
                Console.WriteLine("|        |");
            }
            Console.SetCursorPosition(88, 9);
            Console.WriteLine("----------");

            CouleurAffichage(this.joueurs[1].maMain.cartes.Item1);
            Console.SetCursorPosition(88, 3);
            Console.WriteLine(nombreCarte(this.joueurs[1].maMain.cartes.Item1) + "" + FormeCarte(this.joueurs[1].maMain.cartes.Item1));
            Console.SetCursorPosition(95, 9);
            Console.WriteLine(nombreCarte(this.joueurs[1].maMain.cartes.Item1) + "" + FormeCarte(this.joueurs[1].maMain.cartes.Item1));
            //this.joueurs[1].cart1

            //deuxiem carete joueur 2

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(104, 3);
            Console.WriteLine("----------");
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(104, 4 + i);
                Console.WriteLine("|        |");
            }
            Console.SetCursorPosition(104, 9);
            Console.WriteLine("----------");

            CouleurAffichage(this.joueurs[1].maMain.cartes.Item2);
            Console.SetCursorPosition(104, 3);
            Console.WriteLine(nombreCarte(this.joueurs[1].maMain.cartes.Item2) + "" + FormeCarte(this.joueurs[1].maMain.cartes.Item2));
            Console.SetCursorPosition(111, 9);
            Console.WriteLine(nombreCarte(this.joueurs[1].maMain.cartes.Item2) + "" + FormeCarte(this.joueurs[1].maMain.cartes.Item2));
            //this.joueurs[1].cart1
            //------------------------------------

            //nom joueur 3
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(40, 38);
            Console.WriteLine(this.joueurs[2].argent + "\u0024");

            //montent joueur 3

            Console.SetCursorPosition(56, 38);
            Console.WriteLine(this.joueurs[2].pseudo);

            //premier carte joueur 3

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(40, 30);
            Console.WriteLine("----------");
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(40, 31 + i);
                Console.WriteLine("|        |");
            }
            Console.SetCursorPosition(40, 36);
            Console.WriteLine("----------");

            CouleurAffichage(this.joueurs[2].maMain.cartes.Item1);
            Console.SetCursorPosition(40, 30);
            Console.WriteLine(nombreCarte(this.joueurs[2].maMain.cartes.Item1) + "" + FormeCarte(this.joueurs[2].maMain.cartes.Item1));
            Console.SetCursorPosition(47, 36);
            Console.WriteLine(nombreCarte(this.joueurs[2].maMain.cartes.Item1) + "" + FormeCarte(this.joueurs[2].maMain.cartes.Item1));


            //deuxiem carete joueur 3

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(56, 30);
            Console.WriteLine("----------");
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(56, 31 + i);
                Console.WriteLine("|        |");
            }
            Console.SetCursorPosition(56, 36);
            Console.WriteLine("----------");

            CouleurAffichage(this.joueurs[2].maMain.cartes.Item2);
            Console.SetCursorPosition(56, 30);
            Console.WriteLine(nombreCarte(this.joueurs[2].maMain.cartes.Item2) + "" + FormeCarte(this.joueurs[2].maMain.cartes.Item2));
            Console.SetCursorPosition(63, 36);
            Console.WriteLine(nombreCarte(this.joueurs[2].maMain.cartes.Item2) + "" + FormeCarte(this.joueurs[2].maMain.cartes.Item2));
            //-------------------------------
            //this.joueurs[2].cart1

            //nom joueur 4
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(88, 38);
            Console.WriteLine(this.joueurs[3].pseudo);

            //montent joueur 4

            Console.SetCursorPosition(104, 38);
            Console.WriteLine(this.joueurs[3].argent + "\u0024");

            //premier carte joueur 4

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(88, 30);
            Console.WriteLine("----------");
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(88, 31 + i);
                Console.WriteLine("|        |");
            }
            Console.SetCursorPosition(88, 36);
            Console.WriteLine("----------");

            CouleurAffichage(this.joueurs[3].maMain.cartes.Item1);
            Console.SetCursorPosition(88, 30);
            Console.WriteLine(nombreCarte(this.joueurs[3].maMain.cartes.Item1) + "" + FormeCarte(this.joueurs[3].maMain.cartes.Item1));
            Console.SetCursorPosition(95, 36);//asd
            Console.WriteLine(nombreCarte(this.joueurs[3].maMain.cartes.Item1) + "" + FormeCarte(this.joueurs[3].maMain.cartes.Item1));
            //this.joueurs[3].cart1

            //deuxiem carete joueur 4

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(104, 30);
            Console.WriteLine("----------");
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(104, 31 + i);
                Console.WriteLine("|        |");
            }
            Console.SetCursorPosition(104, 36);
            Console.WriteLine("----------");

            CouleurAffichage(this.joueurs[3].maMain.cartes.Item1);
            Console.SetCursorPosition(104, 30);
            Console.WriteLine(nombreCarte(this.joueurs[3].maMain.cartes.Item2) + "" + FormeCarte(this.joueurs[3].maMain.cartes.Item2));
            Console.SetCursorPosition(111, 36);
            Console.WriteLine(nombreCarte(this.joueurs[3].maMain.cartes.Item2) + "" + FormeCarte(this.joueurs[3].maMain.cartes.Item2));

            //------------------------------------

            //dealer
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
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
            Console.SetCursorPosition(0, 44);
        }
        public void UpdateGagnant(Joueur j)
        {
            throw new NotImplementedException();
        }
        public bool FinPartie()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Retourne la couleur de l'affichage
        /// </summary>
        /// <param name="laCarte"></param>
        private void CouleurAffichage(Carte laCarte)
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
        /// <summary>
        /// Affiche le logo de la carte
        /// </summary>
        /// <param name="laCarte"></param>
        /// <returns></returns>
        private char FormeCarte(Carte laCarte)
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
        /// <summary>
        /// retourne le nombre pour L'affichage
        /// </summary>
        /// <param name="laCarte"></param>
        /// <returns></returns>
        private string nombreCarte(Carte laCarte)
        {
            string nombre;
            switch (laCarte.maValeur)
            {
                case Valeur.Deux:
                    {
                        nombre = " 2";
                        break;
                    }
                case Valeur.Trois:
                    {
                        nombre = " 3";
                        break;
                    }
                case Valeur.Quatre:
                    {
                        nombre = " 4";
                        break;
                    }
                case Valeur.Cinq:
                    {
                        nombre = " 5";
                        break;
                    }
                case Valeur.Six:
                    {
                        nombre = " 6";
                        break;
                    }
                case Valeur.Sept:
                    {
                        nombre = " 7";
                        break;
                    }
                case Valeur.Huit:
                    {
                        nombre = " 8";
                        break;
                    }
                case Valeur.Neuf:
                    {
                        nombre = " 9";
                        break;
                    }
                case Valeur.Dix:
                    {
                        nombre = "10";
                        break;
                    }
                case Valeur.Valet:
                    {
                        nombre = " J";
                        break;
                    }
                case Valeur.reine:
                    {
                        nombre = " Q";
                        break;
                    }
                case Valeur.Roi:
                    {
                        nombre = " R";
                        break;
                    }
                case Valeur.As:
                    {
                        nombre = " A";
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
