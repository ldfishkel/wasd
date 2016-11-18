namespace ClinicaFrba.RegistrarAgenda
{
    partial class AgendasAnterioresForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._agendaAnteriorGrid = new System.Windows.Forms.DataGridView();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._agendaAnteriorGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 368);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._agendaAnteriorGrid);
            this.groupBox1.Location = new System.Drawing.Point(13, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 346);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // _agendaAnteriorGrid
            // 
            this._agendaAnteriorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._agendaAnteriorGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dia,
            this.FechaDesde,
            this.FechaHasta,
            this.HoraDesde,
            this.HoraHasta,
            this.Especialidad});
            this._agendaAnteriorGrid.Location = new System.Drawing.Point(13, 19);
            this._agendaAnteriorGrid.Name = "_agendaAnteriorGrid";
            this._agendaAnteriorGrid.RowHeadersVisible = false;
            this._agendaAnteriorGrid.Size = new System.Drawing.Size(608, 314);
            this._agendaAnteriorGrid.TabIndex = 0;
            // 
            // Dia
            // 
            this.Dia.HeaderText = "Dia";
            this.Dia.Name = "Dia";
            this.Dia.ReadOnly = true;
            // 
            // FechaDesde
            // 
            this.FechaDesde.HeaderText = "Fecha Desde";
            this.FechaDesde.Name = "FechaDesde";
            this.FechaDesde.ReadOnly = true;
            // 
            // FechaHasta
            // 
            this.FechaHasta.HeaderText = "Fecha Hasta";
            this.FechaHasta.Name = "FechaHasta";
            this.FechaHasta.ReadOnly = true;
            // 
            // HoraDesde
            // 
            this.HoraDesde.HeaderText = "Hora Desde";
            this.HoraDesde.Name = "HoraDesde";
            this.HoraDesde.ReadOnly = true;
            // 
            // HoraHasta
            // 
            this.HoraHasta.HeaderText = "Hora Hasta";
            this.HoraHasta.Name = "HoraHasta";
            this.HoraHasta.ReadOnly = true;
            // 
            // Especialidad
            // 
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.ReadOnly = true;
            // 
            // AgendasAnterioresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 397);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AgendasAnterioresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgendasAnterioresForm";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._agendaAnteriorGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView _agendaAnteriorGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
    }
}