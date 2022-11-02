using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    internal class Paquet
    {
        List<Carte> cartes;
        
        public Paquet()
        {
            Reinitialiser();
            Brasser();
        }
        public void Distribuer(Joueur j)
        {       
            MainJoueur mainInit =  new MainJoueur(Tuple.Create(GetTopCarte(), GetTopCarte()));
            j.maMain = mainInit;
        }
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
        public void Brasser()
        {
            Random rand = new Random();
            this.cartes = cartes.OrderBy(x => rand.Next()).ToList();
        }
        public Carte GetTopCarte()
        {
            return this.cartes[0];
            this.cartes.RemoveAt(0);
        }
    }
}
