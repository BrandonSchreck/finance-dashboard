using FinanceDashboard.WebApi.Extensions;
using FinanceDashboard.WebApi.Infrastructure.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NSubstitute;

namespace FinanceDashboard.WebApi.Tests.Extensions;

[TestClass]
public class ServiceCollectionExtensionsTests
{
    [DataTestMethod]
    [DataRow("Development")]
    [DataRow("Production")]
    public void AddPersistence_Should_Register_DbContext(string env)
    {
        // Arrange
        var services = new ServiceCollection();

        var mockEnv = Substitute.For<IWebHostEnvironment>();
        mockEnv.EnvironmentName.Returns(env);

        var config = new ConfigurationBuilder().AddInMemoryCollection(new Dictionary<string, string?> {
            { "ConnectionStrings:DefaultConnection", "Host=localhost;Database=test;Username=test;Password=test" }
        }).Build();

        // Act
        var provider = services.AddPersistence(config, mockEnv).BuildServiceProvider();
        
        // Assert
        using var scope = provider.CreateScope();
        var context =  scope.ServiceProvider.GetService<FinanceDashboardDbContext>();
        Assert.IsNotNull(context);
        // no way to test EnableDetailedErrors or EnableSensitiveDataLogging because they are private/internal
    }
}