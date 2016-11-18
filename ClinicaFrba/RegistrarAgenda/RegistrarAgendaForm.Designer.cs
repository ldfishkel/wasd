namespace ClinicaFrba.RegistrarAgenda
{
    partial class RegistrarAgendaForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._fechaHasta = new System.Windows.Forms.DateTimePicker();
            this._fechaDesde = new System.Windows.Forms.DateTimePicker();
            this._registrarAgendaBtn = new System.Windows.Forms.Button();
            this._sabadoGroupBox = new System.Windows.Forms.GroupBox();
            this._sabadoCheck = new System.Windows.Forms.CheckBox();
            this._sabadoEspecialidad = new System.Windows.Forms.ComboBox();
            this._sabadoDesde = new System.Windows.Forms.ComboBox();
            this._sabadoHasta = new System.Windows.Forms.ComboBox();
            this._viernesGroupBox = new System.Windows.Forms.GroupBox();
            this._viernesCheck = new System.Windows.Forms.CheckBox();
            this._viernesEspecialidad = new System.Windows.Forms.ComboBox();
            this._viernesDesde = new System.Windows.Forms.ComboBox();
            this._viernesHasta = new System.Windows.Forms.ComboBox();
            this._juevesGroupBox = new System.Windows.Forms.GroupBox();
            this._juevesCheck = new System.Windows.Forms.CheckBox();
            this._juevesEspecialidad = new System.Windows.Forms.ComboBox();
            this._juevesDesde = new System.Windows.Forms.ComboBox();
            this._juevesHasta = new System.Windows.Forms.ComboBox();
            this._miercolesGroupBox = new System.Windows.Forms.GroupBox();
            this._miercolesCheck = new System.Windows.Forms.CheckBox();
            this._miercolesEspecialidad = new System.Windows.Forms.ComboBox();
            this._miercolesDesde = new System.Windows.Forms.ComboBox();
            this._miercolesHasta = new System.Windows.Forms.ComboBox();
            this._martesGroupBox = new System.Windows.Forms.GroupBox();
            this._martesCheck = new System.Windows.Forms.CheckBox();
            this._martesEspecialidad = new System.Windows.Forms.ComboBox();
            this._martesDesde = new System.Windows.Forms.ComboBox();
            this._martesHasta = new System.Windows.Forms.ComboBox();
            this._lunesGroupBox = new System.Windows.Forms.GroupBox();
            this._lunesCheck = new System.Windows.Forms.CheckBox();
            this._lunesEspecialidad = new System.Windows.Forms.ComboBox();
            this._lunesDesde = new System.Windows.Forms.ComboBox();
            this._lunesHasta = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this._agendaActualGroup = new System.Windows.Forms.GroupBox();
            this._panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this._sabadoGroupBox.SuspendLayout();
            this._viernesGroupBox.SuspendLayout();
            this._juevesGroupBox.SuspendLayout();
            this._miercolesGroupBox.SuspendLayout();
            this._martesGroupBox.SuspendLayout();
            this._lunesGroupBox.SuspendLayout();
            this._agendaActualGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panel
            // 
            this._panel.Controls.Add(this._agendaActualGroup);
            this._panel.Controls.Add(this.button1);
            this._panel.Location = new System.Drawing.Point(19, 20);
            this._panel.Name = "_panel";
            this._panel.Size = new System.Drawing.Size(541, 429);
            this._panel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._fechaHasta);
            this.groupBox1.Controls.Add(this._fechaDesde);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 43);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Desde";
            // 
            // _fechaHasta
            // 
            this._fechaHasta.Location = new System.Drawing.Point(313, 17);
            this._fechaHasta.Name = "_fechaHasta";
            this._fechaHasta.Size = new System.Drawing.Size(184, 20);
            this._fechaHasta.TabIndex = 1;
            // 
            // _fechaDesde
            // 
            this._fechaDesde.Location = new System.Drawing.Point(68, 17);
            this._fechaDesde.Name = "_fechaDesde";
            this._fechaDesde.Size = new System.Drawing.Size(180, 20);
            this._fechaDesde.TabIndex = 0;
            // 
            // _registrarAgendaBtn
            // 
            this._registrarAgendaBtn.Location = new System.Drawing.Point(6, 353);
            this._registrarAgendaBtn.Name = "_registrarAgendaBtn";
            this._registrarAgendaBtn.Size = new System.Drawing.Size(504, 23);
            this._registrarAgendaBtn.TabIndex = 12;
            this._registrarAgendaBtn.Text = "Registrar Agenda Profesional";
            this._registrarAgendaBtn.UseVisualStyleBackColor = true;
            this._registrarAgendaBtn.Click += new System.EventHandler(this.RegistrarAgendaBtnClick);
            // 
            // _sabadoGroupBox
            // 
            this._sabadoGroupBox.Controls.Add(this._sabadoCheck);
            this._sabadoGroupBox.Controls.Add(this._sabadoEspecialidad);
            this._sabadoGroupBox.Controls.Add(this._sabadoDesde);
            this._sabadoGroupBox.Controls.Add(this._sabadoHasta);
            this._sabadoGroupBox.Location = new System.Drawing.Point(6, 303);
            this._sabadoGroupBox.Name = "_sabadoGroupBox";
            this._sabadoGroupBox.Size = new System.Drawing.Size(504, 43);
            this._sabadoGroupBox.TabIndex = 11;
            this._sabadoGroupBox.TabStop = false;
            // 
            // _sabadoCheck
            // 
            this._sabadoCheck.AutoSize = true;
            this._sabadoCheck.Location = new System.Drawing.Point(17, 19);
            this._sabadoCheck.Name = "_sabadoCheck";
            this._sabadoCheck.Size = new System.Drawing.Size(63, 17);
            this._sabadoCheck.TabIndex = 0;
            this._sabadoCheck.Text = "Sabado";
            this._sabadoCheck.UseVisualStyleBackColor = true;
            // 
            // _sabadoEspecialidad
            // 
            this._sabadoEspecialidad.FormattingEnabled = true;
            this._sabadoEspecialidad.Location = new System.Drawing.Point(377, 17);
            this._sabadoEspecialidad.Name = "_sabadoEspecialidad";
            this._sabadoEspecialidad.Size = new System.Drawing.Size(121, 21);
            this._sabadoEspecialidad.TabIndex = 8;
            this._sabadoEspecialidad.Text = "Especialidad";
            // 
            // _sabadoDesde
            // 
            this._sabadoDesde.FormattingEnabled = true;
            this._sabadoDesde.Location = new System.Drawing.Point(103, 16);
            this._sabadoDesde.Name = "_sabadoDesde";
            this._sabadoDesde.Size = new System.Drawing.Size(121, 21);
            this._sabadoDesde.TabIndex = 6;
            this._sabadoDesde.Text = "Hora Desde";
            // 
            // _sabadoHasta
            // 
            this._sabadoHasta.FormattingEnabled = true;
            this._sabadoHasta.Location = new System.Drawing.Point(242, 17);
            this._sabadoHasta.Name = "_sabadoHasta";
            this._sabadoHasta.Size = new System.Drawing.Size(121, 21);
            this._sabadoHasta.TabIndex = 7;
            this._sabadoHasta.Text = "Hora Hasta";
            // 
            // _viernesGroupBox
            // 
            this._viernesGroupBox.Controls.Add(this._viernesCheck);
            this._viernesGroupBox.Controls.Add(this._viernesEspecialidad);
            this._viernesGroupBox.Controls.Add(this._viernesDesde);
            this._viernesGroupBox.Controls.Add(this._viernesHasta);
            this._viernesGroupBox.Location = new System.Drawing.Point(6, 254);
            this._viernesGroupBox.Name = "_viernesGroupBox";
            this._viernesGroupBox.Size = new System.Drawing.Size(504, 43);
            this._viernesGroupBox.TabIndex = 11;
            this._viernesGroupBox.TabStop = false;
            // 
            // _viernesCheck
            // 
            this._viernesCheck.AutoSize = true;
            this._viernesCheck.Location = new System.Drawing.Point(17, 19);
            this._viernesCheck.Name = "_viernesCheck";
            this._viernesCheck.Size = new System.Drawing.Size(61, 17);
            this._viernesCheck.TabIndex = 0;
            this._viernesCheck.Text = "Viernes";
            this._viernesCheck.UseVisualStyleBackColor = true;
            // 
            // _viernesEspecialidad
            // 
            this._viernesEspecialidad.FormattingEnabled = true;
            this._viernesEspecialidad.Location = new System.Drawing.Point(377, 17);
            this._viernesEspecialidad.Name = "_viernesEspecialidad";
            this._viernesEspecialidad.Size = new System.Drawing.Size(121, 21);
            this._viernesEspecialidad.TabIndex = 8;
            this._viernesEspecialidad.Text = "Especialidad";
            // 
            // _viernesDesde
            // 
            this._viernesDesde.FormattingEnabled = true;
            this._viernesDesde.Location = new System.Drawing.Point(103, 16);
            this._viernesDesde.Name = "_viernesDesde";
            this._viernesDesde.Size = new System.Drawing.Size(121, 21);
            this._viernesDesde.TabIndex = 6;
            this._viernesDesde.Text = "Hora Desde";
            // 
            // _viernesHasta
            // 
            this._viernesHasta.FormattingEnabled = true;
            this._viernesHasta.Location = new System.Drawing.Point(242, 17);
            this._viernesHasta.Name = "_viernesHasta";
            this._viernesHasta.Size = new System.Drawing.Size(121, 21);
            this._viernesHasta.TabIndex = 7;
            this._viernesHasta.Text = "Hora Hasta";
            // 
            // _juevesGroupBox
            // 
            this._juevesGroupBox.Controls.Add(this._juevesCheck);
            this._juevesGroupBox.Controls.Add(this._juevesEspecialidad);
            this._juevesGroupBox.Controls.Add(this._juevesDesde);
            this._juevesGroupBox.Controls.Add(this._juevesHasta);
            this._juevesGroupBox.Location = new System.Drawing.Point(6, 205);
            this._juevesGroupBox.Name = "_juevesGroupBox";
            this._juevesGroupBox.Size = new System.Drawing.Size(504, 43);
            this._juevesGroupBox.TabIndex = 11;
            this._juevesGroupBox.TabStop = false;
            // 
            // _juevesCheck
            // 
            this._juevesCheck.AutoSize = true;
            this._juevesCheck.Location = new System.Drawing.Point(17, 19);
            this._juevesCheck.Name = "_juevesCheck";
            this._juevesCheck.Size = new System.Drawing.Size(60, 17);
            this._juevesCheck.TabIndex = 0;
            this._juevesCheck.Text = "Jueves";
            this._juevesCheck.UseVisualStyleBackColor = true;
            // 
            // _juevesEspecialidad
            // 
            this._juevesEspecialidad.FormattingEnabled = true;
            this._juevesEspecialidad.Location = new System.Drawing.Point(377, 17);
            this._juevesEspecialidad.Name = "_juevesEspecialidad";
            this._juevesEspecialidad.Size = new System.Drawing.Size(121, 21);
            this._juevesEspecialidad.TabIndex = 8;
            this._juevesEspecialidad.Text = "Especialidad";
            // 
            // _juevesDesde
            // 
            this._juevesDesde.FormattingEnabled = true;
            this._juevesDesde.Location = new System.Drawing.Point(103, 16);
            this._juevesDesde.Name = "_juevesDesde";
            this._juevesDesde.Size = new System.Drawing.Size(121, 21);
            this._juevesDesde.TabIndex = 6;
            this._juevesDesde.Text = "Hora Desde";
            // 
            // _juevesHasta
            // 
            this._juevesHasta.FormattingEnabled = true;
            this._juevesHasta.Location = new System.Drawing.Point(242, 17);
            this._juevesHasta.Name = "_juevesHasta";
            this._juevesHasta.Size = new System.Drawing.Size(121, 21);
            this._juevesHasta.TabIndex = 7;
            this._juevesHasta.Text = "Hora Hasta";
            // 
            // _miercolesGroupBox
            // 
            this._miercolesGroupBox.Controls.Add(this._miercolesCheck);
            this._miercolesGroupBox.Controls.Add(this._miercolesEspecialidad);
            this._miercolesGroupBox.Controls.Add(this._miercolesDesde);
            this._miercolesGroupBox.Controls.Add(this._miercolesHasta);
            this._miercolesGroupBox.Location = new System.Drawing.Point(6, 156);
            this._miercolesGroupBox.Name = "_miercolesGroupBox";
            this._miercolesGroupBox.Size = new System.Drawing.Size(504, 43);
            this._miercolesGroupBox.TabIndex = 11;
            this._miercolesGroupBox.TabStop = false;
            // 
            // _miercolesCheck
            // 
            this._miercolesCheck.AutoSize = true;
            this._miercolesCheck.Location = new System.Drawing.Point(17, 19);
            this._miercolesCheck.Name = "_miercolesCheck";
            this._miercolesCheck.Size = new System.Drawing.Size(71, 17);
            this._miercolesCheck.TabIndex = 0;
            this._miercolesCheck.Text = "Miercoles";
            this._miercolesCheck.UseVisualStyleBackColor = true;
            // 
            // _miercolesEspecialidad
            // 
            this._miercolesEspecialidad.FormattingEnabled = true;
            this._miercolesEspecialidad.Location = new System.Drawing.Point(377, 17);
            this._miercolesEspecialidad.Name = "_miercolesEspecialidad";
            this._miercolesEspecialidad.Size = new System.Drawing.Size(121, 21);
            this._miercolesEspecialidad.TabIndex = 8;
            this._miercolesEspecialidad.Text = "Especialidad";
            // 
            // _miercolesDesde
            // 
            this._miercolesDesde.FormattingEnabled = true;
            this._miercolesDesde.Location = new System.Drawing.Point(103, 16);
            this._miercolesDesde.Name = "_miercolesDesde";
            this._miercolesDesde.Size = new System.Drawing.Size(121, 21);
            this._miercolesDesde.TabIndex = 6;
            this._miercolesDesde.Text = "HoraDesde";
            // 
            // _miercolesHasta
            // 
            this._miercolesHasta.FormattingEnabled = true;
            this._miercolesHasta.Location = new System.Drawing.Point(242, 17);
            this._miercolesHasta.Name = "_miercolesHasta";
            this._miercolesHasta.Size = new System.Drawing.Size(121, 21);
            this._miercolesHasta.TabIndex = 7;
            this._miercolesHasta.Text = "Hora Hasta";
            // 
            // _martesGroupBox
            // 
            this._martesGroupBox.Controls.Add(this._martesCheck);
            this._martesGroupBox.Controls.Add(this._martesEspecialidad);
            this._martesGroupBox.Controls.Add(this._martesDesde);
            this._martesGroupBox.Controls.Add(this._martesHasta);
            this._martesGroupBox.Location = new System.Drawing.Point(6, 107);
            this._martesGroupBox.Name = "_martesGroupBox";
            this._martesGroupBox.Size = new System.Drawing.Size(504, 43);
            this._martesGroupBox.TabIndex = 10;
            this._martesGroupBox.TabStop = false;
            // 
            // _martesCheck
            // 
            this._martesCheck.AutoSize = true;
            this._martesCheck.Location = new System.Drawing.Point(17, 19);
            this._martesCheck.Name = "_martesCheck";
            this._martesCheck.Size = new System.Drawing.Size(58, 17);
            this._martesCheck.TabIndex = 0;
            this._martesCheck.Text = "Martes";
            this._martesCheck.UseVisualStyleBackColor = true;
            // 
            // _martesEspecialidad
            // 
            this._martesEspecialidad.FormattingEnabled = true;
            this._martesEspecialidad.Location = new System.Drawing.Point(377, 17);
            this._martesEspecialidad.Name = "_martesEspecialidad";
            this._martesEspecialidad.Size = new System.Drawing.Size(121, 21);
            this._martesEspecialidad.TabIndex = 8;
            this._martesEspecialidad.Text = "Especialidad";
            // 
            // _martesDesde
            // 
            this._martesDesde.FormattingEnabled = true;
            this._martesDesde.Location = new System.Drawing.Point(103, 16);
            this._martesDesde.Name = "_martesDesde";
            this._martesDesde.Size = new System.Drawing.Size(121, 21);
            this._martesDesde.TabIndex = 6;
            this._martesDesde.Text = "Hora Desde";
            // 
            // _martesHasta
            // 
            this._martesHasta.FormattingEnabled = true;
            this._martesHasta.Location = new System.Drawing.Point(242, 17);
            this._martesHasta.Name = "_martesHasta";
            this._martesHasta.Size = new System.Drawing.Size(121, 21);
            this._martesHasta.TabIndex = 7;
            this._martesHasta.Text = "Hora Hasta";
            // 
            // _lunesGroupBox
            // 
            this._lunesGroupBox.Controls.Add(this._lunesCheck);
            this._lunesGroupBox.Controls.Add(this._lunesEspecialidad);
            this._lunesGroupBox.Controls.Add(this._lunesDesde);
            this._lunesGroupBox.Controls.Add(this._lunesHasta);
            this._lunesGroupBox.Location = new System.Drawing.Point(6, 58);
            this._lunesGroupBox.Name = "_lunesGroupBox";
            this._lunesGroupBox.Size = new System.Drawing.Size(504, 43);
            this._lunesGroupBox.TabIndex = 9;
            this._lunesGroupBox.TabStop = false;
            // 
            // _lunesCheck
            // 
            this._lunesCheck.AutoSize = true;
            this._lunesCheck.Location = new System.Drawing.Point(17, 19);
            this._lunesCheck.Name = "_lunesCheck";
            this._lunesCheck.Size = new System.Drawing.Size(55, 17);
            this._lunesCheck.TabIndex = 0;
            this._lunesCheck.Text = "Lunes";
            this._lunesCheck.UseVisualStyleBackColor = true;
            // 
            // _lunesEspecialidad
            // 
            this._lunesEspecialidad.FormattingEnabled = true;
            this._lunesEspecialidad.Location = new System.Drawing.Point(377, 17);
            this._lunesEspecialidad.Name = "_lunesEspecialidad";
            this._lunesEspecialidad.Size = new System.Drawing.Size(121, 21);
            this._lunesEspecialidad.TabIndex = 8;
            this._lunesEspecialidad.Text = "Especialidad";
            // 
            // _lunesDesde
            // 
            this._lunesDesde.FormattingEnabled = true;
            this._lunesDesde.Location = new System.Drawing.Point(103, 16);
            this._lunesDesde.Name = "_lunesDesde";
            this._lunesDesde.Size = new System.Drawing.Size(121, 21);
            this._lunesDesde.TabIndex = 6;
            this._lunesDesde.Text = "Hora Desde";
            // 
            // _lunesHasta
            // 
            this._lunesHasta.FormattingEnabled = true;
            this._lunesHasta.Location = new System.Drawing.Point(242, 17);
            this._lunesHasta.Name = "_lunesHasta";
            this._lunesHasta.Size = new System.Drawing.Size(121, 21);
            this._lunesHasta.TabIndex = 7;
            this._lunesHasta.Text = "Hora Hasta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(521, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ver Agendas Anteriores";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _agendaActualGroup
            // 
            this._agendaActualGroup.Controls.Add(this.groupBox1);
            this._agendaActualGroup.Controls.Add(this._registrarAgendaBtn);
            this._agendaActualGroup.Controls.Add(this._sabadoGroupBox);
            this._agendaActualGroup.Controls.Add(this._viernesGroupBox);
            this._agendaActualGroup.Controls.Add(this._lunesGroupBox);
            this._agendaActualGroup.Controls.Add(this._juevesGroupBox);
            this._agendaActualGroup.Controls.Add(this._martesGroupBox);
            this._agendaActualGroup.Controls.Add(this._miercolesGroupBox);
            this._agendaActualGroup.Location = new System.Drawing.Point(11, 4);
            this._agendaActualGroup.Name = "_agendaActualGroup";
            this._agendaActualGroup.Size = new System.Drawing.Size(520, 385);
            this._agendaActualGroup.TabIndex = 14;
            this._agendaActualGroup.TabStop = false;
            // 
            // RegistrarAgendaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 464);
            this.Controls.Add(this._panel);
            this.Name = "RegistrarAgendaForm";
            this.Text = "Form1";
            this._panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this._sabadoGroupBox.ResumeLayout(false);
            this._sabadoGroupBox.PerformLayout();
            this._viernesGroupBox.ResumeLayout(false);
            this._viernesGroupBox.PerformLayout();
            this._juevesGroupBox.ResumeLayout(false);
            this._juevesGroupBox.PerformLayout();
            this._miercolesGroupBox.ResumeLayout(false);
            this._miercolesGroupBox.PerformLayout();
            this._martesGroupBox.ResumeLayout(false);
            this._martesGroupBox.PerformLayout();
            this._lunesGroupBox.ResumeLayout(false);
            this._lunesGroupBox.PerformLayout();
            this._agendaActualGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panel;
        private System.Windows.Forms.GroupBox _sabadoGroupBox;
        private System.Windows.Forms.CheckBox _sabadoCheck;
        private System.Windows.Forms.ComboBox _sabadoEspecialidad;
        private System.Windows.Forms.ComboBox _sabadoDesde;
        private System.Windows.Forms.ComboBox _sabadoHasta;
        private System.Windows.Forms.GroupBox _viernesGroupBox;
        private System.Windows.Forms.CheckBox _viernesCheck;
        private System.Windows.Forms.ComboBox _viernesEspecialidad;
        private System.Windows.Forms.ComboBox _viernesDesde;
        private System.Windows.Forms.ComboBox _viernesHasta;
        private System.Windows.Forms.GroupBox _juevesGroupBox;
        private System.Windows.Forms.CheckBox _juevesCheck;
        private System.Windows.Forms.ComboBox _juevesEspecialidad;
        private System.Windows.Forms.ComboBox _juevesDesde;
        private System.Windows.Forms.ComboBox _juevesHasta;
        private System.Windows.Forms.GroupBox _miercolesGroupBox;
        private System.Windows.Forms.CheckBox _miercolesCheck;
        private System.Windows.Forms.ComboBox _miercolesEspecialidad;
        private System.Windows.Forms.ComboBox _miercolesDesde;
        private System.Windows.Forms.ComboBox _miercolesHasta;
        private System.Windows.Forms.GroupBox _martesGroupBox;
        private System.Windows.Forms.CheckBox _martesCheck;
        private System.Windows.Forms.ComboBox _martesEspecialidad;
        private System.Windows.Forms.ComboBox _martesDesde;
        private System.Windows.Forms.ComboBox _martesHasta;
        private System.Windows.Forms.GroupBox _lunesGroupBox;
        private System.Windows.Forms.CheckBox _lunesCheck;
        private System.Windows.Forms.ComboBox _lunesEspecialidad;
        private System.Windows.Forms.ComboBox _lunesDesde;
        private System.Windows.Forms.ComboBox _lunesHasta;
        private System.Windows.Forms.Button _registrarAgendaBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker _fechaHasta;
        private System.Windows.Forms.DateTimePicker _fechaDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox _agendaActualGroup;
    }
}