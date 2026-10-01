namespace ActividadListView
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            menuArchivo = new ToolStripMenuItem();
            menuNuevo = new ToolStripMenuItem();
            menuGuardar = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            menuGuardarComo = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            menuSalir = new ToolStripMenuItem();
            menuEdicion = new ToolStripMenuItem();
            menuAgregar = new ToolStripMenuItem();
            menuEditar = new ToolStripMenuItem();
            menuEliminar = new ToolStripMenuItem();
            menuVista = new ToolStripMenuItem();
            menuAjustarColumnas = new ToolStripMenuItem();
            menuLimpiarVista = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnNuevo = new ToolStripSplitButton();
            btnAgregar = new ToolStripMenuItem();
            btnEditar = new ToolStripMenuItem();
            btnEliminar = new ToolStripMenuItem();
            btnAbrir = new ToolStripButton();
            btnGuardar = new ToolStripButton();
            btnGuardarComo = new ToolStripButton();
            lvDatos = new ListView();
            statusStrip1 = new StatusStrip();
            lblEstado = new ToolStripStatusLabel();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuArchivo, menuEdicion, menuVista });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(882, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuArchivo
            // 
            menuArchivo.DropDownItems.AddRange(new ToolStripItem[] { menuNuevo, menuGuardar, guardarToolStripMenuItem, menuGuardarComo, toolStripMenuItem2, menuSalir });
            menuArchivo.Name = "menuArchivo";
            menuArchivo.Size = new Size(73, 24);
            menuArchivo.Text = "Archivo";
            // 
            // menuNuevo
            // 
            menuNuevo.Name = "menuNuevo";
            menuNuevo.Size = new Size(189, 26);
            menuNuevo.Text = "Nuevo";
            // 
            // menuGuardar
            // 
            menuGuardar.Name = "menuGuardar";
            menuGuardar.Size = new Size(189, 26);
            menuGuardar.Text = "Abrir";
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(189, 26);
            guardarToolStripMenuItem.Text = "Guardar";
            // 
            // menuGuardarComo
            // 
            menuGuardarComo.Name = "menuGuardarComo";
            menuGuardarComo.Size = new Size(189, 26);
            menuGuardarComo.Text = "Guardar Como";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(189, 26);
            toolStripMenuItem2.Text = "--";
            // 
            // menuSalir
            // 
            menuSalir.Name = "menuSalir";
            menuSalir.Size = new Size(189, 26);
            menuSalir.Text = "Salir";
            // 
            // menuEdicion
            // 
            menuEdicion.DropDownItems.AddRange(new ToolStripItem[] { menuAgregar, menuEditar, menuEliminar });
            menuEdicion.Name = "menuEdicion";
            menuEdicion.Size = new Size(72, 24);
            menuEdicion.Text = "Edición";
            // 
            // menuAgregar
            // 
            menuAgregar.Name = "menuAgregar";
            menuAgregar.Size = new Size(201, 26);
            menuAgregar.Text = "Agregar registro";
            // 
            // menuEditar
            // 
            menuEditar.Name = "menuEditar";
            menuEditar.Size = new Size(201, 26);
            menuEditar.Text = "Editar registro";
            // 
            // menuEliminar
            // 
            menuEliminar.Name = "menuEliminar";
            menuEliminar.Size = new Size(201, 26);
            menuEliminar.Text = "Eliminar registro";
            // 
            // menuVista
            // 
            menuVista.DropDownItems.AddRange(new ToolStripItem[] { menuAjustarColumnas, menuLimpiarVista });
            menuVista.Name = "menuVista";
            menuVista.Size = new Size(55, 24);
            menuVista.Text = "Vista";
            // 
            // menuAjustarColumnas
            // 
            menuAjustarColumnas.Name = "menuAjustarColumnas";
            menuAjustarColumnas.Size = new Size(205, 26);
            menuAjustarColumnas.Text = "Ajustar columnas";
            // 
            // menuLimpiarVista
            // 
            menuLimpiarVista.Name = "menuLimpiarVista";
            menuLimpiarVista.Size = new Size(205, 26);
            menuLimpiarVista.Text = "Limpiar vista";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNuevo, btnAbrir, btnGuardar, btnGuardarComo });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(882, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            btnNuevo.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnNuevo.DropDownItems.AddRange(new ToolStripItem[] { btnAgregar, btnEditar, btnEliminar });
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.ImageTransparentColor = Color.Magenta;
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(71, 24);
            btnNuevo.Text = "Nuevo";
            // 
            // btnAgregar
            // 
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(146, 26);
            btnAgregar.Text = "Agregar";
            // 
            // btnEditar
            // 
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(146, 26);
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(146, 26);
            btnEliminar.Text = "Eliminar";
            // 
            // btnAbrir
            // 
            btnAbrir.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnAbrir.Image = (Image)resources.GetObject("btnAbrir.Image");
            btnAbrir.ImageTransparentColor = Color.Magenta;
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(46, 24);
            btnAbrir.Text = "Abrir";
            btnAbrir.Click += btnAbrir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageTransparentColor = Color.Magenta;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(66, 24);
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnGuardarComo
            // 
            btnGuardarComo.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnGuardarComo.Image = (Image)resources.GetObject("btnGuardarComo.Image");
            btnGuardarComo.ImageTransparentColor = Color.Magenta;
            btnGuardarComo.Name = "btnGuardarComo";
            btnGuardarComo.Size = new Size(110, 24);
            btnGuardarComo.Text = "Guardar Como";
            btnGuardarComo.Click += btnGuardarComo_Click;
            // 
            // lvDatos
            // 
            lvDatos.Dock = DockStyle.Fill;
            lvDatos.FullRowSelect = true;
            lvDatos.GridLines = true;
            lvDatos.Location = new Point(0, 55);
            lvDatos.MultiSelect = false;
            lvDatos.Name = "lvDatos";
            lvDatos.Size = new Size(882, 498);
            lvDatos.TabIndex = 2;
            lvDatos.UseCompatibleStateImageBehavior = false;
            lvDatos.View = View.Details;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblEstado });
            statusStrip1.Location = new Point(0, 527);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(882, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblEstado
            // 
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(40, 20);
            lblEstado.Text = "Listo";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Archivos compatibles|*.csv;*.json|Archivos CSV|*.csv|Archivos JSON|*.json|Todos los archivos|*.*";
            openFileDialog1.Title = "Abrir archivo";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "Archivos CSV|*.csv|Archivos JSON|*.json|Todos los archivos|*.*";
            saveFileDialog1.Title = "Guardar archivo";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(statusStrip1);
            Controls.Add(lvDatos);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(900, 600);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CSV & JSON Manager";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStrip toolStrip1;
        private ListView lvDatos;
        private StatusStrip statusStrip1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem menuArchivo;
        private ToolStripMenuItem menuNuevo;
        private ToolStripMenuItem menuGuardar;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem menuGuardarComo;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem menuSalir;
        private ToolStripMenuItem menuEdicion;
        private ToolStripMenuItem menuAgregar;
        private ToolStripMenuItem menuEditar;
        private ToolStripMenuItem menuEliminar;
        private ToolStripMenuItem menuVista;
        private ToolStripMenuItem menuAjustarColumnas;
        private ToolStripMenuItem menuLimpiarVista;
        private ToolStripButton btnGuardarComo;
        private ToolStripSplitButton btnNuevo;
        private ToolStripMenuItem btnAgregar;
        private ToolStripMenuItem btnEditar;
        private ToolStripMenuItem btnEliminar;
        private ToolStripButton btnAbrir;
        private ToolStripButton btnGuardar;
        private ToolStripStatusLabel lblEstado;
    }
}
