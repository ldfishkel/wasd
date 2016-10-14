namespace ClinicaFrba.AbmAfiliado
{
    partial class AltaAfiliado
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
            this._no_familia = new System.Windows.Forms.RadioButton();
            this._si_familia = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._nombre_familiar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._apellido_familiar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._sexo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this._estado_civil = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this._fecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this._mail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this._telefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this._direccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._cancelar = new System.Windows.Forms.Button();
            this._aceptar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._numero_documento = new System.Windows.Forms.TextBox();
            this._tipo_documento = new System.Windows.Forms.TextBox();
            this._apellido = new System.Windows.Forms.TextBox();
            this._nombre = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._no_familia);
            this.groupBox1.Controls.Add(this._si_familia);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this._sexo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this._estado_civil);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this._fecha_nacimiento);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this._mail);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this._telefono);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this._direccion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this._cancelar);
            this.groupBox1.Controls.Add(this._aceptar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._numero_documento);
            this.groupBox1.Controls.Add(this._tipo_documento);
            this.groupBox1.Controls.Add(this._apellido);
            this.groupBox1.Controls.Add(this._nombre);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(531, 555);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // _no_familia
            // 
            this._no_familia.AutoSize = true;
            this._no_familia.Location = new System.Drawing.Point(284, 241);
            this._no_familia.Name = "_no_familia";
            this._no_familia.Size = new System.Drawing.Size(47, 21);
            this._no_familia.TabIndex = 29;
            this._no_familia.TabStop = true;
            this._no_familia.Text = "No";
            this._no_familia.UseVisualStyleBackColor = true;
            this._no_familia.CheckedChanged += new System.EventHandler(this._no_familia_CheckedChanged);
            // 
            // _si_familia
            // 
            this._si_familia.AutoSize = true;
            this._si_familia.Location = new System.Drawing.Point(236, 241);
            this._si_familia.Name = "_si_familia";
            this._si_familia.Size = new System.Drawing.Size(41, 21);
            this._si_familia.TabIndex = 28;
            this._si_familia.TabStop = true;
            this._si_familia.Text = "Si";
            this._si_familia.UseVisualStyleBackColor = true;
            this._si_familia.CheckedChanged += new System.EventHandler(this._si_familia_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(8, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 250);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grupo Familiar";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 1;
            this.button3.Text = "Agregar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._nombre_familiar,
            this._apellido_familiar});
            this.dataGridView1.Location = new System.Drawing.Point(7, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(502, 186);
            this.dataGridView1.TabIndex = 0;
            // 
            // _nombre_familiar
            // 
            this._nombre_familiar.HeaderText = "Nombre";
            this._nombre_familiar.Name = "_nombre_familiar";
            this._nombre_familiar.Width = 200;
            // 
            // _apellido_familiar
            // 
            this._apellido_familiar.HeaderText = "Apellido";
            this._apellido_familiar.Name = "_apellido_familiar";
            this._apellido_familiar.Width = 200;
            // 
            // _sexo
            // 
            this._sexo.FormattingEnabled = true;
            this._sexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this._sexo.Location = new System.Drawing.Point(306, 208);
            this._sexo.Name = "_sexo";
            this._sexo.Size = new System.Drawing.Size(82, 24);
            this._sexo.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(209, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Tiene hijos o familiares a cargo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Estado Civil";
            // 
            // _estado_civil
            // 
            this._estado_civil.FormattingEnabled = true;
            this._estado_civil.Items.AddRange(new object[] {
            "Soltero/a",
            "Casado/a",
            "Viudo/a",
            "Concubinato",
            "Divorciado/a"});
            this._estado_civil.Location = new System.Drawing.Point(117, 208);
            this._estado_civil.Name = "_estado_civil";
            this._estado_civil.Size = new System.Drawing.Size(132, 24);
            this._estado_civil.TabIndex = 23;
            this._estado_civil.Text = "Seleccione uno";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(261, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Sexo";
            // 
            // _fecha_nacimiento
            // 
            this._fecha_nacimiento.Location = new System.Drawing.Point(117, 180);
            this._fecha_nacimiento.Name = "_fecha_nacimiento";
            this._fecha_nacimiento.Size = new System.Drawing.Size(271, 22);
            this._fecha_nacimiento.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Fecha de Nac.";
            // 
            // _mail
            // 
            this._mail.Location = new System.Drawing.Point(306, 152);
            this._mail.Name = "_mail";
            this._mail.Size = new System.Drawing.Size(217, 22);
            this._mail.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Email";
            // 
            // _telefono
            // 
            this._telefono.Location = new System.Drawing.Point(117, 153);
            this._telefono.Name = "_telefono";
            this._telefono.Size = new System.Drawing.Size(132, 22);
            this._telefono.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Telefono";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // _direccion
            // 
            this._direccion.Location = new System.Drawing.Point(117, 124);
            this._direccion.Name = "_direccion";
            this._direccion.Size = new System.Drawing.Size(406, 22);
            this._direccion.TabIndex = 15;
            this._direccion.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Direccion";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // _cancelar
            // 
            this._cancelar.Location = new System.Drawing.Point(423, 519);
            this._cancelar.Margin = new System.Windows.Forms.Padding(4);
            this._cancelar.Name = "_cancelar";
            this._cancelar.Size = new System.Drawing.Size(100, 28);
            this._cancelar.TabIndex = 13;
            this._cancelar.Text = "Cancelar";
            this._cancelar.UseVisualStyleBackColor = true;
            this._cancelar.Click += new System.EventHandler(this._cancelar_Click);
            // 
            // _aceptar
            // 
            this._aceptar.Location = new System.Drawing.Point(315, 519);
            this._aceptar.Margin = new System.Windows.Forms.Padding(4);
            this._aceptar.Name = "_aceptar";
            this._aceptar.Size = new System.Drawing.Size(100, 28);
            this._aceptar.TabIndex = 12;
            this._aceptar.Text = "Aceptar";
            this._aceptar.UseVisualStyleBackColor = true;
            this._aceptar.Click += new System.EventHandler(this._aceptar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Num. de Doc.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tipo de Doc.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // _numero_documento
            // 
            this._numero_documento.Location = new System.Drawing.Point(359, 94);
            this._numero_documento.Margin = new System.Windows.Forms.Padding(4);
            this._numero_documento.Name = "_numero_documento";
            this._numero_documento.Size = new System.Drawing.Size(164, 22);
            this._numero_documento.TabIndex = 3;
            // 
            // _tipo_documento
            // 
            this._tipo_documento.Location = new System.Drawing.Point(117, 94);
            this._tipo_documento.Margin = new System.Windows.Forms.Padding(4);
            this._tipo_documento.Name = "_tipo_documento";
            this._tipo_documento.Size = new System.Drawing.Size(132, 22);
            this._tipo_documento.TabIndex = 2;
            // 
            // _apellido
            // 
            this._apellido.Location = new System.Drawing.Point(117, 64);
            this._apellido.Margin = new System.Windows.Forms.Padding(4);
            this._apellido.Name = "_apellido";
            this._apellido.Size = new System.Drawing.Size(406, 22);
            this._apellido.TabIndex = 1;
            // 
            // _nombre
            // 
            this._nombre.Location = new System.Drawing.Point(117, 34);
            this._nombre.Margin = new System.Windows.Forms.Padding(4);
            this._nombre.Name = "_nombre";
            this._nombre.Size = new System.Drawing.Size(406, 22);
            this._nombre.TabIndex = 0;
            this._nombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AltaAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 584);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AltaAfiliado";
            this.Text = "AltaAfiliado";
            this.Load += new System.EventHandler(this.AltaAfiliado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button _cancelar;
        private System.Windows.Forms.Button _aceptar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _numero_documento;
        private System.Windows.Forms.TextBox _tipo_documento;
        private System.Windows.Forms.TextBox _apellido;
        private System.Windows.Forms.TextBox _nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _direccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker _fecha_nacimiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _mail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _telefono;
        private System.Windows.Forms.ComboBox _estado_civil;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox _sexo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton _no_familia;
        private System.Windows.Forms.RadioButton _si_familia;
        private System.Windows.Forms.DataGridViewTextBoxColumn _nombre_familiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn _apellido_familiar;
    }
}