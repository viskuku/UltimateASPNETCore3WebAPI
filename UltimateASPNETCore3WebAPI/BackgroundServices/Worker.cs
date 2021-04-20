using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using RestSharp;

namespace UltimateASPNETCore3WebAPI.BackgroundServices
{
    public class Worker : BackgroundService
    {
        private const string UrlBase = "http://aisweb.decea.gov.br/api/?";
        private const string ApiKey = "1524259561";
        private const string ApiPass = "5931744e-1792-11eb-9a71-0050569ac1e0";

        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await PegarNotamPorDataAsync(DateTime.Now);
                await Task.Delay( 3000 , stoppingToken);
                _logger.LogInformation("Notam AisWeb running at: {time}", DateTimeOffset.Now);
            }
        }

        private async Task PegarNotamPorDataAsync(DateTime dataBusca)
        {
            /*
            http://aisweb.decea.gov.br/api/?apiKey={{api_key}}&apiPass={{api_pass}}&area=notam&dist={{notam_dist}}&nof={{notam_nof}}&serie={{notam_serie}}&categoria={{notam_categoria}}&status={{status}}&fir={{notam_fir}}&nnotam={{notam_nnotam}}&ano={{notam_ano}}&dt_ref={{notam_dt_ref}}&dt={{notam_dt}}&all={{notam_all}}&minutes={{notam_minutes}}&dt_start={{notam_dt_start}}&dt_end={{notam_dt_end}}&icaocode={{notam_icao_code}}
            */

            //Console.WriteLine(IConfiguration.GetSection("AisWeb:AiswebApiKey"));

            var client =
                new RestClient($"{UrlBase}apiKey={ApiKey}&apiPass={ApiPass}&area=notam&dt_ref={dataBusca:dd-MM-yy}")
                {
                    Timeout = -1
                };
            var request = new RestRequest(Method.GET);
            var response = await client.ExecuteAsync(request);
            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(response.Content);

            string xpath = "aisweb/notam/item";
            var nodes = xmlDoc.SelectNodes(xpath);
            /*
            foreach (XmlNode childrenNode in nodes)
            {
                Console.WriteLine(
                    "Movie - Id: " + childrenNode.SelectSingleNode(".//id").InnerText +
                    ", Cod: " + childrenNode.SelectSingleNode(".//cod").InnerText);
            }
            */
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
