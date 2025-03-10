using System.Reflection;
using System.Text.Json;
using System.Text.Json.Nodes;
using Microsoft.Extensions.Configuration;

namespace Toolbox.Common.Configuration;

public static class ConfigurationBuilderExtensions
{
    public static IConfigurationBuilder AddDevelopmentEnvironment(this IConfigurationBuilder self,
        Assembly projectAssembly)
    {
#if DEBUG
        return self
            .AddUserSecrets(projectAssembly, true)
            .AddEnvironmentVariables("Hello");
#else
        return self;
#endif
    }

    public static IConfigurationBuilder AddJsonObject(this IConfigurationBuilder builder, object value, string prefix)
    {
        var json = new JsonObject {
            [prefix] = JsonSerializer.SerializeToNode(value)
        };

        return builder.AddJsonString(json.ToString());
    }

    public static IConfigurationBuilder AddJsonString(this IConfigurationBuilder builder, string json)
    {
        if (builder == null)
        {
            throw new ArgumentNullException(nameof(builder));
        }

        return builder.Add<JsonStringConfigurationSource>(s => s.JsonString = json);
    }
}