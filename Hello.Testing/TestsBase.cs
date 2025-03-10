namespace Hello.Testing;

public class TestsBase<T> where T : StepsBase
{
    protected TestsBase() { }

    protected T CreateSteps()
    {
        T steps = Activator.CreateInstance<T>() ?? throw new InvalidOperationException();
        return steps;
    }
}