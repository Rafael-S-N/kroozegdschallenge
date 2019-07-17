using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Krooze.EntranceTest.WriteHere.Tests.WebTests
{
    public class WebTest
    {
        public JObject GetAllMovies()
        {
            //TODO: Consume the following API: https://swapi.co/documentation using only .NET standard libraries (do not import the helpers on this page)
            // -Return the films object

            var request = (HttpWebRequest)WebRequest.Create("https://swapi.co/api/films/");
            request.ContentType = "application/json";
            request.Method = "GET";

            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var moviesObj = JsonConvert.DeserializeObject<JObject>(streamReader.ReadToEnd());
                return moviesObj;
            }
        }

        public string GetDirector()
        {
            //TODO: Consume the following API: https://swapi.co/documentation using only .NET standard libraries (do not import the helpers on this page)
            // -Return the name of person that directed the most star wars movies, based on the films object return

            var request = (HttpWebRequest)WebRequest.Create("https://swapi.co/api/films/");
            request.ContentType = "application/json";
            request.Method = "GET";

            var response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var moviesObj = JsonConvert.DeserializeObject<JObject>(streamReader.ReadToEnd());
                var director = moviesObj["results"].Value<JArray>().FirstOrDefault(x => x["episode_id"].Value<int>() == 4);
                return director["director"].Value<string>(); 
            }
        }
    }
}
