using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace Toolbox.Common.Configuration;

public class JsonStringConfigurationSource : JsonStreamConfigurationSource
{
    public string? JsonString { get; set; }

    public override IConfigurationProvider Build(IConfigurationBuilder builder) => new JsonStringConfigurationProvider(this);
}