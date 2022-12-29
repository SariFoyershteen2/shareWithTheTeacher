// See https://aka.ms/new-console-template for more information
using System.Xml.Linq;
const string FILENAME= "..//..//..//country.xml";


XDocument doc = XDocument.Load(FILENAME);

var y = doc.Root.Descendants("language")
        .Where(p => p.Value.CompareTo("עברית") == 0).Ancestors("event");
y.ToList().ForEach(ev => Console.WriteLine(ev.Attribute("name")?.Value));

var z = doc.Root.Descendants("CapitalCity")
        .Where(p => p.Value.CompareTo("Pariz") == 0).Ancestors("event");
z.ToList().ForEach(ev => Console.WriteLine(ev.Attribute("name")?.Value));

XElement el = new("event", new XAttribute("name", "אוקריאנה")
                        , new XElement("language", "רוסית")
                        , new XElement("cities", new XElement("city", new XAttribute("name", "Odesa"), new XAttribute("numOfPeople", "400000")))
                        );

doc.Root.Add(el);
doc.Root.Save(FILENAME);


//XElement ele = new("event", new XAttribute("name", "אוקראינה")
//                        , new XElement("language", "רוסית")
//                        , new XElement("cities", new XElement("city", new XAttribute("name", "Odesa"), new XAttribute("numOfPeople", "400000")))
//                        );

//doc.Root.Add(el);

//doc.Root.Save(FILENAME);

///הוספת עיר
var c = doc.Root.Descendants("name")
        .Where(p => p.Value.CompareTo("Isreal") == 0).Ancestors("event");
//z.ToList().ForEach(ev => Console.WriteLine(ev.Attribute("name")?.Value));
XElement ele = new("event", new XElement("city", new XAttribute("name", "Bet Shemesh"), new XAttribute("numOfPeople", "4000050"))
               
                       );

doc.Root.Add(ele);
doc.Root.Save(FILENAME);


//var c = doc.Root.Descendants("city")
//        .Where(p => p.Name.CompareTo("Odesa") == 0).Ancestors("event");
//y.ToList().ForEach(ev => doc.Root.Remove(city));