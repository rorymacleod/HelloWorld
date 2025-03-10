namespace Hello.Testing;

public abstract class StepsBase : IDisposable
{
    public DriverBase Driver { get; } = DriverProvider.Instance.GetDriver();

    internal void Start()
    {
        Driver.Initialize();
        var initTask = Driver.InitializeAsync();
        if (initTask.Status != TaskStatus.RanToCompletion)
        {
            initTask.GetAwaiter().GetResult();
        }
    }

    public void Dispose() { }
}
