namespace AgenteProblemaWinForms___Edwin_Lasso;

public static class GeminiConfig
{
    public static string GetApiKey()
    {
        return Environment.GetEnvironmentVariable("GOOGLE_GENAI_API_KEY")
            ?? throw new InvalidOperationException(
                "No se encontró la variable de entorno GOOGLE_GENAI_API_KEY.");
    }
}