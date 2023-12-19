namespace Server
{
    using Microsoft.AspNet.SignalR;
    using System.Web.Http;

    public class ValuesController : ApiController
    {
        private readonly IHubContext hubContext = GlobalHost.ConnectionManager.GetHubContext<SignalRHub>();

        // GET api/values 
        public string Get()
        {
            hubContext.Clients.All.Send("John", new RandomPayload { Message = "Message from .NET Framework server!"});
            return "Message sent!";
        }
    }

    // Complex type to send over the wire
    public class RandomPayload
    {
        public string Message { get; set; }
    }
    
    // The SignalR hub
    public class SignalRHub : Hub
    { }
}