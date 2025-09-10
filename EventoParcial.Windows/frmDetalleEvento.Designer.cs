namespace EventoParcial.Windows
{
    partial class frmDetalleEvento
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
            btnCerrar = new Button();
            label7 = new Label();
            groupBox1 = new GroupBox();
            txtLocalidad = new TextBox();
            label5 = new Label();
            txtDireccion = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtSalon = new TextBox();
            txtEvento = new TextBox();
            label2 = new Label();
            label8 = new Label();
            label1 = new Label();
            txtFecha = new TextBox();
            txtCantidad = new TextBox();
            txtTipoEvento = new TextBox();
            label9 = new Label();
            txtEstado = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(540, 18);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 62);
            btnCerrar.TabIndex = 18;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(298, 26);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 15;
            label7.Text = "Cantidad ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtLocalidad);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSalon);
            groupBox1.Location = new Point(43, 104);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(522, 138);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = " Datos del Salón ";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(77, 97);
            txtLocalidad.MaxLength = 255;
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.ReadOnly = true;
            txtLocalidad.Size = new Size(403, 23);
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
            // txtSalon
            // 
            txtSalon.Location = new Point(77, 20);
            txtSalon.MaxLength = 255;
            txtSalon.Name = "txtSalon";
            txtSalon.ReadOnly = true;
            txtSalon.Size = new Size(403, 23);
            txtSalon.TabIndex = 13;
            // 
            // txtEvento
            // 
            txtEvento.Location = new Point(105, 62);
            txtEvento.MaxLength = 255;
            txtEvento.Name = "txtEvento";
            txtEvento.ReadOnly = true;
            txtEvento.Size = new Size(418, 23);
            txtEvento.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 65);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 12;
            label2.Text = "Evento:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(48, 267);
            label8.Name = "label8";
            label8.Size = new Size(89, 15);
            label8.TabIndex = 8;
            label8.Text = "Tipo de Evento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 26);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 9;
            label1.Text = "Fecha:";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(105, 23);
            txtFecha.MaxLength = 255;
            txtFecha.Name = "txtFecha";
            txtFecha.ReadOnly = true;
            txtFecha.Size = new Size(138, 23);
            txtFecha.TabIndex = 13;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(385, 23);
            txtCantidad.MaxLength = 255;
            txtCantidad.Name = "txtCantidad";
            txtCantidad.ReadOnly = true;
            txtCantidad.Size = new Size(138, 23);
            txtCantidad.TabIndex = 13;
            // 
            // txtTipoEvento
            // 
            txtTipoEvento.Location = new Point(142, 264);
            txtTipoEvento.MaxLength = 255;
            txtTipoEvento.Name = "txtTipoEvento";
            txtTipoEvento.ReadOnly = true;
            txtTipoEvento.Size = new Size(138, 23);
            txtTipoEvento.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(298, 267);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 8;
            label9.Text = "Estado:";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(362, 264);
            txtEstado.MaxLength = 255;
            txtEstado.Name = "txtEstado";
            txtEstado.ReadOnly = true;
            txtEstado.Size = new Size(203, 23);
            txtEstado.TabIndex = 13;
            // 
            // frmDetalleEvento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 348);
            Controls.Add(btnCerrar);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            Controls.Add(txtCantidad);
            Controls.Add(txtEstado);
            Controls.Add(txtTipoEvento);
            Controls.Add(txtFecha);
            Controls.Add(txtEvento);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label1);
            Name = "frmDetalleEvento";
            Text = "frmDetalleEvento";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrar;
        private Label label7;
        private GroupBox groupBox1;
        private TextBox txtLocalidad;
        private Label label5;
        private TextBox txtDireccion;
        private Label label4;
        private Label label3;
        private TextBox txtSalon;
        private TextBox txtEvento;
        private Label label2;
        private Label label8;
        private Label label1;
        private TextBox txtFecha;
        private TextBox txtCantidad;
        private TextBox txtTipoEvento;
        private Label label9;
        private TextBox txtEstado;
    }
}