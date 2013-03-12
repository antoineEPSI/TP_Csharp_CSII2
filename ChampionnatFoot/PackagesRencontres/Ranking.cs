using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PackagesRencontres
{
    public class Ranking
    {

        public class RankingEntry
        {
            public Club club;
            public PackagesRencontres.PointSystem.ITotal points;

            public Club Club
            {
                get
                {
                    return club;
                }
            }

            public PackagesRencontres.PointSystem.ITotal Points
            {
                get
                {
                    return points;
                }
            }

            public int CompareTo(object obj)
            {

            }

            public void RankingEntry(Club club, PackagesRencontres.PointSystem.ITotal points)
            {

            }

        }

        private RankingEntry[] entries;
        private PointSystem system;

        public Ranking(PointSystem system, Club[] clubs)
        {
            this.system = system;
            entries = new RankingEntry[clubs.Length];
            this.entries = clubs;
        }
    
        public RankingEntry EntryFromClub(Club c)
        {
            throw new System.NotImplementedException();
        }

        public Club GetClub(int index)
        {
            throw new System.NotImplementedException();
        }

        public PackagesRencontres.PointSystem.ITotal GetPoints(Club club)
        {
            throw new System.NotImplementedException();
        }

        public PackagesRencontres.PointSystem.ITotal GetPoints(int index)
        {
            throw new System.NotImplementedException();
        }

        public void Register(Match m)
        {
            throw new System.NotImplementedException();
        }

        public void Method()
        {
            throw new System.NotImplementedException();
        }
    }
}
