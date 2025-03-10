using System;
using System.Collections.Generic;
using System.Linq;

namespace Hello.Testing;

public abstract class DriverBase
{
    public async Task<T> NavigateToPage<T>() where T : PageBase
    {
        throw new NotImplementedException();
    }

    public void Initialize()
    {
        throw new NotImplementedException();
    }

    public Task InitializeAsync()
    {
        throw new NotImplementedException();
    }
}