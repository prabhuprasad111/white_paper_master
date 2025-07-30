using Microsoft.Extensions.Configuration;
using System.IdentityModel.Tokens.Jwt;
using white_paper_master.Helpers;

namespace white_paper_master.Tests.Helpers
{
    [TestFixture]
    public class JwtTokenGeneratorTests
    {
        private IConfiguration _configuration;

        [SetUp]
        public void Setup()
        {
            var inMemorySettings = new Dictionary<string, string> {
                {"Jwt:Key", "ThisIsASecretKeyForTesting123456"},  // Must be >= 256 bits (32 chars)
                {"Jwt:Issuer", "TestIssuer"},
                {"Jwt:Audience", "TestAudience"},
                {"Jwt:ExpireMinutes", "60"}
            };

            _configuration = new ConfigurationBuilder()
                .AddInMemoryCollection(inMemorySettings)
                .Build();
        }

        [Test]
        public void GenerateToken_ShouldReturnValidJwt()
        {
            // Arrange
            var username = "testuser";

            // Act
            var token = JwtTokenGenerator.GenerateToken(username, _configuration);

            // Assert
            Assert.IsNotNull(token, "Token should not be null.");
            Assert.IsNotEmpty(token, "Token should not be empty.");

            // Optional: Validate token structure
            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(token);

            Assert.AreEqual(username, jwtToken.Subject);
            Assert.AreEqual("TestIssuer", jwtToken.Issuer);
        }
    }
}
