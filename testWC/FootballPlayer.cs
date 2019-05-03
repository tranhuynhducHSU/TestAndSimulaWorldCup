using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testWC
{
    class FootballPlayer
    {   
        private int clothersNum;
        private int age;
        private string name;

        public int ClothersNum { get => clothersNum; set => clothersNum = value; }
        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }

        public FootballPlayer()
        {
            ClothersNum = -1;
            Age = 0;
            Name = "";
        }
        public FootballPlayer(int cloNum, int age, string name)
        {
            ClothersNum = cloNum;
            Age = age;
            Name = name;
        }

        internal static bool checkNumNegative(FootballPlayer footballPlayer)
        {
            if (footballPlayer.ClothersNum < 0)
            {
                return true;
            }
            return false;
        }
    }
}
