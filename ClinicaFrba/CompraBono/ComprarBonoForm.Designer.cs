namespace ClinicaFrba.CompraBono
{
    partial class ComprarBonoForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._planLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._nombreYApellidoLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._nroAfliladoLbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._nroDocumento = new System.Windows.Forms.TextBox();
            this._tipoDeDoc = new System.Windows.Forms.ComboBox();
            this._compraGroupBox = new System.Windows.Forms.GroupBox();
            this._precio = new System.Windows.Forms.Label();
            this._comprarBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this._cantidadBonos = new System.Windows.Forms.NumericUpDown();
            this.cantidadLabel = new System.Windows.Forms.Label();
            this._panel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this._compraGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cantidadBonos)).BeginInit();
            this.SuspendLayout();
            // 
            // _panel
            // 
            this._panel.Controls.Add(this.groupBox2);
            this._panel.Controls.Add(this._compraGroupBox);
            this._panel.Location = new System.Drawing.Point(13, 12);
            this._panel.Name = "_panel";
            this._panel.Size = new System.Drawing.Size(491, 205);
            this._panel.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this._nroDocumento);
            this.groupBox2.Controls.Add(this._tipoDeDoc);
            this.groupBox2.Location = new System.Drawing.Point(13, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 131);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._planLbl);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this._nombreYApellidoLbl);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this._nroAfliladoLbl);
            this.groupBox3.Location = new System.Drawing.Point(6, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(445, 56);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // _planLbl
            // 
            this._planLbl.AutoSize = true;
            this._planLbl.Location = new System.Drawing.Point(91, 32);
            this._planLbl.Name = "_planLbl";
            this._planLbl.Size = new System.Drawing.Size(0, 13);
            this._planLbl.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Plan";
            // 
            // _nombreYApellidoLbl
            // 
            this._nombreYApellidoLbl.AutoSize = true;
            this._nombreYApellidoLbl.Location = new System.Drawing.Point(285, 12);
            this._nombreYApellidoLbl.Name = "_nombreYApellidoLbl";
            this._nombreYApellidoLbl.Size = new System.Drawing.Size(0, 13);
            this._nombreYApellidoLbl.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre y Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nro de Afiliado";
            // 
            // _nroAfliladoLbl
            // 
            this._nroAfliladoLbl.AutoSize = true;
            this._nroAfliladoLbl.Location = new System.Drawing.Point(88, 12);
            this._nroAfliladoLbl.Name = "_nroAfliladoLbl";
            this._nroAfliladoLbl.Size = new System.Drawing.Size(0, 13);
            this._nroAfliladoLbl.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(339, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BuscarAfiliadoClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero de documento";
            // 
            // _nroDocumento
            // 
            this._nroDocumento.Location = new System.Drawing.Point(141, 48);
            this._nroDocumento.Name = "_nroDocumento";
            this._nroDocumento.Size = new System.Drawing.Size(128, 20);
            this._nroDocumento.TabIndex = 1;
            // 
            // _tipoDeDoc
            // 
            this._tipoDeDoc.FormattingEnabled = true;
            this._tipoDeDoc.Items.AddRange(new object[] {
            "DNI"});
            this._tipoDeDoc.Location = new System.Drawing.Point(19, 20);
            this._tipoDeDoc.Name = "_tipoDeDoc";
            this._tipoDeDoc.Size = new System.Drawing.Size(116, 21);
            this._tipoDeDoc.TabIndex = 0;
            this._tipoDeDoc.Text = "Tipo de documento";
            // 
            // _compraGroupBox
            // 
            this._compraGroupBox.Controls.Add(this._precio);
            this._compraGroupBox.Controls.Add(this._comprarBtn);
            this._compraGroupBox.Controls.Add(this.label2);
            this._compraGroupBox.Controls.Add(this._cantidadBonos);
            this._compraGroupBox.Controls.Add(this.cantidadLabel);
            this._compraGroupBox.Enabled = false;
            this._compraGroupBox.Location = new System.Drawing.Point(13, 147);
            this._compraGroupBox.Name = "_compraGroupBox";
            this._compraGroupBox.Size = new System.Drawing.Size(464, 49);
            this._compraGroupBox.TabIndex = 0;
            this._compraGroupBox.TabStop = false;
            // 
            // _precio
            // 
            this._precio.AutoSize = true;
            this._precio.Location = new System.Drawing.Point(227, 22);
            this._precio.Name = "_precio";
            this._precio.Size = new System.Drawing.Size(13, 13);
            this._precio.TabIndex = 1;
            this._precio.Text = "0";
            // 
            // _comprarBtn
            // 
            this._comprarBtn.Enabled = false;
            this._comprarBtn.Location = new System.Drawing.Point(339, 13);
            this._comprarBtn.Name = "_comprarBtn";
            this._comprarBtn.Size = new System.Drawing.Size(104, 28);
            this._comprarBtn.TabIndex = 3;
            this._comprarBtn.Text = "Comprar";
            this._comprarBtn.UseVisualStyleBackColor = true;
            this._comprarBtn.Click += new System.EventHandler(this.ComprarClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Precio $";
            // 
            // _cantidadBonos
            // 
            this._cantidadBonos.Location = new System.Drawing.Point(118, 18);
            this._cantidadBonos.Name = "_cantidadBonos";
            this._cantidadBonos.Size = new System.Drawing.Size(33, 20);
            this._cantidadBonos.TabIndex = 2;
            this._cantidadBonos.ValueChanged += new System.EventHandler(this.CantidadBonosChanged);
            // 
            // cantidadLabel
            // 
            this.cantidadLabel.AutoSize = true;
            this.cantidadLabel.Location = new System.Drawing.Point(16, 21);
            this.cantidadLabel.Name = "cantidadLabel";
            this.cantidadLabel.Size = new System.Drawing.Size(96, 13);
            this.cantidadLabel.TabIndex = 0;
            this.cantidadLabel.Text = "Cantidad de bonos";
            // 
            // ComprarBonoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 228);
            this.Controls.Add(this._panel);
            this.Name = "ComprarBonoForm";
            this.Text = "Compra de Bonos";
            this._panel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this._compraGroupBox.ResumeLayout(false);
            this._compraGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cantidadBonos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panel;
        private System.Windows.Forms.GroupBox _compraGroupBox;
        private System.Windows.Forms.Button _comprarBtn;
        private System.Windows.Forms.NumericUpDown _cantidadBonos;
        private System.Windows.Forms.Label cantidadLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox _tipoDeDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _nroDocumento;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label _precio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label _planLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label _nombreYApellidoLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label _nroAfliladoLbl;
    }
}