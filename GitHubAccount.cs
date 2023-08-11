using System;
using System.Net;

namespace Alexware.GitHubUser
{
    class GitHubAccount
    {
        private string APIKey;

        public GitHubAccount(string Key)
        {
            APIKey = Key;
        }

        public GitHubAccountResponse GetUserInformation(string Username)
        {
            string RequestURL = $"https://api.github.com/users/{Username}";
            
        }
    }
}