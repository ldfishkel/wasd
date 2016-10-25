namespace ClinicaFrba.CancelarTurno
{
    partial class CancelarTurnoForm
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
            this._rangoGruopBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this._fechaHasta = new System.Windows.Forms.DateTimePicker();
            this._fechaDesde = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._turnosView = new System.Windows.Forms.DataGridView();
            this.Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Afiliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this._panel.SuspendLayout();
            this._rangoGruopBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._turnosView)).BeginInit();
            this.SuspendLayout();
            // 
            // _panel
            // 
            this._panel.Controls.Add(this._rangoGruopBox);
            this._panel.Controls.Add(this.groupBox1);
            this._panel.Location = new System.Drawing.Point(13, 13);
            this._panel.Name = "_panel";
            this._panel.Size = new System.Drawing.Size(764, 324);
            this._panel.TabIndex = 0;
            // 
            // _rangoGruopBox
            // 
            this._rangoGruopBox.Controls.Add(this.label2);
            this._rangoGruopBox.Controls.Add(this.label1);
            this._rangoGruopBox.Controls.Add(this.button1);
            this._rangoGruopBox.Controls.Add(this._fechaHasta);
            this._rangoGruopBox.Controls.Add(this._fechaDesde);
            this._rangoGruopBox.Location = new System.Drawing.Point(13, 260);
            this._rangoGruopBox.Name = "_rangoGruopBox";
            this._rangoGruopBox.Size = new System.Drawing.Size(737, 52);
            this._rangoGruopBox.TabIndex = 2;
            this._rangoGruopBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Desde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancelar Rango";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CancelarRangoClick);
            // 
            // _fechaHasta
            // 
            this._fechaHasta.Location = new System.Drawing.Point(350, 19);
            this._fechaHasta.Name = "_fechaHasta";
            this._fechaHasta.Size = new System.Drawing.Size(243, 20);
            this._fechaHasta.TabIndex = 1;
            // 
            // _fechaDesde
            // 
            this._fechaDesde.Location = new System.Drawing.Point(50, 19);
            this._fechaDesde.Name = "_fechaDesde";
            this._fechaDesde.Size = new System.Drawing.Size(243, 20);
            this._fechaDesde.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._turnosView);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 241);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turnos";
            // 
            // _turnosView
            // 
            this._turnosView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._turnosView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Turno,
            this.Fecha,
            this.Hora,
            this.Profesional,
            this.Especialidad,
            this.Afiliado,
            this.Accion});
            this._turnosView.Location = new System.Drawing.Point(6, 18);
            this._turnosView.Name = "_turnosView";
            this._turnosView.RowHeadersVisible = false;
            this._turnosView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this._turnosView.Size = new System.Drawing.Size(725, 217);
            this._turnosView.TabIndex = 0;
            this._turnosView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellContentClick);
            // 
            // Turno
            // 
            this.Turno.HeaderText = "Turno";
            this.Turno.Name = "Turno";
            this.Turno.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // Profesional
            // 
            this.Profesional.HeaderText = "Profesional";
            this.Profesional.Name = "Profesional";
            this.Profesional.ReadOnly = true;
            // 
            // Especialidad
            // 
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.ReadOnly = true;
            // 
            // Afiliado
            // 
            this.Afiliado.HeaderText = "Afiliado";
            this.Afiliado.Name = "Afiliado";
            this.Afiliado.ReadOnly = true;
            // 
            // Accion
            // 
            this.Accion.HeaderText = "Accion";
            this.Accion.Name = "Accion";
            // 
            // CancelarTurnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 349);
            this.Controls.Add(this._panel);
            this.Name = "CancelarTurnoForm";
            this.Text = "Cancelar Turno";
            this._panel.ResumeLayout(false);
            this._rangoGruopBox.ResumeLayout(false);
            this._rangoGruopBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._turnosView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panel;
        private System.Windows.Forms.DataGridView _turnosView;
        private System.Windows.Forms.GroupBox _rangoGruopBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker _fechaHasta;
        private System.Windows.Forms.DateTimePicker _fechaDesde;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesional;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Afiliado;
        private System.Windows.Forms.DataGridViewButtonColumn Accion;
    }
}