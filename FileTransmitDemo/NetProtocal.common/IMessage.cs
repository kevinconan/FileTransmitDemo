using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetProtocol.Common
{
    public abstract class IMessage
    {
        public CommandType CommandType { get; set; }
        public object Content { get; set; }

    }

    public enum CommandType : int { 
        HeartBeats = 0,
        Login = 1,
        Logout = 2,
        Response = 3,
        File = 4
    }
}
