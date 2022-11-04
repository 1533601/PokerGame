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
        public string nom { get; set; }
        public string pseudo { get; set; }
        public int argent { get; set; }
        public bool actif { get; set; }
        public MainJoueur maMain { get; set; }

        public Joueur(string nom, string pseudo, int argent, MainJoueur maMain)
        {
            this.nom = nom;
            this.pseudo = pseudo;
            this.argent = argent;
            this.actif = true;
            this.maMain = maMain;
        }
        public void Miser(int montant)
        {
            bool verif;
            int laMise;
            Console.WriteLine("Comment d'argent voulez-vous miser");
            do
            {
                Console.ReadLine();
                verif = int.TryParse(Console.ReadLine(), out laMise);
            }
            while (verif == false);
            if(laMise < montant)
            {
                Console.WriteLine("fond insuffisant");
            }
            else
            {
                this.argent = this.argent - laMise;
            }
        }
        public void Check()
        {
            Console.WriteLine("Vous avez check");
        }
        public void Call()
        {
            Console.WriteLine("Vous avez call");
        }
        public void Coucher()
        {
            this.actif = false;
            Console.WriteLine("Vous vous êtes coucher");
        }
        public void Raise(int montant)
        {
            if(this.argent > montant)
            {
                this.argent = 0;
            }
            else
            {
                this.argent = this.argent - montant;
            }
        }
        public void ResetMain()
        {
            this.maMain = null;
        }
    }
}
