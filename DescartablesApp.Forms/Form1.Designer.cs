namespace DescartablesApp.Forms
{
    partial class Form1
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
            btnAbrirFormProductos = new Button();
            btnAbrirVentas = new Button();
            btnDetalleVenta = new Button();
            SuspendLayout();
            // 
            // btnAbrirFormProductos
            // 
            btnAbrirFormProductos.Location = new Point(93, 68);
            btnAbrirFormProductos.Name = "btnAbrirFormProductos";
            btnAbrirFormProductos.Size = new Size(143, 46);
            btnAbrirFormProductos.TabIndex = 0;
            btnAbrirFormProductos.Text = "Productos";
            btnAbrirFormProductos.UseVisualStyleBackColor = true;
            btnAbrirFormProductos.Click += btnAbrirFormProductos_Click;
            // 
            // btnAbrirVentas
            // 
            btnAbrirVentas.Location = new Point(451, 68);
            btnAbrirVentas.Name = "btnAbrirVentas";
            btnAbrirVentas.Size = new Size(143, 46);
            btnAbrirVentas.TabIndex = 1;
            btnAbrirVentas.Text = "Ventas";
            btnAbrirVentas.UseVisualStyleBackColor = true;
            btnAbrirVentas.Click += btnAbrirVentas_Click;
            // 
            // btnDetalleVenta
            // 
            btnDetalleVenta.Location = new Point(271, 178);
            btnDetalleVenta.Name = "btnDetalleVenta";
            btnDetalleVenta.Size = new Size(143, 46);
            btnDetalleVenta.TabIndex = 2;
            btnDetalleVenta.Text = "Detalles de ventas";
            btnDetalleVenta.UseVisualStyleBackColor = true;
            btnDetalleVenta.Click += btnDetalleVenta_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDetalleVenta);
            Controls.Add(btnAbrirVentas);
            Controls.Add(btnAbrirFormProductos);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAbrirFormProductos;
        private Button btnAbrirVentas;
        private Button btnDetalleVenta;
    }
}
