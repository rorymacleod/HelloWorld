using Hello.Application.Tests.Pages;
using Hello.Testing;
using Shouldly;

namespace Hello.Application.Tests.Greeting;

public class GreetingSteps : StepsBase
{
    private GreetingPage? Page;

    public async Task WhenTheGreetingPageIsOpened()
    {
        Page = await Driver.NavigateToPage<GreetingPage>();
    }

    public void ThenTheGreetingIs(string expected)
    {
        Page.ShouldNotBeNull();
        Page.Greeting.ShouldBe(expected);
    }
}
