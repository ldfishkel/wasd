namespace ClinicaFrba.RegistrarLlegada
{
    partial class BonosViewForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._ComprarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._UsarBtn = new System.Windows.Forms.Button();
            this._bonosCombo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 119);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._ComprarBtn);
            this.groupBox2.Location = new System.Drawing.Point(13, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 50);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // _ComprarBtn
            // 
            this._ComprarBtn.Location = new System.Drawing.Point(6, 13);
            this._ComprarBtn.Name = "_ComprarBtn";
            this._ComprarBtn.Size = new System.Drawing.Size(221, 29);
            this._ComprarBtn.TabIndex = 0;
            this._ComprarBtn.Text = "Comprar Bono";
            this._ComprarBtn.UseVisualStyleBackColor = true;
            this._ComprarBtn.Click += new System.EventHandler(this.ComprarClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._UsarBtn);
            this.groupBox1.Controls.Add(this._bonosCombo);
            this.groupBox1.Location = new System.Drawing.Point(13, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 43);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // _UsarBtn
            // 
            this._UsarBtn.Enabled = false;
            this._UsarBtn.Location = new System.Drawing.Point(147, 9);
            this._UsarBtn.Name = "_UsarBtn";
            this._UsarBtn.Size = new System.Drawing.Size(80, 26);
            this._UsarBtn.TabIndex = 1;
            this._UsarBtn.Text = "Usar";
            this._UsarBtn.UseVisualStyleBackColor = true;
            this._UsarBtn.Click += new System.EventHandler(this._UsarBtn_Click);
            // 
            // _bonosCombo
            // 
            this._bonosCombo.FormattingEnabled = true;
            this._bonosCombo.Location = new System.Drawing.Point(6, 13);
            this._bonosCombo.Name = "_bonosCombo";
            this._bonosCombo.Size = new System.Drawing.Size(135, 21);
            this._bonosCombo.TabIndex = 0;
            this._bonosCombo.Text = "Bonos";
            this._bonosCombo.SelectedIndexChanged += new System.EventHandler(this._bonosCombo_SelectedIndexChanged);
            // 
            // BonosViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 144);
            this.Controls.Add(this.panel1);
            this.Name = "BonosViewForm";
            this.Text = "BonosViewForm";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button _ComprarBtn;
        private System.Windows.Forms.Button _UsarBtn;
        private System.Windows.Forms.ComboBox _bonosCombo;
    }
}