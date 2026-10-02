using System;
using System.Collections.Generic;
using System.Text;

namespace AgenteProblemaWinForms___Edwin_Lasso.Tools
{
 

    public static class SupportTools
    {
        /// <summary>
        /// Consulta la base local de soluciones de TechAssist
        /// para encontrar procedimientos de diagnóstico relacionados
        /// con un problema técnico.
        /// </summary>
        public static string BuscarSolucion(string problema)
        {
            if (string.IsNullOrWhiteSpace(problema))
            {
                return "No se proporcionó ningún problema para consultar.";
            }

            string consulta = problema.ToLowerInvariant();

            if (consulta.Contains("internet") ||
                consulta.Contains("wifi") ||
                consulta.Contains("wi-fi") ||
                consulta.Contains("red"))
            {
                return """
                Categoría: Conectividad de red

                Problema identificado:
                El equipo presenta problemas para acceder a Internet.

                Pasos de diagnóstico recomendados:

                1. Verificar que el Wi-Fi esté activado.
                2. Comprobar si otros dispositivos tienen Internet.
                3. Desconectar y volver a conectar la red Wi-Fi.
                4. Reiniciar el adaptador de red.
                5. Reiniciar el router si otros dispositivos también
                   presentan problemas.
                6. Si el problema continúa, revisar la configuración
                   de red o solicitar asistencia técnica.

                Seguridad:
                No solicitar contraseñas ni credenciales al usuario.
                """;
            }

            if (consulta.Contains("audio") ||
                consulta.Contains("sonido") ||
                consulta.Contains("micrófono") ||
                consulta.Contains("microfono"))
            {
                return """
                Categoría: Audio

                Problema identificado:
                El equipo presenta problemas relacionados con el audio.

                Pasos de diagnóstico recomendados:

                1. Comprobar que el volumen no esté silenciado.
                2. Verificar el dispositivo de salida seleccionado.
                3. Comprobar la conexión de auriculares o altavoces.
                4. Probar otro dispositivo de audio.
                5. Si continúa, revisar el controlador de audio.

                Seguridad:
                No solicitar credenciales ni modificar configuraciones
                sensibles automáticamente.
                """;
            }

            if (consulta.Contains("impresora") ||
                consulta.Contains("imprimir") ||
                consulta.Contains("impresión") ||
                consulta.Contains("impresion"))
            {
                return """
                Categoría: Impresión

                Problema identificado:
                La impresora presenta problemas para imprimir.

                Pasos de diagnóstico recomendados:

                1. Comprobar que la impresora esté encendida.
                2. Verificar la conexión USB o de red.
                3. Comprobar si aparece como disponible.
                4. Revisar si existe una cola de impresión pendiente.
                5. Intentar imprimir una página de prueba.
                6. Si continúa el problema, solicitar asistencia técnica.

                Seguridad:
                No modificar configuraciones administrativas
                automáticamente.
                """;
            }

            if (consulta.Contains("lenta") ||
                consulta.Contains("rendimiento") ||
                consulta.Contains("espacio") ||
                consulta.Contains("lento"))
            {
                return """
                Categoría: Rendimiento

                Problema identificado:
                El equipo presenta lentitud o problemas de rendimiento.

                Pasos de diagnóstico recomendados:

                1. Comprobar cuánto espacio libre queda.
                2. Cerrar aplicaciones que no se estén utilizando.
                3. Revisar las aplicaciones que se ejecutan al iniciar.
                4. Reiniciar el equipo.
                5. Comprobar si el problema aparece con una aplicación
                   específica.
                6. Si la lentitud continúa, realizar un diagnóstico
                   técnico más detallado.

                Seguridad:
                No eliminar archivos automáticamente.
                """;
            }

            return """
            No se encontró una solución específica en la base local.

            El problema requiere más información antes de seleccionar
            un procedimiento de diagnóstico.
            """;
        }
    }
}

