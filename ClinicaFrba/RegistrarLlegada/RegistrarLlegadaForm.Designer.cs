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
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreAfiliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroAfiliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancelado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this._panel.Size = new System.Drawing.Size(761, 325);
            this._panel.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._turnosView);
            this.groupBox2.Location = new System.Drawing.Point(11, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(738, 220);
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
            this.Especialidad,
            this.NombreAfiliado,
            this.NroAfiliado,
            this.Cancelado,
            this.Accion});
            this._turnosView.Location = new System.Drawing.Point(9, 20);
            this._turnosView.Name = "_turnosView";
            this._turnosView.RowHeadersVisible = false;
            this._turnosView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this._turnosView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._turnosView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this._turnosView.ShowEditingIcon = false;
            this._turnosView.Size = new System.Drawing.Size(721, 183);
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
            // Accion
            // 
            this.Accion.HeaderText = "Accion";
            this.Accion.Name = "Accion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this._profesionalCombo);
            this.groupBox1.Controls.Add(this._especialidad);
            this.groupBox1.Controls.Add(this._nombreProfesional);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BuscarClick);
            // 
            // _profesionalCombo
            // 
            this._profesionalCombo.FormattingEnabled = true;
            this._profesionalCombo.Location = new System.Drawing.Point(204, 46);
            this._profesionalCombo.Name = "_profesionalCombo";
            this._profesionalCombo.Size = new System.Drawing.Size(527, 21);
            this._profesionalCombo.TabIndex = 3;
            this._profesionalCombo.Text = "Profesional";
            this._profesionalCombo.SelectedIndexChanged += new System.EventHandler(this.ProfesionalChanged);
            // 
            // _especialidad
            // 
            this._especialidad.FormattingEnabled = true;
            this._especialidad.Location = new System.Drawing.Point(9, 46);
            this._especialidad.Name = "_especialidad";
            this._especialidad.Size = new System.Drawing.Size(189, 21);
            this._especialidad.TabIndex = 2;
            this._especialidad.Text = "Especialidad";
            this._especialidad.SelectedIndexChanged += new System.EventHandler(this.EspecialidadChanged);
            // 
            // _nombreProfesional
            // 
            this._nombreProfesional.Location = new System.Drawing.Point(111, 16);
            this._nombreProfesional.Name = "_nombreProfesional";
            this._nombreProfesional.Size = new System.Drawing.Size(503, 20);
            this._nombreProfesional.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Profesional";
            // 
            // RegistrarLlegadaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 349);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAfiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroAfiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cancelado;
        private System.Windows.Forms.DataGridViewButtonColumn Accion;
    }
}