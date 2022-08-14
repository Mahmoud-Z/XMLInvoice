using System;
using System.ComponentModel;
using System.Web;
using System.Xml.Serialization;

namespace XmlTest
{
    //Omar: Hi Gemy Joniour
    public class CompanyName
    {
        [XmlAttribute]
        public string type { get; set; }
        //[XmlIgnore]
        [XmlElementAttribute(IsNullable = true)]
        public int? Numberes { get; set; }
        public string test { get; set; }
        public DateTime? Time { get; set; }
        [XmlText()] 
        public string value { get; set; }
        public bool ShouldSerializeNumberes() => Numberes.HasValue;
    }
    public class Customer
    {
        [XmlElement("CusID")]
        //CusID_x0024_uui_x002A__x0023_a
        public int CustomerID { get; set; }
        [XmlElement("LName", Namespace = "http://www.google2.com")]
        public string LName { get; set; }
        public string FName { get; set; }
        public CompanyName CompanyName { get; set; }
    }
}
