namespace Luis.MasteringExtJs.WebApi.Models
{
    public class AuthTicket
    {
        public string Ticket { get; set; }
        public bool Success { set; get; }
        public string Msg { get; set; }
        public bool Authenticated { get; set; }
    }
}