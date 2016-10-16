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
        private const int MENU_WIDTH = 180;

        private Usuario _user;
        private Rol _rol;

        //forms
        private ABMRolForm _abmRolForm;
        private ABMAfiliadosForm _abmAfiliadosForm;
        private RegistrarAgendaForm _registrarAgendaForm;
        private ComprarBonoForm _comprarBonoForm;
        private PedirTurnoForm _pedirTurnoForm;
        private CancelarTurnoForm _cancelarTurnoForm;
        private RegistrarLlegadaForm _registrarLlegadaForm;
        private DiagnosticarForm _diagnosticarForm;
        private VerEstadisticasForm _verEstadisticasForm;

        public MenuForm(ABMRolForm abmRolForm,
                        ABMAfiliadosForm abmAfiliadosForm,
                        RegistrarAgendaForm registrarAgendaForm,
                        ComprarBonoForm comprarBonoForm,
                        PedirTurnoForm pedirTurnoForm,
                        CancelarTurnoForm cancelarTurnoForm,
                        RegistrarLlegadaForm registrarLlegadaForm,
                        DiagnosticarForm diagnosticarForm,
                        VerEstadisticasForm verEstadisticasForm
            )
        {
            _abmRolForm = abmRolForm;
            _abmAfiliadosForm = abmAfiliadosForm;
            _registrarAgendaForm = registrarAgendaForm;
            _comprarBonoForm = comprarBonoForm;
            _pedirTurnoForm = pedirTurnoForm;
            _cancelarTurnoForm = cancelarTurnoForm;
            _registrarLlegadaForm = registrarLlegadaForm;
            _diagnosticarForm = diagnosticarForm;
            _verEstadisticasForm = verEstadisticasForm;
        }

        public Usuario User()
        {
            return _user;
        }

        public Rol Rol()
        {
            return _rol;
        }

        public void FixWidth(Control content)
        {
            Width = content.Width + MENU_WIDTH;
        }

        public void Init(Usuario user, Rol rol, Action<object, FormClosingEventArgs> close)
        {
            _user = user;
            _rol = rol;

            InitializeComponent();

            this.FormClosing += new FormClosingEventHandler(close);

            InitializeTabs();
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
                case "ABM Roles": tab.Controls.Add(_abmRolForm.Init(this)); break;
                case "ABM Afiliados": tab.Controls.Add(_abmAfiliadosForm.Init(this)); break;
                case "Registrar Agenda": tab.Controls.Add(_registrarAgendaForm.Init(this)); break;
                case "Comprar Bonos": tab.Controls.Add(_comprarBonoForm.Init(this)); break;
                case "Pedir Turno": tab.Controls.Add(_pedirTurnoForm.Init(this)); break;
                case "Cancelar Turno": tab.Controls.Add(_cancelarTurnoForm.Init(this)); break;
                case "Registrar Llegada": tab.Controls.Add(_registrarLlegadaForm.Init(this)); break;
                case "Diagnosticar": tab.Controls.Add(_diagnosticarForm.Init(this)); break;
                case "Ver Estadisticas": tab.Controls.Add(_verEstadisticasForm.Init(this)); break;
                default: break;
            }
        }
    }
}
