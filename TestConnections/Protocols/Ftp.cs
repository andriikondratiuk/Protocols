//ftp://[<пользователь>[:<пароль>]@]<хост>[:<порт>]/<путь>
using System;

namespace TestConnections.Protocols
{
    public class Ftp : BaseProtocol
    {
        public Ftp(string host)
            : base(host, SchemasName.FTP)
        {
            Port = "21";
        }
        public override string GetConnectionStr()
        {
            Validate();

            var str = $"{Schema}://" + User?.Insert(User.Length, "@");

            if (User != null & Password != null)
            {
                str = str.Insert(str.Length - 1, $":{Password}");
            }

            str += _host + Port?.Insert(0, ":") + UrlPath?.Insert(0, "/");

            return str;
        }

        public static Ftp Load(string path)
        {
            throw new NotImplementedException();
        }
    }
}
