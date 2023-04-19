
using FLyWeightPatternHUseyn;

SoldierType[] soldierTypes = { SoldierType.Leytenant, SoldierType.Kapitan, SoldierType.Leytenant };


SoldierFactory soldierFactory = new();

int locationY = 10;
int locationX = 10;

foreach (var item in soldierTypes)
{
    locationX += 5;
    locationY += 10;
    Soldier sld = soldierFactory.GetSoldier(item);

    sld.MoveTo(locationX, locationY);
}

Leytenant leytenant = new();
leytenant.MoveTo(locationX, locationY);