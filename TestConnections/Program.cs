using System;
using System.IO;
using TestConnections.Protocols;

namespace TestConnections
{
    public static class Program
    {
        public static void Main()
        {
            //Ssh protocol = new Ssh("blala.com") { User = "", Password = "ssh-dss-c1-b1-30-29-d7-b8-de-6c-97-77-10-d7-46-41-63-87" };
            //Console.WriteLine(protocol.GetConnectionStr());

            var pathToFtpConfigurationFile = "";
            var pathToFile = "";

            var ftpConfiguration = Ftp.Load(pathToFtpConfigurationFile);
            var storage = new Storage(ftpConfiguration);
            var fileContent = File.ReadAllBytes(pathToFile);
            var url = storage.UploadFile("example-1", fileContent);

            Console.WriteLine(url);
        }
    }
}
