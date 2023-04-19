using FacadeDpELchin;

Model model = new Model();
model.CreateModel();
Body body = new Body();
body.CreateBody();
Features features = new Features();
features.CreateFetaures();
Motor Motor = new Motor();
Motor.CreateMotor();


Console.WriteLine("\n\n");


var facade = new FacadeCar();
facade.CreateCar();

