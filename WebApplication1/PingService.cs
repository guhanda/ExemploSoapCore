using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;

namespace WebApplication1
{
    [ServiceContract]
    public interface IPingService
    {
        [OperationContract]
        string Ping(string msg);
    }

    public class PingService : IPingService
    {
        public string Ping(string msg)
        {
            return msg;
        }
    }
}
