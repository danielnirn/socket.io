using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quobject.SocketIoClientDotNet.Client;

namespace IOT
{
    class Program
    {
        static void Main(string[] args)
        {

            var socket = IO.Socket("http://localhost:3000");
            socket.On(Socket.EVENT_CONNECT, () =>
            {
                socket.Emit("hi", "test");
	
            });

            socket.On("hi", (data) =>
            {
                Console.WriteLine(data);
                    // socket.Disconnect();
            });
            Console.ReadLine();
        }
    }
}
