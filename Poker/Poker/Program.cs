using PokerGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paquet lePaquet = new Paquet();
            bool verif = false;
            int argent;
            Joueur[] joueursPartie = new Joueur[4];
            for (int i = 0; i < joueursPartie.Length; i++)
            {
                Console.WriteLine("Le nom du joueur " + (i + 1));
                string leNom = Console.ReadLine();
                Console.WriteLine("Le pseudo du joueur " + (i + 1));
                string lePseudo = Console.ReadLine();
                do
                {
                    Console.WriteLine("Comment d'argent à le joueur " + (i + 1));
                    verif = int.TryParse(Console.ReadLine(), out argent);
                    Console.Clear();
                }
                while (verif == false);
                MainJoueur laMain = new MainJoueur(Tuple.Create(lePaquet.GetTopCarte(), lePaquet.GetTopCarte()));
                joueursPartie[i] = new Joueur(leNom, lePseudo, laMain);
            }
            Partie laPartie = new Partie(joueursPartie, lePaquet);
            do
            {
                laPartie.JouerTour();
                laPartie.tour++;
            }
            while (laPartie.tour <= 3);
        }
    }
}
