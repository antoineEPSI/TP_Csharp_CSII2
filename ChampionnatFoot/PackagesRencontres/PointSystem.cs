using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PackagesRencontres
{
    public abstract class PointSystem
    {

        public class ITotal : IComparable
        {
            public void Increment(ITotal with)
            {
                
            }

            public override string ToString()
            {
                return base.ToString();
            }
        }

        public ITotal InitialPoints
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public ITotal GetPointsFromMatch(Match m, bool isHome)
        {
            throw new System.NotImplementedException();
        }
    }
}
