using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PackagesRencontres
{
    public class Club
    {
        private string m_name;

        public Club(string name)
        {
            m_name = name;
        }

        public override string ToString()
        {
            return m_name;
        }

    }
}
