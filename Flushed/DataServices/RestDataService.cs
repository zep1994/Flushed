using Flushed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Flushed.DataServices
{
    public class RestDataService : IRestDataService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseAddress;
        private readonly string _url;
        private readonly JsonSerializerOptions _jsonSerializeOptions;

        public RestDataService()
        {
            _httpClient = new HttpClient();
            _baseAddress = DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5035" : "https://localhost:7016";
            _url = $"{_baseAddress}/api";

            _jsonSerializeOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
        }


        public Task AddIbsCountAsync(IbsCount ibsCount)
        {
            throw new NotImplementedException();
        }

        public Task<List<IbsCount>> GetIbsCountAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateIbsCountAsync(IbsCount ibsCount)
        {
            throw new NotImplementedException();
        }

        public Task DeleteIbsCountAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
