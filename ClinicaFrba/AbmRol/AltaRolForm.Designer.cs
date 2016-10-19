namespace ClinicaFrba.AbmRol
{
    partial class AltaRolForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._funcionalidadesView = new System.Windows.Forms.DataGridView();
            this.FuncionalidadId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funcionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this._funcionalidadCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._nombre = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._funcionalidadesView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 313);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(15, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(281, 43);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(268, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Guardar Rol";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GuardarClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._funcionalidadesView);
            this.groupBox2.Location = new System.Drawing.Point(15, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 153);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funcionalidades";
            // 
            // _funcionalidadesView
            // 
            this._funcionalidadesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._funcionalidadesView.ColumnHeadersVisible = false;
            this._funcionalidadesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FuncionalidadId,
            this.Funcionalidad,
            this.Action});
            this._funcionalidadesView.Location = new System.Drawing.Point(7, 19);
            this._funcionalidadesView.Name = "_funcionalidadesView";
            this._funcionalidadesView.RowHeadersVisible = false;
            this._funcionalidadesView.Size = new System.Drawing.Size(266, 124);
            this._funcionalidadesView.TabIndex = 1;
            this._funcionalidadesView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellContentClick);
            // 
            // FuncionalidadId
            // 
            this.FuncionalidadId.FillWeight = 50F;
            this.FuncionalidadId.HeaderText = "FuncionalidadId";
            this.FuncionalidadId.Name = "FuncionalidadId";
            this.FuncionalidadId.ReadOnly = true;
            this.FuncionalidadId.Width = 50;
            // 
            // Funcionalidad
            // 
            this.Funcionalidad.FillWeight = 150F;
            this.Funcionalidad.HeaderText = "Funcionalidad";
            this.Funcionalidad.Name = "Funcionalidad";
            this.Funcionalidad.ReadOnly = true;
            this.Funcionalidad.Width = 150;
            // 
            // Action
            // 
            this.Action.FillWeight = 60F;
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.Width = 60;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this._funcionalidadCombo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._nombre);
            this.groupBox1.Location = new System.Drawing.Point(15, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AgregarClick);
            // 
            // _funcionalidadCombo
            // 
            this._funcionalidadCombo.FormattingEnabled = true;
            this._funcionalidadCombo.Location = new System.Drawing.Point(17, 51);
            this._funcionalidadCombo.Name = "_funcionalidadCombo";
            this._funcionalidadCombo.Size = new System.Drawing.Size(183, 21);
            this._funcionalidadCombo.TabIndex = 2;
            this._funcionalidadCombo.Text = "Funcionalidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // _nombre
            // 
            this._nombre.Location = new System.Drawing.Point(64, 18);
            this._nombre.Name = "_nombre";
            this._nombre.Size = new System.Drawing.Size(207, 20);
            this._nombre.TabIndex = 0;
            // 
            // AltaRolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 336);
            this.Controls.Add(this.panel1);
            this.Name = "AltaRolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Rol";
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._funcionalidadesView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView _funcionalidadesView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox _funcionalidadCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _nombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuncionalidadId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionalidad;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
    }
}