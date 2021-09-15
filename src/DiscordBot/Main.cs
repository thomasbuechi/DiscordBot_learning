using System;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;

namespace DiscordBot_learning
{
    public class Program
    {
        private DiscordSocketClient client;
        
        public static void Main(string[] args)
            => new Program().MainAsync().GetAwaiter().GetResult();

        public async Task MainAsync()
        {
            const string token = "ODg3NzEwODk5MTc0MDA2Nzg0.YUIHMw._0iXDhLhGQZj5DnEcDEKzt5eVt8";
            client = new DiscordSocketClient();
            client.Log += Log;
            
            await client.LoginAsync(TokenType.Bot, token);
            await client.StartAsync();

            // Block this task until the program is closed.
            await Task.Delay(-1);
        }
        
        
        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
    }

}