using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testWC
{
    class Club
    {
        private string name;
        private int numOfPlayer;
        private List<FootballPlayer> listPlayer;

        public string Name { get => name; set => name = value; }
        public int NumOfPlayer { get => numOfPlayer; set => numOfPlayer = value; }
        public List<FootballPlayer> ListPlayer { get => listPlayer; set => listPlayer = value; }

        public Club()
        {
            Name = "";
            NumOfPlayer = 0;
            ListPlayer = new List<FootballPlayer>();
        }
        public Club(string name, int numOfPlayer, List<FootballPlayer> listPlayer)
        {
            Name = name;
            NumOfPlayer = numOfPlayer;
            ListPlayer = listPlayer;
        }

        internal static bool checkIndenticalNumOfClothers(Club club)
        {

            for (int i = 0; i < club.ListPlayer.Count - 1; i++)
            {
                if (club.ListPlayer[i].ClothersNum == club.ListPlayer[i + 1].ClothersNum)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
