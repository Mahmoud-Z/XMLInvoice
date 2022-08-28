using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace XmlTest
{
    public class SerializeSampleViewModel<T>
    {
        public string Serialize(string xmlFileName,T Entity, string invoiceType)
        {
            //XmlAttributeOverrides xOver = new XmlAttributeOverrides();
            //XmlAttributes attrs = new XmlAttributes();
            //attrs.XmlIgnore = true;
            //xOver.Add(typeof(CompanyName), "Numberes", attrs);
            //xOver.Add(typeof(CompanyName), "Time", attrs);
            var namespaces = new XmlSerializerNamespaces(); 
            namespaces.Add("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
            namespaces.Add("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"); 
            namespaces.Add("ext", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2");
            string ResultText = "";
            var serializer = new XmlSerializer(typeof(T),null,null, new XmlRootAttribute(invoiceType), "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2");
            using(var sw = new StringWriter())
            {
                serializer.Serialize(sw, Entity, namespaces);
                ResultText = sw.ToString();
            }
            WriteXmlFile(ResultText, xmlFileName);
            return ResultText;
        }
        public T Deserialize(string xmlFileName, T Entity)
        {
            Entity = default(T);
            var serializer = new XmlSerializer(typeof(T));
            using (var tw = new FileStream(xmlFileName + "/sample.xml", FileMode.Open))
            {
                Entity=(T)serializer.Deserialize(tw);
                tw.Close();
            }
            return Entity;
        }
        public T Deserialize2(string xmlFileName, T Entity)
        {
            Entity = default(T);
            var serializer = new XmlSerializer(typeof(T));
            using (var tw = new FileStream(xmlFileName + "/XML Test.xml", FileMode.Open))
            {
                Entity = (T)serializer.Deserialize(tw);
                tw.Close();
            }
            return Entity;
        }
        public void WriteXmlFile(string xml,string xmlFileName)
        {
            if (!Directory.Exists(Path.GetDirectoryName(xmlFileName)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(xmlFileName));
            }
            if (File.Exists(xmlFileName + "/sample.xml"))
            {
                File.Delete(xmlFileName + "/sample.xml");
            }
            File.AppendAllText(xmlFileName+"/sample.xml", xml,Encoding.Unicode);
            XDocument doc = XDocument.Load(xmlFileName + "sample.xml");
            doc.Descendants().Where(e => e.IsEmpty || string.IsNullOrEmpty(e.Value)/* || e.Value.ToString() == "-1" || e.Value.ToString() == "false"*/).Remove();
            doc.Save(xmlFileName + "sample.xml");
        }
    }
}
