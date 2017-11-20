using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Octopus.Client;

namespace OctoClient
{
    internal class Program
    {
        public static void Main()
        {
            var server = ConfigurationManager.AppSettings["server"];
            var apiKey = ConfigurationManager.AppSettings["apiKey"];

            var endpoint = new OctopusServerEndpoint(server, apiKey);
            var repository = new OctopusRepository(endpoint);

            var groups = repository.Environments.GetAll().Select((environment, index) => new RDCManFileGroup
            {
                properties = new RDCManFileGroupProperties { name = $"{index + 1}. {environment.Name}" },
                server = repository.Environments.GetMachines(environment).Select(machine => new RDCManFileGroupServer
                {
                    properties = new RDCManFileGroupServerProperties
                    {
                        displayName = machine.Name,
                        name = machine.Name,
                        comment = string.Join(Environment.NewLine, machine.Roles)
                    }
                }).ToArray()
            });

            var rdcMan = new RDCMan
            {
                file = new RDCManFile
                {
                    properties = new RDCManFileProperties { name = "Octopus" },
                    group = groups.ToArray()
                },
                programVersion = 2.7M,
                schemaVersion = 3
            };

            var xmlSerializer = new XmlSerializer(typeof(RDCMan));
            var output = File.Create("result.rdg");
            xmlSerializer.Serialize(output, rdcMan);
        }
    }
}
