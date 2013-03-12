using PackagesRencontres;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestPackagesRencontres
{
    
    
    /// <summary>
    ///Classe de test pour MatchTest, destinée à contenir tous
    ///les tests unitaires MatchTest
    ///</summary>
    [TestClass()]
    public class MatchTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        



        #region Attributs de tests supplémentaires
        // 
        //Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        //Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test dans la classe
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Utilisez ClassCleanup pour exécuter du code après que tous les tests ont été exécutés dans une classe
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Test pour Away
        ///</summary>
        [TestMethod()]
        public void AwayTest()
        {
            //Vars nécessaires au test
            string nomClub1 = "Paris", nomClub2 = "Narbonne";
            Club club1 = new Club(nomClub1);
            Club club2 = new Club(nomClub2);
            Match target = new Match(club1, 0, false, club2, 0, false);
            //Début des tests
            Assert.AreEqual(club2, target.Away);
        }

        /// <summary>
        ///Test pour AwayGoals
        ///</summary>
        [TestMethod()]
        public void AwayGoalsTest()
        {
            //Vars nécessaires au test
            string nomClub1 = "Paris", nomClub2 = "Narbonne";
            Club club1 = new Club(nomClub1);
            Club club2 = new Club(nomClub2);
            Match target = new Match(club1, 0, false, club2, 2, false);
            //Debut des tests
            Assert.AreEqual(2, target.AwayGoals);
        }

        /// <summary>
        ///Test pour Home
        ///</summary>
        [TestMethod()]
        public void HomeTest()
        {
            //Vars nécessaires au test
            string nomClub1 = "Paris", nomClub2 = "Narbonne";
            Club club1 = new Club(nomClub1);
            Club club2 = new Club(nomClub2);
            Match target = new Match(club1, 0, false, club2, 0, false);
            //Début des tests
            Assert.AreEqual(club1, target.Home);
        }

        /// <summary>
        ///Test pour HomeGoals
        ///</summary>
        [TestMethod()]
        public void HomeGoalsTest()
        {
            //Vars nécessaires au test
            string nomClub1 = "Paris", nomClub2 = "Narbonne";
            Club club1 = new Club(nomClub1);
            Club club2 = new Club(nomClub2);
            Match target = new Match(club1, 5, false, club2, 0, false);
            //Debut des tests
            Assert.AreEqual(5, target.HomeGoals);
        }

        /// <summary>
        ///Test pour IsAwayForfeit
        ///</summary>
        [TestMethod()]
        public void IsAwayForfeitTest()
        {
            //Vars nécessaires au test
            string nomClub1 = "Paris", nomClub2 = "Narbonne";
            Club club1 = new Club(nomClub1);
            Club club2 = new Club(nomClub2);
            Match target = new Match(club1, 5, false, club2, 0, false);
            //Debut des tests
            Assert.AreEqual(false, target.IsAwayForfeit);
        }

        /// <summary>
        ///Test pour IsDraw
        ///</summary>
        [TestMethod()]
        public void IsDrawTest()
        {
            //Vars nécessaires au test
            string nomClub1 = "Paris", nomClub2 = "Narbonne";
            Club club1 = new Club(nomClub1);
            Club club2 = new Club(nomClub2);
            Match target = new Match(club1, 1, false, club2, 1, false);
            //Debut des tests
            Assert.AreEqual(true, target.IsDraw);
        }

        /// <summary>
        ///Test pour IsHomeForfeit
        ///</summary>
        [TestMethod()]
        public void IsHomeForfeitTest()
        {
            //Vars nécessaires au test
            string nomClub1 = "Paris", nomClub2 = "Narbonne";
            Club club1 = new Club(nomClub1);
            Club club2 = new Club(nomClub2);
            Match target = new Match(club1, 5, false, club2, 0, false);
            //Debut des tests
            Assert.AreEqual(false, target.IsHomeForfeit);
        }

        /// <summary>
        ///Test pour Constructeur Match
        ///</summary>
        [TestMethod()]
        public void MatchConstructorTest()
        {
            //Vars nécessaires au test
            string nomClub1 = "Paris", nomClub2 = "Narbonne";
            Club club1 = new Club(nomClub1);
            Club club2 = new Club(nomClub2);
            Match target = new Match(club1, 5, false, club2, 0, false);
            //Debut des tests
            Assert.IsNotNull(target);
        }
    }
}
