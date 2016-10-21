using System;

namespace TestConnections.Protocols
{
    public class WebDav : BaseProtocol
    {
        public WebDav(string host) : base(host)
        {            
        }

        public override string GetConnectionStr()
        {
            var str = $"{_schema}://";
            str += _host;
            str += UrlPath?.Insert(0, "/");
            return str;
        }
    }
}
