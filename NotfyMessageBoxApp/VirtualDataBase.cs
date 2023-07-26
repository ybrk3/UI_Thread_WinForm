using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotfyMessageBoxApp
{
    public sealed class VirtualDataBase
    {
        public List<User> users;
        public VirtualDataBase()
        {
            users = new List<User>();
        }
    }
}
