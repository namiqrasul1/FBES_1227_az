using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterHuseynPattern
{
    public class EnemyRobot
    {
        int damageRobot { get; set; } = 5;

       public void smashHand()
        {
            Console.WriteLine($"Robot damage{damageRobot}");
        }
    }
}
