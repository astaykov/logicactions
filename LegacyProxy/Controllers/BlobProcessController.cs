using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Web.Http;

namespace LegacyProxy.Controllers
{
    public class BlobProcessController : ApiController
    {
        protected static string acct = "stlogicbuffer";
        protected static string key = "2NOI0AlshUZvOHTsHKNuL51jIoUKyAH+tSRU34iJPFMPiZI2TgiP5Hgm+P9YcFmH+Xtlq8+GHG2zPtwgsJRbVA==";
        protected readonly StorageCredentials stCredentials = new StorageCredentials(acct, key);

        public string Put(string blobPath)
        {
            string blobFullUriString = string.Format("https://{0}.blob.core.windows.net{1}", acct, blobPath);
            CloudBlockBlob blob = new CloudBlockBlob(new Uri(blobFullUriString), stCredentials);
            return blob.Exists().ToString();

        }

    }
}
