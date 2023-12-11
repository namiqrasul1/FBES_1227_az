using ChainOfResponsibility.Models.Bases;

Human human1 = new("shotmenlikdirustam", "ruso@shamaxi.com", "xangalforever");
Human human2 = new(null, "islam@pulumyoxdu.com", "hormeasdasdasdt");

CheckerDirector director = new();
Console.WriteLine(director.MakeHumanChecker(human1) ? "Valid User": "Invalid User");
Console.WriteLine(director.MakeHumanChecker(human2) ? "Valid User": "Invalid User");