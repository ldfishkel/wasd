namespace ClinicaFrba.Menu
{
    partial class MenuForm
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
            this.MaximizeBox = false;
            this._functionsTabControl = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // _functionsTabControl
            // 
            this._functionsTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this._functionsTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this._functionsTabControl.ItemSize = new System.Drawing.Size(30, 120);
            this._functionsTabControl.Location = new System.Drawing.Point(12, 12);
            this._functionsTabControl.Multiline = true;
            this._functionsTabControl.Name = "_functionsTabControl";
            this._functionsTabControl.SelectedIndex = 0;
            this._functionsTabControl.Size = new System.Drawing.Size(636, 420);
            this._functionsTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this._functionsTabControl.TabIndex = 0;
            this._functionsTabControl.SelectedIndexChanged += new System.EventHandler(this.OnTabSelected);
            this._functionsTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(TabLabelDrawing);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 442);
            this.Controls.Add(this._functionsTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuFormOnClose);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl _functionsTabControl;
    }
}