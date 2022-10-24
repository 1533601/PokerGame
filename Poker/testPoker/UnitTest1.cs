using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Poker;
using PokerGame;

namespace testPoker
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestComparer()
        {
            Carte uneCarte = new Carte(Valeur.Trois, Couleur.Carreau);
            Carte autreCarte = new Carte(Valeur.Cinq, Couleur.Carreau);
            Assert.AreEqual(2, uneCarte.Commparer(autreCarte));
        }
    }
}
