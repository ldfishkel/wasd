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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._profesionalView = new System.Windows.Forms.DataGridView();
            this.NombreProfesional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this._profesionalCombo = new System.Windows.Forms.ComboBox();
            this._especialidad = new System.Windows.Forms.ComboBox();
            this._nombreProfesional = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._panel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._profesionalView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panel
            // 
            this._panel.Controls.Add(this.groupBox2);
            this._panel.Controls.Add(this.groupBox1);
            this._panel.Location = new System.Drawing.Point(13, 16);
            this._panel.Name = "_panel";
            this._panel.Size = new System.Drawing.Size(649, 249);
            this._panel.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._profesionalView);
            this.groupBox2.Location = new System.Drawing.Point(12, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 150);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Turnos";
            // 
            // _profesionalView
            // 
            this._profesionalView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._profesionalView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreProfesional,
            this.Especialidad,
            this.Accion});
            this._profesionalView.Location = new System.Drawing.Point(9, 20);
            this._profesionalView.Name = "_profesionalView";
            this._profesionalView.RowHeadersVisible = false;
            this._profesionalView.RowHeadersWidth = 200;
            this._profesionalView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._profesionalView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this._profesionalView.ShowEditingIcon = false;
            this._profesionalView.Size = new System.Drawing.Size(605, 119);
            this._profesionalView.TabIndex = 0;
            this._profesionalView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellContentClick);
            // 
            // NombreProfesional
            // 
            this.NombreProfesional.FillWeight = 300F;
            this.NombreProfesional.HeaderText = "Nombre Profesional";
            this.NombreProfesional.Name = "NombreProfesional";
            this.NombreProfesional.ReadOnly = true;
            this.NombreProfesional.Width = 300;
            // 
            // Especialidad
            // 
            this.Especialidad.FillWeight = 200F;
            this.Especialidad.HeaderText = "Especiaidad";
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.ReadOnly = true;
            this.Especialidad.Width = 200;
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
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 79);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // _profesionalCombo
            // 
            this._profesionalCombo.FormattingEnabled = true;
            this._profesionalCombo.Location = new System.Drawing.Point(204, 46);
            this._profesionalCombo.Name = "_profesionalCombo";
            this._profesionalCombo.Size = new System.Drawing.Size(328, 21);
            this._profesionalCombo.TabIndex = 3;
            this._profesionalCombo.Text = "Profesional";
            // 
            // _especialidad
            // 
            this._especialidad.FormattingEnabled = true;
            this._especialidad.Location = new System.Drawing.Point(9, 46);
            this._especialidad.Name = "_especialidad";
            this._especialidad.Size = new System.Drawing.Size(189, 21);
            this._especialidad.TabIndex = 2;
            this._especialidad.Text = "Especialidad";
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
            // PedirTurnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 274);
            this.Controls.Add(this._panel);
            this.Name = "PedirTurnoForm";
            this.Text = "Pedir Turno";
            this._panel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._profesionalView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox _profesionalCombo;
        private System.Windows.Forms.ComboBox _especialidad;
        private System.Windows.Forms.TextBox _nombreProfesional;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView _profesionalView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProfesional;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewButtonColumn Accion;
    }
}