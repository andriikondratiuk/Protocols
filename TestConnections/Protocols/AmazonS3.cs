//s3://my-bucket/my/funny/picture.jpg
//http://mybucket.s3.amazonaws.com/myobject.ext
using System;

namespace TestConnections.Protocols
{
    public class AmazonS3 : BaseProtocol
    {
        public AmazonS3(string host) : base(host)
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
