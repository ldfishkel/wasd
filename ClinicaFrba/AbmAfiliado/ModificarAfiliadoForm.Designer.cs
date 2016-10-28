namespace ClinicaFrba.AbmAfiliado
{
    partial class ModificarAfiliadoForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._planMedico = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._estadoCivil = new System.Windows.Forms.ComboBox();
            this._direccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this._telefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this._mail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._motivo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 176);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(503, 27);
            this.button1.TabIndex = 33;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GuardarClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this._motivo);
            this.groupBox3.Controls.Add(this._planMedico);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this._estadoCivil);
            this.groupBox3.Controls.Add(this._direccion);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this._telefono);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this._mail);
            this.groupBox3.Location = new System.Drawing.Point(12, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(503, 125);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            // 
            // _planMedico
            // 
            this._planMedico.FormattingEnabled = true;
            this._planMedico.Location = new System.Drawing.Point(79, 86);
            this._planMedico.Name = "_planMedico";
            this._planMedico.Size = new System.Drawing.Size(168, 21);
            this._planMedico.TabIndex = 33;
            this._planMedico.Text = "Plan";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Plan";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 52);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Estado Civil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Direccion";
            // 
            // _estadoCivil
            // 
            this._estadoCivil.FormattingEnabled = true;
            this._estadoCivil.Location = new System.Drawing.Point(79, 49);
            this._estadoCivil.Margin = new System.Windows.Forms.Padding(2);
            this._estadoCivil.Name = "_estadoCivil";
            this._estadoCivil.Size = new System.Drawing.Size(168, 21);
            this._estadoCivil.TabIndex = 23;
            this._estadoCivil.Text = "Estado Civil";
            // 
            // _direccion
            // 
            this._direccion.Location = new System.Drawing.Point(78, 14);
            this._direccion.Margin = new System.Windows.Forms.Padding(2);
            this._direccion.Name = "_direccion";
            this._direccion.Size = new System.Drawing.Size(169, 20);
            this._direccion.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Telefono";
            // 
            // _telefono
            // 
            this._telefono.Location = new System.Drawing.Point(347, 13);
            this._telefono.Margin = new System.Windows.Forms.Padding(2);
            this._telefono.Name = "_telefono";
            this._telefono.Size = new System.Drawing.Size(151, 20);
            this._telefono.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Email";
            // 
            // _mail
            // 
            this._mail.Location = new System.Drawing.Point(347, 48);
            this._mail.Margin = new System.Windows.Forms.Padding(2);
            this._mail.Name = "_mail";
            this._mail.Size = new System.Drawing.Size(151, 20);
            this._mail.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Motivo";
            // 
            // _motivo
            // 
            this._motivo.Location = new System.Drawing.Point(347, 89);
            this._motivo.Margin = new System.Windows.Forms.Padding(2);
            this._motivo.Name = "_motivo";
            this._motivo.Size = new System.Drawing.Size(151, 20);
            this._motivo.TabIndex = 35;
            // 
            // ModificarAfiliadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 200);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificarAfiliadoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarAfiliadoForm";
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox _planMedico;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox _estadoCivil;
        private System.Windows.Forms.TextBox _direccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _telefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _mail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _motivo;
    }
}