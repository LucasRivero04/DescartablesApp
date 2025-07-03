namespace DescartablesApp.Forms
{
    partial class FormTicketVenta
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
            txtTicket = new TextBox();
            SuspendLayout();
            // 
            // txtTicket
            // 
            txtTicket.Dock = DockStyle.Fill;
            txtTicket.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTicket.Location = new Point(0, 0);
            txtTicket.Multiline = true;
            txtTicket.Name = "txtTicket";
            txtTicket.ReadOnly = true;
            txtTicket.ScrollBars = ScrollBars.Vertical;
            txtTicket.Size = new Size(551, 327);
            txtTicket.TabIndex = 0;
            // 
            // FormTicketVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 327);
            Controls.Add(txtTicket);
            Name = "FormTicketVenta";
            Text = "FormTicketVenta";
            Load += FormTicketVenta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTicket;
    }
}