using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLyWeightPatternHUseyn
{
    public class SoldierFactory
    {
        private readonly Dictionary<SoldierType, Soldier> _soldiers = new();


        public Soldier GetSoldier(SoldierType soldierType)
        {
            Soldier soldier = null;

            if (_soldiers.ContainsKey(soldierType))
            {
                soldier = _soldiers[soldierType];
            }
            else
            {
                switch (soldierType)
                {
                    case SoldierType.Leytenant: soldier=  new Leytenant();
                        _soldiers.Add(SoldierType.Leytenant,soldier);
                        break;
                    case SoldierType.Kapitan: soldier= new Kapitan();
                        _soldiers.Add(SoldierType.Kapitan, soldier);
                        break;
                    default:
                        break;
                }
            }

            return soldier;
        }
    }
}
