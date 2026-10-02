using AgenteProblemaWinForms;
using AgenteProblemaWinForms___Edwin_Lasso;
using Microsoft.Agents.AI;
//using AgenteProblemaWinForms___Edwin_Lasso.Tools;

namespace AgenteProblemaWinForms___Edwin_Lasso;

public partial class Form1 : Form
{
    private AIAgent? _agent;
    private AgentSession? _session;

    public Form1()
    {
        InitializeComponent();
       /// ConfigurarLayout();
       // UIStyles.Aplicar(this);

        this.Load += Form1_Load;
    }
    private void ConfigurarLayout()
    {
        statusStripPrincipal.Dock = DockStyle.Bottom;

        menuStripPrincipal.Dock = DockStyle.Top;
        toolStripPrincipal.Dock = DockStyle.Top;

        pnlHeader.Dock = DockStyle.Top;
        pnlSidebar.Dock = DockStyle.Left;
        pnlConversacion.Dock = DockStyle.Fill;

        Controls.SetChildIndex(statusStripPrincipal, 0);
        Controls.SetChildIndex(pnlConversacion, 1);
        Controls.SetChildIndex(pnlSidebar, 2);
        Controls.SetChildIndex(pnlHeader, 3);
        Controls.SetChildIndex(toolStripPrincipal, 4);
        Controls.SetChildIndex(menuStripPrincipal, 5);
    }

    private void CrearAgente()
    {
        try
        {
            _agent = AgentFactory.CrearTechAssist();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Error al crear TechAssist",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private async void Form1_Load(object? sender, EventArgs e)
    {
        CrearAgente();

        if (_agent is null)
            return;

        try
        {
            _session = await _agent.CreateSessionAsync();

            ChatRenderer.MostrarBienvenida(
                rtbConversacion);

            lblEstadoAgente.Text = "● ONLINE";
            lblModelo.Text = "Gemini";
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Error de TechAssist",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private async void btnEnviar_Click(object sender, EventArgs e)
    {
        string consulta = txtConsulta.Text.Trim();

        if (string.IsNullOrWhiteSpace(consulta))
        {
            MessageBox.Show(
                "Escribe primero tu problema técnico.",
                "TechAssist",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            return;
        }

        if (_agent is null || _session is null)
        {
            MessageBox.Show(
                "El agente todavía no está listo.",
                "TechAssist",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return;
        }

        try
        {
            btnEnviar.Enabled = false;
            txtConsulta.Enabled = false;

            // Mostrar inmediatamente lo que escribió el usuario
            ChatRenderer.MostrarUsuario(
                rtbConversacion,
                consulta);

            // Mostrar estado de procesamiento
            ChatRenderer.MostrarProcesando(
                rtbConversacion);

            var response = await _agent.RunAsync(// AQUIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
                consulta, 
                _session);

            // Mostrar respuesta del agente
            ChatRenderer.MostrarAgente(
                rtbConversacion,
                response.Text);

            txtConsulta.Clear();
        }
        catch (Exception ex)
        {
            ChatRenderer.MostrarSistema(
                rtbConversacion,
                "⚠ Error al comunicarse con TechAssist.");

            MessageBox.Show(
                ex.Message,
                "Error de TechAssist",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        finally
        {
            btnEnviar.Enabled = true;
            txtConsulta.Enabled = true;
            txtConsulta.Focus();
        }
    }

    private async void btnNuevaSesion_Click(
    object sender,
    EventArgs e)
    {
        if (_agent is null)
            return;

        try
        {
            _session = await _agent.CreateSessionAsync();

            ChatRenderer.Limpiar(
                rtbConversacion);

            ChatRenderer.MostrarSistema(
                rtbConversacion,
                "🔄 Nueva sesión iniciada.");

            ChatRenderer.MostrarBienvenida(
                rtbConversacion);

            txtConsulta.Clear();
            txtConsulta.Focus();

            lblEstadoAgente.Text = "● ONLINE";
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Error al crear la sesión",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private void statusStripPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {

    }

    private void pnlSidebar_Paint(object sender, PaintEventArgs e)
    {

    }
}