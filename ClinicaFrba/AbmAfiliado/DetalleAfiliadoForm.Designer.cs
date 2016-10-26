namespace ClinicaFrba.AbmAfiliado
{
    partial class DetalleAfiliadoForm
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
            this._historialPlanMedico = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._fechaNacimiento = new System.Windows.Forms.TextBox();
            this._sexo = new System.Windows.Forms.TextBox();
            this._nroDoc = new System.Windows.Forms.TextBox();
            this._estadoCivil = new System.Windows.Forms.TextBox();
            this._tipoDoc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this._planMedico = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this._nroAfiliado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._nombre = new System.Windows.Forms.TextBox();
            this._apellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._direccion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._telefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._mail = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._historialPlanMedico)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(10, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 274);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._historialPlanMedico);
            this.groupBox1.Location = new System.Drawing.Point(474, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 263);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cambios de Plan";
            // 
            // _historialPlanMedico
            // 
            this._historialPlanMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._historialPlanMedico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Motivo});
            this._historialPlanMedico.Location = new System.Drawing.Point(16, 26);
            this._historialPlanMedico.Name = "_historialPlanMedico";
            this._historialPlanMedico.RowHeadersVisible = false;
            this._historialPlanMedico.Size = new System.Drawing.Size(304, 221);
            this._historialPlanMedico.TabIndex = 0;
            // 
            // Fecha
            // 
            this.Fecha.FillWeight = 150F;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 150;
            // 
            // Motivo
            // 
            this.Motivo.FillWeight = 150F;
            this.Motivo.HeaderText = "Motivo";
            this.Motivo.Name = "Motivo";
            this.Motivo.ReadOnly = true;
            this.Motivo.Width = 150;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._fechaNacimiento);
            this.groupBox3.Controls.Add(this._sexo);
            this.groupBox3.Controls.Add(this._nroDoc);
            this.groupBox3.Controls.Add(this._estadoCivil);
            this.groupBox3.Controls.Add(this._tipoDoc);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this._planMedico);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this._nroAfiliado);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this._nombre);
            this.groupBox3.Controls.Add(this._apellido);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this._direccion);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this._telefono);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this._mail);
            this.groupBox3.Location = new System.Drawing.Point(11, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(454, 263);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            // 
            // _fechaNacimiento
            // 
            this._fechaNacimiento.Location = new System.Drawing.Point(322, 226);
            this._fechaNacimiento.Margin = new System.Windows.Forms.Padding(2);
            this._fechaNacimiento.Name = "_fechaNacimiento";
            this._fechaNacimiento.ReadOnly = true;
            this._fechaNacimiento.Size = new System.Drawing.Size(119, 20);
            this._fechaNacimiento.TabIndex = 39;
            // 
            // _sexo
            // 
            this._sexo.Location = new System.Drawing.Point(79, 226);
            this._sexo.Margin = new System.Windows.Forms.Padding(2);
            this._sexo.Name = "_sexo";
            this._sexo.ReadOnly = true;
            this._sexo.Size = new System.Drawing.Size(137, 20);
            this._sexo.TabIndex = 38;
            // 
            // _nroDoc
            // 
            this._nroDoc.Location = new System.Drawing.Point(303, 92);
            this._nroDoc.Margin = new System.Windows.Forms.Padding(2);
            this._nroDoc.Name = "_nroDoc";
            this._nroDoc.ReadOnly = true;
            this._nroDoc.Size = new System.Drawing.Size(138, 20);
            this._nroDoc.TabIndex = 37;
            // 
            // _estadoCivil
            // 
            this._estadoCivil.Location = new System.Drawing.Point(80, 160);
            this._estadoCivil.Margin = new System.Windows.Forms.Padding(2);
            this._estadoCivil.Name = "_estadoCivil";
            this._estadoCivil.ReadOnly = true;
            this._estadoCivil.Size = new System.Drawing.Size(136, 20);
            this._estadoCivil.TabIndex = 36;
            // 
            // _tipoDoc
            // 
            this._tipoDoc.Location = new System.Drawing.Point(79, 92);
            this._tipoDoc.Margin = new System.Windows.Forms.Padding(2);
            this._tipoDoc.Name = "_tipoDoc";
            this._tipoDoc.ReadOnly = true;
            this._tipoDoc.Size = new System.Drawing.Size(138, 20);
            this._tipoDoc.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 196);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Plan Medico";
            // 
            // _planMedico
            // 
            this._planMedico.Location = new System.Drawing.Point(80, 194);
            this._planMedico.Margin = new System.Windows.Forms.Padding(2);
            this._planMedico.Name = "_planMedico";
            this._planMedico.ReadOnly = true;
            this._planMedico.Size = new System.Drawing.Size(137, 20);
            this._planMedico.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(225, 197);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Afiliado N°";
            // 
            // _nroAfiliado
            // 
            this._nroAfiliado.Location = new System.Drawing.Point(304, 194);
            this._nroAfiliado.Margin = new System.Windows.Forms.Padding(2);
            this._nroAfiliado.Name = "_nroAfiliado";
            this._nroAfiliado.ReadOnly = true;
            this._nroAfiliado.Size = new System.Drawing.Size(137, 20);
            this._nroAfiliado.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // _nombre
            // 
            this._nombre.Location = new System.Drawing.Point(79, 24);
            this._nombre.Name = "_nombre";
            this._nombre.ReadOnly = true;
            this._nombre.Size = new System.Drawing.Size(362, 20);
            this._nombre.TabIndex = 0;
            // 
            // _apellido
            // 
            this._apellido.Location = new System.Drawing.Point(79, 58);
            this._apellido.Name = "_apellido";
            this._apellido.ReadOnly = true;
            this._apellido.Size = new System.Drawing.Size(362, 20);
            this._apellido.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tipo de Doc.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Num. de Doc.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 163);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Estado Civil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Direccion";
            // 
            // _direccion
            // 
            this._direccion.Location = new System.Drawing.Point(79, 125);
            this._direccion.Margin = new System.Windows.Forms.Padding(2);
            this._direccion.Name = "_direccion";
            this._direccion.ReadOnly = true;
            this._direccion.Size = new System.Drawing.Size(137, 20);
            this._direccion.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 227);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Telefono";
            // 
            // _telefono
            // 
            this._telefono.Location = new System.Drawing.Point(304, 125);
            this._telefono.Margin = new System.Windows.Forms.Padding(2);
            this._telefono.Name = "_telefono";
            this._telefono.ReadOnly = true;
            this._telefono.Size = new System.Drawing.Size(137, 20);
            this._telefono.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(225, 229);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Fecha Nacimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(225, 163);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Email";
            // 
            // _mail
            // 
            this._mail.Location = new System.Drawing.Point(304, 160);
            this._mail.Margin = new System.Windows.Forms.Padding(2);
            this._mail.Name = "_mail";
            this._mail.ReadOnly = true;
            this._mail.Size = new System.Drawing.Size(137, 20);
            this._mail.TabIndex = 19;
            // 
            // DetalleAfiliadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 294);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "DetalleAfiliadoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetalleAfiliadoForm";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._historialPlanMedico)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _nombre;
        private System.Windows.Forms.TextBox _apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _direccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _telefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _mail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView _historialPlanMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox _planMedico;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox _nroAfiliado;
        private System.Windows.Forms.TextBox _sexo;
        private System.Windows.Forms.TextBox _nroDoc;
        private System.Windows.Forms.TextBox _estadoCivil;
        private System.Windows.Forms.TextBox _tipoDoc;
        private System.Windows.Forms.TextBox _fechaNacimiento;
    }
}