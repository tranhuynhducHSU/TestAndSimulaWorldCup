using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testWC
{
    [TestClass]
    public class TestPlayer
    {
        FootballPlayer footballPlayer;
        FootballPlayer footballPlayer1;
        Club club;
        bool result;
        public TestPlayer()
        {
            footballPlayer = new FootballPlayer(0, 99, "Ngô Bá Khá");
            footballPlayer1 = new FootballPlayer(-22, -10, "Nguyễn Quang Hải");
            club = new Club();
            club.ListPlayer.Add(footballPlayer);
            club.ListPlayer.Add(footballPlayer1);
            result = false;
        }
        [TestMethod]
        public void TestPlayerInClub()
        {
            //Số áo của cầu thủ trong 1 đội phải khác nhau.
            result = Club.checkIndenticalNumOfClothers(club);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestNumOfClothers()
        {
            //số áo cầu thủ là số không âm và không lớn hơn 99
            result = FootballPlayer.checkNumNegative(footballPlayer);
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void TestAgeOfPlayer()
        {
            //Kiểm tra độ tuổi của cầu thủ
        }
    }
}
