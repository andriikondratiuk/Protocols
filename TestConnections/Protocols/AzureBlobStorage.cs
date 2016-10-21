//https://myaccount.blob.core.windows.net/mycontainer/myblob
using System;

namespace TestConnections.Protocols
{
    class AzureBlobStorage : BaseProtocol
    {
        public AzureBlobStorage(string host)
            : base(host, SchemasName.https)
        {
        }

        public override string GetConnectionStr()
        {
            var str = $"{Schema}://" + _host + UrlPath?.Insert(0, "/");

            return str;
        }
    }
}
