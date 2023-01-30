using System.Xml.Serialization;

namespace Lesson15
{
    [Serializable]
    public class Car
    {
        [XmlAttribute("Identifier")]
        public int Id { get; set; }
        [XmlAttribute]
        public string? Vendor { get; set; }
        [XmlAttribute]
        public string? Model { get; set; }
        [XmlAttribute]
        public int Year { get; set; }

        public override string ToString()
        {
            return $"{Vendor} {Model} {Year}";
        }
    }
}
