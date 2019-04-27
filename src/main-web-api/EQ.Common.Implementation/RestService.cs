using AutoMapper;
using EQ.Common.Interfaces;
using EQ.Common.Models.Exceptions;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HttpMethod = EQ.Common.Models.Enums.HttpMethod;

namespace EQ.Common.Implementation
{
    public class RestService : IRestService
    {
        private readonly IRestClient _client;

        public RestService(IRestClient client)
        {
            _client = client;
        }

        public string GetBaseUrl()
        {
            return _client.BaseHost ?? _client.BaseUrl.ToString();
        }

        public void AddBaseUrl(string baseUrl)
        {
            _client.BaseUrl = new Uri(baseUrl);
        }

        public void AddDefaultHeader(string name, string value)
        {
            _client.RemoveDefaultParameter(name);
            _client.AddDefaultHeader(name, value);
        }

        public async Task<T> ExecuteAsync<T>(string resource, HttpMethod method)
        {
            return await ExecuteAsync<T>(resource, method, null);
        }

        public async Task<T> ExecuteAsync<T>(string resource, HttpMethod method, object data)
        {
            var response = await ExecuteAsync(resource, method, data);

            return JsonConvert.DeserializeObject<T>(response.Content);
        }

        public async Task<Models.RestResponse> ExecuteAsync(string resource, HttpMethod method)
        {
            return await ExecuteAsync(resource, method, null);
        }

        public async Task<Models.RestResponse> ExecuteAsync(string resource, HttpMethod method, object data, Dictionary<string, string> headers = null)
        {
            var request = new RestRequest((Method)method);

            if (!string.IsNullOrEmpty(resource))
            {
                request.Resource = resource;
            }

            if (data != null)
            {
                if (data is string)
                {
                    request.AddParameter("application/x-www-form-urlencoded", data, ParameterType.RequestBody);
                }
                else
                {
                    request.RequestFormat = DataFormat.Json;
                    request.AddParameter("application/json;charset=utf-8", JsonConvert.SerializeObject(data), ParameterType.RequestBody);
                }
            }

            if (headers != null && headers.Any())
            {
                foreach (var header in headers)
                {
                    request.AddHeader(header.Key, header.Value);
                }
            }

            var response = await _client.ExecuteTaskAsync(request);
            if (!response.IsSuccessful)
            {
                throw new ApiException(response.Content, response.StatusCode);
            }

            return Mapper.Map<Models.RestResponse>(response);
        }
    }
}