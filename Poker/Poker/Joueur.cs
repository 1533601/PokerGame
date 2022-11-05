using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    internal class Joueur
    {
        string nom;
        public string pseudo { get; set; }
        public int argent { get; set; }
        public bool actif { get; set; }
        public MainJoueur maMain { get; set; }
        public int mise { get; set; }
        public Joueur(string nom, string pseudo, int argent, MainJoueur maMain)
        {
            this.nom = nom;
            this.pseudo = pseudo;
            this.argent = argent;
            this.actif = true;
            this.maMain = maMain;
        }
       /// <summary>
       /// Fonction Call au poker
       /// </summary>
       /// <returns></returns>
        public int Call(int montant)
        {

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Vous avez call");
            this.argent = this.argent - montant;
            mise = montant;


            Console.Clear();
            return montant;
        }
        /// <summary>
        /// Usager se couche
        /// </summary>
        public void Coucher()
        {
            this.actif = false;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Vous vous êtes coucher");
            Console.Clear();
        }
        /// <summary>
        /// Augmente le pot sinon lance la première mise
        /// </summary>
        /// <param name="montant"></param>
        /// <returns></returns>
        public int Raise(int montant)
        {

            bool verif;
            int laMise;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.Black;
            
            do
            {
                Console.WriteLine("Combien voulez-vous miser?");
                verif = int.TryParse(Console.ReadLine(), out laMise);
                Console.Clear();
                
            }
            while (verif == false);
            if (laMise > this.argent)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("fond insuffisant");
                Raise(montant);
            }
            else
            {
                this.argent = this.argent - (laMise+montant);
                mise = montant+laMise;         
            }
            return mise;
        }
        /// <summary>
        /// Reset la main de l'usager
        /// </summary>
        public void ResetMain()
        {
            this.maMain = null;
        }
    }
}
