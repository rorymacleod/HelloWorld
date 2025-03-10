using Microsoft.Extensions.Configuration.Json;

namespace Toolbox.Common.Configuration;

public class JsonStringConfigurationProvider : JsonStreamConfigurationProvider
{
    private bool Loaded;
    private readonly JsonStringConfigurationSource StringSource;

    public JsonStringConfigurationProvider(JsonStringConfigurationSource source) : base(source)
    {
        StringSource = source;
    }

    public override void Load()
    {
        if (Loaded)
        {
            return;
        }

        if (!string.IsNullOrWhiteSpace(StringSource.JsonString))
        {
            using var stream = new MemoryStream();
            using var writer = new StreamWriter(stream);
            writer.Write(StringSource.JsonString);
            writer.Flush();
            stream.Position = 0;
            Load(stream);
            Loaded = true;
        }
    }
}