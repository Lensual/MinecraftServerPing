using System;
using MinecraftServerPing_CSharp;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            MinecraftPingReply data = new MinecraftPing().getPing(new MinecraftPingOptions().setHostname("example.net").setPort(25565));
            Console.WriteLine(data.description + "  --  " + data.getPlayers().getOnline() + "/" + data.getPlayers().getMax());
            Console.ReadKey();
        }
    }
}
