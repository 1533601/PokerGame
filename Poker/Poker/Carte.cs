using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    public class Carte
    {
        Valeur maValeur;
        Couleur maCouleur;
        bool visible { get; set; }
        public Carte(Valeur maValeur, Couleur maCouleur)
        {
            this.maValeur = maValeur;
            this.maCouleur = maCouleur;
            this.visible = false;
        }
        
        public int Commparer(Carte laCarte)
        {
            int laComparaison = this.maValeur - laCarte.maValeur;
            return Math.Abs(laComparaison);
        }
        public void Retoruner()
        {
            this.visible = true;
        }
    }
}
