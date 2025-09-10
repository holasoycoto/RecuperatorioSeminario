namespace EventoParcial.Windows
{
    partial class frmEventos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            toolBar = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            tsbDetalles = new ToolStripButton();
            tsbSuspender = new ToolStripButton();
            tsbVigente = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbFiltrar = new ToolStripDropDownButton();
            porSalónToolStripMenuItem = new ToolStripMenuItem();
            cboSalonFiltro = new ToolStripComboBox();
            tsbActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbCerrar = new ToolStripButton();
            panelInferior = new Panel();
            txtCantidad = new TextBox();
            label1 = new Label();
            panelGrilla = new Panel();
            dgvDatos = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colSalon = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            toolBar.SuspendLayout();
            panelInferior.SuspendLayout();
            panelGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // toolBar
            // 
            toolBar.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbEditar, tsbDetalles, tsbSuspender, tsbVigente, toolStripSeparator1, tsbFiltrar, tsbActualizar, toolStripSeparator2, tsbCerrar });
            toolBar.Location = new Point(0, 0);
            toolBar.Name = "toolBar";
            toolBar.Size = new Size(984, 62);
            toolBar.TabIndex = 0;
            toolBar.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            tsbNuevo.Image = Properties.Resources.Nuevo;
            tsbNuevo.ImageScaling = ToolStripItemImageScaling.None;
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(46, 59);
            tsbNuevo.Text = "Nuevo";
            tsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // tsbEditar
            // 
            tsbEditar.Image = Properties.Resources.Edit;
            tsbEditar.ImageScaling = ToolStripItemImageScaling.None;
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(44, 59);
            tsbEditar.Text = "Editar";
            tsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // tsbDetalles
            // 
            tsbDetalles.Image = Properties.Resources.details_40px;
            tsbDetalles.ImageScaling = ToolStripItemImageScaling.None;
            tsbDetalles.ImageTransparentColor = Color.Magenta;
            tsbDetalles.Name = "tsbDetalles";
            tsbDetalles.Size = new Size(52, 59);
            tsbDetalles.Text = "Detalles";
            tsbDetalles.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // tsbSuspender
            // 
            tsbSuspender.Image = Properties.Resources.calendar_delete_40px;
            tsbSuspender.ImageScaling = ToolStripItemImageScaling.None;
            tsbSuspender.ImageTransparentColor = Color.Magenta;
            tsbSuspender.Name = "tsbSuspender";
            tsbSuspender.Size = new Size(66, 59);
            tsbSuspender.Text = "Suspender";
            tsbSuspender.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // tsbVigente
            // 
            tsbVigente.Image = Properties.Resources.calendar_plus_40px;
            tsbVigente.ImageScaling = ToolStripItemImageScaling.None;
            tsbVigente.ImageTransparentColor = Color.Magenta;
            tsbVigente.Name = "tsbVigente";
            tsbVigente.Size = new Size(51, 59);
            tsbVigente.Text = "Vigente";
            tsbVigente.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 62);
            // 
            // tsbFiltrar
            // 
            tsbFiltrar.DropDownItems.AddRange(new ToolStripItem[] { porSalónToolStripMenuItem });
            tsbFiltrar.Image = Properties.Resources.filter_40px;
            tsbFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbFiltrar.ImageTransparentColor = Color.Magenta;
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(53, 59);
            tsbFiltrar.Text = "Filtrar";
            tsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // porSalónToolStripMenuItem
            // 
            porSalónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cboSalonFiltro });
            porSalónToolStripMenuItem.Name = "porSalónToolStripMenuItem";
            porSalónToolStripMenuItem.Size = new Size(124, 22);
            porSalónToolStripMenuItem.Text = "Por Salón";
            // 
            // cboSalonFiltro
            // 
            cboSalonFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSalonFiltro.Name = "cboSalonFiltro";
            cboSalonFiltro.Size = new Size(121, 23);
            // 
            // tsbActualizar
            // 
            tsbActualizar.Image = Properties.Resources.Update;
            tsbActualizar.ImageScaling = ToolStripItemImageScaling.None;
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(63, 59);
            tsbActualizar.Text = "Actualizar";
            tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbActualizar.Click += tsbActualizar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 62);
            // 
            // tsbCerrar
            // 
            tsbCerrar.Image = Properties.Resources.Close;
            tsbCerrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbCerrar.ImageTransparentColor = Color.Magenta;
            tsbCerrar.Name = "tsbCerrar";
            tsbCerrar.Size = new Size(44, 59);
            tsbCerrar.Text = "Salir";
            tsbCerrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbCerrar.Click += tsbCerrar_Click;
            // 
            // panelInferior
            // 
            panelInferior.Controls.Add(txtCantidad);
            panelInferior.Controls.Add(label1);
            panelInferior.Dock = DockStyle.Bottom;
            panelInferior.Location = new Point(0, 523);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(984, 100);
            panelInferior.TabIndex = 1;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(185, 31);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.ReadOnly = true;
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 34);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 0;
            label1.Text = "Cantidad Registros:";
            // 
            // panelGrilla
            // 
            panelGrilla.Controls.Add(dgvDatos);
            panelGrilla.Dock = DockStyle.Fill;
            panelGrilla.Location = new Point(0, 62);
            panelGrilla.Name = "panelGrilla";
            panelGrilla.Size = new Size(984, 461);
            panelGrilla.TabIndex = 2;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colId, colFecha, colNombre, colCantidad, colSalon, colEstado });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(984, 461);
            dgvDatos.TabIndex = 0;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha";
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            // 
            // colNombre
            // 
            colNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            // 
            // colSalon
            // 
            colSalon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colSalon.HeaderText = "Salón";
            colSalon.Name = "colSalon";
            colSalon.ReadOnly = true;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            colEstado.Resizable = DataGridViewTriState.True;
            colEstado.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // frmEventos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 623);
            Controls.Add(panelGrilla);
            Controls.Add(panelInferior);
            Controls.Add(toolBar);
            Name = "frmEventos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eventos";
            Load += frmEventos_Load;
            toolBar.ResumeLayout(false);
            toolBar.PerformLayout();
            panelInferior.ResumeLayout(false);
            panelInferior.PerformLayout();
            panelGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolBar;
        private Panel panelInferior;
        private Panel panelGrilla;
        private ToolStripButton tsbEditar;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbSuspender;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbCerrar;
        private DataGridView dgvDatos;
        private ToolStripButton tsbVigente;
        private ToolStripButton tsbDetalles;
        private TextBox txtCantidad;
        private Label label1;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colSalon;
        private DataGridViewTextBoxColumn colEstado;
        private ToolStripDropDownButton tsbFiltrar;
        private ToolStripMenuItem porSalónToolStripMenuItem;
        private ToolStripComboBox cboSalonFiltro;
    }
}
