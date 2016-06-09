using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;


namespace LobiStream
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            using (StreamReader stream = new StreamReader(client.OpenRead("https://stream.lobi.co/1/guest/group/a5babead5099b687d25354a8c94ca81309b290e3")))
            {
                while (true)
                {
                    Console.WriteLine(stream.ReadLine());
                }
            }
        }
    }
}
