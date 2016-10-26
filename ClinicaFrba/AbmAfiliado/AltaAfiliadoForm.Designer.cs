namespace ClinicaFrba.AbmAfiliado
{
    partial class AltaAfiliadoForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this._tipoDoc = new System.Windows.Forms.ComboBox();
            this._nombre = new System.Windows.Forms.TextBox();
            this._apellido = new System.Windows.Forms.TextBox();
            this._numeroDocumento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._sexo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._estadoCivil = new System.Windows.Forms.ComboBox();
            this._direccion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this._telefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._mail = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._afiliadosACargo = new System.Windows.Forms.DataGridView();
            this._nombre_familiar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Relacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this._aceptarBtn = new System.Windows.Forms.Button();
            this._planMedico = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._afiliadosACargo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this._aceptarBtn);
            this.groupBox1.Location = new System.Drawing.Point(8, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(941, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._planMedico);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this._tipoDoc);
            this.groupBox3.Controls.Add(this._nombre);
            this.groupBox3.Controls.Add(this._apellido);
            this.groupBox3.Controls.Add(this._numeroDocumento);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this._sexo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this._estadoCivil);
            this.groupBox3.Controls.Add(this._direccion);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this._fechaNacimiento);
            this.groupBox3.Controls.Add(this._telefono);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this._mail);
            this.groupBox3.Location = new System.Drawing.Point(8, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(500, 229);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
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
            // _tipoDoc
            // 
            this._tipoDoc.FormattingEnabled = true;
            this._tipoDoc.Location = new System.Drawing.Point(79, 92);
            this._tipoDoc.Name = "_tipoDoc";
            this._tipoDoc.Size = new System.Drawing.Size(169, 21);
            this._tipoDoc.TabIndex = 30;
            this._tipoDoc.Text = "Tipo Documento";
            // 
            // _nombre
            // 
            this._nombre.Location = new System.Drawing.Point(79, 24);
            this._nombre.Name = "_nombre";
            this._nombre.Size = new System.Drawing.Size(415, 20);
            this._nombre.TabIndex = 0;
            // 
            // _apellido
            // 
            this._apellido.Location = new System.Drawing.Point(79, 58);
            this._apellido.Name = "_apellido";
            this._apellido.Size = new System.Drawing.Size(311, 20);
            this._apellido.TabIndex = 1;
            // 
            // _numeroDocumento
            // 
            this._numeroDocumento.Location = new System.Drawing.Point(343, 92);
            this._numeroDocumento.Name = "_numeroDocumento";
            this._numeroDocumento.Size = new System.Drawing.Size(151, 20);
            this._numeroDocumento.TabIndex = 3;
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
            // _sexo
            // 
            this._sexo.FormattingEnabled = true;
            this._sexo.Location = new System.Drawing.Point(447, 57);
            this._sexo.Margin = new System.Windows.Forms.Padding(2);
            this._sexo.Name = "_sexo";
            this._sexo.Size = new System.Drawing.Size(47, 21);
            this._sexo.TabIndex = 1;
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
            this.label4.Location = new System.Drawing.Point(264, 95);
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
            // _estadoCivil
            // 
            this._estadoCivil.FormattingEnabled = true;
            this._estadoCivil.Location = new System.Drawing.Point(80, 160);
            this._estadoCivil.Margin = new System.Windows.Forms.Padding(2);
            this._estadoCivil.Name = "_estadoCivil";
            this._estadoCivil.Size = new System.Drawing.Size(168, 21);
            this._estadoCivil.TabIndex = 23;
            this._estadoCivil.Text = "Estado Civil";
            // 
            // _direccion
            // 
            this._direccion.Location = new System.Drawing.Point(79, 125);
            this._direccion.Margin = new System.Windows.Forms.Padding(2);
            this._direccion.Name = "_direccion";
            this._direccion.Size = new System.Drawing.Size(169, 20);
            this._direccion.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(403, 60);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Telefono";
            // 
            // _fechaNacimiento
            // 
            this._fechaNacimiento.Location = new System.Drawing.Point(103, 193);
            this._fechaNacimiento.Margin = new System.Windows.Forms.Padding(2);
            this._fechaNacimiento.Name = "_fechaNacimiento";
            this._fechaNacimiento.Size = new System.Drawing.Size(193, 20);
            this._fechaNacimiento.TabIndex = 21;
            // 
            // _telefono
            // 
            this._telefono.Location = new System.Drawing.Point(343, 125);
            this._telefono.Margin = new System.Windows.Forms.Padding(2);
            this._telefono.Name = "_telefono";
            this._telefono.Size = new System.Drawing.Size(151, 20);
            this._telefono.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 196);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Fecha Nacimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 163);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Email";
            // 
            // _mail
            // 
            this._mail.Location = new System.Drawing.Point(343, 160);
            this._mail.Margin = new System.Windows.Forms.Padding(2);
            this._mail.Name = "_mail";
            this._mail.Size = new System.Drawing.Size(151, 20);
            this._mail.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this._afiliadosACargo);
            this.groupBox2.Location = new System.Drawing.Point(513, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(423, 229);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grupo Familiar";
            // 
            // _afiliadosACargo
            // 
            this._afiliadosACargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._afiliadosACargo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._nombre_familiar,
            this.Relacion,
            this.Accion});
            this._afiliadosACargo.Location = new System.Drawing.Point(10, 24);
            this._afiliadosACargo.Margin = new System.Windows.Forms.Padding(2);
            this._afiliadosACargo.Name = "_afiliadosACargo";
            this._afiliadosACargo.RowHeadersVisible = false;
            this._afiliadosACargo.RowTemplate.Height = 24;
            this._afiliadosACargo.Size = new System.Drawing.Size(404, 156);
            this._afiliadosACargo.TabIndex = 0;
            this._afiliadosACargo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellContentClick);
            // 
            // _nombre_familiar
            // 
            this._nombre_familiar.HeaderText = "Familiar";
            this._nombre_familiar.Name = "_nombre_familiar";
            this._nombre_familiar.Width = 200;
            // 
            // Relacion
            // 
            this.Relacion.HeaderText = "Relacion";
            this.Relacion.Name = "Relacion";
            this.Relacion.ReadOnly = true;
            // 
            // Accion
            // 
            this.Accion.HeaderText = "Accion";
            this.Accion.Name = "Accion";
            // 
            // _aceptarBtn
            // 
            this._aceptarBtn.Enabled = false;
            this._aceptarBtn.Location = new System.Drawing.Point(8, 243);
            this._aceptarBtn.Name = "_aceptarBtn";
            this._aceptarBtn.Size = new System.Drawing.Size(928, 25);
            this._aceptarBtn.TabIndex = 12;
            this._aceptarBtn.Text = "Aceptar";
            this._aceptarBtn.UseVisualStyleBackColor = true;
            this._aceptarBtn.Click += new System.EventHandler(this.AceptarClick);
            // 
            // _planMedico
            // 
            this._planMedico.FormattingEnabled = true;
            this._planMedico.Location = new System.Drawing.Point(344, 193);
            this._planMedico.Name = "_planMedico";
            this._planMedico.Size = new System.Drawing.Size(150, 21);
            this._planMedico.TabIndex = 33;
            this._planMedico.Text = "Plan";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(309, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Plan";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(404, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "Agregar Persona a cargo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AltaAfiliadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 295);
            this.Controls.Add(this.groupBox1);
            this.Name = "AltaAfiliadoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaAfiliado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._afiliadosACargo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button _aceptarBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _numeroDocumento;
        private System.Windows.Forms.TextBox _apellido;
        private System.Windows.Forms.TextBox _nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _direccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker _fechaNacimiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _mail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _telefono;
        private System.Windows.Forms.ComboBox _estadoCivil;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox _sexo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView _afiliadosACargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn _nombreFamiliar;
        private System.Windows.Forms.DataGridViewTextBoxColumn _apellidoFamiliar;
        private System.Windows.Forms.ComboBox _tipoDoc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn _nombre_familiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Relacion;
        private System.Windows.Forms.DataGridViewButtonColumn Accion;
        private System.Windows.Forms.ComboBox _planMedico;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
    }
}