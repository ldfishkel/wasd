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
            this._turnosView = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Afiliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this._panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._turnosView)).BeginInit();
            this.SuspendLayout();
            // 
            // _panel
            // 
            this._panel.Controls.Add(this._turnosView);
            this._panel.Location = new System.Drawing.Point(13, 13);
            this._panel.Name = "_panel";
            this._panel.Size = new System.Drawing.Size(884, 243);
            this._panel.TabIndex = 0;
            // 
            // _turnosView
            // 
            this._turnosView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._turnosView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Hora,
            this.Profesional,
            this.Especialidad,
            this.Afiliado,
            this.Accion});
            this._turnosView.Location = new System.Drawing.Point(15, 13);
            this._turnosView.Name = "_turnosView";
            this._turnosView.RowHeadersVisible = false;
            this._turnosView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this._turnosView.Size = new System.Drawing.Size(855, 217);
            this._turnosView.TabIndex = 0;
            this._turnosView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellContentClick);
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
            this.Profesional.FillWeight = 200F;
            this.Profesional.HeaderText = "Profesional";
            this.Profesional.Name = "Profesional";
            this.Profesional.ReadOnly = true;
            this.Profesional.Width = 200;
            // 
            // Especialidad
            // 
            this.Especialidad.FillWeight = 150F;
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.ReadOnly = true;
            this.Especialidad.Width = 150;
            // 
            // Afiliado
            // 
            this.Afiliado.FillWeight = 200F;
            this.Afiliado.HeaderText = "Afiliado";
            this.Afiliado.Name = "Afiliado";
            this.Afiliado.ReadOnly = true;
            this.Afiliado.Width = 200;
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
            this.ClientSize = new System.Drawing.Size(909, 263);
            this.Controls.Add(this._panel);
            this.Name = "CancelarTurnoForm";
            this.Text = "Cancelar Turno";
            this._panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._turnosView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panel;
        private System.Windows.Forms.DataGridView _turnosView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesional;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Afiliado;
        private System.Windows.Forms.DataGridViewButtonColumn Accion;
    }
}