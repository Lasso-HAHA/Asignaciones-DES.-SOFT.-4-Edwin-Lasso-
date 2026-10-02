using System.Drawing;
using System.Windows.Forms;

namespace AgenteProblemaWinForms;

public static class ChatRenderer
{
    private static readonly Color ColorUsuario =
        Color.FromArgb(70, 140, 255);

    private static readonly Color ColorAgente =
        Color.FromArgb(110, 170, 255);

    private static readonly Color Texto =
        Color.FromArgb(245, 247, 250);

    private static readonly Color TextoSecundario =
        Color.FromArgb(170, 176, 187);


    public static void Limpiar(RichTextBox chat)
    {
        chat.Clear();
    }


    public static void MostrarBienvenida(RichTextBox chat)
    {
        AgregarTexto(
            chat,
            "🤖  TECHASSIST\n",
            ColorAgente,
            true,
            11);

        AgregarTexto(
            chat,
            "Hola, soy TechAssist, tu asistente de diagnóstico técnico.\n",
            Texto,
            false,
            10);

        AgregarTexto(
            chat,
            "Describe el problema que estás teniendo y te ayudaré a realizar un diagnóstico inicial.\n\n",
            TextoSecundario,
            false,
            9);

        DesplazarAlFinal(chat);
    }


    public static void MostrarUsuario(
        RichTextBox chat,
        string mensaje)
    {
        AgregarTexto(
            chat,
            "👤  TÚ\n",
            ColorUsuario,
            true,
            10);

        AgregarTexto(
            chat,
            mensaje + "\n\n",
            Texto,
            false,
            10);

        DesplazarAlFinal(chat);
    }


    public static void MostrarProcesando(
        RichTextBox chat)
    {
        AgregarTexto(
            chat,
            "🤖  TECHASSIST está analizando...\n\n",
            TextoSecundario,
            true,
            9);

        DesplazarAlFinal(chat);
    }


    public static void MostrarAgente(
        RichTextBox chat,
        string mensaje)
    {
        AgregarTexto(
            chat,
            "🤖  TECHASSIST\n",
            ColorAgente,
            true,
            10);

        AgregarTexto(
            chat,
            mensaje + "\n\n",
            Texto,
            false,
            10);

        DesplazarAlFinal(chat);
    }


    public static void MostrarSistema(
        RichTextBox chat,
        string mensaje)
    {
        AgregarTexto(
            chat,
            mensaje + "\n\n",
            TextoSecundario,
            false,
            9);

        DesplazarAlFinal(chat);
    }


    private static void AgregarTexto(
        RichTextBox chat,
        string texto,
        Color color,
        bool negrita,
        float tamanio)
    {
        chat.SelectionStart = chat.TextLength;
        chat.SelectionLength = 0;

        chat.SelectionColor = color;

        chat.SelectionFont = new Font(
            "Segoe UI",
            tamanio,
            negrita
                ? FontStyle.Bold
                : FontStyle.Regular);

        chat.AppendText(texto);

        chat.SelectionColor = Texto;

        chat.SelectionFont =
            new Font("Segoe UI", 10F);
    }


    private static void DesplazarAlFinal(
        RichTextBox chat)
    {
        chat.SelectionStart = chat.TextLength;
        chat.SelectionLength = 0;
        chat.ScrollToCaret();
    }
}