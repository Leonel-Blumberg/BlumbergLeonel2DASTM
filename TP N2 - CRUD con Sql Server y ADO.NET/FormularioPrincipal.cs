using System.CodeDom;
using System.Drawing.Text;
using System.Linq.Expressions;
using TP_N2___CRUD_con_Sql_Server_y_ADO.NET.Clases;

namespace TP_N2___CRUD_con_Sql_Server_y_ADO.NET
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
            Refrescar();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ModificarDato(null);
        }

        private void ModificarDato(int? id)
        {
            if (VerificarDatos() == true)
            {
                DatosDB datosDB = new();

                try
                {
                    if (id == null)
                        datosDB.AgregarPersona(txtNombre.Text, int.Parse(txtEdad.Text));
                    else
                        datosDB.EditarPersona(txtNombre.Text, int.Parse(txtEdad.Text), (int)id);

                    txtNombre.Text = "";
                    txtEdad.Text = "";

                    if (id == null)
                        MessageBox.Show("Persona agregada con éxito.", "Info: Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Persona modificada con éxito.", "Info: Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (DBException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Refrescar();
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int? id = GetID();

            if (id != null)
                ModificarDato(id);
            else
                MessageBox.Show("No se pudo obtener el ID de la persona seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetID();

            try
            {
                if (id != null)
                {
                    DatosDB datosDB = new();
                    datosDB.EliminarPersona((int) id);

                    MessageBox.Show("Persona eliminada con éxito.", "Info: Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Refrescar();
                }
                else
                    MessageBox.Show("No se pudo obtener el ID de la persona seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DBException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region HELPER
        private int? GetID()
        {
            try
            {
                return int.Parse(dgvVisDatos.Rows[dgvVisDatos.CurrentRow.Index].Cells[0].Value.ToString()!);
            }
            catch
            {
                return null;
            }
        }
        #endregion

        private bool VerificarDatos()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                    throw new DatoIncompletoException("Debe ingresar un nombre.");

                if (string.IsNullOrWhiteSpace(txtEdad.Text))
                    throw new DatoIncompletoException("Debe ingresar una edad.");
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
            Refrescar();
        }

        private void Refrescar()
        {
            DatosDB datosDB = new();
            dgvVisDatos.DataSource = datosDB.GetDatos();
        }

        private void DgvVisDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVisDatos.SelectedRows.Count > 0)
            {
                btnEditar.BackColor = Color.LightSalmon;
                btnEditar.Enabled = true;

                btnEliminar.BackColor = Color.LightSalmon;
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

        private void PermitirSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (char.IsControl(c))
                return;

            if (char.IsDigit(c))
                return;

            e.Handled = true;
        }

        private void PermitirSoloNumeros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                string texto = Clipboard.GetText();

                if (!EsNumeroValido(texto))
                    e.SuppressKeyPress = true;
            }
        }

        private static bool EsNumeroValido(string texto)
        {
            return texto.All(char.IsDigit);
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