using Hello.Testing;
using Xunit;

namespace Hello.Application.Tests.Greeting;

public class GreetingTests : TestsBase<GreetingSteps> {
    [Fact]
    public async Task _010_Greeting_is_hello_world() {
        using var s = CreateSteps();
        await s.WhenTheGreetingPageIsOpened();
        s.ThenTheGreetingIs("Hello World.");
    }

}
