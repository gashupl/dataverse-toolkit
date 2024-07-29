namespace Pg.Dataverse.Kafka.Functions.Utilities
{
    public static class AuthHelper
    {
        public static bool IsAuthenticated(string? expected, string? actual)
        {
            return expected != null && expected.Equals(actual, StringComparison.OrdinalIgnoreCase) 
                ? true : false;
        }
    }
}
