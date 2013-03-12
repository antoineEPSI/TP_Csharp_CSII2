using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PackagesRencontres
{
    public class FrenchLeague1PointSystem : PointSystem
    {
        public class PointTotal
        {
            public int goalaverage;
            public int points;

            public PointTotal()
            {

            }

            public PointTotal(Match m, bool home)
            {

            }

            public int CompareTo(object obj)
            {
                throw new NotImplementedException();
            }

            public void Increment(PackagesRencontres.PointSystem.ITotal with)
            {

            }

            public override string ToString()
            {
                return base.ToString();
            }
        }

        private static FrenchLeague1PointSystem theInstance;

        public PackagesRencontres.PointSystem.ITotal InitialPoints
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public static PointSystem Instance
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public PackagesRencontres.PointSystem.ITotal GetPointsFromMatch(Match m, bool isHome)
        {
            throw new NotImplementedException();
        }

    }
}
