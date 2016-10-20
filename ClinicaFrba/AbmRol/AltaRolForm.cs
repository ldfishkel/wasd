namespace ClinicaFrba.AbmRol
{
    using DataAccess;
    using DataAccess.DAO;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using System.Linq;
    using System.Text;

    public partial class AltaRolForm : Form
    {
        private RolDao _rolDao;
        private Rol _rol;
        private bool _modify;

        public AltaRolForm(RolDao rolDao)
        {
            _rolDao = rolDao;
            _rol = new Rol();
            _rol.Funcionalidads = new HashSet<Funcionalidad>();
            _modify = false;

            InitializeComponent();
            InitializeCombo();
        }

        public AltaRolForm(RolDao rolDao, Rol rol)
        {
            InitializeComponent();

            _rolDao = rolDao;
            _rol = rol;
            _modify = true;
            _nombre.Text = rol.rol_nombre;

            Text = "Modificar Rol";

            AgregarClick(null, null);
            InitializeCombo();
        }

        private void InitializeCombo()
        {
            _funcionalidadCombo.Items.AddRange(_rolDao.GetFuncionalidades().ToArray());
        }

        private void AgregarClick(object sender, EventArgs e)
        {
            if ((Funcionalidad)_funcionalidadCombo.SelectedItem != null)
                _rol.Funcionalidads.Add((Funcionalidad)_funcionalidadCombo.SelectedItem);

            _funcionalidadesView.Rows.Clear();
            foreach (Funcionalidad funcionalidad in _rol.Funcionalidads)
            {
                _funcionalidadesView.Rows.Add(funcionalidad.funcionalidad_id, funcionalidad.funcionalidad_nombre, "Quitar");
            }
        }

        private void GuardarClick(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                _rol.rol_nombre = _nombre.Text;
                _rol.rol_activo = true;

                bool success = false;

                if (_modify)
                   success = _rolDao.Modify(_rol);
                else
                    success = _rolDao.Guardar(_rol);

                if (success)
                    Close();
            }
        }

        private void CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int id = (int)senderGrid.Rows[e.RowIndex].Cells[0].Value;

                _rol.Funcionalidads.Remove(_rol.Funcionalidads.First(x => x.funcionalidad_id == id));

                senderGrid.Rows.RemoveAt(e.RowIndex);
            }
        }

        private bool ValidateFields()
        {
            StringBuilder sb = new StringBuilder();

            if (String.IsNullOrEmpty(_nombre.Text))
                sb.AppendLine("Debe ingresar nobmre");

            if (_rol.Funcionalidads.Count == 0)
                sb.AppendLine("Debe agregar funcionalidad");

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString());
                return false;
            }

            return true;
        }
    }
}
