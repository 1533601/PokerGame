using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    internal class Carte
    {
        Valeur maValeur;
        Couleur maCouleur;
        bool visible;
        public Carte(Valeur maValeur, Couleur maCouleur)
        {
            this.maValeur = maValeur;
            this.maCouleur = maCouleur;
        }
        
        public int Commparer(Carte laCarte)
        {
            throw new NotImplementedException();
        }
        public void Retoruner()
        {
            throw new NotImplementedException();
        }
    }
}
