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
        public Valeur maValeur { get; set; }
        public Couleur maCouleur { get; set; }
        public bool visible { get; set; }
        public Carte(Valeur maValeur, Couleur maCouleur)
        {
            this.maValeur = maValeur;
            this.maCouleur = maCouleur;
            this.visible = false;
        }
        /// <summary>
        /// Comparaison de la carte avec une autre cart et retourne un score
        /// </summary>
        /// <param name="laCarte"></param>
        /// <returns></returns>
        public int Commparer(Carte laCarte)
        {
            int laComparaison = this.maValeur - laCarte.maValeur;
            return Math.Abs(laComparaison);
        }
        /// <summary>
        /// Retourne la carte de la river pour qU,elle devienne vissible
        /// </summary>
        public void Retoruner()
        {
            this.visible = true;
        }
        /// <summary>
        /// Retourne la carte pour qu'elle devient visible ou invisible
        /// </summary>
        public void RetournerCarteJoueur()
        {
            if (this.visible == true)
            {
                this.visible = false;
            }
            else
            {
                this.visible = true;
            }
        }
    }
}
