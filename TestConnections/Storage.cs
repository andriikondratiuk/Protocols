using System;
using System.IO;
using TestConnections.Protocols;

namespace TestConnections
{
    public class Storage
    {
        private readonly BaseProtocol _uploadConfiguration;

        public Storage(BaseProtocol uploadConfiguration)
        {
            _uploadConfiguration = uploadConfiguration;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="content"></param>
        /// <returns>Url to uploaded file</returns>
        public string UploadFile(string fileName, byte[] content)
        {
            //New name used for preventing upload two files with same name into storage
            var name = Guid.NewGuid().ToString() + Path.GetExtension(fileName); 

            throw new NotImplementedException();

            return _uploadConfiguration.PublicAccessUrl + name;
        }
    }
}
