namespace DescartablesApp.Forms
{
    partial class FormDetalleVenta
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
            btnVerDetalle = new Button();
            btnBuscarVentaPorId = new Button();
            label1 = new Label();
            txtIdVenta = new TextBox();
            dgvVentas = new DataGridView();
            btnMostrarTodo = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnMostrarTodo);
            groupBox1.Controls.Add(btnVerDetalle);
            groupBox1.Controls.Add(btnBuscarVentaPorId);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtIdVenta);
            groupBox1.Controls.Add(dgvVentas);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 426);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles de ventas";
            // 
            // btnVerDetalle
            // 
            btnVerDetalle.Location = new Point(416, 79);
            btnVerDetalle.Name = "btnVerDetalle";
            btnVerDetalle.Size = new Size(161, 36);
            btnVerDetalle.TabIndex = 10;
            btnVerDetalle.Text = "Ver detalle";
            btnVerDetalle.UseVisualStyleBackColor = true;
            btnVerDetalle.Click += btnVerDetalle_Click;
            // 
            // btnBuscarVentaPorId
            // 
            btnBuscarVentaPorId.Location = new Point(30, 79);
            btnBuscarVentaPorId.Name = "btnBuscarVentaPorId";
            btnBuscarVentaPorId.Size = new Size(161, 36);
            btnBuscarVentaPorId.TabIndex = 9;
            btnBuscarVentaPorId.Text = "Buscar";
            btnBuscarVentaPorId.UseVisualStyleBackColor = true;
            btnBuscarVentaPorId.Click += btnBuscarVentaPorId_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 19);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 2;
            label1.Text = "Id Venta";
            // 
            // txtIdVenta
            // 
            txtIdVenta.Location = new Point(30, 36);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(161, 23);
            txtIdVenta.TabIndex = 1;
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(30, 135);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.Size = new Size(709, 273);
            dgvVentas.TabIndex = 0;
            // 
            // btnMostrarTodo
            // 
            btnMostrarTodo.Location = new Point(220, 79);
            btnMostrarTodo.Name = "btnMostrarTodo";
            btnMostrarTodo.Size = new Size(161, 36);
            btnMostrarTodo.TabIndex = 11;
            btnMostrarTodo.Text = "Mostrar todo";
            btnMostrarTodo.UseVisualStyleBackColor = true;
            btnMostrarTodo.Click += btnMostrarTodo_Click;
            // 
            // FormDetalleVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "FormDetalleVenta";
            Text = "DetalleVenta";
            Load += FormDetalleVenta_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnVerDetalle;
        private Button btnBuscarVentaPorId;
        private Label label1;
        private TextBox txtIdVenta;
        private DataGridView dgvVentas;
        private Button btnMostrarTodo;
    }
}