using Bond;
using Krooze.EntranceTest.WriteHere.Structure.Model;
using System.IO;
using System.Xml.Serialization;

namespace Krooze.EntranceTest.WriteHere.Tests.LogicTests
{
    public class XMLTest
    {
        public CruiseDTO TranslateXML()
        {
            //TODO: Take the Cruises.xml file, on the Resources folder, and translate it to the CruisesDTO object,

            FileStream st = new FileStream("C:/Users/Rafael/Desktop/kroozegdschallenge/Krooze.EntranceTest.WriteHere/Resources/Cruises.xml", FileMode.OpenOrCreate);
            XmlSerializer dsXML = new XmlSerializer(typeof(CruiseDTO));
            CruiseDTO cruise = (CruiseDTO)dsXML.Deserialize(st);
            return cruise;
        }
    }
}
