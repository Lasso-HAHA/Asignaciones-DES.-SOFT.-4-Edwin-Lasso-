namespace AgenteProblemaWinForms___Edwin_Lasso;

public static class OpenAIConfig
{
    public static string GetApiKey()
    {
        return Environment.GetEnvironmentVariable("OPENAI_API_KEY")
            ?? throw new InvalidOperationException(
                "No se encontró la variable de entorno OPENAI_API_KEY.");
    }
}