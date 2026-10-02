using System.Drawing;
using System.Windows.Forms;

namespace AgenteProblemaWinForms;

public static class UIStyles
{
    // =========================
    // PALETA TECHASSIST
    // =========================

    public static readonly Color Background =
        Color.FromArgb(15, 17, 21);

    public static readonly Color Surface =
        Color.FromArgb(22, 24, 29);

    public static readonly Color Header =
        Color.FromArgb(25, 28, 34);

    public static readonly Color Input =
        Color.FromArgb(30, 33, 40);

    public static readonly Color Button =
        Color.FromArgb(32, 36, 44);

    public static readonly Color ButtonHover =
        Color.FromArgb(45, 50, 61);

    public static readonly Color Accent =
        Color.FromArgb(70, 140, 255);

    public static readonly Color TextPrimary =
        Color.FromArgb(245, 247, 250);

    public static readonly Color TextSecondary =
        Color.FromArgb(170, 176, 187);

    public static readonly Color Border =
        Color.FromArgb(45, 49, 58);


    // =========================
    // MÉTODO PRINCIPAL
    // =========================

    public static void Aplicar(Form form)
    {
        form.BackColor = Background;
        form.ForeColor = TextPrimary;

        // -------------------------
        // Paneles
        // -------------------------

        AplicarPanel(form.Controls["pnlHeader"], Header);
        AplicarPanel(form.Controls["pnlSidebar"], Surface);
        AplicarPanel(form.Controls["pnlConversacion"], Background);


        // -------------------------
        // Header
        // -------------------------

        AplicarLabel(
            form.Controls["lblTitulo"],
            TextPrimary,
            18,
            true);

        AplicarLabel(
            form.Controls["lblSubtitulo"],
            TextSecondary,
            9,
            false);

        AplicarLabel(
            form.Controls["lblEstadoAgente"],
            Accent,
            10,
            true);

        AplicarLabel(
            form.Controls["lblModelo"],
            TextSecondary,
            9,
            false);


        // -------------------------
        // Sidebar
        // -------------------------

        AplicarLabel(
            form.Controls["lblSidebarTitulo"],
            TextPrimary,
            14,
            true);

        AplicarLabel(
            form.Controls["lblSidebarDescripcion"],
            TextSecondary,
            9,
            false);

        AplicarLabel(
            form.Controls["lblSidebarInfo"],
            TextSecondary,
            8,
            true);

        AplicarLabel(
            form.Controls["lblSidebarModelo"],
            TextPrimary,
            9,
            false);


        // -------------------------
        // Botones
        // -------------------------

        AplicarBoton(form.Controls["btnChat"]);
        AplicarBoton(form.Controls["btnHerramientas"]);
        AplicarBoton(form.Controls["btnConfiguracion"]);
        AplicarBoton(form.Controls["btnEnviar"]);


        // -------------------------
        // Conversación
        // -------------------------

        AplicarChat(form);


        // -------------------------
        // Entrada
        // -------------------------

        AplicarEntrada(form);


        // -------------------------
        // Menú
        // -------------------------

        AplicarMenu(form);


        // -------------------------
        // Toolbar
        // -------------------------

        AplicarToolStrip(form);


        // -------------------------
        // StatusStrip
        // -------------------------

        AplicarStatusStrip(form);
    }


    // =========================================================
    // PANELES
    // =========================================================

    private static void AplicarPanel(
        Control? control,
        Color color)
    {
        if (control == null)
            return;

        control.BackColor = color;
    }


    // =========================================================
    // LABELS
    // =========================================================

    private static void AplicarLabel(
        Control? control,
        Color color,
        float tamanio,
        bool negrita)
    {
        if (control == null)
            return;

        control.ForeColor = color;

        control.Font = new Font(
            "Segoe UI",
            tamanio,
            negrita
                ? FontStyle.Bold
                : FontStyle.Regular);
    }


    // =========================================================
    // BOTONES
    // =========================================================

    private static void AplicarBoton(Control? control)
    {
        if (control is not Button boton)
            return;

        boton.FlatStyle = FlatStyle.Flat;

        boton.FlatAppearance.BorderSize = 0;

        boton.BackColor = Button;

        boton.ForeColor = TextPrimary;

        boton.Font = new Font(
            "Segoe UI",
            9F,
            FontStyle.Regular);

        boton.Cursor = Cursors.Hand;

        boton.UseVisualStyleBackColor = false;

        boton.Margin = new Padding(8, 5, 8, 5);
    }


    // =========================================================
    // CHAT
    // =========================================================

    private static void AplicarChat(Form form)
    {
        Control? panel =
            form.Controls["pnlConversacion"];

        if (panel == null)
            return;

        foreach (Control control in panel.Controls)
        {
            if (control is RichTextBox chat)
            {
                chat.BackColor = Background;

                chat.ForeColor = TextPrimary;

                chat.BorderStyle =
                    BorderStyle.None;

                chat.Font =
                    new Font(
                        "Segoe UI",
                        10F);

                chat.Padding =
                    new Padding(15);

                chat.DetectUrls = false;
            }
        }
    }


    // =========================================================
    // ENTRADA DE TEXTO
    // =========================================================

    private static void AplicarEntrada(Form form)
    {
        Control? panel =
            form.Controls["pnlConversacion"];

        if (panel == null)
            return;

        foreach (Control control in panel.Controls)
        {
            if (control is Panel entrada)
            {
                foreach (Control hijo in entrada.Controls)
                {
                    if (hijo is TextBox texto)
                    {
                        texto.BackColor = Input;

                        texto.ForeColor =
                            TextPrimary;

                        texto.BorderStyle =
                            BorderStyle.FixedSingle;

                        texto.Font =
                            new Font(
                                "Segoe UI",
                                10F);
                    }

                    if (hijo is Button boton)
                    {
                        boton.BackColor =
                            Accent;

                        boton.ForeColor =
                            Color.White;

                        boton.FlatStyle =
                            FlatStyle.Flat;

                        boton.FlatAppearance
                            .BorderSize = 0;

                        boton.Font =
                            new Font(
                                "Segoe UI",
                                9F,
                                FontStyle.Bold);

                        boton.UseVisualStyleBackColor =
                            false;
                    }
                }
            }
        }
    }


    // =========================================================
    // MENÚ
    // =========================================================

    private static void AplicarMenu(Form form)
    {
        foreach (Control control in form.Controls)
        {
            if (control is MenuStrip menu)
            {
                menu.BackColor = Header;

                menu.ForeColor =
                    TextPrimary;

                menu.RenderMode =
                    ToolStripRenderMode.System;

                foreach (ToolStripItem item in menu.Items)
                {
                    item.ForeColor =
                        TextPrimary;

                    item.BackColor =
                        Header;
                }
            }
        }
    }


    // =========================================================
    // TOOLSTRIP
    // =========================================================

    private static void AplicarToolStrip(Form form)
    {
        foreach (Control control in form.Controls)
        {
            if (control is ToolStrip toolStrip)
            {
                toolStrip.BackColor =
                    Surface;

                toolStrip.ForeColor =
                    TextPrimary;

                toolStrip.RenderMode =
                    ToolStripRenderMode.System;

                foreach (ToolStripItem item
                         in toolStrip.Items)
                {
                    item.ForeColor =
                        TextPrimary;

                    item.BackColor =
                        Surface;
                }
            }
        }
    }


    // =========================================================
    // STATUSSTRIP
    // =========================================================

    private static void AplicarStatusStrip(Form form)
    {
        foreach (Control control in form.Controls)
        {
            if (control is StatusStrip status)
            {
                status.BackColor =
                    Header;

                status.ForeColor =
                    TextSecondary;

                foreach (ToolStripItem item
                         in status.Items)
                {
                    item.ForeColor =
                        TextSecondary;

                    item.BackColor =
                        Header;
                }
            }
        }
    }
}