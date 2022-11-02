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
        string pseudo;
        int argent;
        bool actif;
        public MainJoueur maMain { get; set; }

        public Joueur(string nom, string pseudo, int argent, bool actif, MainJoueur maMain)
        {
            this.nom = nom;
            this.pseudo = pseudo;
            this.argent = argent;
            this.actif = actif;
            this.maMain = maMain;
        }
        public void Miser(int montant)
        {
            Console.Clear();
            bool verif;
            int laMise;
            Console.WriteLine("Comment d'argent voulez-vous miser");
            do
            {
                Console.ReadLine();
                verif = int.TryParse(Console.ReadLine(), out laMise);
            }
            while (verif == false);
            if(laMise > montant)
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
            throw new NotImplementedException();
        }
        public void Call()
        {
            throw new NotImplementedException();
        }
        public void Coucher()
        {
            throw new NotImplementedException();
        }
        public void Raise(int montant)
        {
            throw new NotImplementedException();
        }
        public void ResetMain()
        {
            throw new NotImplementedException();
        }
    }
}
