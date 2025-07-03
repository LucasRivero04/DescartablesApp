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
            lBN = new Label();
            SuspendLayout();
            // 
            // btnAbrirFormProductos
            // 
            btnAbrirFormProductos.BackColor = Color.Black;
            btnAbrirFormProductos.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold);
            btnAbrirFormProductos.ForeColor = Color.Gray;
            btnAbrirFormProductos.Location = new Point(101, 132);
            btnAbrirFormProductos.Name = "btnAbrirFormProductos";
            btnAbrirFormProductos.Size = new Size(143, 46);
            btnAbrirFormProductos.TabIndex = 0;
            btnAbrirFormProductos.Text = "Productos";
            btnAbrirFormProductos.UseVisualStyleBackColor = false;
            btnAbrirFormProductos.Click += btnAbrirFormProductos_Click;
            // 
            // btnAbrirVentas
            // 
            btnAbrirVentas.BackColor = Color.Black;
            btnAbrirVentas.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAbrirVentas.ForeColor = Color.Gray;
            btnAbrirVentas.Location = new Point(539, 132);
            btnAbrirVentas.Name = "btnAbrirVentas";
            btnAbrirVentas.Size = new Size(143, 46);
            btnAbrirVentas.TabIndex = 1;
            btnAbrirVentas.Text = "Ventas";
            btnAbrirVentas.UseVisualStyleBackColor = false;
            btnAbrirVentas.Click += btnAbrirVentas_Click;
            // 
            // btnDetalleVenta
            // 
            btnDetalleVenta.BackColor = Color.Black;
            btnDetalleVenta.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold);
            btnDetalleVenta.ForeColor = Color.Gray;
            btnDetalleVenta.Location = new Point(319, 132);
            btnDetalleVenta.Name = "btnDetalleVenta";
            btnDetalleVenta.Size = new Size(163, 46);
            btnDetalleVenta.TabIndex = 2;
            btnDetalleVenta.Text = "Detalles de ventas";
            btnDetalleVenta.UseVisualStyleBackColor = false;
            btnDetalleVenta.Click += btnDetalleVenta_Click;
            // 
            // lBN
            // 
            lBN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lBN.AutoSize = true;
            lBN.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lBN.ForeColor = Color.YellowGreen;
            lBN.Location = new Point(268, 23);
            lBN.Name = "lBN";
            lBN.Size = new Size(286, 27);
            lBN.TabIndex = 3;
            lBN.Text = "DESCARTABLE LOS NOGALES";
            lBN.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(lBN);
            Controls.Add(btnDetalleVenta);
            Controls.Add(btnAbrirVentas);
            Controls.Add(btnAbrirFormProductos);
            Cursor = Cursors.AppStarting;
            ForeColor = Color.Red;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "DESCARTABLE LOS NOGALES";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAbrirFormProductos;
        private Button btnAbrirVentas;
        private Button btnDetalleVenta;
        private Label lBN;
    }
}
