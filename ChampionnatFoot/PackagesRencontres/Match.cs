using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PackagesRencontres
{
    public class Match
    {
        private Club m_away;
        private Club m_home;
        private int m_goalAway;
        private int m_goalHome;
        private bool m_forfeitHome;
        private bool m_forfeitAway;

        public Match(Club home, int goalHome, bool forfeitHome, Club away, int goalAway, bool forfeitAway)
        {
            m_away = away;
            m_goalAway = goalAway;
            m_home = home;
            m_goalHome = goalHome;
            m_forfeitHome = forfeitHome;
            m_forfeitAway = forfeitAway;
        }

        public Club Away
        {
            get
            {
                return m_away;
            }
        }

        public int AwayGoals
        {
            get
            {
                return m_goalAway;
            }
        }

        public Club Home
        {
            get
            {
                return m_home;
            }
        }

        public int HomeGoals
        {
            get
            {
                return m_goalHome;
            }
        }

        public bool IsAwayForfeit
        {
            get
            {
                return m_forfeitAway;
            }
        }

        public bool IsDraw
        {
            get
            {
                if (m_goalAway == m_goalHome)
                    return true;
                else
                    return false;
            }
        }

        public bool IsHomeForfeit
        {
            get
            {
                return m_forfeitHome;
            }
        }


    }
}
