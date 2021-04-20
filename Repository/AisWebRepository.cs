using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Contracts;
using Entities;
using Entities.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RestSharp;

namespace Repository
{
    class AisWebRepository: RepositoryBase<Aisweb>, IAisWebRepository
    {
        private readonly string UrlBase = "http://aisweb.decea.gov.br/api/?";
        private readonly string ApiKey = "1524259561";
        private readonly string ApiPass = "5931744e-1792-11eb-9a71-0050569ac1e0";

        public AisWebRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task PegarNotamPorDataAsync(DateTime dataBusca)
        {
            /*
            http://aisweb.decea.gov.br/api/?apiKey={{api_key}}&apiPass={{api_pass}}&area=notam&dist={{notam_dist}}&nof={{notam_nof}}&serie={{notam_serie}}&categoria={{notam_categoria}}&status={{status}}&fir={{notam_fir}}&nnotam={{notam_nnotam}}&ano={{notam_ano}}&dt_ref={{notam_dt_ref}}&dt={{notam_dt}}&all={{notam_all}}&minutes={{notam_minutes}}&dt_start={{notam_dt_start}}&dt_end={{notam_dt_end}}&icaocode={{notam_icao_code}}
            */

            //Console.WriteLine(IConfiguration.GetSection("AisWeb:AiswebApiKey"));

            var client = new RestClient($"{UrlBase}apiKey={ApiKey}&apiPass={ApiPass}&area=notam&dt_ref={dataBusca.ToString("dd-MM-yy")}");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            var response = await client.ExecuteAsync(request);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(response.Content);

            string xpath = "aisweb/notam/item";
            var nodes = xmlDoc.SelectNodes(xpath);

            foreach (XmlNode childrenNode in nodes)
            {
                Console.WriteLine(
                    "Movie - Id: " + childrenNode.SelectSingleNode(".//id").InnerText +
                    ", Cod: " + childrenNode.SelectSingleNode(".//cod").InnerText);
            }

            /*
            var response = await Task.Run((() => client.Execute(new RestRequest())));
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(response.Content);

            string xpath = "aisweb/notam/item";
            var nodes = xmlDoc.SelectNodes(xpath);

            foreach (XmlNode childrenNode in nodes)
            {
                Console.WriteLine(
                    "Movie - Id: " + childrenNode.SelectSingleNode(".//id").InnerText +
                    ", Name: " + childrenNode.SelectSingleNode(".//Name").InnerText);
            }


            Console.WriteLine(nodes.Count);

            */
        }

    
    }
}
