namespace ClinicaFrba.RegistrarLlegada
{
    partial class RegistrarLlegadaForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._turnosView = new System.Windows.Forms.DataGridView();
            this.turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreAfiliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroAfiliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancelado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Llego = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._tipoEspecialidad = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this._profesionalCombo = new System.Windows.Forms.ComboBox();
            this._especialidad = new System.Windows.Forms.ComboBox();
            this._nombreProfesional = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._panel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._turnosView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panel
            // 
            this._panel.Controls.Add(this.groupBox2);
            this._panel.Controls.Add(this.groupBox1);
            this._panel.Location = new System.Drawing.Point(13, 13);
            this._panel.Name = "_panel";
            this._panel.Size = new System.Drawing.Size(966, 324);
            this._panel.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._turnosView);
            this.groupBox2.Location = new System.Drawing.Point(11, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(942, 223);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Turnos";
            // 
            // _turnosView
            // 
            this._turnosView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._turnosView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.turno,
            this.Hora,
            this.Profesional,
            this.Especialidad,
            this.NombreAfiliado,
            this.NroAfiliado,
            this.Cancelado,
            this.Llego,
            this.Accion});
            this._turnosView.Location = new System.Drawing.Point(9, 19);
            this._turnosView.Name = "_turnosView";
            this._turnosView.RowHeadersVisible = false;
            this._turnosView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this._turnosView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._turnosView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this._turnosView.ShowEditingIcon = false;
            this._turnosView.Size = new System.Drawing.Size(919, 194);
            this._turnosView.TabIndex = 0;
            this._turnosView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellContentClick);
            // 
            // turno
            // 
            this.turno.HeaderText = "turno";
            this.turno.Name = "turno";
            this.turno.ReadOnly = true;
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
            this.Especialidad.HeaderText = "Especiaidad";
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.ReadOnly = true;
            // 
            // NombreAfiliado
            // 
            this.NombreAfiliado.HeaderText = "NombreAfiliado";
            this.NombreAfiliado.Name = "NombreAfiliado";
            this.NombreAfiliado.ReadOnly = true;
            // 
            // NroAfiliado
            // 
            this.NroAfiliado.HeaderText = "NroAfiliado";
            this.NroAfiliado.Name = "NroAfiliado";
            this.NroAfiliado.ReadOnly = true;
            // 
            // Cancelado
            // 
            this.Cancelado.HeaderText = "Cancelado";
            this.Cancelado.Name = "Cancelado";
            this.Cancelado.ReadOnly = true;
            // 
            // Llego
            // 
            this.Llego.HeaderText = "LLego";
            this.Llego.Name = "Llego";
            this.Llego.ReadOnly = true;
            // 
            // Accion
            // 
            this.Accion.HeaderText = "Accion";
            this.Accion.Name = "Accion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._tipoEspecialidad);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this._profesionalCombo);
            this.groupBox1.Controls.Add(this._especialidad);
            this.groupBox1.Controls.Add(this._nombreProfesional);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(943, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // _tipoEspecialidad
            // 
            this._tipoEspecialidad.FormattingEnabled = true;
            this._tipoEspecialidad.Location = new System.Drawing.Point(10, 46);
            this._tipoEspecialidad.Name = "_tipoEspecialidad";
            this._tipoEspecialidad.Size = new System.Drawing.Size(196, 21);
            this._tipoEspecialidad.TabIndex = 5;
            this._tipoEspecialidad.Text = "Tipo de Especialidad";
            this._tipoEspecialidad.SelectedIndexChanged += new System.EventHandler(this.TipoEspecialidadChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(719, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BuscarClick);
            // 
            // _profesionalCombo
            // 
            this._profesionalCombo.FormattingEnabled = true;
            this._profesionalCombo.Location = new System.Drawing.Point(540, 46);
            this._profesionalCombo.Name = "_profesionalCombo";
            this._profesionalCombo.Size = new System.Drawing.Size(389, 21);
            this._profesionalCombo.TabIndex = 3;
            this._profesionalCombo.Text = "Profesional";
            this._profesionalCombo.SelectedIndexChanged += new System.EventHandler(this.ProfesionalChanged);
            // 
            // _especialidad
            // 
            this._especialidad.FormattingEnabled = true;
            this._especialidad.Location = new System.Drawing.Point(212, 46);
            this._especialidad.Name = "_especialidad";
            this._especialidad.Size = new System.Drawing.Size(322, 21);
            this._especialidad.TabIndex = 2;
            this._especialidad.Text = "Especialidad";
            this._especialidad.SelectedIndexChanged += new System.EventHandler(this.EspecialidadChanged);
            // 
            // _nombreProfesional
            // 
            this._nombreProfesional.Location = new System.Drawing.Point(111, 16);
            this._nombreProfesional.Name = "_nombreProfesional";
            this._nombreProfesional.Size = new System.Drawing.Size(602, 20);
            this._nombreProfesional.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Profesional";
            // 
            // RegistrarLlegadaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 349);
            this.Controls.Add(this._panel);
            this.Name = "RegistrarLlegadaForm";
            this.Text = "Registrar Llegada";
            this._panel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._turnosView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox _profesionalCombo;
        private System.Windows.Forms.ComboBox _especialidad;
        private System.Windows.Forms.TextBox _nombreProfesional;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView _turnosView;
        private System.Windows.Forms.ComboBox _tipoEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesional;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAfiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroAfiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cancelado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Llego;
        private System.Windows.Forms.DataGridViewButtonColumn Accion;
    }
}