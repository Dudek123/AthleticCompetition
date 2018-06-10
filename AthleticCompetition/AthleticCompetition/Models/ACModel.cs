using AthleticCompetition.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;

namespace AthleticCompetition.Models
{
    public class ACModel
    {
        Competition competition = new Competition();
        Discipline newDiscipline = new Discipline();
        Result newResult = new Result();

        public ACModel()
        {
                
        }

        public bool SaveDiscipline(string name, List<string> players, List<string> results)
        {
            if (name == null)
            {
                Console.WriteLine("Wybierz dyscyplinę");
                return false;
            }
            
            foreach(var a in players)
            {
                if (a == string.Empty)
                    return false;
            }

            foreach (var a in results)
            {
                if (a == string.Empty)
                    return false;
            }


            Discipline newDiscipline = new Discipline(name);
            for(int i = 0; i < players.Count; i++)
            {
                Result newResult = new Result(players[i], results[i]);
                newDiscipline.AddResult(newResult);
            }
            competition.AddDiscipline(newDiscipline);
            return true;
        }

        public bool SaveCompetition(string name, string location, string date)
        {
            if (name == "" || location == "")
            {
                return false;
            }
                
            competition.CompetitionName = name;
            competition.CompetitionLocation = location;
            competition.CompetitionDate = date;

            try
            {
                if (System.IO.File.Exists(competition.CompetitionName + ".xml"))
                    System.IO.File.Delete(competition.CompetitionName + ".xml");
            }
            catch(Exception)
            {
                return false;
            }

            if (competition.Disciplines.Count == 0)
                return false;

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create(competition.CompetitionName + ".xml", settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Competition");
                writer.WriteElementString("CompetitionName", competition.CompetitionName);
                writer.WriteElementString("CompetitionLocation", competition.CompetitionLocation);
                writer.WriteElementString("CompetitionDate", competition.CompetitionDate);
                foreach (Discipline d in competition.Disciplines)
                {
                    writer.WriteStartElement("Discipline");
                    writer.WriteElementString("DisciplineName", d.DisciplineName);

                    foreach (Result r in d.Results)
                    {
                        writer.WriteStartElement("Result");
                        writer.WriteElementString("Player", r.Player);
                        writer.WriteElementString("PlayerResult", r.PlayerResult);
                        writer.WriteEndElement();
                    }

                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }

            return true;
        }

        public bool LoadCompetition(string path)
        {
            competition.ClearCompetition();

            XmlDocument document = new XmlDocument();

            try
            {
                document.Load(path);
            }
            catch (Exception)
            {
                return false;
            }

            XPathNavigator navigator = document.CreateNavigator();
            XPathNodeIterator disciplines = navigator.Select("/Competition/Discipline");

            XPathNavigator competitionName = navigator.SelectSingleNode("/Competition/CompetitionName");
            competition.CompetitionName = competitionName.Value;

            XPathNavigator competitionLocation = navigator.SelectSingleNode("/Competition/CompetitionLocation");
            competition.CompetitionLocation = competitionLocation.Value;

            XPathNavigator competitionDate = navigator.SelectSingleNode("/Competition/CompetitionDate");
            competition.CompetitionDate = competitionDate.Value;

            foreach (XPathNavigator d in disciplines)
            {
                XPathNavigator nav = d.SelectSingleNode("DisciplineName");
                Discipline disc = new Discipline(nav.Value);

                XPathNodeIterator results = d.Select("Result");

                foreach (XPathNavigator r in results)
                {
                    XPathNavigator nav2 = r.SelectSingleNode("Player");
                    XPathNavigator nav3 = r.SelectSingleNode("PlayerResult");
 
                    Result res = new Result(nav2.Value, nav3.Value);

                    disc.AddResult(res);
                }
                competition.AddDiscipline(disc);
            }
            Console.WriteLine("Odczytałem z pliku dane");
            return true;
        }

        public string[] GetXMLFiles()
        {
            return Directory.GetFiles(Directory.GetCurrentDirectory().ToString(), "*.xml");
        }

        public bool ClearCompetition()
        {
            competition.ClearCompetition();
            return true;
        }

        public List<string> GetCompetitionInfos()
        {
            List<string> lista = new List<string>();
            lista.Add(competition.CompetitionName);
            lista.Add(competition.CompetitionLocation);
            lista.Add(competition.CompetitionDate);
            return lista;
        }

        public Discipline GetDiscipline(int number)
        {
            return competition.GetDiscipline(number);
        }
    }
}
