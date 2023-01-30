using System.Xml.Serialization;

namespace Lesson15
{
    [Serializable]
    public class Gallery
    {
        [XmlArray]
        public List<Car>? Cars { get; set; }
        [XmlAttribute]
        public string? Name { get; set; }
        [XmlAttribute]
        public string? Address { get; set; }
        [XmlAttribute("phone")]
        public string? PhoneNumber { get; set; }
    }
}
