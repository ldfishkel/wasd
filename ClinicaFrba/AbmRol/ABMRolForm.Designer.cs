namespace ClinicaFrba.AbmRol
{
    partial class ABMRolForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._rolView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Action2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this._panel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._rolView)).BeginInit();
            this.SuspendLayout();
            // 
            // _panel
            // 
            this._panel.Controls.Add(this.groupBox2);
            this._panel.Controls.Add(this.groupBox1);
            this._panel.Location = new System.Drawing.Point(12, 13);
            this._panel.Name = "_panel";
            this._panel.Size = new System.Drawing.Size(381, 295);
            this._panel.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(10, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 43);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(334, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear Nuevo Rol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AltaClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._rolView);
            this.groupBox1.Location = new System.Drawing.Point(10, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 232);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Roles";
            // 
            // _rolView
            // 
            this._rolView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._rolView.ColumnHeadersVisible = false;
            this._rolView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Rol,
            this.Action1,
            this.Action2});
            this._rolView.Location = new System.Drawing.Point(13, 18);
            this._rolView.Name = "_rolView";
            this._rolView.RowHeadersVisible = false;
            this._rolView.Size = new System.Drawing.Size(334, 202);
            this._rolView.TabIndex = 0;
            this._rolView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellContentClick);
            // 
            // Id
            // 
            this.Id.FillWeight = 30F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 30;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            // 
            // Action1
            // 
            this.Action1.HeaderText = "Action1";
            this.Action1.Name = "Action1";
            // 
            // Action2
            // 
            this.Action2.HeaderText = "Action2";
            this.Action2.Name = "Action2";
            // 
            // ABMRolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 317);
            this.Controls.Add(this._panel);
            this.Name = "ABMRolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Rol";
            this._panel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._rolView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView _rolView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewButtonColumn Action1;
        private System.Windows.Forms.DataGridViewButtonColumn Action2;
    }
}