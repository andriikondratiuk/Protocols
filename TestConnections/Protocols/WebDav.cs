using System;

namespace TestConnections.Protocols
{
    public class WebDav : BaseProtocol
    {
        public WebDav(string host) : base(host, SchemasName.WebDav)
        {
        }

        public override string GetConnectionStr()
        {
            var str = $"{Schema}://" + _host + UrlPath?.Insert(0, "/");

            return str;
        }
    }
}
