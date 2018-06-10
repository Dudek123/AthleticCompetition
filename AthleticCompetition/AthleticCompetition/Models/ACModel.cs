using AthleticCompetition.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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
                        writer.WriteElementString("Result", r.PlayerResult);
                        writer.WriteEndElement();
                    }

                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }

            return true;
        }
    }
}
