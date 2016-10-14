namespace ClinicaFrba.AbmAfiliado
{
    partial class ABMAfiliadosForm
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
            this._altaBtn = new System.Windows.Forms.Button();
            this._afiliadosGrid = new System.Windows.Forms.DataGridView();
            this.NroAfiliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Baja = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this._panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._afiliadosGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // _panel
            // 
            this._panel.Controls.Add(this._altaBtn);
            this._panel.Controls.Add(this._afiliadosGrid);
            this._panel.Location = new System.Drawing.Point(16, 15);
            this._panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._panel.Name = "_panel";
            this._panel.Size = new System.Drawing.Size(964, 394);
            this._panel.TabIndex = 0;
            // 
            // _altaBtn
            // 
            this._altaBtn.Location = new System.Drawing.Point(812, 6);
            this._altaBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._altaBtn.Name = "_altaBtn";
            this._altaBtn.Size = new System.Drawing.Size(147, 28);
            this._altaBtn.TabIndex = 1;
            this._altaBtn.Text = "Alta";
            this._altaBtn.UseVisualStyleBackColor = true;
            this._altaBtn.Click += new System.EventHandler(this.AltaClick);
            // 
            // _afiliadosGrid
            // 
            this._afiliadosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._afiliadosGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroAfiliado,
            this.Nombre,
            this.Plan,
            this.Ver,
            this.Baja,
            this.Modificar});
            this._afiliadosGrid.Location = new System.Drawing.Point(0, 4);
            this._afiliadosGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._afiliadosGrid.MultiSelect = false;
            this._afiliadosGrid.Name = "_afiliadosGrid";
            this._afiliadosGrid.RowHeadersVisible = false;
            this._afiliadosGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this._afiliadosGrid.Size = new System.Drawing.Size(805, 390);
            this._afiliadosGrid.TabIndex = 0;
            this._afiliadosGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._afiliadosGrid_CellContentClick);
            // 
            // NroAfiliado
            // 
            this.NroAfiliado.HeaderText = "Nro Afiliado";
            this.NroAfiliado.Name = "NroAfiliado";
            this.NroAfiliado.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre y Apellido";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Plan
            // 
            this.Plan.HeaderText = "Plan";
            this.Plan.Name = "Plan";
            this.Plan.ReadOnly = true;
            // 
            // Ver
            // 
            this.Ver.HeaderText = "Ver";
            this.Ver.Name = "Ver";
            // 
            // Baja
            // 
            this.Baja.HeaderText = "Baja";
            this.Baja.Name = "Baja";
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Name = "Modificar";
            // 
            // ABMAfiliadosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 423);
            this.Controls.Add(this._panel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ABMAfiliadosForm";
            this.Text = "ABMAfiliados";
            this._panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._afiliadosGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panel;
        private System.Windows.Forms.DataGridView _afiliadosGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroAfiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plan;
        private System.Windows.Forms.DataGridViewButtonColumn Ver;
        private System.Windows.Forms.DataGridViewButtonColumn Baja;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.Button _altaBtn;
    }
}