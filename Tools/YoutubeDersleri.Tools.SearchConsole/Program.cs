using Google.Apis.Auth.OAuth2;
using Google.Apis.SearchConsole.v1;
using Google.Apis.Services;
using System;

namespace YoutubeDersleri.Tools.SearchConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("url giriniz");
            var url = Console.ReadLine();

            var json_file = System.IO.File.ReadAllText("site.json");

            var service = new IndexWrapper(json_file);
            var result = service.Publish(url);

            if (result)
                Console.WriteLine("Url dizine gönderildi");
            else
                Console.WriteLine("GÖnderemedim hata oldu");


            Console.WriteLine("işlem bitti");
            Console.ReadLine();
        }
    }

    public class ServiceStarter
    {
        private readonly string credentialsJson;

        public ServiceStarter(string credentialsJson)
        {
            this.credentialsJson = credentialsJson;
        }

        private readonly string[] _scopes =
        {
            SearchConsoleService.Scope.WebmastersReadonly,
            SearchConsoleService.Scope.Webmasters,
        };

        public SearchConsoleService GetWebmasterService()
        {
            var credential = GoogleCredential.FromJson(credentialsJson)
                .CreateScoped(_scopes)
                .UnderlyingCredential as ServiceAccountCredential;

            return new SearchConsoleService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
            });
        }
    }
}
