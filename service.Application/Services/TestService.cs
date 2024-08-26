using AutoMapper;
using service.Application.Exceptions;
using service.Application.Interfaces;
using service.Domain.Entities;
using service.Domain.Responses;

namespace service.Application.Services
{
    public class TestService(IMapper mapper, ITestRepository testRepository) : ITestService
    {
        private readonly IMapper _automapper = mapper;
        private readonly ITestRepository _testRepository = testRepository;

        public async Task<TestResponse> GetTestAsync()
        {
            TestObject? result = await _testRepository.GetTestAsync();

            if (result == null) throw new CustomException("null");

            TestResponse testResponse = _automapper.Map<TestResponse>(result);

            return testResponse;
        }

    }
}
