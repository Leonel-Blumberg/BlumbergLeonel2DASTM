namespace TP_N4___CRUD_con_Sql_Server_y_Entity_Framework
{
    partial class FormularioPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            gbxVisDatos = new GroupBox();
            lblVisDatos = new Label();
            dgvVisDatos = new DataGridView();
            gbxManejoDatos = new GroupBox();
            dtpFechaNacimiento = new DateTimePicker();
            lblFechaNacimiento = new Label();
            lblTextoNotaEliminar = new Label();
            lblTextoNotaEditar = new Label();
            lblTextoNota = new Label();
            lblNota = new Label();
            btnReiniciar = new Button();
            btnSalir = new Button();
            btnRefrescar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            lblManejoDatos = new Label();
            txtCorreo = new TextBox();
            lblNombre = new Label();
            lblCorreo = new Label();
            txtNombre = new TextBox();
            gbxVisDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVisDatos).BeginInit();
            gbxManejoDatos.SuspendLayout();
            SuspendLayout();
            // 
            // gbxVisDatos
            // 
            gbxVisDatos.Controls.Add(lblVisDatos);
            gbxVisDatos.Controls.Add(dgvVisDatos);
            gbxVisDatos.Location = new Point(475, 14);
            gbxVisDatos.Name = "gbxVisDatos";
            gbxVisDatos.Size = new Size(643, 531);
            gbxVisDatos.TabIndex = 21;
            gbxVisDatos.TabStop = false;
            // 
            // lblVisDatos
            // 
            lblVisDatos.AutoSize = true;
            lblVisDatos.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVisDatos.ForeColor = Color.DarkOrange;
            lblVisDatos.Location = new Point(189, 19);
            lblVisDatos.Name = "lblVisDatos";
            lblVisDatos.Size = new Size(267, 30);
            lblVisDatos.TabIndex = 18;
            lblVisDatos.Text = "Visualización de los Datos";
            // 
            // dgvVisDatos
            // 
            dgvVisDatos.AllowUserToAddRows = false;
            dgvVisDatos.AllowUserToDeleteRows = false;
            dgvVisDatos.AllowUserToResizeColumns = false;
            dgvVisDatos.AllowUserToResizeRows = false;
            dgvVisDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvVisDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvVisDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVisDatos.Location = new Point(28, 65);
            dgvVisDatos.MultiSelect = false;
            dgvVisDatos.Name = "dgvVisDatos";
            dgvVisDatos.ReadOnly = true;
            dgvVisDatos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvVisDatos.ScrollBars = ScrollBars.Vertical;
            dgvVisDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVisDatos.Size = new Size(589, 449);
            dgvVisDatos.TabIndex = 19;
            dgvVisDatos.SelectionChanged += DgvVisDatos_SelectionChanged;
            // 
            // gbxManejoDatos
            // 
            gbxManejoDatos.Controls.Add(dtpFechaNacimiento);
            gbxManejoDatos.Controls.Add(lblFechaNacimiento);
            gbxManejoDatos.Controls.Add(lblTextoNotaEliminar);
            gbxManejoDatos.Controls.Add(lblTextoNotaEditar);
            gbxManejoDatos.Controls.Add(lblTextoNota);
            gbxManejoDatos.Controls.Add(lblNota);
            gbxManejoDatos.Controls.Add(btnReiniciar);
            gbxManejoDatos.Controls.Add(btnSalir);
            gbxManejoDatos.Controls.Add(btnRefrescar);
            gbxManejoDatos.Controls.Add(btnEliminar);
            gbxManejoDatos.Controls.Add(btnEditar);
            gbxManejoDatos.Controls.Add(btnAgregar);
            gbxManejoDatos.Controls.Add(lblManejoDatos);
            gbxManejoDatos.Controls.Add(txtCorreo);
            gbxManejoDatos.Controls.Add(lblNombre);
            gbxManejoDatos.Controls.Add(lblCorreo);
            gbxManejoDatos.Controls.Add(txtNombre);
            gbxManejoDatos.Location = new Point(12, 14);
            gbxManejoDatos.Name = "gbxManejoDatos";
            gbxManejoDatos.Size = new Size(457, 531);
            gbxManejoDatos.TabIndex = 20;
            gbxManejoDatos.TabStop = false;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
            dtpFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtpFechaNacimiento.Location = new Point(191, 121);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(238, 23);
            dtpFechaNacimiento.TabIndex = 18;
            dtpFechaNacimiento.Value = new DateTime(2025, 9, 11, 0, 0, 0, 0);
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaNacimiento.ForeColor = Color.White;
            lblFechaNacimiento.Location = new Point(18, 121);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(167, 21);
            lblFechaNacimiento.TabIndex = 17;
            lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lblTextoNotaEliminar
            // 
            lblTextoNotaEliminar.AutoSize = true;
            lblTextoNotaEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTextoNotaEliminar.ForeColor = Color.DarkOrange;
            lblTextoNotaEliminar.Location = new Point(177, 254);
            lblTextoNotaEliminar.Name = "lblTextoNotaEliminar";
            lblTextoNotaEliminar.Size = new Size(74, 21);
            lblTextoNotaEliminar.TabIndex = 14;
            lblTextoNotaEliminar.Text = "eliminar";
            // 
            // lblTextoNotaEditar
            // 
            lblTextoNotaEditar.AutoSize = true;
            lblTextoNotaEditar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTextoNotaEditar.ForeColor = Color.DarkOrange;
            lblTextoNotaEditar.Location = new Point(112, 254);
            lblTextoNotaEditar.Name = "lblTextoNotaEditar";
            lblTextoNotaEditar.Size = new Size(55, 21);
            lblTextoNotaEditar.TabIndex = 13;
            lblTextoNotaEditar.Text = "editar";
            // 
            // lblTextoNota
            // 
            lblTextoNota.AutoSize = true;
            lblTextoNota.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextoNota.ForeColor = Color.White;
            lblTextoNota.Location = new Point(77, 254);
            lblTextoNota.Name = "lblTextoNota";
            lblTextoNota.Size = new Size(365, 42);
            lblTextoNota.TabIndex = 12;
            lblTextoNota.Text = "Para              o                   algún dato, debe\r\nseleccionarlo primero en el cuadro de visualización.";
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNota.ForeColor = Color.DarkOrange;
            lblNota.Location = new Point(18, 251);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(61, 25);
            lblNota.TabIndex = 11;
            lblNota.Text = "Nota:";
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.DarkOrange;
            btnReiniciar.FlatStyle = FlatStyle.Popup;
            btnReiniciar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnReiniciar.ForeColor = Color.Black;
            btnReiniciar.Location = new Point(244, 483);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(185, 31);
            btnReiniciar.TabIndex = 16;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += BtnReiniciar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.DarkOrange;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnSalir.ForeColor = Color.Black;
            btnSalir.Location = new Point(18, 483);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(185, 31);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += BtnSalir_Click;
            // 
            // btnRefrescar
            // 
            btnRefrescar.BackColor = Color.DarkOrange;
            btnRefrescar.FlatStyle = FlatStyle.Popup;
            btnRefrescar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnRefrescar.ForeColor = Color.Black;
            btnRefrescar.Location = new Point(18, 204);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(411, 31);
            btnRefrescar.TabIndex = 10;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = false;
            btnRefrescar.Click += BtnRefrescar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Silver;
            btnEliminar.Enabled = false;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(298, 161);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(131, 31);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += BtnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Silver;
            btnEditar.Enabled = false;
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnEditar.ForeColor = Color.Black;
            btnEditar.Location = new Point(159, 161);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(131, 31);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += BtnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DarkOrange;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(18, 161);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(131, 31);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += BtnAgregar_Click;
            // 
            // lblManejoDatos
            // 
            lblManejoDatos.AutoSize = true;
            lblManejoDatos.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblManejoDatos.ForeColor = Color.DarkOrange;
            lblManejoDatos.Location = new Point(156, 19);
            lblManejoDatos.Name = "lblManejoDatos";
            lblManejoDatos.Size = new Size(149, 30);
            lblManejoDatos.TabIndex = 2;
            lblManejoDatos.Text = "Manejo Datos";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(95, 92);
            txtCorreo.MaxLength = 120;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(334, 23);
            txtCorreo.TabIndex = 6;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(18, 63);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(75, 21);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorreo.ForeColor = Color.White;
            lblCorreo.Location = new Point(18, 92);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(65, 21);
            lblCorreo.TabIndex = 5;
            lblCorreo.Text = "Correo:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(95, 63);
            txtNombre.MaxLength = 120;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(334, 23);
            txtNombre.TabIndex = 4;
            // 
            // FormularioPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1131, 559);
            Controls.Add(gbxVisDatos);
            Controls.Add(gbxManejoDatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormularioPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejemplo de CRUD con Sql Server y Entity Framework";
            gbxVisDatos.ResumeLayout(false);
            gbxVisDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVisDatos).EndInit();
            gbxManejoDatos.ResumeLayout(false);
            gbxManejoDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxVisDatos;
        private Label lblVisDatos;
        private DataGridView dgvVisDatos;
        private GroupBox gbxManejoDatos;
        private Label lblTextoNotaEliminar;
        private Label lblTextoNotaEditar;
        private Label lblTextoNota;
        private Label lblNota;
        private Button btnReiniciar;
        private Button btnSalir;
        private Button btnRefrescar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
        private Label lblManejoDatos;
        private TextBox txtCorreo;
        private Label lblNombre;
        private Label lblCorreo;
        private TextBox txtNombre;
        private DateTimePicker dtpFechaNacimiento;
        private Label lblFechaNacimiento;
    }
}
