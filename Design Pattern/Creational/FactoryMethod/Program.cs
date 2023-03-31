using FactoryMethod.Abstracts;
using FactoryMethod.Concretes;



//var kargo = new KamilKargo();
//kargo.Logistics.Add(new RoadLogistic());
//kargo.Logistics.Add(new SeaLogistic());

//var transport = kargo.Logistics[1].CreateTransport();
//kargo.Logistics[0].PlanDelivery();
//kargo.Logistics[1].PlanDelivery();
//transport.Deliver();

//BadLogistic bl = new() { State = "road" };

//ITransport? transport = null;

//if (bl.State == "road")
//    transport = new Truck();
//else if (bl.State == "sea")
//    transport = new Ship();

//transport?.Deliver();

Logistic logistic = new AirLogistic();

var trasport = logistic.CreateTransport();

trasport.Deliver();