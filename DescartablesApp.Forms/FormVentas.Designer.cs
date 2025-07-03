namespace DescartablesApp.Forms
{
    partial class FormVentas
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
            groupBox1 = new GroupBox();
            lblTotal = new Label();
            cmbProductos = new ComboBox();
            btnConfirmar = new Button();
            btnAgregarAlCarrito = new Button();
            label1 = new Label();
            dgvDetalle = new DataGridView();
            label2 = new Label();
            nupCantidad = new NumericUpDown();
            btnCancelar = new Button();
            label3 = new Label();
            cmbFormaPago = new ComboBox();
            btnEliminar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupCantidad).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbFormaPago);
            groupBox1.Controls.Add(lblTotal);
            groupBox1.Controls.Add(nupCantidad);
            groupBox1.Controls.Add(cmbProductos);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnConfirmar);
            groupBox1.Controls.Add(btnAgregarAlCarrito);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dgvDetalle);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 426);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ventas";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(308, 134);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(147, 32);
            lblTotal.TabIndex = 16;
            lblTotal.Text = "Total: $0.00";
            // 
            // cmbProductos
            // 
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(30, 37);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(161, 23);
            cmbProductos.TabIndex = 13;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(224, 79);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(161, 36);
            btnConfirmar.TabIndex = 10;
            btnConfirmar.Text = "Confirmar venta";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnAgregarAlCarrito
            // 
            btnAgregarAlCarrito.Location = new Point(30, 79);
            btnAgregarAlCarrito.Name = "btnAgregarAlCarrito";
            btnAgregarAlCarrito.Size = new Size(161, 36);
            btnAgregarAlCarrito.TabIndex = 9;
            btnAgregarAlCarrito.Text = "Agregar al carrito";
            btnAgregarAlCarrito.UseVisualStyleBackColor = true;
            btnAgregarAlCarrito.Click += btnAgregarAlCarrito_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 19);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 2;
            label1.Text = "Producto";
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AllowUserToDeleteRows = false;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(30, 184);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.Size = new Size(709, 224);
            dgvDetalle.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 19);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 4;
            label2.Text = "Cantidad";
            // 
            // nupCantidad
            // 
            nupCantidad.Location = new Point(224, 38);
            nupCantidad.Name = "nupCantidad";
            nupCantidad.Size = new Size(161, 23);
            nupCantidad.TabIndex = 14;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(605, 79);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(161, 36);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(413, 19);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 6;
            label3.Text = "Método de pago";
            // 
            // cmbFormaPago
            // 
            cmbFormaPago.FormattingEnabled = true;
            cmbFormaPago.Items.AddRange(new object[] { "Efectivo", "Transferencia", "Tarjeta de crédito", "Tarjeta de débito" });
            cmbFormaPago.Location = new Point(413, 38);
            cmbFormaPago.Name = "cmbFormaPago";
            cmbFormaPago.Size = new Size(161, 23);
            cmbFormaPago.TabIndex = 17;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(413, 79);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(161, 36);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "FormVentas";
            Text = "FormVentas";
            Load += FormVentas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupCantidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnConfirmar;
        private Button btnAgregarAlCarrito;
        private Label label1;
        private DataGridView dgvDetalle;
        private ComboBox cmbProductos;
        private Label lblTotal;
        private ComboBox cmbFormaPago;
        private NumericUpDown nupCantidad;
        private Button btnCancelar;
        private Button btnEliminar;
        private Label label3;
        private Label label2;
    }
}