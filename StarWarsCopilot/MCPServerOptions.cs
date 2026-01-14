namespace StarWarsCopilot;

public static class MCPServerOptions
{
	public static string Name => "StarWarsMCPServer";
	public static string Command => "dotnet";
	public static List<string> Arguments => [
		"run",
		"--project",
		"C:\\Projects\\CodeMash2026\\StarWarsCopilot\\StarWarsMCPServer\\StarWarsMCPServer.csproj"
	];
}