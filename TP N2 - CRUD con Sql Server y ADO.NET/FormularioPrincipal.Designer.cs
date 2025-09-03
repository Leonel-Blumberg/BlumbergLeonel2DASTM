namespace TP_N2___CRUD_con_Sql_Server_y_ADO.NET
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            lblManejoDatos = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            lblEdad = new Label();
            gbxManejoDatos = new GroupBox();
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
            gbxVisDatos = new GroupBox();
            lblVisDatos = new Label();
            dgvVisDatos = new DataGridView();
            gbxManejoDatos.SuspendLayout();
            gbxVisDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVisDatos).BeginInit();
            SuspendLayout();
            // 
            // lblManejoDatos
            // 
            lblManejoDatos.AutoSize = true;
            lblManejoDatos.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblManejoDatos.ForeColor = Color.LightSalmon;
            lblManejoDatos.Location = new Point(156, 19);
            lblManejoDatos.Name = "lblManejoDatos";
            lblManejoDatos.Size = new Size(149, 30);
            lblManejoDatos.TabIndex = 2;
            lblManejoDatos.Text = "Manejo Datos";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(18, 63);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(75, 21);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(95, 63);
            txtNombre.MaxLength = 120;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(334, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(95, 92);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(334, 23);
            txtEdad.TabIndex = 6;
            txtEdad.KeyDown += PermitirSoloNumeros_KeyDown;
            txtEdad.KeyPress += PermitirSoloNumeros_KeyPress;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEdad.Location = new Point(18, 92);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(50, 21);
            lblEdad.TabIndex = 5;
            lblEdad.Text = "Edad:";
            // 
            // gbxManejoDatos
            // 
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
            gbxManejoDatos.Controls.Add(txtEdad);
            gbxManejoDatos.Controls.Add(lblNombre);
            gbxManejoDatos.Controls.Add(lblEdad);
            gbxManejoDatos.Controls.Add(txtNombre);
            gbxManejoDatos.Location = new Point(12, 12);
            gbxManejoDatos.Name = "gbxManejoDatos";
            gbxManejoDatos.Size = new Size(457, 531);
            gbxManejoDatos.TabIndex = 1;
            gbxManejoDatos.TabStop = false;
            // 
            // lblTextoNotaEliminar
            // 
            lblTextoNotaEliminar.AutoSize = true;
            lblTextoNotaEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTextoNotaEliminar.Location = new Point(177, 227);
            lblTextoNotaEliminar.Name = "lblTextoNotaEliminar";
            lblTextoNotaEliminar.Size = new Size(74, 21);
            lblTextoNotaEliminar.TabIndex = 14;
            lblTextoNotaEliminar.Text = "eliminar";
            // 
            // lblTextoNotaEditar
            // 
            lblTextoNotaEditar.AutoSize = true;
            lblTextoNotaEditar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTextoNotaEditar.Location = new Point(112, 227);
            lblTextoNotaEditar.Name = "lblTextoNotaEditar";
            lblTextoNotaEditar.Size = new Size(55, 21);
            lblTextoNotaEditar.TabIndex = 13;
            lblTextoNotaEditar.Text = "editar";
            // 
            // lblTextoNota
            // 
            lblTextoNota.AutoSize = true;
            lblTextoNota.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextoNota.Location = new Point(77, 227);
            lblTextoNota.Name = "lblTextoNota";
            lblTextoNota.Size = new Size(365, 42);
            lblTextoNota.TabIndex = 12;
            lblTextoNota.Text = "Para              o                   algún dato, debe\r\nseleccionarlo primero en el cuadro de visualización.";
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNota.Location = new Point(18, 224);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(61, 25);
            lblNota.TabIndex = 11;
            lblNota.Text = "Nota:";
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.LightSalmon;
            btnReiniciar.FlatStyle = FlatStyle.Popup;
            btnReiniciar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnReiniciar.ForeColor = Color.White;
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
            btnSalir.BackColor = Color.LightSalmon;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnSalir.ForeColor = Color.White;
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
            btnRefrescar.BackColor = Color.LightSalmon;
            btnRefrescar.FlatStyle = FlatStyle.Popup;
            btnRefrescar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnRefrescar.ForeColor = Color.White;
            btnRefrescar.Location = new Point(18, 177);
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
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(298, 134);
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
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(159, 134);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(131, 31);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += BtnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.LightSalmon;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(18, 134);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(131, 31);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += BtnAgregar_Click;
            // 
            // gbxVisDatos
            // 
            gbxVisDatos.Controls.Add(lblVisDatos);
            gbxVisDatos.Controls.Add(dgvVisDatos);
            gbxVisDatos.Location = new Point(475, 12);
            gbxVisDatos.Name = "gbxVisDatos";
            gbxVisDatos.Size = new Size(643, 531);
            gbxVisDatos.TabIndex = 17;
            gbxVisDatos.TabStop = false;
            // 
            // lblVisDatos
            // 
            lblVisDatos.AutoSize = true;
            lblVisDatos.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVisDatos.ForeColor = Color.LightSalmon;
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
            // FormularioPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 559);
            Controls.Add(gbxVisDatos);
            Controls.Add(gbxManejoDatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormularioPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejemplo de CRUD con Sql Server y ADO.NET";
            gbxManejoDatos.ResumeLayout(false);
            gbxManejoDatos.PerformLayout();
            gbxVisDatos.ResumeLayout(false);
            gbxVisDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVisDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblManejoDatos;
        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private Label lblEdad;
        private GroupBox gbxManejoDatos;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
        private GroupBox gbxVisDatos;
        private Label lblVisDatos;
        private DataGridView dgvVisDatos;
        private Button btnReiniciar;
        private Button btnSalir;
        private Button btnRefrescar;
        private Label lblNota;
        private Label lblTextoNota;
        private Label lblTextoNotaEliminar;
        private Label lblTextoNotaEditar;
    }
}
