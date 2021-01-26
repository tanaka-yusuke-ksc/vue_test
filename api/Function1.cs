public static class Function1
{
    [FunctionName("Function1")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
        ILogger log)
    {
        var claimsPrincipal = req.HttpContext.User;

        var builder = new StringBuilder();

        builder.AppendLine($"Name = {claimsPrincipal.Identity.Name ?? "(null)"}");
        builder.AppendLine($"IsAuthenticated = {claimsPrincipal.Identity.IsAuthenticated}");
        builder.AppendLine($"AuthenticationType = {claimsPrincipal.Identity.AuthenticationType ?? "(null)"}");

        foreach (var claim in claimsPrincipal.Claims)
        {
            builder.AppendLine($"{claim.Type} = {claim.Value}");
        }

        return new OkObjectResult(builder.ToString());
    }
}