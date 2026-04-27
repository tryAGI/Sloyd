namespace Sloyd.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static SloydClient GetAuthenticatedClient()
    {
        _ = Environment.GetEnvironmentVariable("SLOYD_CLIENT_ID") is { Length: > 0 } clientIdValue
            ? clientIdValue
            : throw new AssertInconclusiveException("SLOYD_CLIENT_ID environment variable is not found.");

        _ = Environment.GetEnvironmentVariable("SLOYD_CLIENT_SECRET") is { Length: > 0 } clientSecretValue
            ? clientSecretValue
            : throw new AssertInconclusiveException("SLOYD_CLIENT_SECRET environment variable is not found.");

        var client = new SloydClient(options: null);
        
        return client;
    }
}
