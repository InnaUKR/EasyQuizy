using System;
using System.Net;

namespace EQ.Common.Models
{
    public class RestResponse
    {
        public string ErrorMessage { get; set; }

        public string Server { get; set; }

        public Uri ResponseUri { get; set; }

        public Exception ErrorException { get; set; }

        public byte[] RawBytes { get; set; }

        public bool IsSuccessful { get; set; }

        public HttpStatusCode StatusCode { get; set; }

        public string Content { get; set; }

        public string ContentEncoding { get; set; }

        public long ContentLength { get; set; }

        public string ContentType { get; set; }

        public string StatusDescription { get; set; }

        Version ProtocolVersion { get; set; }
    }
}