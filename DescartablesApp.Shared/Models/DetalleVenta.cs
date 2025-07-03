using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.Text.Json.Serialization;

namespace DescartablesApp.API.Models
{
    public class DetalleVenta
    {
        public int Id { get; set; }
        public int VentaId { get; set; }
        public int ProductoId { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }

        // Relaciones 
        //[JsonIgnore]
        [ValidateNever]
        public Venta Venta { get; set; } //Una venta puede tener muchos detalles
        //[JsonIgnore]
        [ValidateNever]
        public Producto Producto { get; set; } //Un detalle pertenece a un producto
    }
}
