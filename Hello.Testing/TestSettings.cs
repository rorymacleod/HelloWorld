namespace Hello.Testing;

public class TestSettings
{
    public string DriverProvider { get; set; } = "ViewModel";

    public List<DriverProviderSettings> DriverProviders { get; set; } = [
        new() {
            Name = "ViewModel",
            Type = "Hello.Testing.ViewModel.ViewModelDriverProvider"
        }
    ];

    public class DriverProviderSettings
    {
        public string Name { get; set; }

        public string Type { get; set; }
    }
}