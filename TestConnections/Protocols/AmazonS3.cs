//s3://my-bucket/my/funny/picture.jpg
//http://mybucket.s3.amazonaws.com/myobject.ext
using System;

namespace TestConnections.Protocols
{
    public class AmazonS3 : BaseProtocol
    {
        public AmazonS3(string host)
            : base(host, SchemasName.S3)
        {
        }

        public override string GetConnectionStr()
        {
            var str = $"{Schema}://" + _host + UrlPath?.Insert(0, "/");

            return str;
        }
    }
}
