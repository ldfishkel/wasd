namespace ClinicaFrba.Menu
{
    using AbmAfiliado;
    using AbmRol;
    using CancelarTurno;
    using CompraBono;
    using DataAccess;
    using Diagnosticar;
    using PedirTurno;
    using RegistrarAgenda;
    using RegistrarLlegada;
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using VerEstadisticas;

    public partial class MenuForm : Form
    {
        private Form _mainForm;
        private Usuario _user;
        private Rol _rol;

        public MenuForm(Usuario usuario, Rol rol, Form parent)
        {
            _mainForm = parent;
            _user = usuario;
            _rol = rol;

            InitializeComponent();
            InitializeTabs();
        }

        public Usuario User()
        {
            return _user;
        }

        public Rol Rol()
        {
            return _rol;
        }

        private void InitializeTabs()
        {
            foreach (Funcionalidad funcionalidad in _rol.Funcionalidads)
            {
                var tab = new TabPage();
                tab.Name = tab.Text = funcionalidad.funcionalidad_nombre;
                tab.Padding = new Padding(3);
                tab.Size = new Size(192, 74);
                tab.UseVisualStyleBackColor = true;
                this._functionsTabControl.Controls.Add(tab);
            }

            OnTabSelected(null, null);
        }

        private void OnTabSelected(object sender, EventArgs e)
        {
            var tab = _functionsTabControl.SelectedTab;
            switch (tab.Name)
            {
                case "ABM Roles": tab.Controls.Add(new ABMRolForm(this).GetTabContent()); break;
                case "ABM Afiliados": tab.Controls.Add(new ABMAfiliadosForm(this).GetTabContent()); break;
                case "Registrar Agenda": tab.Controls.Add(new RegistrarAgendaForm(this).GetTabContent()); break;
                case "Comprar Bonos": tab.Controls.Add(new ComprarBonoForm(this).GetTabContent()); break;
                case "Pedir Turno": tab.Controls.Add(new PedirTurnoForm(this).GetTabContent()); break;
                case "Cancelar Turno": tab.Controls.Add(new CancelarTurnoForm(this).GetTabContent()); break;
                case "Registrar Llegada": tab.Controls.Add(new RegistrarLlegadaForm(this).GetTabContent()); break;
                case "Diagnosticar": tab.Controls.Add(new DiagnosticarForm(this).GetTabContent()); break;
                case "Ver Estadisticas": tab.Controls.Add(new VerEstadisticasForm(this).GetTabContent()); break;
                default: break;
            }
        }

        private void MenuFormOnClose(object sender, EventArgs e)
        {
            _mainForm.Close();
        }

        private void TabLabelDrawing(Object sender, System.Windows.Forms.DrawItemEventArgs e)
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
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            Font _tabFont = new Font("Arial", (float)12.0, FontStyle.Bold, GraphicsUnit.Pixel);

            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }
    }
}
