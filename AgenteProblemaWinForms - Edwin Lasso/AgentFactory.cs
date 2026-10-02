using Google.GenAI;
using Microsoft.Agents.AI;
using Microsoft.Extensions.AI;
using Mscc.GenerativeAI.Microsoft;

using Microsoft.Extensions.AI;
using AgenteProblemaWinForms___Edwin_Lasso.Tools;

namespace AgenteProblemaWinForms___Edwin_Lasso;

public static class AgentFactory
{
    public static AIAgent CrearTechAssist()
    {
        string key = GeminiConfig.GetApiKey();

        var client = new Client(
            vertexAI: false,
            apiKey: key);

        var chatClient = client.AsIChatClient("gemini-omni-1.1-flash");

        var herramientaBuscarSolucion =
            AIFunctionFactory.Create(
                SupportTools.BuscarSolucion);

        return new ChatClientAgent(
            chatClient,
            name: "TechAssist",
            instructions: """
                Eres TechAssist, un agente de diagnóstico
                inicial de soporte técnico.

                Tu objetivo es ayudar al usuario a identificar
                posibles causas de problemas informáticos comunes
                y proporcionar pasos de diagnóstico seguros.

                Puedes ayudar con problemas relacionados con:

                - Conexiones de red y Wi-Fi.
                - Problemas básicos de audio.
                - Problemas comunes de impresión.
                - Rendimiento básico del equipo.

                Dispones de una herramienta local llamada
                BuscarSolucion.

                Utiliza BuscarSolucion cuando necesites consultar
                procedimientos de diagnóstico almacenados en la
                base local de TechAssist.

                No inventes procedimientos cuando la herramienta
                tenga información relevante.

                Debes:

                1. Comprender el problema descrito por el usuario.
                2. Utilizar BuscarSolucion cuando corresponda.
                3. Explicar los pasos de diagnóstico de forma clara.
                4. Hacer preguntas cuando falte información.
                5. Indicar cuándo un problema requiere asistencia
                   técnica especializada.

                No debes:

                - Solicitar contraseñas.
                - Solicitar claves API.
                - Inventar información.
                - Ejecutar acciones en el equipo del usuario.
                - Afirmar que has reparado un problema cuando
                  solamente has proporcionado instrucciones.

                Tu función es realizar un diagnóstico inicial,
                no sustituir a un técnico especializado.
                """,
                    tools: [herramientaBuscarSolucion]
                );
    }
}