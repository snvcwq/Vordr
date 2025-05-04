using MediatR;
using System.Net;
using System.Net.Sockets;
using Vordr.Application.SocketMessages.HandleSocketMessagesCommand;
using Vordr.Common.Helpers;
using Vordr.Common.Messaging;

namespace Presentation.Options;

public static class SocketHelper
{
    public static void StartListening(this System.Net.Sockets.Socket server, IPEndPoint ipEndPoint)
    {
        server.Bind(ipEndPoint);
        server.Listen();
        Console.WriteLine($"Server started Listening on port {ipEndPoint.Port}");
    }
    
     public static async Task StartAcceptingClientsAsync(this System.Net.Sockets.Socket server, ISender sender)
    {
        while (true)
            try
            {
                var handler = await server.AcceptAsync();
                _ = Task.Run(() => HandleClientAsync(handler, sender));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while accepting client: {ex.Message}");
            }
    }

    private static async Task HandleClientAsync(System.Net.Sockets.Socket handler, ISender sender)
    {
        try
        {
            while (true)
            {
                var buffer = new byte[5 * 1024 * 1024];
                var received = await handler.ReceiveAsync(buffer, SocketFlags.None);
                if (received == 0)
                {
                    Console.WriteLine("Client disconnected.");
                    break;
                }
                var message = received.FromBytes(buffer).JsonDeserialize<SocketMessage>();

                var result = await sender.Send(new HandleSocketMessagesCommand(message));
                
                await handler.SendAsync(result.JsonSerialize().ToBytes(), SocketFlags.None);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error occurred while handling client: {ex.Message}");
        }
    }

    private static async Task SendMessage<T>(this System.Net.Sockets.Socket socket, T message)
    {
        await socket.SendAsync(message.JsonSerialize().ToBytes(), SocketFlags.None);
    }
}
