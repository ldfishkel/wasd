namespace ClinicaFrba.Menu
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

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
            this._functionsTabControl.Size = new System.Drawing.Size(854, 420);
            this._functionsTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this._functionsTabControl.TabIndex = 0;
            this._functionsTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.TabLabelDrawing);
            this._functionsTabControl.SelectedIndexChanged += new System.EventHandler(this.OnTabSelected);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 442);
            this.Controls.Add(this._functionsTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        private void TabLabelDrawing(Object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            TabPage _tabPage = _functionsTabControl.TabPages[e.Index];
            Rectangle _tabBounds = _functionsTabControl.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {
                _textBrush = new SolidBrush(Color.Red);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            Font _tabFont = new Font("Arial", (float)12.0, FontStyle.Bold, GraphicsUnit.Pixel);

            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        #endregion

        private System.Windows.Forms.TabControl _functionsTabControl;
    }
}