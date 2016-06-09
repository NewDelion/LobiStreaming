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
            //プラグインを神が作りますw(公開バージョン)
            //https://web.lobi.co/group/a5babead5099b687d25354a8c94ca81309b290e3
            string group_id = "a5babead5099b687d25354a8c94ca81309b290e3";

            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            //ゲストじゃなくて、アプリをLobiに登録してアクセストークンを使ってストリームを受信しても内容は同じだった
            using (StreamReader stream = new StreamReader(client.OpenRead("https://stream.lobi.co/1/guest/group/" + group_id)))
            {
                while (true)
                {
                    Console.WriteLine(stream.ReadLine());
                }
            }
        }
    }
}
