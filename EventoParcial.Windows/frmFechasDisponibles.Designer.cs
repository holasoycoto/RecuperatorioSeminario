namespace EventoParcial.Windows
{
    partial class frmFechasDisponibles
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
            monthCalendar1 = new MonthCalendar();
            cboSalon = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.CalendarDimensions = new Size(3, 2);
            monthCalendar1.Location = new Point(32, 63);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // cboSalon
            // 
            cboSalon.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSalon.FormattingEnabled = true;
            cboSalon.Location = new Point(86, 18);
            cboSalon.Name = "cboSalon";
            cboSalon.Size = new Size(273, 23);
            cboSalon.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 21);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Salón:";
            // 
            // frmFechasDisponibles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 450);
            Controls.Add(cboSalon);
            Controls.Add(label3);
            Controls.Add(monthCalendar1);
            Name = "frmFechasDisponibles";
            Text = "frmFechasDisponibles";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private ComboBox cboSalon;
        private Label label3;
    }
}