using System;

namespace TestConnections.Protocols
{
    public abstract class BaseProtocol
    {
        protected BaseProtocol(string host, SchemasName schema)
        {
            _host = host;
            Schema = schema;
        }

        public string User { get; set; }
        public string Password { get; set; }
        public string Port { get; set; }

        public string UrlPath { get; set; }

        public SchemasName Schema { get; private set; }

        /// <summary>
        /// Base url for access uploaded file via web
        /// </summary>
        public string PublicAccessUrl { get; set; }

        protected string _host;

        public abstract string GetConnectionStr();

        

        protected void Validate()
        {
            if (User == "" || Password == "")
            {
                throw new Exception("User or Password not corect!");
            }
        }
    }
}
