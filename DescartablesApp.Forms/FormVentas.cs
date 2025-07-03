using DescartablesApp.API.Models;
using DescartablesApp.Shared.Models;
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

namespace DescartablesApp.Forms
{
    public partial class FormVentas : Form
    {
        private readonly HttpClient _http = new HttpClient { BaseAddress = new Uri("http://localhost:5292") };
        private List<Producto> _productos = new List<Producto>();
        private List<DetalleVentaTemp> _detalles = new List<DetalleVentaTemp>();

        public FormVentas()
        {
            InitializeComponent();
        }

        private async Task CargarProductosAsync()
        {
            _productos = await _http.GetFromJsonAsync<List<Producto>>("/api/productos");
            cmbProductos.DataSource = _productos;
            cmbProductos.DisplayMember = "Nombre";
            cmbProductos.ValueMember = "Id";
        }


        private async void FormVentas_Load(object sender, EventArgs e)
        {
            await CargarProductosAsync();
        }

        private void ActualizarTotal()
        {
            var total = _detalles.Sum(d => d.Subtotal);
            lblTotal.Text = $"Total: ${total:F2}";
        }


        private void btnAgregarAlCarrito_Click(object sender, EventArgs e)
        {
            var producto = (Producto)cmbProductos.SelectedItem;
            var cantidad = (int)nupCantidad.Value;

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a cero.");
                return;
            }

            var detalle = new DetalleVentaTemp
            {
                ProductoId = producto.Id,
                NombreProducto = producto.Nombre,
                PrecioUnitario = producto.PrecioVenta,
                Cantidad = cantidad
            };

            _detalles.Add(detalle);
            dgvDetalle.DataSource = null;
            dgvDetalle.DataSource = _detalles;

            ActualizarTotal();
        }

        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!_detalles.Any())
            {
                MessageBox.Show("Agrega al menos un producto.");
                return;
            }

            var venta = new Venta
            {
                FormaPago = cmbFormaPago.Text,
                Detalles = _detalles.Select(d => new DetalleVenta
                {
                    ProductoId = d.ProductoId,
                    PrecioUnitario = d.PrecioUnitario,
                    Cantidad = d.Cantidad,
                    Subtotal = d.Subtotal
                }).ToList()
            };

            var response = await _http.PostAsJsonAsync("/api/ventas", venta);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Venta registrada con éxito.");
                _detalles.Clear();
                dgvDetalle.DataSource = null;
                ActualizarTotal();
            }
            else
            {
                var error = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Error al registrar venta: " + error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {            
            if (dgvDetalle.SelectedRows.Count > 0)
            {
                var row = dgvDetalle.SelectedRows[0];
                var detalle = (DetalleVentaTemp)row.DataBoundItem;
                _detalles.Remove(detalle);
                dgvDetalle.DataSource = null;
                dgvDetalle.DataSource = _detalles;
                ActualizarTotal();
            }
            else
            {
                MessageBox.Show("Selecciona un producto para eliminar.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {            
            if (MessageBox.Show("¿Estás seguro de cancelar la venta?", "Cancelar Venta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _detalles.Clear();
                dgvDetalle.DataSource = null;
                ActualizarTotal();
                cmbProductos.SelectedIndex = -1;
                nupCantidad.Value = 1;
            }
        }
    }
}
