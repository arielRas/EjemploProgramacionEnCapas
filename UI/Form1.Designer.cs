namespace UI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMostrarPedidos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCargarLista = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecioActual = new System.Windows.Forms.TextBox();
            this.txtModificarPrecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnModificarPrecioProducto = new System.Windows.Forms.Button();
            this.txtBoxProductos2 = new System.Windows.Forms.ComboBox();
            this.groupCargaProducto = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAltaProducto = new System.Windows.Forms.Button();
            this.txtNuevoPrecio = new System.Windows.Forms.TextBox();
            this.txtNuevaDescripcion = new System.Windows.Forms.TextBox();
            this.groupGenerarPedido = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnGenerarPedido = new System.Windows.Forms.Button();
            this.groupCargarPedido = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnQuitarProducto = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmarPedido = new System.Windows.Forms.Button();
            this.dataGridPedido = new System.Windows.Forms.DataGridView();
            this.txtBoxCantidad = new System.Windows.Forms.ComboBox();
            this.txtBoxProducto = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupCargaProducto.SuspendLayout();
            this.groupGenerarPedido.SuspendLayout();
            this.groupCargarPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(747, 304);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(127, 76);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnMostrarPedidos
            // 
            this.btnMostrarPedidos.Location = new System.Drawing.Point(584, 304);
            this.btnMostrarPedidos.Name = "btnMostrarPedidos";
            this.btnMostrarPedidos.Size = new System.Drawing.Size(127, 76);
            this.btnMostrarPedidos.TabIndex = 10;
            this.btnMostrarPedidos.Text = "MOSTRAR PEDIDOS REALIZADOS";
            this.btnMostrarPedidos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnCargarLista);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPrecioActual);
            this.groupBox1.Controls.Add(this.txtModificarPrecio);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnModificarPrecioProducto);
            this.groupBox1.Controls.Add(this.txtBoxProductos2);
            this.groupBox1.Location = new System.Drawing.Point(189, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 205);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar precio producto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Precio actual";
            // 
            // btnCargarLista
            // 
            this.btnCargarLista.Location = new System.Drawing.Point(219, 23);
            this.btnCargarLista.Name = "btnCargarLista";
            this.btnCargarLista.Size = new System.Drawing.Size(83, 42);
            this.btnCargarLista.TabIndex = 12;
            this.btnCargarLista.Text = "ACTUALIZAR LISTA";
            this.btnCargarLista.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nuevo precio";
            // 
            // txtPrecioActual
            // 
            this.txtPrecioActual.Enabled = false;
            this.txtPrecioActual.Location = new System.Drawing.Point(23, 88);
            this.txtPrecioActual.Name = "txtPrecioActual";
            this.txtPrecioActual.Size = new System.Drawing.Size(65, 20);
            this.txtPrecioActual.TabIndex = 13;
            // 
            // txtModificarPrecio
            // 
            this.txtModificarPrecio.Location = new System.Drawing.Point(143, 88);
            this.txtModificarPrecio.Name = "txtModificarPrecio";
            this.txtModificarPrecio.Size = new System.Drawing.Size(65, 20);
            this.txtModificarPrecio.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Producto";
            // 
            // btnModificarPrecioProducto
            // 
            this.btnModificarPrecioProducto.Location = new System.Drawing.Point(46, 138);
            this.btnModificarPrecioProducto.Name = "btnModificarPrecioProducto";
            this.btnModificarPrecioProducto.Size = new System.Drawing.Size(144, 38);
            this.btnModificarPrecioProducto.TabIndex = 5;
            this.btnModificarPrecioProducto.Text = "MODIFICAR PRECIO";
            this.btnModificarPrecioProducto.UseVisualStyleBackColor = true;
            // 
            // txtBoxProductos2
            // 
            this.txtBoxProductos2.FormattingEnabled = true;
            this.txtBoxProductos2.Location = new System.Drawing.Point(22, 34);
            this.txtBoxProductos2.Name = "txtBoxProductos2";
            this.txtBoxProductos2.Size = new System.Drawing.Size(186, 21);
            this.txtBoxProductos2.TabIndex = 0;
            // 
            // groupCargaProducto
            // 
            this.groupCargaProducto.Controls.Add(this.label8);
            this.groupCargaProducto.Controls.Add(this.label6);
            this.groupCargaProducto.Controls.Add(this.btnAltaProducto);
            this.groupCargaProducto.Controls.Add(this.txtNuevoPrecio);
            this.groupCargaProducto.Controls.Add(this.txtNuevaDescripcion);
            this.groupCargaProducto.Location = new System.Drawing.Point(12, 232);
            this.groupCargaProducto.Name = "groupCargaProducto";
            this.groupCargaProducto.Size = new System.Drawing.Size(171, 205);
            this.groupCargaProducto.TabIndex = 8;
            this.groupCargaProducto.TabStop = false;
            this.groupCargaProducto.Text = "Alta de Producto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nueva descripcion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Precio";
            // 
            // btnAltaProducto
            // 
            this.btnAltaProducto.Location = new System.Drawing.Point(29, 138);
            this.btnAltaProducto.Name = "btnAltaProducto";
            this.btnAltaProducto.Size = new System.Drawing.Size(114, 38);
            this.btnAltaProducto.TabIndex = 13;
            this.btnAltaProducto.Text = "ALTA DE PRODUCTO";
            this.btnAltaProducto.UseVisualStyleBackColor = true;
            // 
            // txtNuevoPrecio
            // 
            this.txtNuevoPrecio.Location = new System.Drawing.Point(46, 88);
            this.txtNuevoPrecio.Name = "txtNuevoPrecio";
            this.txtNuevoPrecio.Size = new System.Drawing.Size(80, 20);
            this.txtNuevoPrecio.TabIndex = 12;
            // 
            // txtNuevaDescripcion
            // 
            this.txtNuevaDescripcion.Location = new System.Drawing.Point(9, 39);
            this.txtNuevaDescripcion.Name = "txtNuevaDescripcion";
            this.txtNuevaDescripcion.Size = new System.Drawing.Size(151, 20);
            this.txtNuevaDescripcion.TabIndex = 11;
            // 
            // groupGenerarPedido
            // 
            this.groupGenerarPedido.Controls.Add(this.label3);
            this.groupGenerarPedido.Controls.Add(this.txtDni);
            this.groupGenerarPedido.Controls.Add(this.btnGenerarPedido);
            this.groupGenerarPedido.Location = new System.Drawing.Point(12, 12);
            this.groupGenerarPedido.Name = "groupGenerarPedido";
            this.groupGenerarPedido.Size = new System.Drawing.Size(171, 205);
            this.groupGenerarPedido.TabIndex = 6;
            this.groupGenerarPedido.TabStop = false;
            this.groupGenerarPedido.Text = "Generar pedido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "DNI Cliente";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(29, 68);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(114, 20);
            this.txtDni.TabIndex = 2;
            // 
            // btnGenerarPedido
            // 
            this.btnGenerarPedido.Location = new System.Drawing.Point(29, 122);
            this.btnGenerarPedido.Name = "btnGenerarPedido";
            this.btnGenerarPedido.Size = new System.Drawing.Size(114, 39);
            this.btnGenerarPedido.TabIndex = 0;
            this.btnGenerarPedido.Text = "GENERAR PEDIDO";
            this.btnGenerarPedido.UseVisualStyleBackColor = true;
            // 
            // groupCargarPedido
            // 
            this.groupCargarPedido.Controls.Add(this.label4);
            this.groupCargarPedido.Controls.Add(this.btnQuitarProducto);
            this.groupCargarPedido.Controls.Add(this.txtPrecio);
            this.groupCargarPedido.Controls.Add(this.btnAgregarProducto);
            this.groupCargarPedido.Controls.Add(this.label2);
            this.groupCargarPedido.Controls.Add(this.label1);
            this.groupCargarPedido.Controls.Add(this.btnConfirmarPedido);
            this.groupCargarPedido.Controls.Add(this.dataGridPedido);
            this.groupCargarPedido.Controls.Add(this.txtBoxCantidad);
            this.groupCargarPedido.Controls.Add(this.txtBoxProducto);
            this.groupCargarPedido.Enabled = false;
            this.groupCargarPedido.Location = new System.Drawing.Point(189, 12);
            this.groupCargarPedido.Name = "groupCargarPedido";
            this.groupCargarPedido.Size = new System.Drawing.Size(778, 205);
            this.groupCargarPedido.TabIndex = 7;
            this.groupCargarPedido.TabStop = false;
            this.groupCargarPedido.Text = "Cargar Pedido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Precio";
            // 
            // btnQuitarProducto
            // 
            this.btnQuitarProducto.Location = new System.Drawing.Point(214, 96);
            this.btnQuitarProducto.Name = "btnQuitarProducto";
            this.btnQuitarProducto.Size = new System.Drawing.Size(83, 31);
            this.btnQuitarProducto.TabIndex = 6;
            this.btnQuitarProducto.Text = "QUITAR";
            this.btnQuitarProducto.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(23, 141);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(65, 20);
            this.txtPrecio.TabIndex = 9;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(214, 34);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(83, 31);
            this.btnAgregarProducto.TabIndex = 2;
            this.btnAgregarProducto.Text = "AGREGAR";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Producto";
            // 
            // btnConfirmarPedido
            // 
            this.btnConfirmarPedido.Location = new System.Drawing.Point(214, 152);
            this.btnConfirmarPedido.Name = "btnConfirmarPedido";
            this.btnConfirmarPedido.Size = new System.Drawing.Size(83, 38);
            this.btnConfirmarPedido.TabIndex = 5;
            this.btnConfirmarPedido.Text = "CONFIRMAR PEDIDO";
            this.btnConfirmarPedido.UseVisualStyleBackColor = true;
            // 
            // dataGridPedido
            // 
            this.dataGridPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPedido.Location = new System.Drawing.Point(303, 34);
            this.dataGridPedido.Name = "dataGridPedido";
            this.dataGridPedido.Size = new System.Drawing.Size(466, 156);
            this.dataGridPedido.TabIndex = 4;
            // 
            // txtBoxCantidad
            // 
            this.txtBoxCantidad.FormattingEnabled = true;
            this.txtBoxCantidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.txtBoxCantidad.Location = new System.Drawing.Point(22, 87);
            this.txtBoxCantidad.Name = "txtBoxCantidad";
            this.txtBoxCantidad.Size = new System.Drawing.Size(66, 21);
            this.txtBoxCantidad.TabIndex = 3;
            // 
            // txtBoxProducto
            // 
            this.txtBoxProducto.FormattingEnabled = true;
            this.txtBoxProducto.Location = new System.Drawing.Point(22, 34);
            this.txtBoxProducto.Name = "txtBoxProducto";
            this.txtBoxProducto.Size = new System.Drawing.Size(186, 21);
            this.txtBoxProducto.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 446);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrarPedidos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupCargaProducto);
            this.Controls.Add(this.groupGenerarPedido);
            this.Controls.Add(this.groupCargarPedido);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupCargaProducto.ResumeLayout(false);
            this.groupCargaProducto.PerformLayout();
            this.groupGenerarPedido.ResumeLayout(false);
            this.groupGenerarPedido.PerformLayout();
            this.groupCargarPedido.ResumeLayout(false);
            this.groupCargarPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMostrarPedidos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCargarLista;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecioActual;
        private System.Windows.Forms.TextBox txtModificarPrecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnModificarPrecioProducto;
        private System.Windows.Forms.ComboBox txtBoxProductos2;
        private System.Windows.Forms.GroupBox groupCargaProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAltaProducto;
        private System.Windows.Forms.TextBox txtNuevoPrecio;
        private System.Windows.Forms.TextBox txtNuevaDescripcion;
        private System.Windows.Forms.GroupBox groupGenerarPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnGenerarPedido;
        private System.Windows.Forms.GroupBox groupCargarPedido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnQuitarProducto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmarPedido;
        private System.Windows.Forms.DataGridView dataGridPedido;
        private System.Windows.Forms.ComboBox txtBoxCantidad;
        private System.Windows.Forms.ComboBox txtBoxProducto;
    }
}

