using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Pipes;

namespace NamedPipeClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Connecting to named pipe...");
            NamedPipeClientStream client = new NamedPipeClientStream("pipename");
            Console.WriteLine("Object created");
            client.Connect();
            Console.WriteLine("Connected");
            byte[] buff = new byte[512];
            Console.WriteLine("buffer prepared");
            client.Read(buff, 0, 512); 
            Console.WriteLine("Data read");
            Console.WriteLine(System.Text.Encoding.Default.GetString(buff).Split('\0')[0]);
            Console.WriteLine("Data printed, any key to exit...");
            Console.ReadLine();
        }
    }
}
