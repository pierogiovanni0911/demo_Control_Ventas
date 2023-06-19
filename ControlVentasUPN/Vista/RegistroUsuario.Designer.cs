namespace ControlVentasUPN.Vista
{
    partial class RegistroUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContrasenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApllUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cboTipoUsuario = new System.Windows.Forms.ComboBox();
            this.cboSede = new System.Windows.Forms.ComboBox();
            this.nombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrasenhaUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privilegiosUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboSede);
            this.groupBox1.Controls.Add(this.cboTipoUsuario);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtContrasenha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtApllUsuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombreUsuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Nuevo Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo de Usuario";
            // 
            // txtContrasenha
            // 
            this.txtContrasenha.Location = new System.Drawing.Point(134, 100);
            this.txtContrasenha.Name = "txtContrasenha";
            this.txtContrasenha.Size = new System.Drawing.Size(100, 20);
            this.txtContrasenha.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(10, 100);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuario";
            // 
            // txtApllUsuario
            // 
            this.txtApllUsuario.Location = new System.Drawing.Point(134, 49);
            this.txtApllUsuario.Name = "txtApllUsuario";
            this.txtApllUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtApllUsuario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellidos";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(10, 49);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtNombreUsuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreUsuario,
            this.apellidoUsuario,
            this.usuario,
            this.contrasenhaUsuario,
            this.privilegiosUsuario,
            this.sede});
            this.dataGridView1.Location = new System.Drawing.Point(269, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 210);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(55, 255);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(98, 22);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo Usuario";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(180, 255);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 22);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(307, 255);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(98, 22);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(433, 255);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(98, 22);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(557, 255);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 22);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sede";
            // 
            // cboTipoUsuario
            // 
            this.cboTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoUsuario.FormattingEnabled = true;
            this.cboTipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor"});
            this.cboTipoUsuario.Location = new System.Drawing.Point(10, 151);
            this.cboTipoUsuario.Name = "cboTipoUsuario";
            this.cboTipoUsuario.Size = new System.Drawing.Size(100, 21);
            this.cboTipoUsuario.TabIndex = 11;
            // 
            // cboSede
            // 
            this.cboSede.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSede.FormattingEnabled = true;
            this.cboSede.Items.AddRange(new object[] {
            "Breña",
            "Independencia",
            "Surco"});
            this.cboSede.Location = new System.Drawing.Point(134, 151);
            this.cboSede.Name = "cboSede";
            this.cboSede.Size = new System.Drawing.Size(100, 21);
            this.cboSede.TabIndex = 12;
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.HeaderText = "Nombre";
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.ReadOnly = true;
            // 
            // apellidoUsuario
            // 
            this.apellidoUsuario.HeaderText = "Apellidos";
            this.apellidoUsuario.Name = "apellidoUsuario";
            this.apellidoUsuario.ReadOnly = true;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // contrasenhaUsuario
            // 
            this.contrasenhaUsuario.HeaderText = "Contraseña";
            this.contrasenhaUsuario.Name = "contrasenhaUsuario";
            this.contrasenhaUsuario.ReadOnly = true;
            // 
            // privilegiosUsuario
            // 
            this.privilegiosUsuario.HeaderText = "Privilegios";
            this.privilegiosUsuario.Name = "privilegiosUsuario";
            this.privilegiosUsuario.ReadOnly = true;
            // 
            // sede
            // 
            this.sede.HeaderText = "Sede";
            this.sede.Name = "sede";
            this.sede.ReadOnly = true;
            // 
            // RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 303);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistroUsuario";
            this.Text = "Registro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtContrasenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApllUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboTipoUsuario;
        private System.Windows.Forms.ComboBox cboSede;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasenhaUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn privilegiosUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn sede;
    }
}