using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    internal class Partie
    {
        List<Joueur> joueurs;
        int indiceJoueurCouran;
        Paquet lePaquet;
        int tour;

        public Partie(List<Joueur> joueurs, int indiceJoueurCouran, Paquet lePaquet, int tour)
        {
            this.joueurs = joueurs;
            this.indiceJoueurCouran = indiceJoueurCouran;
            this.lePaquet = lePaquet;
            this.tour = tour;
        }
        public void JouerTour()
        {
            throw new NotImplementedException();
        }
        public int GetGagnant(List<Joueur> joueurs)
        {
            throw new NotImplementedException();
        }
        public void AfficherJeu()
        {
            throw new NotImplementedException();
        }
        public void UpdateGagnant(Joueur j)
        {
            throw new NotImplementedException();
        }
        public bool FinPartie()
        {
            throw new NotImplementedException();
        }
    }
}
