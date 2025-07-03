namespace DescartablesApp.Forms
{
    partial class FormProductos
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
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnCrearProducto = new Button();
            label4 = new Label();
            txtStock = new TextBox();
            label3 = new Label();
            txtPrecioVenta = new TextBox();
            label2 = new Label();
            txtPrecioCosto = new TextBox();
            label1 = new Label();
            txtNombre = new TextBox();
            dgvProductos = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(btnCrearProducto);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPrecioVenta);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPrecioCosto);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(dgvProductos);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Productos";
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
            // btnModificar
            // 
            btnModificar.Location = new Point(224, 79);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(161, 36);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnCrearProducto
            // 
            btnCrearProducto.Location = new Point(30, 79);
            btnCrearProducto.Name = "btnCrearProducto";
            btnCrearProducto.Size = new Size(161, 36);
            btnCrearProducto.TabIndex = 9;
            btnCrearProducto.Text = "Crear";
            btnCrearProducto.UseVisualStyleBackColor = true;
            btnCrearProducto.Click += btnCrearProducto_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(605, 19);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 8;
            label4.Text = "Stock";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(605, 36);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(161, 23);
            txtStock.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(413, 19);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 6;
            label3.Text = "Precio Venta";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(413, 36);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(161, 23);
            txtPrecioVenta.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 19);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 4;
            label2.Text = "Precio Costo";
            // 
            // txtPrecioCosto
            // 
            txtPrecioCosto.Location = new Point(224, 36);
            txtPrecioCosto.Name = "txtPrecioCosto";
            txtPrecioCosto.Size = new Size(161, 23);
            txtPrecioCosto.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 19);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(30, 36);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(161, 23);
            txtNombre.TabIndex = 1;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(30, 135);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.Size = new Size(709, 273);
            dgvProductos.TabIndex = 0;
            dgvProductos.CellClick += dgvProductos_CellClick;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            dgvProductos.SelectionChanged += dgvProductos_SelectionChanged;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "FormProductos";
            Text = "FormProductos";
            Load += FormProductos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvProductos;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtPrecioCosto;
        private Label label1;
        private Label label3;
        private TextBox txtPrecioVenta;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnCrearProducto;
        private Label label4;
        private TextBox txtStock;
        private Button btnCancelar;
    }
}