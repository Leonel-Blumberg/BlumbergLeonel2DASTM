using Microsoft.EntityFrameworkCore;
using TP_N4___CRUD_con_Sql_Server_y_Entity_Framework.Models;

namespace TP_N4___CRUD_con_Sql_Server_y_Entity_Framework
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();

            ActualizarDTPFechaNacimiento();
            RefrescarDGV();
        }

        private void ActualizarDTPFechaNacimiento()
        {
            dtpFechaNacimiento.MaxDate = DateTime.Today;
            dtpFechaNacimiento.Value = DateTime.Today;
        }

        private void RefrescarDGV()
        {
            using CRUDWindowsFormContext db = new();
            var listaDatos = db.Personas3.ToList();
            dgvVisDatos.DataSource = listaDatos;
            dgvVisDatos.Columns["FechadeNacimiento"].HeaderText = "Fecha de Nacimiento";
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ModificarDato(null);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int? id = GetID();

            if (id != null)
                ModificarDato(id);
            else
                MessageBox.Show("No se pudo obtener el ID de la persona seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ModificarDato(int? id)
        {
            if (VerificarDatos() == true)
            {
                using CRUDWindowsFormContext db = new();
                Personas3 oPersonas3 = new();

                if (id != null)
                    oPersonas3 = db.Personas3.Find(id)!;

                oPersonas3.Nombre = txtNombre.Text.Trim();
                oPersonas3.Correo = txtCorreo.Text.Trim();
                oPersonas3.FechaDeNacimiento = DateOnly.FromDateTime(dtpFechaNacimiento.Value);

                if (id == null)
                    db.Personas3.Add(oPersonas3);

                db.SaveChanges();

                txtNombre.Text = "";
                txtCorreo.Text = "";
                ActualizarDTPFechaNacimiento();

                if (id == null)
                    MessageBox.Show("Persona agregada con éxito.", "Info: Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Persona modificada con éxito.", "Info: Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefrescarDGV();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetID();

            if (id != null)
            {
                using CRUDWindowsFormContext db = new();

                Personas3 oPersonas3 = db.Personas3.Find(id)!;
                db.Personas3.Remove(oPersonas3);
                db.SaveChanges();

                MessageBox.Show("Persona eliminada con éxito.", "Info: Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefrescarDGV();
            }
            else
                MessageBox.Show("No se pudo obtener el ID de la persona seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #region HELPER
        private int? GetID()
        {
            try { return int.Parse(dgvVisDatos.Rows[dgvVisDatos.CurrentRow.Index].Cells[0].Value.ToString()!); }
            catch { return null; }
        }
        #endregion

        private bool VerificarDatos()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                    throw new DatoIncompletoException("Debe ingresar un nombre.");

                if (string.IsNullOrWhiteSpace(txtCorreo.Text))
                    throw new DatoIncompletoException("Debe ingresar un correo.");
            }
            catch (DatoIncompletoException ex)
            {
                MessageBox.Show(ex.Message, "Aviso: Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            RefrescarDGV();
        }

        private void DgvVisDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVisDatos.SelectedRows.Count > 0)
            {
                btnEditar.BackColor = Color.DarkOrange;
                btnEditar.Enabled = true;

                btnEliminar.BackColor = Color.DarkOrange;
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEditar.BackColor = Color.Silver;
                btnEditar.Enabled = false;

                btnEliminar.BackColor = Color.Silver;
                btnEliminar.Enabled = false;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnReiniciar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
