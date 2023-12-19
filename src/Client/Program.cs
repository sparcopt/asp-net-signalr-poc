using Microsoft.AspNet.SignalR.Client;

using var hubConnection = new HubConnection("http://localhost:9000");
var hubProxy = hubConnection.CreateHubProxy("SignalRHub");

hubProxy.On<string, RandomPayload>("send", (sender, payload) =>  Console.WriteLine($"Message from server >> {sender} said: {payload.Message}"));

await hubConnection.Start();
Console.ReadKey();

// Complex type to receive over the wire
public class RandomPayload
{
    public string Message { get; set; }
}
