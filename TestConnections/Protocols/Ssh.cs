//ssh://[<user>[;fingerprint=<host-key fingerprint>]@]<host>[:<port>]
using System;

namespace TestConnections.Protocols
{
    public class Ssh : BaseProtocol
    {
        public Ssh(string host) : base(host)
        {
            _schema = SchemasName.ssh;
            Port = "22";
        }

        public override string GetConnectionStr()
        {
                Empty();
                var str = $"{_schema}://";
                str += User?.Insert(User.Length, "@");
                if (User != null & Password != null)
                {
                    str = str.Insert(str.Length - 1, $";fingerprint={Password}");
                }
                str += _host;
                str += Port?.Insert(0, ":");
                return str;        
        }
    }
}
