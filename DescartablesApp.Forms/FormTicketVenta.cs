using DescartablesApp.API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DescartablesApp.Forms
{
    public partial class FormTicketVenta : Form
    {
        public FormTicketVenta(Venta venta)
        {
            InitializeComponent();
            MostrarTicket(venta);
        }

        private void FormTicketVenta_Load(object sender, EventArgs e)
        {

        }

        private void MostrarTicket(Venta venta)
        {
            var sb = new StringBuilder();
            sb.AppendLine("== COMPROBANTE DE VENTA ==");
            sb.AppendLine($"Fecha: {venta.Fecha}");
            sb.AppendLine($"Forma de pago: {venta.FormaPago}");
            sb.AppendLine(new string('-', 60));
            sb.AppendLine($"{"Producto",-30} {"Cant",5} {"P.Unit",10} {"Subtotal",10}");

            foreach (var d in venta.Detalles)
            {
                string nombre = d.Producto?.Nombre ?? "Producto";
                if (nombre.Length > 30)
                    nombre = nombre.Substring(0, 27) + "..."; // recortamos si es muy largo

                sb.AppendLine($"{nombre,-30} {d.Cantidad,5} {d.PrecioUnitario,10:C} {d.Subtotal,10:C}");
            }

            sb.AppendLine(new string('-', 60));
            sb.AppendLine($"{"TOTAL:",-45}{venta.Total,15:C}");

            txtTicket.Text = sb.ToString();
        }

    }
}
