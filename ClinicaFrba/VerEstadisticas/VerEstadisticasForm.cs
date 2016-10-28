namespace ClinicaFrba.VerEstadisticas
{
    using DataAccess.DAO;
    using Menu;
    using System;
    using System.Text;
    using System.Windows.Forms;

    public partial class VerEstadisticasForm : Form
    {
        private EstadisticasDao _estadisticasDao;

        public VerEstadisticasForm(EstadisticasDao estadisticasDao)
        {
            _estadisticasDao = estadisticasDao;
        }

        public Panel Init(MenuForm parent)
        {
            InitializeComponent();

            parent.Text = "Estadisticas";
            parent.FixBounds(_panel);

            return _panel;
        }

        private void VerEstadisticasClick(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            _grid1.Rows.Clear();

            foreach (var result in _estadisticasDao.Consulta1(_fechaDesde.Value, _fechaHasta.Value))
                _grid1.Rows.Add(result.especialidad,
                                       result.cancelaciones,
                                       result.mes);

            _grid4.Rows.Clear();

            foreach (var result in _estadisticasDao.Consulta4(_fechaDesde.Value, _fechaHasta.Value))
                _grid4.Rows.Add(result.afiliado_numero,
                                       result.afiliado_apellido,
                                       result.afiliado_nombre,
                                       result.cantidad,
                                       result.pertenece_a_grupo,
                                       result.mes);

            _grid5.Rows.Clear();

            foreach (var result in _estadisticasDao.Consulta5(_fechaDesde.Value, _fechaHasta.Value))
                _grid1.Rows.Add(result.especialidad_nombre,
                                       result.cantidad,
                                       result.mes);
        }

        private bool ValidateFields()
        {
            StringBuilder sb = new StringBuilder();

            if (_fechaDesde.Value.CompareTo(_fechaHasta.Value) >= 0)
                sb.AppendLine("Fecha hasta debe ser posterior a fecha desde");

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString());
                return false;
            }

            return true;
        }
    }
}
