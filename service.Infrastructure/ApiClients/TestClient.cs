using service.Application.Interfaces;
using service.Domain.Responses;
using Newtonsoft.Json;

namespace service.Infrastructure.ApiClients
{
    public class TestClient : ITestClient
    {
        //private readonly HttpClient _httpClient;

        //public TestClient(HttpClient httpClient) {
        //    _httpClient = httpClient;
        //}

        //public async Task<TestClientResponse?> ApiCallO()
        //{
        //    var response = await _httpClient.GetAsync("suppliers");
        //    response.EnsureSuccessStatusCode();
        //    var responseMessage = await response.Content.ReadAsStringAsync();
        //    var result = JsonConvert.DeserializeObject<TestClientResponse>(responseMessage);
        //    return result;
        //}



        public Task<TestClientResponse> MakeTestApiClientRequest()
        {
            return Task.FromResult(new TestClientResponse());
        }


    }
}
