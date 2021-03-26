using Tests.ApiFactory;
using Xunit;

namespace Tests
{
    public class ApiTests : IClassFixture<CustomApiFactory>
    {
        private readonly CustomApiFactory _factory;

        public ApiTests(CustomApiFactory factory)
        {
            _factory = factory;
        }

        [Fact]
        public void Get_base_url_returns_success_status_code()
        {
            var client = _factory.CreateClient();

            var response = client.GetAsync("/").Result;

            Assert.True(response.IsSuccessStatusCode,
                $"Response code is: {response.StatusCode}");
        }
    }
}
