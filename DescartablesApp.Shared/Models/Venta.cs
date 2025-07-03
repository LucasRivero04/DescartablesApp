using System.Text.Json.Serialization;

namespace DescartablesApp.API.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public string FormaPago { get; set; }

        // Relaciones
        
        public List<DetalleVenta> Detalles { get; set; }
    }
}
