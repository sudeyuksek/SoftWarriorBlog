using Google.Apis.Auth.OAuth2;
using Google.Apis.Indexing.v3;
using Google.Apis.Indexing.v3.Data;
using Google.Apis.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace YoutubeDersleri.Tools.SearchConsole
{
    public class IndexWrapper
    {
        private readonly string credentialsJson;

        public IndexWrapper(string credentialsJson)
        {
            this.credentialsJson = credentialsJson;
        }

        private readonly string[] _scopes =
        {
            IndexingService.Scope.Indexing
        };

        public IndexingService GetIndexingService()
        {
            var credential = GoogleCredential.FromJson(credentialsJson)
                .CreateScoped(_scopes)
                .UnderlyingCredential as ServiceAccountCredential;

            return new IndexingService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
            });
        }

        public bool Publish(string url)
        {
            try
            {
                var service = GetIndexingService();
                var url_address = new UrlNotification()
                {
                    Type = "URL_UPDATED",
                    Url = url,
                };

                var requestResponse = service.UrlNotifications.Publish(url_address);
                var response = requestResponse.Execute();


                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
