using System.Collections.Generic;

namespace Luis.MasteringExtJs.WebApi.Models
{
    public class Group
    {
        public Group()
        {
            Users = new List<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public List<User> Users { get; set; }
    }
}