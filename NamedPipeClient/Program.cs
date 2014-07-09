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
            byte[] buff = new byte[64];
            Console.WriteLine("buffer prepared");
            client.Read(buff, 0, 64); 
            Console.WriteLine("Data read");
            Console.WriteLine(System.Text.Encoding.Default.GetString(buff));
            Console.WriteLine("Data printed, any key to exit...");
            Console.ReadLine();
        }
    }
}
