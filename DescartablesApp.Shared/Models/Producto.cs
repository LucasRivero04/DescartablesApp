﻿namespace DescartablesApp.API.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioCosto { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
    }
}
