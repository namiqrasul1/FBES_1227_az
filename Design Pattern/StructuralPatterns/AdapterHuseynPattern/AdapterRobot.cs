using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterHuseynPattern
{
    internal class AdapterRobot : IAtacker
    {
        EnemyRobot EnemyRobot;

        public AdapterRobot(EnemyRobot enemyRobot)
        {
            EnemyRobot = enemyRobot;
        }

        public void Weapon()
        {
            EnemyRobot.smashHand();
        }
    }
}
