using DescartablesApp.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DescartablesApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VentasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public VentasController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Venta>> CrearVenta(Venta venta)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                venta.Fecha = DateTime.Now;
                venta.Total = venta.Detalles.Sum(d => d.Subtotal);

                _context.Ventas.Add(venta);
                await _context.SaveChangesAsync();

                // Descontar stock
                foreach (var item in venta.Detalles)
                {
                    var producto = await _context.Productos.FindAsync(item.ProductoId);
                    if (producto == null) return BadRequest($"Producto ID {item.ProductoId} no existe");
                    if (producto.Stock < item.Cantidad) return BadRequest($"Stock insuficiente para {producto.Nombre}");

                    producto.Stock -= item.Cantidad;
                }

                await _context.SaveChangesAsync();
                await transaction.CommitAsync();

                return CreatedAtAction(nameof(ObtenerVenta), new { id = venta.Id }, venta);
            }
            catch
            {
                await transaction.RollbackAsync();
                return StatusCode(500, "Error al registrar la venta.");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Venta>> ObtenerVenta(int id)
        {
            var venta = await _context.Ventas
                .Include(v => v.Detalles)
                .ThenInclude(d => d.Producto)
                .FirstOrDefaultAsync(v => v.Id == id);

            if (venta == null) return NotFound();
            return venta;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Venta>>> ListarVentas()
        {
            return await _context.Ventas
                .Include(v => v.Detalles)
                .ThenInclude(d => d.Producto)
                .OrderByDescending(v => v.Fecha)
                .ToListAsync();
        }
    }

}
