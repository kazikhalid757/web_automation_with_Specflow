using Microsoft.Extensions.Configuration;

namespace Tumblr.Support
{
    public static class TestConfiguration
    {
        private static IConfiguration? _configuration;

        static TestConfiguration()
        {
            _configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
        }

        public static string BaseUrl => _configuration?["TestSettings:BaseUrl"] ?? "https://www.tumblr.com/";
        public static string Browser => _configuration?["TestSettings:Browser"] ?? "Chrome";
        public static int ImplicitWait => int.Parse(_configuration?["TestSettings:ImplicitWait"] ?? "10");
        public static int PageLoadTimeout => int.Parse(_configuration?["TestSettings:PageLoadTimeout"] ?? "30");
        public static string TestEmail => _configuration?["TestData:Email"] ?? "test@example.com";
        public static string TestPassword => _configuration?["TestData:Password"] ?? "testpassword123";
    }
} 