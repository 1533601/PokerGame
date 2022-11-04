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
        public Tuple<Carte, Carte> cartes { get; set; }
        int force { get; set; }

        public MainJoueur(Tuple<Carte, Carte> cartes)
        {
            this.cartes = cartes;
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
