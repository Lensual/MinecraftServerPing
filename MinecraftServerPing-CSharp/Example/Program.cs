using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MinecraftServerPing_CSharp;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            MinecraftPingReply data = new MinecraftPing().getPing(new MinecraftPingOptions().setHostname("three.mengcraft.com").setPort(12633));
            Console.WriteLine(data.description + "  --  " + data.getPlayers().getOnline() + "/" + data.getPlayers().getMax());
        }
    }
}
