using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    internal class Paquet
    {
        List<Carte> cartes = new List<Carte>();
        
        public Paquet()
        {
            Reinitialiser();
            Brasser();
        }
        /// <summary>
        /// Distribue les cartes
        /// </summary>
        /// <param name="j"></param>
        public void Distribuer(Joueur j)
        {       
            MainJoueur mainInit =  new MainJoueur(Tuple.Create(GetTopCarte(), GetTopCarte()));
            j.maMain = mainInit;
        }
        /// <summary>
        /// Reset le packet ou l'initialise 
        /// </summary>
        public void Reinitialiser()
        {
            this.cartes.Clear();
            for (int i = 2; i < 15; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    this.cartes.Add(new Carte((Valeur)i, (Couleur)j));
                }
            }
        }
        /// <summary>
        /// Brasse le paquet de Carte
        /// </summary>
        public void Brasser()
        {
            Random rand = new Random();
            this.cartes = cartes.OrderBy(x => rand.Next()).ToList();
        }
        /// <summary>
        /// Obitent la carte au sommet du packet
        /// </summary>
        /// <returns></returns>
        public Carte GetTopCarte()
        {
            this.cartes.RemoveAt(0);
            return this.cartes[0];
            
        }
    }
}
