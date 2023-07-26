using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserApp
{
    public sealed class VirtualDB
    {
        public List< User> users = new List<User>();
        public VirtualDB()
        {
            User user1 = new User()
            {
                Id = Guid.NewGuid(),
                Name = "Burak",
                Username = "brk",
                Password = "123",
                Email = "b@b.com.tr"
            };
            User user2 = new User()
            {
                Id = Guid.NewGuid(),
                Name = "Melis",
                Username = "mls",
                Password = "123",
                Email = "m@b.com.tr"
            };

            users.Add(user1);
            users.Add(user2);

        }
    }
}
