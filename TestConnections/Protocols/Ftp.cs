//ftp://[<пользователь>[:<пароль>]@]<хост>[:<порт>]/<путь>
using System;

namespace TestConnections.Protocols
{
    public class Ftp : BaseProtocol
    {
        public Ftp(string host):base(host)
        {
            _schema = SchemasName.ftp;
            Port = "21";
        }
        public override string GetConnectionStr()
        {
            Empty();
            var str = $"{_schema}://";
            str += User?.Insert(User.Length, "@");
            if (User != null & Password != null)
            {
                str = str.Insert(str.Length - 1,$":{Password}");
            }           
            str += _host;
            str += Port?.Insert(0,":");
            str += UrlPath?.Insert(0,"/");
            return str;
        }
    }
}
