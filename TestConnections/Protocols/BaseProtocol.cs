using System;

namespace TestConnections.Protocols
{
    public abstract class BaseProtocol
    {
        public BaseProtocol(string host)
        {
            _host = host;
            _schema = SchemasName.http;
        }
       
        public string User { get; set; }
        public string Password { get; set; }
        public string Port { get; set; }
        public string UrlPath { get; set; }

        protected SchemasName _schema;
        protected string _host;

        public abstract string GetConnectionStr();

        protected void Empty()
        {
            if (User == "" || Password == "")
            {
                throw new Exception("User or Password not corect!");
            }
        }
    }
}
