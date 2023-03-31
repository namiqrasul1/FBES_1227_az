using AbstractFactory.Abstracts;
using AbstractFactory.Concretes;

IFurnitureFactory factory = new ArtFurnitureFactory();

var chair = factory.CreateChair();

chair.WhoAreYou();
