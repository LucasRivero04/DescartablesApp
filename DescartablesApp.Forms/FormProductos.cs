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

namespace DescartablesApp.Forms
{
    public partial class FormProductos : Form
    {
        private readonly HttpClient _http = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:5292") // tu API
        };
        public FormProductos()
        {
            InitializeComponent();
        }

        private async Task CrearProductoAsync(string nombre, decimal precioCosto, decimal precioVenta, int stock)
        {
            var producto = new Producto
            {
                Nombre = nombre,
                PrecioCosto = precioCosto,
                PrecioVenta = precioVenta,
                Stock = stock
            };
            {


                var response = await _http.PostAsJsonAsync("/api/productos", producto);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Producto creado correctamente.");
                    await ObtenerProductosAsync(); 
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Error al crear producto: " + error);
                }
            }
        }
        
        private async Task ObtenerProductosAsync()
        {
            try
            {
                var response = await _http.GetAsync("/api/productos");
                if (response.IsSuccessStatusCode)
                {
                    var productos = await response.Content.ReadFromJsonAsync<List<Producto>>();
                    if (productos != null)
                    {
                        dgvProductos.DataSource = productos;
                    }
                }
                else
                {
                    MessageBox.Show("Error al cargar productos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener productos: " + ex.Message);
            }
        }



        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtPrecioCosto.Clear();
            txtPrecioVenta.Clear();
            txtStock.Clear();
        }

        private async void btnCrearProducto_Click(object sender, EventArgs e)
        {            
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioCosto.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioVenta.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            if (!decimal.TryParse(txtPrecioCosto.Text, out var precioCosto) ||
                !decimal.TryParse(txtPrecioVenta.Text, out var precioVenta) ||
                !int.TryParse(txtStock.Text, out var stock))
            {
                MessageBox.Show("Por favor, ingrese valores válidos para los precios y el stock.");
                return;
            }

            if (precioCosto <= 0 || precioVenta <= 0 || stock < 0)
            {
                MessageBox.Show("Los precios deben ser mayores a cero y el stock no puede ser negativo.");
                return;
            }
            if (precioVenta < precioCosto)
            {
                MessageBox.Show("El precio de venta no puede ser menor que el precio de costo.");
                return;
            }
    
            await CrearProductoAsync(
                    txtNombre.Text,
                    decimal.Parse(txtPrecioCosto.Text),
                    decimal.Parse(txtPrecioVenta.Text),
                    int.Parse(txtStock.Text)
            );

            LimpiarCampos();
        }


        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void FormProductos_Load(object sender, EventArgs e)
        {
            try
            {
                await ObtenerProductosAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Mostrar los datos del producto seleccionado en los campos de texto
            if (e.RowIndex >= 0 && e.RowIndex < dgvProductos.Rows.Count)
            {
                var row = dgvProductos.Rows[e.RowIndex];
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtPrecioCosto.Text = row.Cells["PrecioCosto"].Value.ToString();
                txtPrecioVenta.Text = row.Cells["PrecioVenta"].Value.ToString();
                txtStock.Text = row.Cells["Stock"].Value.ToString();
            }
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            //Logica para modificar el producto seleccionado tomando los datos de los campos de texto
            if (dgvProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un producto para modificar.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioCosto.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioVenta.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            if (!decimal.TryParse(txtPrecioCosto.Text, out var precioCosto) ||
                !decimal.TryParse(txtPrecioVenta.Text, out var precioVenta) ||
                !int.TryParse(txtStock.Text, out var stock))
            {
                MessageBox.Show("Por favor, ingrese valores válidos para los precios y el stock.");
                return;
            }
            if (precioCosto <= 0 || precioVenta <= 0 || stock < 0)
            {
                MessageBox.Show("Los precios deben ser mayores a cero y el stock no puede ser negativo.");
                return;
            }
            if (precioVenta < precioCosto)
            {
                MessageBox.Show("El precio de venta no puede ser menor que el precio de costo.");
                return;
            }
            // Obtener el producto seleccionado
            var productoSeleccionado = dgvProductos.SelectedRows[0].DataBoundItem as Producto;
            if (productoSeleccionado != null)
            {
                // Actualizar los campos del producto seleccionado
                productoSeleccionado.Nombre = txtNombre.Text;
                productoSeleccionado.PrecioCosto = decimal.Parse(txtPrecioCosto.Text);
                productoSeleccionado.PrecioVenta = decimal.Parse(txtPrecioVenta.Text);
                productoSeleccionado.Stock = int.Parse(txtStock.Text);
                // Enviar la solicitud de actualización a la API
                var response = _http.PutAsJsonAsync($"/api/productos/{productoSeleccionado.Id}", productoSeleccionado).Result;
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Producto modificado correctamente.");
                    await ObtenerProductosAsync(); // Recargar productos
                    LimpiarCampos();
                }
                else
                {
                    var error = response.Content.ReadAsStringAsync().Result;
                    MessageBox.Show("Error al modificar el producto: " + error);
                }
            }
            else
            {
                MessageBox.Show("No se pudo encontrar el producto seleccionado.");
            }
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                btnCrearProducto.Enabled = false;
            }
            else
            {
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnCrearProducto.Enabled = true;
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            //Logica para eliminar el producto seleccionado
            if (dgvProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.");
                return;
            }
            var productoSeleccionado = dgvProductos.SelectedRows[0].DataBoundItem as Producto;
            if (productoSeleccionado != null)
            {
                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    var response = _http.DeleteAsync($"/api/productos/{productoSeleccionado.Id}").Result;
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Producto eliminado correctamente.");
                        await ObtenerProductosAsync(); // Recargar productos
                        LimpiarCampos();
                    }
                    else
                    {
                        var error = response.Content.ReadAsStringAsync().Result;
                        MessageBox.Show("Error al eliminar el producto: " + error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se pudo encontrar el producto seleccionado.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Logica para cancelar la operacion y limpiar los campos
            LimpiarCampos();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCrearProducto.Enabled = true;
            if (dgvProductos.SelectedRows.Count > 0)
            {
                dgvProductos.ClearSelection(); // Deseleccionar cualquier fila seleccionada
            }

        }
    }
}
