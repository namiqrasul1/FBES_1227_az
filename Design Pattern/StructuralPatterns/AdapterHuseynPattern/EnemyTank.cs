using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterHuseynPattern
{
    internal class EnemyTank:IAtacker
    {
        int damageTank { get; set; } = 10;

        public void Weapon()
        {
            Console.WriteLine($"Tank damage {damageTank}");
        }
    }
}
