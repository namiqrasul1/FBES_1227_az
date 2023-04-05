using AdapterHuseynPattern;

EnemyTank EnemyTank = new();

EnemyTank.Weapon();

EnemyRobot enemyRobot = new();

AdapterRobot AdapterRobot = new(enemyRobot);


AdapterRobot.Weapon();