using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    internal class MainJoueur
    {
        Tuple<Carte, Carte> cartes;
        int force;

        public MainJoueur(Tuple<Carte, Carte> cartes, int force)
        {
            this.cartes = cartes;
            this.force = force;
        }
        public int Comparer(MainJoueur laMainJoueur)
        {
            throw new NotImplementedException(); 
        }
        public void CalculerForce()
        {
            throw new NotImplementedException();
        }
    }
}
