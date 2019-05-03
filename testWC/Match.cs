using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testWC
{
    class Match
    {
        private Club team1;
        private Club team2;
        private DateTime time;
        private string where;


        public string Where { get => where; set => where = value; }
        public DateTime Time { get => time; set => time = value; }
        internal Club Team2 { get => team2; set => team2 = value; }
        internal Club Team1 { get => team1; set => team1 = value; }

        public Match()
        {
            Team1 = new Club();
            Team2 = new Club();
            Time = new DateTime();
            Where = "";
        }

        public bool CheckNameOfWatch(Match match)
        {
            if (match.Team1.Name != team2.Name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
