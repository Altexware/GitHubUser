using Alexware.GitHubUser;

namespace TestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a GitHub username: ");
            string? user = Console.ReadLine();
            GitHubAccountResponse res = new GitHubAccount().GetUserInformation(user);
            if (!string.IsNullOrEmpty(user))
            {
                Console.WriteLine($"Name: {res.name}");
                Console.WriteLine($"ID: {res.id}");
                Console.WriteLine($"Avatar Url: {res.avatar_url}");
                Console.WriteLine($"Location: {res.location}");
                Console.WriteLine($"Hireable: {res.hireable}");
                Console.WriteLine($"Account Creation Time: {res.created_at}");
            }
        }
    }
}