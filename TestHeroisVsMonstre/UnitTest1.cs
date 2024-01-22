using LlibreriaHeroisVsMonstre;

namespace TestHeroisVsMonstre
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NotInRangeTest()
        {
            int min = 0, max = 10, num = 5;
            bool expected = false;
            Assert.AreEqual(Metodes.InRange(num, min, max), expected);
        }
        [TestMethod]
        public void NotInRangeTest2()
        {
            int min = 200, max = 400, num = 500;
            bool expected = true;
            Assert.AreEqual(Metodes.InRange(num, min, max), expected);
        }
        [TestMethod]
        public void CheckStatTest()
        {
            int min = 0, max = 10, num = 12;
            int expected = min;
            Assert.IsTrue(expected == Metodes.CheeckStat(num, min, max));
        }
        [TestMethod]
        public void CheckStatTest2()
        {
            int min = 800, max = 1200, num = 1000;
            int expected = num;
            Assert.IsTrue(expected == Metodes.CheeckStat(num, min, max));
        }
        [TestMethod]
        public void RandomTest()
        {
            int max = 300, min = 20;
            double num = Metodes.RandomStats(min, max);
            Assert.IsTrue(num >= min && num <= max);
        }
        [TestMethod]
        public void CooldownTest()
        {
            int num = 20;
            int expected = 19;
            Assert.AreEqual(Metodes.CoolDown(num), expected);
        }
        [TestMethod]
        public void CooldownTest2()
        {
            int num = 0;
            int expected = 0;
            Assert.AreEqual(Metodes.CoolDown(num), expected);
        }
        [TestMethod]
        public void OrderHpTest()
        {
            double num1 = 600, num2 = 44, num3 = 230, num4 = 55;
            double[] expected = { 44, 55, 230, 600 };
            Assert.AreEqual(Metodes.OrderHp(num1, num2, num3, num4),expected);
        }
        [TestMethod]
        public void DamageTest()
        {
            int dmg = 100, prot = 20;
            int expected = 80;
            Assert.AreEqual(Metodes.Damage(dmg, prot), expected);
        }
        [TestMethod]
        public void DamageTest2()
        {
            int dmg = 100, prot = 0;
            int expected = 100;
            Assert.AreEqual(Metodes.Damage(dmg, prot), expected);
        }
        [TestMethod]
        public void MonsterAttackTest()
        {
            int mDmg=100, hProt=25;
            bool shield=false;

            double expected = 75;

            Assert.AreEqual(Metodes.MonsterAttack(mDmg,hProt,shield),expected);
            
        }
        [TestMethod]
        public void MonsterAttackTest2()
        {
            int mDmg = 0, hProt = 40;
            bool shield = true;

            double expected = 0;

            Assert.AreEqual(Metodes.MonsterAttack(mDmg, hProt, shield), expected);

        }
        [TestMethod]
        public void HealTest()
        {
            int hp = 100, hpLimit = 700;
            int expected = 600;
            Assert.IsTrue(Metodes.Heal(hp,hpLimit)==expected);
        }
        [TestMethod]
        public void HealTest2()
        {
            int hp = 0, hpLimit = 200;
            int expected = 0;
            Assert.IsTrue(Metodes.Heal(hp, hpLimit) == expected);
        }
    }
}