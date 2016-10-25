namespace ClinicaFrba.Menu
{
    using AbmAfiliado;
    using AbmRol;
    using CancelarTurno;
    using CompraBono;
    using DataAccess;
    using DataAccess.DAO;
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
        #region [FIELDS]

        //Size constants
        private const int MENU_WIDTH = 180;
        private const int MARGIN_RIGHT = 28;
        private const int MARGIN_BOTTOM = 40;
        private const int MARGIN_BOTTOM_BOTTOM = 57;
        private const int MENU_MARGIN_RIGHT = 8;

        //Auth user
        private int _userId;
        private Rol _rol;

        //forms
        private readonly ABMRolForm _abmRolForm;
        private readonly ABMAfiliadosForm _abmAfiliadosForm;
        private readonly RegistrarAgendaForm _registrarAgendaForm;
        private readonly ComprarBonoForm _comprarBonoForm;
        private readonly PedirTurnoForm _pedirTurnoForm;
        private readonly CancelarTurnoForm _cancelarTurnoForm;
        private readonly RegistrarLlegadaForm _registrarLlegadaForm;
        private readonly DiagnosticarForm _diagnosticarForm;
        private readonly VerEstadisticasForm _verEstadisticasForm;

        #endregion

        #region [INIT]

        public MenuForm(ABMRolForm abmRolForm,
                        ABMAfiliadosForm abmAfiliadosForm,
                        RegistrarAgendaForm registrarAgendaForm,
                        ComprarBonoForm comprarBonoForm,
                        PedirTurnoForm pedirTurnoForm,
                        CancelarTurnoForm cancelarTurnoForm,
                        RegistrarLlegadaForm registrarLlegadaForm,
                        DiagnosticarForm diagnosticarForm,
                        VerEstadisticasForm verEstadisticasForm,
                        RolDao rolDao)
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

        public void Init(int userId, Rol rol, Action<object, FormClosingEventArgs> close)
        {
            _userId = userId;
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

        #endregion

        #region [PROVIDERS]

        public int UserId()
        {
            return _userId;
        }

        public Rol Rol()
        {
            return _rol;
        }

        #endregion

        #region [ACTIONS]

        public void FixBounds(Control content)
        {
            Width = content.Width + MENU_WIDTH + MENU_MARGIN_RIGHT;
            Height = content.Height + MARGIN_BOTTOM + MARGIN_BOTTOM_BOTTOM;

            _functionsTabControl.Width = content.Width + MENU_WIDTH - MARGIN_RIGHT;
            _functionsTabControl.Height = content.Height + MARGIN_BOTTOM;

            content.BackColor = Color.WhiteSmoke;
        }

        private void OnTabSelected(object sender, EventArgs e)
        {
            var tab = _functionsTabControl.SelectedTab;

            tab.Controls.Clear();
            tab.BackColor = Color.Gray;

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

        #endregion
    }
}
