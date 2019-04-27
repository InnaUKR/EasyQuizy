using System;
using System.Net;

namespace EQ.Common.Models.Exceptions
{
    public class ApiException : Exception
    {
        public ApiException(string message)
            : base(message)
        {
        }

        public ApiException(string message, HttpStatusCode statusCode)
            : base(message)
        {
            StatusCode = statusCode;
        }

        public ApiException(string message, Exception inner)
            : base(message, inner)
        {
        }

        public HttpStatusCode StatusCode { get; set; }
    }
}