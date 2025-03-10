using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Toolbox.Common.Configuration;

namespace Hello.Testing;

public class DriverProvider
{
    private static readonly Lazy<DriverProvider> InstanceValue = new(CreateInstance, false);

    public static DriverProvider Instance => InstanceValue.Value;

    private static DriverProvider CreateInstance()
    {
        var configuration = new ConfigurationBuilder()
            .AddJsonObject(new TestSettings(), "Test")
            .AddDevelopmentEnvironment(typeof(DriverProvider).Assembly)
            .Build();

        var serviceCollection = new ServiceCollection()
            .Add ;
        serviceCollection.AddOptions<TestSettings>();
        var services = serviceCollection.BuildServiceProvider();

    }

    private readonly IOptions<TestSettings> Settings;
}