using Microsoft.VisualStudio.TestTools.UnitTesting;
using TurnBasedBattleGame.Models;

namespace TurnBasedBattleGame.Tests
{
    [TestClass]
    public class CharacterTests
    {
        [TestMethod]
        public void WarriorAttack_ShouldReduceEnemyHealth()
        {
            var warrior = new Warrior();
            warrior.X = 1;
            warrior.Y = 1;

            var enemy = new Archer();
            enemy.X = 2;
            enemy.Y = 1;

            int initialHealth = enemy.Health;

            bool attackResult = warrior.Attack(enemy);

            Assert.IsTrue(attackResult, "Attack should succeed.");
            Assert.IsTrue(enemy.Health < initialHealth, "Enemy health should decrease after attack.");
        }

        [TestMethod]
        public void MageHeal_ShouldIncreaseOwnHealth()
        {
            var mage = new Mage();
            mage.Health = 50;

            int initialHealth = mage.Health;

            bool healResult = mage.Heal(mage);

            Assert.IsTrue(healResult, "Heal should succeed.");
            Assert.IsTrue(mage.Health > initialHealth, "Mage health should increase after healing.");
        }

        [TestMethod]
        public void WarriorAttack_ShouldFail_WhenEnemyTooFar()
        {
            var warrior = new Warrior();
            warrior.X = 1;
            warrior.Y = 1;

            var enemy = new Archer();
            enemy.X = 10;
            enemy.Y = 10;

            int initialHealth = enemy.Health;

            bool attackResult = warrior.Attack(enemy);

            Assert.IsFalse(attackResult, "Attack should fail because enemy is too far.");
            Assert.AreEqual(initialHealth, enemy.Health, "Enemy health should remain the same after failed attack.");
        }
    }
}
