using Lesson15;
using System.Text;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

void XmlWrite(List<Car> cars)
{
    using XmlTextWriter writer = new("carsFile.xml", Encoding.UTF8);

    writer.Formatting = Formatting.Indented;

    writer.WriteStartDocument();
    writer.WriteStartElement("cars");
    foreach (var car in cars)
    {
        writer.WriteStartElement("car");

        writer.WriteAttributeString(nameof(car.Vendor), car.Vendor);
        writer.WriteAttributeString(nameof(car.Model), car.Model);
        writer.WriteAttributeString(nameof(car.Year), car.Year.ToString());

        //writer.WriteElementString(nameof(car.Vendor), car.Vendor);
        //writer.WriteElementString(nameof(car.Model), car.Model);
        //writer.WriteElementString(nameof(car.Year), car.Year.ToString());

        writer.WriteEndElement();
    }
    writer.WriteEndElement();
    writer.WriteEndDocument();
}

void XmlRead(List<Car> cars)
{
    XmlDocument doc = new();
    doc.Load("carsFile.xml");
    XmlElement? root = doc.DocumentElement;
    if(root != null)
    {
        if (root.HasChildNodes)
        {
            foreach (XmlNode node in root.ChildNodes)
            {
                var car = new Car()
                {
                    Vendor = node.Attributes![0].Value,
                    Model = node.Attributes![1].Value,
                    Year = int.Parse(node.Attributes![2].Value),
                };
                cars.Add(car);
            }
        }
    }
}

//List<Car> cars = new()
//{
//    new(){ Vendor = "Tesla", Model = "Model-X", Year=2022 },
//    new(){ Vendor = "Chevrolet", Model = "Camaro", Year=2022 },
//    new(){ Vendor = "Ford", Model = "Mustang 60", Year=1960 },
//};

////XmlWrite(cars);
//cars.Clear();
//XmlRead(cars);

//cars.ForEach(c => Console.WriteLine(c));

//Gallery gallery = new()
//{
//    Name = "ByCars",
//    Address = "K.Rahimov 70",
//    PhoneNumber = "+994551234567",
//    Cars = new()
//    {
//        new(){ Vendor = "Tesla", Model = "Model-X", Year=2022 },
//        new(){ Vendor = "Chevrolet", Model = "Camaro", Year=2022 },
//        new(){ Vendor = "Ford", Model = "Mustang 60", Year=1960 },
//    }
//};

//var xml = new XmlSerializer(typeof(Gallery));
//using FileStream fs = new FileStream("gallery.xml", FileMode.Create, FileAccess.Write);
//xml.Serialize(fs, gallery);

//Gallery? gallery = null;
//var xml = new XmlSerializer(typeof(Gallery));
//using FileStream fs = new FileStream("gallery.xml", FileMode.Open, FileAccess.Read);
//gallery = xml.Deserialize(fs) as Gallery;
//Console.WriteLine(gallery?.Name);
//Console.WriteLine(gallery?.Address);
//Console.WriteLine(gallery?.PhoneNumber);
//foreach (var item in gallery?.Cars)
//{
//    Console.WriteLine(item);
//}


// JSON
// [] => arrat
// {} => object

List<Car> cars = new()
{
    new(){ Vendor = "Tesla", Model = "Model-X", Year=2022 },
    new(){ Vendor = "Chevrolet", Model = "Camaro", Year=2022 },
    new(){ Vendor = "Ford", Model = "Mustang 60", Year=1960 },
};
var options = new JsonSerializerOptions { WriteIndented = true };
var json = JsonSerializer.Serialize(cars, options);
File.WriteAllText("cars.json", json);

//List<Car>? cars = null;
//var json = File.ReadAllText("cars.json");
//cars = JsonSerializer.Deserialize<List<Car>>(json);

//foreach (var item in cars)
//{
//    Console.WriteLine(item);
//}