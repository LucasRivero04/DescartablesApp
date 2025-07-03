namespace DescartablesApp.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrirFormProductos_Click(object sender, EventArgs e)
        {
            //Abr el formulario de productos
            var formProductos = new FormProductos();
            formProductos.ShowDialog();
        }

        private void btnAbrirVentas_Click(object sender, EventArgs e)
        {
            var formVentas = new FormVentas();
            formVentas.ShowDialog();
        }

        private void btnDetalleVenta_Click(object sender, EventArgs e)
        {
            var formDetalleVenta = new FormDetalleVenta();
            formDetalleVenta.ShowDialog();
        }
    }
}
