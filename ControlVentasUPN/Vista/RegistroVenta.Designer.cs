namespace ControlVentasUPN.Vista
{
    partial class RegistroVenta
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
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.btnLimpiarDatosCl = new System.Windows.Forms.Button();
            this.txtApellidoMaCl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidoPaCl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreCl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxProductos = new System.Windows.Forms.GroupBox();
            this.btnLimpiarCarrito = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCarritoProd = new System.Windows.Forms.DataGridView();
            this.nombreProdVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponibilidadProdVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadProdVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProdVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarProdCarrito = new System.Windows.Forms.Button();
            this.btnAgregarProd = new System.Windows.Forms.Button();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSkuProd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCantidadProd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecioProd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreProd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxBuscar = new System.Windows.Forms.GroupBox();
            this.btnBuscarProdGen = new System.Windows.Forms.Button();
            this.txtNombreProdGeneral = new System.Windows.Forms.TextBox();
            this.dgvProductosGeneral = new System.Windows.Forms.DataGridView();
            this.indiceProdGen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProductoGeneral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skuProdGen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVentaProdGen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponibilidadProdGen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorProdGen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaProdGen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlProdGen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenesProdGen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calificacionPromedioProdGen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadCalifProdGen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRealizarVenta = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.groupBoxCliente.SuspendLayout();
            this.groupBoxProductos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarritoProd)).BeginInit();
            this.groupBoxBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Controls.Add(this.btnLimpiarDatosCl);
            this.groupBoxCliente.Controls.Add(this.txtApellidoMaCl);
            this.groupBoxCliente.Controls.Add(this.label4);
            this.groupBoxCliente.Controls.Add(this.txtApellidoPaCl);
            this.groupBoxCliente.Controls.Add(this.label3);
            this.groupBoxCliente.Controls.Add(this.txtNombreCl);
            this.groupBoxCliente.Controls.Add(this.label2);
            this.groupBoxCliente.Controls.Add(this.txtDocumento);
            this.groupBoxCliente.Controls.Add(this.label1);
            this.groupBoxCliente.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(504, 152);
            this.groupBoxCliente.TabIndex = 0;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Cliente";
            // 
            // btnLimpiarDatosCl
            // 
            this.btnLimpiarDatosCl.Location = new System.Drawing.Point(325, 43);
            this.btnLimpiarDatosCl.Name = "btnLimpiarDatosCl";
            this.btnLimpiarDatosCl.Size = new System.Drawing.Size(102, 23);
            this.btnLimpiarDatosCl.TabIndex = 9;
            this.btnLimpiarDatosCl.Text = "Limpiar";
            this.btnLimpiarDatosCl.UseVisualStyleBackColor = true;
            this.btnLimpiarDatosCl.Click += new System.EventHandler(this.btnLimpiarDatosCl_Click);
            // 
            // txtApellidoMaCl
            // 
            this.txtApellidoMaCl.Location = new System.Drawing.Point(169, 96);
            this.txtApellidoMaCl.Name = "txtApellidoMaCl";
            this.txtApellidoMaCl.Size = new System.Drawing.Size(108, 20);
            this.txtApellidoMaCl.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Apellido Materno";
            // 
            // txtApellidoPaCl
            // 
            this.txtApellidoPaCl.Location = new System.Drawing.Point(22, 96);
            this.txtApellidoPaCl.Name = "txtApellidoPaCl";
            this.txtApellidoPaCl.Size = new System.Drawing.Size(108, 20);
            this.txtApellidoPaCl.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido Paterno";
            // 
            // txtNombreCl
            // 
            this.txtNombreCl.Location = new System.Drawing.Point(169, 43);
            this.txtNombreCl.Name = "txtNombreCl";
            this.txtNombreCl.Size = new System.Drawing.Size(108, 20);
            this.txtNombreCl.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(22, 43);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(108, 20);
            this.txtDocumento.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Documento";
            // 
            // groupBoxProductos
            // 
            this.groupBoxProductos.Controls.Add(this.btnLimpiarCarrito);
            this.groupBoxProductos.Controls.Add(this.groupBox1);
            this.groupBoxProductos.Controls.Add(this.btnBuscarProdCarrito);
            this.groupBoxProductos.Controls.Add(this.btnAgregarProd);
            this.groupBoxProductos.Controls.Add(this.txtMontoTotal);
            this.groupBoxProductos.Controls.Add(this.label9);
            this.groupBoxProductos.Controls.Add(this.txtSkuProd);
            this.groupBoxProductos.Controls.Add(this.label8);
            this.groupBoxProductos.Controls.Add(this.txtCantidadProd);
            this.groupBoxProductos.Controls.Add(this.label7);
            this.groupBoxProductos.Controls.Add(this.txtPrecioProd);
            this.groupBoxProductos.Controls.Add(this.label6);
            this.groupBoxProductos.Controls.Add(this.txtNombreProd);
            this.groupBoxProductos.Controls.Add(this.label5);
            this.groupBoxProductos.Location = new System.Drawing.Point(12, 183);
            this.groupBoxProductos.Name = "groupBoxProductos";
            this.groupBoxProductos.Size = new System.Drawing.Size(504, 442);
            this.groupBoxProductos.TabIndex = 1;
            this.groupBoxProductos.TabStop = false;
            this.groupBoxProductos.Text = "Productos";
            // 
            // btnLimpiarCarrito
            // 
            this.btnLimpiarCarrito.Location = new System.Drawing.Point(364, 72);
            this.btnLimpiarCarrito.Name = "btnLimpiarCarrito";
            this.btnLimpiarCarrito.Size = new System.Drawing.Size(121, 23);
            this.btnLimpiarCarrito.TabIndex = 16;
            this.btnLimpiarCarrito.Text = "Limpiar Carrito";
            this.btnLimpiarCarrito.UseVisualStyleBackColor = true;
            this.btnLimpiarCarrito.Click += new System.EventHandler(this.btnLimpiarCarrito_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCarritoProd);
            this.groupBox1.Location = new System.Drawing.Point(16, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 243);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carrito de Productos";
            // 
            // dgvCarritoProd
            // 
            this.dgvCarritoProd.AllowUserToOrderColumns = true;
            this.dgvCarritoProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarritoProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreProdVenta,
            this.disponibilidadProdVenta,
            this.cantidadProdVenta,
            this.precioProdVenta,
            this.subTotal});
            this.dgvCarritoProd.Location = new System.Drawing.Point(10, 19);
            this.dgvCarritoProd.Name = "dgvCarritoProd";
            this.dgvCarritoProd.Size = new System.Drawing.Size(444, 212);
            this.dgvCarritoProd.TabIndex = 12;
            // 
            // nombreProdVenta
            // 
            this.nombreProdVenta.HeaderText = "Nombre Producto";
            this.nombreProdVenta.Name = "nombreProdVenta";
            // 
            // disponibilidadProdVenta
            // 
            this.disponibilidadProdVenta.HeaderText = "Disponibilidad";
            this.disponibilidadProdVenta.Name = "disponibilidadProdVenta";
            // 
            // cantidadProdVenta
            // 
            this.cantidadProdVenta.HeaderText = "Cantidad";
            this.cantidadProdVenta.Name = "cantidadProdVenta";
            this.cantidadProdVenta.Width = 60;
            // 
            // precioProdVenta
            // 
            this.precioProdVenta.HeaderText = "Precio Unitario";
            this.precioProdVenta.Name = "precioProdVenta";
            this.precioProdVenta.Width = 60;
            // 
            // subTotal
            // 
            this.subTotal.HeaderText = "Sub Total";
            this.subTotal.Name = "subTotal";
            this.subTotal.Width = 80;
            // 
            // btnBuscarProdCarrito
            // 
            this.btnBuscarProdCarrito.Location = new System.Drawing.Point(364, 37);
            this.btnBuscarProdCarrito.Name = "btnBuscarProdCarrito";
            this.btnBuscarProdCarrito.Size = new System.Drawing.Size(121, 23);
            this.btnBuscarProdCarrito.TabIndex = 14;
            this.btnBuscarProdCarrito.Text = "Buscar Producto";
            this.btnBuscarProdCarrito.UseVisualStyleBackColor = true;
            this.btnBuscarProdCarrito.Click += new System.EventHandler(this.btnBuscarProdCarrito_Click);
            // 
            // btnAgregarProd
            // 
            this.btnAgregarProd.Location = new System.Drawing.Point(364, 105);
            this.btnAgregarProd.Name = "btnAgregarProd";
            this.btnAgregarProd.Size = new System.Drawing.Size(121, 23);
            this.btnAgregarProd.TabIndex = 13;
            this.btnAgregarProd.Text = "Agregar Producto";
            this.btnAgregarProd.UseVisualStyleBackColor = true;
            this.btnAgregarProd.Click += new System.EventHandler(this.btnAgregarProd_Click);
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(358, 405);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.ReadOnly = true;
            this.txtMontoTotal.Size = new System.Drawing.Size(108, 20);
            this.txtMontoTotal.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(264, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Monto Total:  S/.";
            // 
            // txtSkuProd
            // 
            this.txtSkuProd.Location = new System.Drawing.Point(22, 37);
            this.txtSkuProd.Name = "txtSkuProd";
            this.txtSkuProd.Size = new System.Drawing.Size(108, 20);
            this.txtSkuProd.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Sku";
            // 
            // txtCantidadProd
            // 
            this.txtCantidadProd.Location = new System.Drawing.Point(22, 94);
            this.txtCantidadProd.Name = "txtCantidadProd";
            this.txtCantidadProd.Size = new System.Drawing.Size(88, 20);
            this.txtCantidadProd.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cantidad Vendida";
            // 
            // txtPrecioProd
            // 
            this.txtPrecioProd.Location = new System.Drawing.Point(127, 94);
            this.txtPrecioProd.Name = "txtPrecioProd";
            this.txtPrecioProd.ReadOnly = true;
            this.txtPrecioProd.Size = new System.Drawing.Size(94, 20);
            this.txtPrecioProd.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Precio Unitario  S/.";
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.Location = new System.Drawing.Point(149, 37);
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.ReadOnly = true;
            this.txtNombreProd.Size = new System.Drawing.Size(188, 20);
            this.txtNombreProd.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre del Producto";
            // 
            // groupBoxBuscar
            // 
            this.groupBoxBuscar.Controls.Add(this.btnBuscarProdGen);
            this.groupBoxBuscar.Controls.Add(this.txtNombreProdGeneral);
            this.groupBoxBuscar.Controls.Add(this.dgvProductosGeneral);
            this.groupBoxBuscar.Location = new System.Drawing.Point(538, 12);
            this.groupBoxBuscar.Name = "groupBoxBuscar";
            this.groupBoxBuscar.Size = new System.Drawing.Size(878, 557);
            this.groupBoxBuscar.TabIndex = 2;
            this.groupBoxBuscar.TabStop = false;
            this.groupBoxBuscar.Text = "Busqueda de Productos por Nombre";
            // 
            // btnBuscarProdGen
            // 
            this.btnBuscarProdGen.Location = new System.Drawing.Point(281, 26);
            this.btnBuscarProdGen.Name = "btnBuscarProdGen";
            this.btnBuscarProdGen.Size = new System.Drawing.Size(106, 23);
            this.btnBuscarProdGen.TabIndex = 3;
            this.btnBuscarProdGen.Text = "Buscar Producto";
            this.btnBuscarProdGen.UseVisualStyleBackColor = true;
            this.btnBuscarProdGen.Click += new System.EventHandler(this.btnBuscarProdGen_Click);
            // 
            // txtNombreProdGeneral
            // 
            this.txtNombreProdGeneral.Location = new System.Drawing.Point(21, 26);
            this.txtNombreProdGeneral.Name = "txtNombreProdGeneral";
            this.txtNombreProdGeneral.Size = new System.Drawing.Size(237, 20);
            this.txtNombreProdGeneral.TabIndex = 2;
            // 
            // dgvProductosGeneral
            // 
            this.dgvProductosGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosGeneral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indiceProdGen,
            this.nombreProductoGeneral,
            this.skuProdGen,
            this.precioVentaProdGen,
            this.disponibilidadProdGen,
            this.colorProdGen,
            this.categoriaProdGen,
            this.urlProdGen,
            this.imagenesProdGen,
            this.calificacionPromedioProdGen,
            this.cantidadCalifProdGen});
            this.dgvProductosGeneral.Location = new System.Drawing.Point(21, 66);
            this.dgvProductosGeneral.Name = "dgvProductosGeneral";
            this.dgvProductosGeneral.Size = new System.Drawing.Size(836, 470);
            this.dgvProductosGeneral.TabIndex = 1;
            // 
            // indiceProdGen
            // 
            this.indiceProdGen.HeaderText = "Índice";
            this.indiceProdGen.Name = "indiceProdGen";
            this.indiceProdGen.ReadOnly = true;
            this.indiceProdGen.Width = 50;
            // 
            // nombreProductoGeneral
            // 
            this.nombreProductoGeneral.HeaderText = "Nombre";
            this.nombreProductoGeneral.Name = "nombreProductoGeneral";
            this.nombreProductoGeneral.ReadOnly = true;
            this.nombreProductoGeneral.Width = 130;
            // 
            // skuProdGen
            // 
            this.skuProdGen.HeaderText = "SKU";
            this.skuProdGen.Name = "skuProdGen";
            this.skuProdGen.ReadOnly = true;
            // 
            // precioVentaProdGen
            // 
            this.precioVentaProdGen.HeaderText = "Precio";
            this.precioVentaProdGen.Name = "precioVentaProdGen";
            this.precioVentaProdGen.ReadOnly = true;
            this.precioVentaProdGen.Width = 70;
            // 
            // disponibilidadProdGen
            // 
            this.disponibilidadProdGen.HeaderText = "Disponibilidad";
            this.disponibilidadProdGen.Name = "disponibilidadProdGen";
            this.disponibilidadProdGen.ReadOnly = true;
            // 
            // colorProdGen
            // 
            this.colorProdGen.HeaderText = "Color";
            this.colorProdGen.Name = "colorProdGen";
            this.colorProdGen.ReadOnly = true;
            // 
            // categoriaProdGen
            // 
            this.categoriaProdGen.HeaderText = "Categoría";
            this.categoriaProdGen.Name = "categoriaProdGen";
            this.categoriaProdGen.ReadOnly = true;
            // 
            // urlProdGen
            // 
            this.urlProdGen.HeaderText = "Link";
            this.urlProdGen.Name = "urlProdGen";
            this.urlProdGen.ReadOnly = true;
            // 
            // imagenesProdGen
            // 
            this.imagenesProdGen.HeaderText = "Imagenes";
            this.imagenesProdGen.Name = "imagenesProdGen";
            this.imagenesProdGen.ReadOnly = true;
            // 
            // calificacionPromedioProdGen
            // 
            this.calificacionPromedioProdGen.HeaderText = "Puntaje Calificación";
            this.calificacionPromedioProdGen.Name = "calificacionPromedioProdGen";
            this.calificacionPromedioProdGen.ReadOnly = true;
            // 
            // cantidadCalifProdGen
            // 
            this.cantidadCalifProdGen.HeaderText = "Cantidad de calificaciones";
            this.cantidadCalifProdGen.Name = "cantidadCalifProdGen";
            this.cantidadCalifProdGen.ReadOnly = true;
            // 
            // btnRealizarVenta
            // 
            this.btnRealizarVenta.Location = new System.Drawing.Point(538, 586);
            this.btnRealizarVenta.Name = "btnRealizarVenta";
            this.btnRealizarVenta.Size = new System.Drawing.Size(121, 23);
            this.btnRealizarVenta.TabIndex = 3;
            this.btnRealizarVenta.Text = "Realizar Venta";
            this.btnRealizarVenta.UseVisualStyleBackColor = true;
            this.btnRealizarVenta.Click += new System.EventHandler(this.btnRealizarVenta_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(675, 586);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(121, 23);
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // RegistroVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 633);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnRealizarVenta);
            this.Controls.Add(this.groupBoxBuscar);
            this.Controls.Add(this.groupBoxProductos);
            this.Controls.Add(this.groupBoxCliente);
            this.Name = "RegistroVenta";
            this.Text = "RegistroVenta";
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            this.groupBoxProductos.ResumeLayout(false);
            this.groupBoxProductos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarritoProd)).EndInit();
            this.groupBoxBuscar.ResumeLayout(false);
            this.groupBoxBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosGeneral)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.TextBox txtApellidoMaCl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellidoPaCl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreCl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiarDatosCl;
        private System.Windows.Forms.GroupBox groupBoxProductos;
        private System.Windows.Forms.TextBox txtNombreProd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecioProd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantidadProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSkuProd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvCarritoProd;
        private System.Windows.Forms.Button btnAgregarProd;
        private System.Windows.Forms.GroupBox groupBoxBuscar;
        private System.Windows.Forms.TextBox txtNombreProdGeneral;
        private System.Windows.Forms.DataGridView dgvProductosGeneral;
        private System.Windows.Forms.Button btnBuscarProdGen;
        private System.Windows.Forms.Button btnRealizarVenta;
        private System.Windows.Forms.Button btnBuscarProdCarrito;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn disponibilidadProdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn indiceProdGen;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoGeneral;
        private System.Windows.Forms.DataGridViewTextBoxColumn skuProdGen;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVentaProdGen;
        private System.Windows.Forms.DataGridViewTextBoxColumn disponibilidadProdGen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorProdGen;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaProdGen;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlProdGen;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagenesProdGen;
        private System.Windows.Forms.DataGridViewTextBoxColumn calificacionPromedioProdGen;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadCalifProdGen;
        private System.Windows.Forms.Button btnLimpiarCarrito;
        private System.Windows.Forms.Button btnFinalizar;
    }
}