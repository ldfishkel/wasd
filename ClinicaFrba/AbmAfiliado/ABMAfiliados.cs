namespace ClinicaFrba.AbmAfiliado
{
    using System;
    using System.Windows.Forms;

    public partial class ABMAfiliadosForm : Form
    {
        public ABMAfiliadosForm(Form parent)
        {
            InitializeComponent();

            parent.Text = "ABM Afiliados";
        }

        public Panel GetTabContent()
        {
            return _panel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "QWEQWEQWQWEQWEQWQWEQW";
           
        }
    }
}
