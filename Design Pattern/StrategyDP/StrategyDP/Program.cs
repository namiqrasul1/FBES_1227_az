using StrategyDP;

var order = new Order { OrderTotal = 100 };

order.SetStrategy(new StandartDelivery());

Console.WriteLine($"Cost {order.CalculateCost()}");
Console.WriteLine($"Delivery time {order.GetDeliveryTime()}");

Console.WriteLine();

order.SetStrategy(new ExpressDelivery());

Console.WriteLine($"Cost {order.CalculateCost()}");
Console.WriteLine($"Delivery time {order.GetDeliveryTime()}");


Console.WriteLine();


order.SetStrategy(new SameDayDelivery());

Console.WriteLine($"Cost {order.CalculateCost()}");
Console.WriteLine($"Delivery time {order.GetDeliveryTime()}");