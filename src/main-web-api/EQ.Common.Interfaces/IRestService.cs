using EQ.Common.Models;
using EQ.Common.Models.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EQ.Common.Interfaces
{
    public interface IRestService
    {
        string GetBaseUrl();

        void AddBaseUrl(string baseUrl);

        void AddDefaultHeader(string name, string value);

        Task<T> ExecuteAsync<T>(string resource, HttpMethod method);

        Task<T> ExecuteAsync<T>(string resource, HttpMethod method, object data);

        Task<RestResponse> ExecuteAsync(string resource, HttpMethod method);

        Task<RestResponse> ExecuteAsync(string resource, HttpMethod method, object data, Dictionary<string, string> headers = null);
    }
}