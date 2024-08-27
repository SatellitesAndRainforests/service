using service.Application.Interfaces;
using service.Application.Mappings;
using Moq;
using service.Application.Services;
using AutoMapper;
using service.Application.Exceptions;
using service.Domain.Responses;
using service.Domain.Entities;

namespace service.Application.Tests.Tests
{
    public class TestServiceTests
    {
        private readonly Mock<ITestRepository> _testRepository;
        private readonly ITestService _testService;

        public TestServiceTests()
        {
            var mappingConfig = new MapperConfiguration(cfg => cfg.AddProfile(new MappingProfile()));
            var mapper = mappingConfig.CreateMapper();
            _testRepository = new Mock<ITestRepository>();
            _testService = new TestService(mapper, _testRepository.Object);
        }


        [Fact]
        public async Task GetTestAsync_ReturnsTestResponseObject()
        {
            TestEntityObject testEntityObject = new TestEntityObject();
            _testRepository.Setup(x => x.GetTestAsync()).ReturnsAsync(testEntityObject);

            var result = await _testService.GetTestAsync();

            Assert.IsType<TestResponse>(result);
        }


        [Fact]
        public async Task GetTestAsync_ReturnsCustomExceptionWhenNullIsReturnedFromTestRepository()
        {
            // Arrange
            TestEntityObject? nullObject = null;
            _testRepository.Setup(x => x.GetTestAsync()).ReturnsAsync(nullObject);

            // Act + Assert
            await Assert.ThrowsAsync<CustomException>(() => _testService.GetTestAsync());
        }


    }
}
 