namespace EventoParcial.Windows
{
    partial class frmEventoAE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            dtpFecha = new DateTimePicker();
            label2 = new Label();
            txtEvento = new TextBox();
            groupBox1 = new GroupBox();
            cboSalon = new ComboBox();
            txtCapacidad = new TextBox();
            label6 = new Label();
            txtLocalidad = new TextBox();
            label5 = new Label();
            txtDireccion = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            nudCantidad = new NumericUpDown();
            label8 = new Label();
            cboTipoEvento = new ComboBox();
            btnOK = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 26);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(89, 24);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(104, 23);
            dtpFecha.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 65);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 2;
            label2.Text = "Evento:";
            // 
            // txtEvento
            // 
            txtEvento.Location = new Point(88, 62);
            txtEvento.MaxLength = 255;
            txtEvento.Name = "txtEvento";
            txtEvento.Size = new Size(460, 23);
            txtEvento.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboSalon);
            groupBox1.Controls.Add(txtCapacidad);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtLocalidad);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(26, 104);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(522, 138);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = " Datos del Salón ";
            // 
            // cboSalon
            // 
            cboSalon.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSalon.FormattingEnabled = true;
            cboSalon.Location = new Point(76, 20);
            cboSalon.Name = "cboSalon";
            cboSalon.Size = new Size(273, 23);
            cboSalon.TabIndex = 1;
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new Point(337, 97);
            txtCapacidad.MaxLength = 255;
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.ReadOnly = true;
            txtCapacidad.Size = new Size(143, 23);
            txtCapacidad.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(265, 100);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 2;
            label6.Text = "Capacidad:";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(77, 97);
            txtLocalidad.MaxLength = 255;
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.ReadOnly = true;
            txtLocalidad.Size = new Size(148, 23);
            txtLocalidad.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 100);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 2;
            label5.Text = "Localidad:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(76, 59);
            txtDireccion.MaxLength = 255;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.ReadOnly = true;
            txtDireccion.Size = new Size(404, 23);
            txtDireccion.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 62);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 2;
            label4.Text = "Dirección:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 23);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 0;
            label3.Text = "Salón:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(232, 26);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 5;
            label7.Text = "Cantidad ";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(296, 24);
            nudCantidad.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 23);
            nudCantidad.TabIndex = 6;
            nudCantidad.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 267);
            label8.Name = "label8";
            label8.Size = new Size(88, 15);
            label8.TabIndex = 0;
            label8.Text = "Tipo de Evento:";
            // 
            // cboTipoEvento
            // 
            cboTipoEvento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoEvento.FormattingEnabled = true;
            cboTipoEvento.Location = new Point(143, 264);
            cboTipoEvento.Name = "cboTipoEvento";
            cboTipoEvento.Size = new Size(233, 23);
            cboTipoEvento.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(31, 301);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 62);
            btnOK.TabIndex = 7;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(473, 301);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 62);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmEventoAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 371);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(cboTipoEvento);
            Controls.Add(nudCantidad);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            Controls.Add(txtEvento);
            Controls.Add(label2);
            Controls.Add(dtpFecha);
            Controls.Add(label8);
            Controls.Add(label1);
            Name = "frmEventoAE";
            Text = "frmEventoAE";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpFecha;
        private Label label2;
        private TextBox txtEvento;
        private GroupBox groupBox1;
        private ComboBox cboSalon;
        private TextBox txtCapacidad;
        private Label label6;
        private TextBox txtDireccion;
        private Label label4;
        private Label label3;
        private Label label7;
        private NumericUpDown nudCantidad;
        private Label label8;
        private ComboBox cboTipoEvento;
        private Button btnOK;
        private Button btnCancelar;
        private TextBox txtLocalidad;
        private Label label5;
        private ErrorProvider errorProvider1;
    }
}