namespace AgenteProblemaWinForms___Edwin_Lasso
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnEnviar = new Button();
            txtConsulta = new TextBox();
            btnNuevaSesion = new Button();
            menuStripPrincipal = new MenuStrip();
            techAssistToolStripMenuItem = new ToolStripMenuItem();
            nuevaSesiónToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            agenteToolStripMenuItem = new ToolStripMenuItem();
            informaciónToolStripMenuItem = new ToolStripMenuItem();
            herramientasToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeTechAssistToolStripMenuItem = new ToolStripMenuItem();
            toolStripPrincipal = new ToolStrip();
            tsbNuevaSesion = new ToolStripButton();
            tsbLimpiar = new ToolStripButton();
            tsbConfiguracion = new ToolStripButton();
            statusStripPrincipal = new StatusStrip();
            tslEstado = new ToolStripStatusLabel();
            tslSesion = new ToolStripStatusLabel();
            tslProveedor = new ToolStripStatusLabel();
            pnlConversacion = new Panel();
            rtbConversacion = new RichTextBox();
            pnlEntrada = new Panel();
            pnlHeader = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblEstadoAgente = new Label();
            lblModelo = new Label();
            pnlSidebar = new Panel();
            lblSidebarModelo = new Label();
            lblSidebarInfo = new Label();
            btnConfiguracion = new Button();
            btnHerramientas = new Button();
            btnChat = new Button();
            lblSidebarDescripcion = new Label();
            lblSidebarTitulo = new Label();
            menuStripPrincipal.SuspendLayout();
            toolStripPrincipal.SuspendLayout();
            statusStripPrincipal.SuspendLayout();
            pnlConversacion.SuspendLayout();
            pnlEntrada.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // btnEnviar
            // 
            btnEnviar.Dock = DockStyle.Right;
            btnEnviar.Location = new Point(872, 0);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(100, 70);
            btnEnviar.TabIndex = 0;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // txtConsulta
            // 
            txtConsulta.Dock = DockStyle.Fill;
            txtConsulta.Location = new Point(0, 0);
            txtConsulta.Multiline = true;
            txtConsulta.Name = "txtConsulta";
            txtConsulta.Size = new Size(972, 70);
            txtConsulta.TabIndex = 1;
            // 
            // btnNuevaSesion
            // 
            btnNuevaSesion.Location = new Point(836, 351);
            btnNuevaSesion.Name = "btnNuevaSesion";
            btnNuevaSesion.Size = new Size(140, 29);
            btnNuevaSesion.TabIndex = 2;
            btnNuevaSesion.Text = "Nueva Sesión";
            btnNuevaSesion.UseVisualStyleBackColor = true;
            btnNuevaSesion.Click += btnNuevaSesion_Click;
            // 
            // menuStripPrincipal
            // 
            menuStripPrincipal.ImageScalingSize = new Size(20, 20);
            menuStripPrincipal.Items.AddRange(new ToolStripItem[] { techAssistToolStripMenuItem, agenteToolStripMenuItem, ayudaToolStripMenuItem });
            menuStripPrincipal.Location = new Point(210, 117);
            menuStripPrincipal.Name = "menuStripPrincipal";
            menuStripPrincipal.Size = new Size(972, 28);
            menuStripPrincipal.TabIndex = 3;
            menuStripPrincipal.Text = "menuStrip1";
            // 
            // techAssistToolStripMenuItem
            // 
            techAssistToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevaSesiónToolStripMenuItem, salirToolStripMenuItem });
            techAssistToolStripMenuItem.Name = "techAssistToolStripMenuItem";
            techAssistToolStripMenuItem.Size = new Size(90, 24);
            techAssistToolStripMenuItem.Text = "TechAssist";
            // 
            // nuevaSesiónToolStripMenuItem
            // 
            nuevaSesiónToolStripMenuItem.Name = "nuevaSesiónToolStripMenuItem";
            nuevaSesiónToolStripMenuItem.Size = new Size(181, 26);
            nuevaSesiónToolStripMenuItem.Text = "Nueva Sesión";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(181, 26);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // agenteToolStripMenuItem
            // 
            agenteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { informaciónToolStripMenuItem, herramientasToolStripMenuItem });
            agenteToolStripMenuItem.Name = "agenteToolStripMenuItem";
            agenteToolStripMenuItem.Size = new Size(71, 24);
            agenteToolStripMenuItem.Text = "Agente";
            // 
            // informaciónToolStripMenuItem
            // 
            informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
            informaciónToolStripMenuItem.Size = new Size(181, 26);
            informaciónToolStripMenuItem.Text = "Información";
            // 
            // herramientasToolStripMenuItem
            // 
            herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            herramientasToolStripMenuItem.Size = new Size(181, 26);
            herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeTechAssistToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(65, 24);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeTechAssistToolStripMenuItem
            // 
            acercaDeTechAssistToolStripMenuItem.Name = "acercaDeTechAssistToolStripMenuItem";
            acercaDeTechAssistToolStripMenuItem.Size = new Size(233, 26);
            acercaDeTechAssistToolStripMenuItem.Text = "Acerca de Tech Assist";
            // 
            // toolStripPrincipal
            // 
            toolStripPrincipal.ImageScalingSize = new Size(20, 20);
            toolStripPrincipal.Items.AddRange(new ToolStripItem[] { tsbNuevaSesion, tsbLimpiar, tsbConfiguracion });
            toolStripPrincipal.Location = new Point(210, 90);
            toolStripPrincipal.Name = "toolStripPrincipal";
            toolStripPrincipal.Size = new Size(972, 27);
            toolStripPrincipal.TabIndex = 4;
            toolStripPrincipal.Text = "toolStrip1";
            // 
            // tsbNuevaSesion
            // 
            tsbNuevaSesion.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbNuevaSesion.Image = (Image)resources.GetObject("tsbNuevaSesion.Image");
            tsbNuevaSesion.ImageTransparentColor = Color.Magenta;
            tsbNuevaSesion.Name = "tsbNuevaSesion";
            tsbNuevaSesion.Size = new Size(102, 24);
            tsbNuevaSesion.Text = "Nueva Sesión";
            // 
            // tsbLimpiar
            // 
            tsbLimpiar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbLimpiar.Image = (Image)resources.GetObject("tsbLimpiar.Image");
            tsbLimpiar.ImageTransparentColor = Color.Magenta;
            tsbLimpiar.Name = "tsbLimpiar";
            tsbLimpiar.Size = new Size(97, 24);
            tsbLimpiar.Text = "Limpiar Chat";
            // 
            // tsbConfiguracion
            // 
            tsbConfiguracion.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbConfiguracion.Image = (Image)resources.GetObject("tsbConfiguracion.Image");
            tsbConfiguracion.ImageTransparentColor = Color.Magenta;
            tsbConfiguracion.Name = "tsbConfiguracion";
            tsbConfiguracion.Size = new Size(106, 24);
            tsbConfiguracion.Text = "Configuración";
            // 
            // statusStripPrincipal
            // 
            statusStripPrincipal.ImageScalingSize = new Size(20, 20);
            statusStripPrincipal.Items.AddRange(new ToolStripItem[] { tslEstado, tslSesion, tslProveedor });
            statusStripPrincipal.Location = new Point(0, 677);
            statusStripPrincipal.Name = "statusStripPrincipal";
            statusStripPrincipal.Size = new Size(1182, 26);
            statusStripPrincipal.TabIndex = 5;
            statusStripPrincipal.Text = "statusStrip1";
            statusStripPrincipal.ItemClicked += statusStripPrincipal_ItemClicked;
            // 
            // tslEstado
            // 
            tslEstado.Name = "tslEstado";
            tslEstado.Size = new Size(102, 20);
            tslEstado.Text = "● Agente listo";
            // 
            // tslSesion
            // 
            tslSesion.Name = "tslSesion";
            tslSesion.Size = new Size(95, 20);
            tslSesion.Text = "Sesión activa";
            // 
            // tslProveedor
            // 
            tslProveedor.Name = "tslProveedor";
            tslProveedor.Size = new Size(56, 20);
            tslProveedor.Text = "Gemini";
            // 
            // pnlConversacion
            // 
            pnlConversacion.Controls.Add(rtbConversacion);
            pnlConversacion.Controls.Add(btnNuevaSesion);
            pnlConversacion.Controls.Add(pnlEntrada);
            pnlConversacion.Dock = DockStyle.Fill;
            pnlConversacion.Location = new Point(210, 145);
            pnlConversacion.Name = "pnlConversacion";
            pnlConversacion.Size = new Size(972, 532);
            pnlConversacion.TabIndex = 6;
            // 
            // rtbConversacion
            // 
            rtbConversacion.BackColor = SystemColors.Control;
            rtbConversacion.BorderStyle = BorderStyle.None;
            rtbConversacion.Dock = DockStyle.Fill;
            rtbConversacion.ForeColor = SystemColors.WindowText;
            rtbConversacion.Location = new Point(0, 0);
            rtbConversacion.Name = "rtbConversacion";
            rtbConversacion.ReadOnly = true;
            rtbConversacion.Size = new Size(972, 462);
            rtbConversacion.TabIndex = 3;
            rtbConversacion.Text = "";
            // 
            // pnlEntrada
            // 
            pnlEntrada.Controls.Add(btnEnviar);
            pnlEntrada.Controls.Add(txtConsulta);
            pnlEntrada.Dock = DockStyle.Bottom;
            pnlEntrada.Location = new Point(0, 462);
            pnlEntrada.Name = "pnlEntrada";
            pnlEntrada.Size = new Size(972, 70);
            pnlEntrada.TabIndex = 1;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.WhiteSmoke;
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Controls.Add(lblSubtitulo);
            pnlHeader.Controls.Add(lblEstadoAgente);
            pnlHeader.Controls.Add(lblModelo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(210, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(972, 90);
            pnlHeader.TabIndex = 7;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(179, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "TECHASSIST";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.Location = new Point(22, 48);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(207, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "AI Technical Support Assistant";
            // 
            // lblEstadoAgente
            // 
            lblEstadoAgente.AutoSize = true;
            lblEstadoAgente.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstadoAgente.Location = new Point(850, 18);
            lblEstadoAgente.Name = "lblEstadoAgente";
            lblEstadoAgente.Size = new Size(87, 23);
            lblEstadoAgente.TabIndex = 2;
            lblEstadoAgente.Text = "● ONLINE";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(850, 48);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(56, 20);
            lblModelo.TabIndex = 3;
            lblModelo.Text = "Gemini";
            // 
            // pnlSidebar
            // 
            pnlSidebar.Controls.Add(lblSidebarModelo);
            pnlSidebar.Controls.Add(lblSidebarInfo);
            pnlSidebar.Controls.Add(btnConfiguracion);
            pnlSidebar.Controls.Add(btnHerramientas);
            pnlSidebar.Controls.Add(btnChat);
            pnlSidebar.Controls.Add(lblSidebarDescripcion);
            pnlSidebar.Controls.Add(lblSidebarTitulo);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(210, 677);
            pnlSidebar.TabIndex = 8;
            pnlSidebar.Paint += pnlSidebar_Paint;
            // 
            // lblSidebarModelo
            // 
            lblSidebarModelo.AutoSize = true;
            lblSidebarModelo.Location = new Point(19, 641);
            lblSidebarModelo.Name = "lblSidebarModelo";
            lblSidebarModelo.Size = new Size(56, 20);
            lblSidebarModelo.TabIndex = 6;
            lblSidebarModelo.Text = "Gemini";
            // 
            // lblSidebarInfo
            // 
            lblSidebarInfo.AutoSize = true;
            lblSidebarInfo.BackColor = SystemColors.Control;
            lblSidebarInfo.Location = new Point(19, 607);
            lblSidebarInfo.Name = "lblSidebarInfo";
            lblSidebarInfo.Size = new Size(119, 20);
            lblSidebarInfo.TabIndex = 5;
            lblSidebarInfo.Text = "AGENTE ACTIVO";
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.Location = new Point(19, 181);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(152, 29);
            btnConfiguracion.TabIndex = 4;
            btnConfiguracion.Text = "⚙  Configuración";
            btnConfiguracion.UseVisualStyleBackColor = true;
            // 
            // btnHerramientas
            // 
            btnHerramientas.Location = new Point(19, 135);
            btnHerramientas.Name = "btnHerramientas";
            btnHerramientas.Size = new Size(152, 29);
            btnHerramientas.TabIndex = 3;
            btnHerramientas.Text = "🔧  Herramientas";
            btnHerramientas.UseVisualStyleBackColor = true;
            // 
            // btnChat
            // 
            btnChat.Location = new Point(19, 90);
            btnChat.Name = "btnChat";
            btnChat.Size = new Size(152, 29);
            btnChat.TabIndex = 2;
            btnChat.Text = "💬  Chat";
            btnChat.UseVisualStyleBackColor = true;
            // 
            // lblSidebarDescripcion
            // 
            lblSidebarDescripcion.AutoSize = true;
            lblSidebarDescripcion.Location = new Point(12, 33);
            lblSidebarDescripcion.Name = "lblSidebarDescripcion";
            lblSidebarDescripcion.Size = new Size(121, 20);
            lblSidebarDescripcion.TabIndex = 1;
            lblSidebarDescripcion.Text = "Asistente técnico";
            // 
            // lblSidebarTitulo
            // 
            lblSidebarTitulo.AutoSize = true;
            lblSidebarTitulo.Location = new Point(12, 9);
            lblSidebarTitulo.Name = "lblSidebarTitulo";
            lblSidebarTitulo.Size = new Size(91, 20);
            lblSidebarTitulo.TabIndex = 0;
            lblSidebarTitulo.Text = "TECHASSIST";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1182, 703);
            Controls.Add(pnlConversacion);
            Controls.Add(menuStripPrincipal);
            Controls.Add(toolStripPrincipal);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            Controls.Add(statusStripPrincipal);
            MainMenuStrip = menuStripPrincipal;
            MinimumSize = new Size(1000, 650);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TechAssist AI - Soporte Técnico";
            menuStripPrincipal.ResumeLayout(false);
            menuStripPrincipal.PerformLayout();
            toolStripPrincipal.ResumeLayout(false);
            toolStripPrincipal.PerformLayout();
            statusStripPrincipal.ResumeLayout(false);
            statusStripPrincipal.PerformLayout();
            pnlConversacion.ResumeLayout(false);
            pnlEntrada.ResumeLayout(false);
            pnlEntrada.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnviar;
        private TextBox txtConsulta;
        private Button btnNuevaSesion;
        private MenuStrip menuStripPrincipal;
        private ToolStripMenuItem techAssistToolStripMenuItem;
        private ToolStripMenuItem nuevaSesiónToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem agenteToolStripMenuItem;
        private ToolStripMenuItem informaciónToolStripMenuItem;
        private ToolStripMenuItem herramientasToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem acercaDeTechAssistToolStripMenuItem;
        private ToolStrip toolStripPrincipal;
        private ToolStripButton tsbNuevaSesion;
        private ToolStripButton tsbLimpiar;
        private ToolStripButton tsbConfiguracion;
        private StatusStrip statusStripPrincipal;
        private ToolStripStatusLabel tslEstado;
        private ToolStripStatusLabel tslSesion;
        private ToolStripStatusLabel tslProveedor;
        private Panel pnlConversacion;
        private Panel pnlEntrada;
        private RichTextBox rtbConversacion;
        private Panel pnlHeader;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblEstadoAgente;
        private Label lblModelo;
        private Panel pnlSidebar;
        private Label lblSidebarTitulo;
        private Button btnConfiguracion;
        private Button btnHerramientas;
        private Button btnChat;
        private Label lblSidebarDescripcion;
        private Label lblSidebarModelo;
        private Label lblSidebarInfo;
    }
}
