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
            cartes = new List<Carte>();
        }
        public void Distribuer(Joueur j)
        {
            throw new NotImplementedException();
        }
        public void Reinitialiser()
        {
            throw new NotImplementedException();
        }
        public void Brasser()
        {
            throw new NotImplementedException();
        }
        public Carte GetTopCarte()
        {
            throw new NotImplementedException();
        }
    }
}
