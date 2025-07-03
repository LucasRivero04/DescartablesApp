using DescartablesApp.API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace DescartablesApp.Forms
{
    public partial class FormDetalleVenta : Form
    {
        private readonly HttpClient _http = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:5292")
        };
        public FormDetalleVenta()
        {
            InitializeComponent();
        }

        private void FormDetalleVenta_Load(object sender, EventArgs e)
        {
            dgvVentas.DataSource = ObtenerVentasAsync();
        }
        
        private async Task ObtenerVentasAsync()
        {
            try
            {
                var response = await _http.GetAsync("/api/ventas");
                if (response.IsSuccessStatusCode)
                {
                    var ventas = await response.Content.ReadFromJsonAsync<List<Venta>>();
                    if (ventas != null)
                    {
                        dgvVentas.DataSource = ventas;
                    }
                }
                else
                {
                    MessageBox.Show("Error al cargar ventas.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener ventas: " + ex.Message);
            }
        }

        private async void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (dgvVentas.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná una venta.");
                return;
            }

            int ventaId = (int)dgvVentas.CurrentRow.Cells["Id"].Value;

            var venta = await _http.GetFromJsonAsync<Venta>($"/api/ventas/{ventaId}");
            if (venta != null)
            {
                var formTicket = new FormTicketVenta(venta);
                formTicket.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se pudo obtener el detalle.");
            }
        }

        private void btnBuscarVentaPorId_Click(object sender, EventArgs e)
        {            
            if (string.IsNullOrWhiteSpace(txtIdVenta.Text))
            {
                MessageBox.Show("Ingrese un ID de venta.");
                return;
            }
            if (int.TryParse(txtIdVenta.Text, out int ventaId))
            {
                var venta = _http.GetFromJsonAsync<Venta>($"/api/ventas/{ventaId}").Result;
                if (venta != null)
                {
                    dgvVentas.DataSource = new List<Venta> { venta };
                }
                else
                {
                    MessageBox.Show("Venta no encontrada.");
                }
            }
            else
            {
                MessageBox.Show("ID de venta inválido.");
            }

        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            dgvVentas.DataSource = ObtenerVentasAsync();
        }
    }
}
