using System;
using TestConnections.Protocols;

namespace TestConnections
{
    public static class Program
    {
        public static void Main()
        {
            Ssh protocol = new Ssh("blala.com") { User = "", Password = "ssh-dss-c1-b1-30-29-d7-b8-de-6c-97-77-10-d7-46-41-63-87" };
            Console.WriteLine(protocol.GetConnectionStr());
        }
    }
}
