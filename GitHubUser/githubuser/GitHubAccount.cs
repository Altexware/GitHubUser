using System;
using System.Net;
using Newtonsoft.Json;
#pragma warning disable 8600
#pragma warning disable 8603
#pragma warning disable SYSLIB0014

namespace Alexware.GitHubUser
{
    public class GitHubAccount
    {
        private string APIKey;

        public GitHubAccount()
        {
            APIKey = "";
        }
        public GitHubAccount(string Key)
        {
            APIKey = Key;
        }
        
        public GitHubAccountResponse GetUserInformation(string? Username)
        {
            if (!string.IsNullOrEmpty(Username))
            {
                HttpWebRequest webRequest = WebRequest.Create($"https://api.github.com/users/{Username}") as HttpWebRequest;
                if (webRequest != null)
                {
                    webRequest.Method = "GET";
                    webRequest.UserAgent = "Anything";
                    webRequest.ServicePoint.Expect100Continue = false;
                    try
                    {
                        using (StreamReader responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
                        {
                            string reader = responseReader.ReadToEnd();
                            return JsonConvert.DeserializeObject<GitHubAccountResponse>(reader);
                        }
                    }
                    catch
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            else
            {
                Console.WriteLine("Sorry, we cannot make a GET request to GitHub with an invalid username.");
                return null;
            }
        }
    }
}