namespace ClinicaFrba.PedirTurno
{
    partial class PedirTurnoForm
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
            this._panel = new System.Windows.Forms.Panel();
            this._fechaHoraGroupbox = new System.Windows.Forms.GroupBox();
            this._turnoBtn = new System.Windows.Forms.Button();
            this._fecha = new System.Windows.Forms.ComboBox();
            this._hora = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._profesionalCombo = new System.Windows.Forms.ComboBox();
            this._especialidad = new System.Windows.Forms.ComboBox();
            this._tipoEspecialidad = new System.Windows.Forms.ComboBox();
            this._panel.SuspendLayout();
            this._fechaHoraGroupbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panel
            // 
            this._panel.Controls.Add(this._fechaHoraGroupbox);
            this._panel.Controls.Add(this.groupBox1);
            this._panel.Location = new System.Drawing.Point(13, 16);
            this._panel.Name = "_panel";
            this._panel.Size = new System.Drawing.Size(315, 219);
            this._panel.TabIndex = 0;
            // 
            // _fechaHoraGroupbox
            // 
            this._fechaHoraGroupbox.Controls.Add(this._turnoBtn);
            this._fechaHoraGroupbox.Controls.Add(this._fecha);
            this._fechaHoraGroupbox.Controls.Add(this._hora);
            this._fechaHoraGroupbox.Enabled = false;
            this._fechaHoraGroupbox.Location = new System.Drawing.Point(12, 110);
            this._fechaHoraGroupbox.Name = "_fechaHoraGroupbox";
            this._fechaHoraGroupbox.Size = new System.Drawing.Size(288, 80);
            this._fechaHoraGroupbox.TabIndex = 2;
            this._fechaHoraGroupbox.TabStop = false;
            this._fechaHoraGroupbox.Text = "Fechas y Horarios disponibles";
            // 
            // _turnoBtn
            // 
            this._turnoBtn.Enabled = false;
            this._turnoBtn.Location = new System.Drawing.Point(7, 48);
            this._turnoBtn.Name = "_turnoBtn";
            this._turnoBtn.Size = new System.Drawing.Size(271, 23);
            this._turnoBtn.TabIndex = 2;
            this._turnoBtn.Text = "Solicitar Turno";
            this._turnoBtn.UseVisualStyleBackColor = true;
            this._turnoBtn.Click += new System.EventHandler(this.SolicitarTurnoClick);
            // 
            // _fecha
            // 
            this._fecha.FormattingEnabled = true;
            this._fecha.Location = new System.Drawing.Point(6, 20);
            this._fecha.Name = "_fecha";
            this._fecha.Size = new System.Drawing.Size(129, 21);
            this._fecha.TabIndex = 1;
            this._fecha.Text = "Fecha";
            this._fecha.SelectedIndexChanged += new System.EventHandler(this.FechaChanged);
            // 
            // _hora
            // 
            this._hora.Enabled = false;
            this._hora.FormattingEnabled = true;
            this._hora.Location = new System.Drawing.Point(141, 21);
            this._hora.Name = "_hora";
            this._hora.Size = new System.Drawing.Size(137, 21);
            this._hora.TabIndex = 0;
            this._hora.Text = "Hora";
            this._hora.SelectedIndexChanged += new System.EventHandler(this.HoraChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._tipoEspecialidad);
            this.groupBox1.Controls.Add(this._profesionalCombo);
            this.groupBox1.Controls.Add(this._especialidad);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 101);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // _profesionalCombo
            // 
            this._profesionalCombo.FormattingEnabled = true;
            this._profesionalCombo.Location = new System.Drawing.Point(6, 73);
            this._profesionalCombo.Name = "_profesionalCombo";
            this._profesionalCombo.Size = new System.Drawing.Size(272, 21);
            this._profesionalCombo.TabIndex = 3;
            this._profesionalCombo.Text = "Profesional";
            this._profesionalCombo.SelectedIndexChanged += new System.EventHandler(this.ProfesionalChanged);
            // 
            // _especialidad
            // 
            this._especialidad.FormattingEnabled = true;
            this._especialidad.Location = new System.Drawing.Point(6, 46);
            this._especialidad.Name = "_especialidad";
            this._especialidad.Size = new System.Drawing.Size(272, 21);
            this._especialidad.TabIndex = 2;
            this._especialidad.Text = "Especialidad";
            this._especialidad.SelectedIndexChanged += new System.EventHandler(this.EspecialidadChanged);
            // 
            // _tipoEspecialidad
            // 
            this._tipoEspecialidad.FormattingEnabled = true;
            this._tipoEspecialidad.Location = new System.Drawing.Point(7, 19);
            this._tipoEspecialidad.Name = "_tipoEspecialidad";
            this._tipoEspecialidad.Size = new System.Drawing.Size(272, 21);
            this._tipoEspecialidad.TabIndex = 4;
            this._tipoEspecialidad.Text = "Tipo de Especialidad";
            this._tipoEspecialidad.SelectedIndexChanged += new System.EventHandler(this.TipoEspecialidadChanged);
            // 
            // PedirTurnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 247);
            this.Controls.Add(this._panel);
            this.Name = "PedirTurnoForm";
            this.Text = "Pedir Turno";
            this._panel.ResumeLayout(false);
            this._fechaHoraGroupbox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox _profesionalCombo;
        private System.Windows.Forms.ComboBox _especialidad;
        private System.Windows.Forms.GroupBox _fechaHoraGroupbox;
        private System.Windows.Forms.ComboBox _fecha;
        private System.Windows.Forms.ComboBox _hora;
        private System.Windows.Forms.Button _turnoBtn;
        private System.Windows.Forms.ComboBox _tipoEspecialidad;
    }
}