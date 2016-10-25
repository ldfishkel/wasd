namespace ClinicaFrba.Diagnosticar
{
    partial class ResultadoConsultaMedicaForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._diagnosticoBtn = new System.Windows.Forms.Button();
            this._diagnosticoTxt = new System.Windows.Forms.RichTextBox();
            this._diagnosticosGrid = new System.Windows.Forms.DataGridView();
            this.Diagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._sintomaBtn = new System.Windows.Forms.Button();
            this._sintomaTxt = new System.Windows.Forms.RichTextBox();
            this._sintomasGrid = new System.Windows.Forms.DataGridView();
            this.Sintoma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._diagnosticosGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._sintomasGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 286);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(12, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(629, 39);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(616, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar resultado de consulta medica";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GuardarResultadoClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._diagnosticoBtn);
            this.groupBox2.Controls.Add(this._diagnosticoTxt);
            this.groupBox2.Controls.Add(this._diagnosticosGrid);
            this.groupBox2.Location = new System.Drawing.Point(337, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 231);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diagnosticos";
            // 
            // _diagnosticoBtn
            // 
            this._diagnosticoBtn.Location = new System.Drawing.Point(215, 19);
            this._diagnosticoBtn.Name = "_diagnosticoBtn";
            this._diagnosticoBtn.Size = new System.Drawing.Size(83, 66);
            this._diagnosticoBtn.TabIndex = 3;
            this._diagnosticoBtn.Text = "Agregar";
            this._diagnosticoBtn.UseVisualStyleBackColor = true;
            this._diagnosticoBtn.Click += new System.EventHandler(this.AgregarDiagnosticoClick);
            // 
            // _diagnosticoTxt
            // 
            this._diagnosticoTxt.Location = new System.Drawing.Point(6, 19);
            this._diagnosticoTxt.Name = "_diagnosticoTxt";
            this._diagnosticoTxt.Size = new System.Drawing.Size(203, 67);
            this._diagnosticoTxt.TabIndex = 2;
            this._diagnosticoTxt.Text = "";
            // 
            // _diagnosticosGrid
            // 
            this._diagnosticosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._diagnosticosGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Diagnostico,
            this.Action2});
            this._diagnosticosGrid.Location = new System.Drawing.Point(6, 93);
            this._diagnosticosGrid.Name = "_diagnosticosGrid";
            this._diagnosticosGrid.RowHeadersVisible = false;
            this._diagnosticosGrid.Size = new System.Drawing.Size(292, 132);
            this._diagnosticosGrid.TabIndex = 1;
            this._diagnosticosGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DiagnosticosCellContentClick);
            // 
            // Diagnostico
            // 
            this.Diagnostico.FillWeight = 170F;
            this.Diagnostico.HeaderText = "Diagnostico";
            this.Diagnostico.Name = "Diagnostico";
            this.Diagnostico.ReadOnly = true;
            this.Diagnostico.Width = 170;
            // 
            // Action2
            // 
            this.Action2.HeaderText = "Action";
            this.Action2.Name = "Action2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._sintomaBtn);
            this.groupBox1.Controls.Add(this._sintomaTxt);
            this.groupBox1.Controls.Add(this._sintomasGrid);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sintomas";
            // 
            // _sintomaBtn
            // 
            this._sintomaBtn.Location = new System.Drawing.Point(223, 19);
            this._sintomaBtn.Name = "_sintomaBtn";
            this._sintomaBtn.Size = new System.Drawing.Size(90, 65);
            this._sintomaBtn.TabIndex = 2;
            this._sintomaBtn.Text = "Agregar";
            this._sintomaBtn.UseVisualStyleBackColor = true;
            this._sintomaBtn.Click += new System.EventHandler(this.AgregarSintomaClick);
            // 
            // _sintomaTxt
            // 
            this._sintomaTxt.Location = new System.Drawing.Point(7, 20);
            this._sintomaTxt.Name = "_sintomaTxt";
            this._sintomaTxt.Size = new System.Drawing.Size(210, 67);
            this._sintomaTxt.TabIndex = 1;
            this._sintomaTxt.Text = "";
            // 
            // _sintomasGrid
            // 
            this._sintomasGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._sintomasGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sintoma,
            this.Action});
            this._sintomasGrid.Location = new System.Drawing.Point(7, 93);
            this._sintomasGrid.Name = "_sintomasGrid";
            this._sintomasGrid.RowHeadersVisible = false;
            this._sintomasGrid.Size = new System.Drawing.Size(306, 132);
            this._sintomasGrid.TabIndex = 0;
            this._sintomasGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SintomasCellContentClick);
            // 
            // Sintoma
            // 
            this.Sintoma.FillWeight = 180F;
            this.Sintoma.HeaderText = "Sintoma";
            this.Sintoma.Name = "Sintoma";
            this.Sintoma.ReadOnly = true;
            this.Sintoma.Width = 180;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            // 
            // ResultadoConsultaMedicaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 319);
            this.Controls.Add(this.panel1);
            this.Name = "ResultadoConsultaMedicaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultadoConsultaMedicaForm";
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._diagnosticosGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._sintomasGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView _sintomasGrid;
        private System.Windows.Forms.DataGridView _diagnosticosGrid;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button _diagnosticoBtn;
        private System.Windows.Forms.RichTextBox _diagnosticoTxt;
        private System.Windows.Forms.Button _sintomaBtn;
        private System.Windows.Forms.RichTextBox _sintomaTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sintoma;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnostico;
        private System.Windows.Forms.DataGridViewButtonColumn Action2;
    }
}