using System.Collections.Generic;
using System.Xml.Serialization;

namespace XmlTest
{
    [XmlRoot("CustomerSource", Namespace = "http://www.google3.com")]
    public class CustomerRoot
    {
        [XmlElement("CustomerDetails", Namespace = "http://www.google.com")]
        public List<Customer> Customers { get; set; }
    }
}
