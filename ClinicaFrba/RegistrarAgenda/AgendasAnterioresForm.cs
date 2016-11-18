using ClinicaFrba.DataAccess;
using ClinicaFrba.DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.RegistrarAgenda
{
    public partial class AgendasAnterioresForm : Form
    {
        private ProfesionalDao _profesionalDao;
     
        public AgendasAnterioresForm(List<Agendum> agendaAnterior, ProfesionalDao profesionalDao)
        {
            InitializeComponent();
            _profesionalDao = profesionalDao;
            LoadGrid(agendaAnterior);
        }

        private void LoadGrid(List<Agendum> agendaAnterior)
        {
            _agendaAnteriorGrid.Rows.Clear();

            foreach (Agendum agenda in agendaAnterior)
                _agendaAnteriorGrid.Rows.Add(agenda.agenda_dia, Utils.FormatDate(agenda.agenda_fecha_desde), Utils.FormatDate(agenda.agenda_fecha_hasta),
                    _profesionalDao.GetHorasSemana().SingleOrDefault(x => x.hora_id == agenda.agenda_hora_desde).ToString(),
                    _profesionalDao.GetHorasSemana().SingleOrDefault(x => x.hora_id == agenda.agenda_hora_hasta).ToString(),
                    _profesionalDao.GetEspecialidades().SingleOrDefault(x => x.especialidad_id == agenda.especialidad_id).ToString());
        }

     
    }
}
