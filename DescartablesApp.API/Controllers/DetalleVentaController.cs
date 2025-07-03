using DescartablesApp.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DescartablesApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DetalleVentasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DetalleVentasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/detalleventas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DetalleVenta>>> ObtenerTodos()
        {
            return await _context.DetallesVenta
                .Include(d => d.Producto)
                .Include(d => d.Venta)
                .ToListAsync();
        }

        // GET: api/detalleventas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DetalleVenta>> ObtenerPorId(int id)
        {
            var detalle = await _context.DetallesVenta
                .Include(d => d.Producto)
                .Include(d => d.Venta)
                .FirstOrDefaultAsync(d => d.Id == id);

            if (detalle == null)
                return NotFound();

            return detalle;
        }

        // GET: api/detalleventas/porventa/3
        [HttpGet("porventa/{ventaId}")]
        public async Task<ActionResult<IEnumerable<DetalleVenta>>> ObtenerPorIdVenta(int ventaId)
        {
            var detalles = await _context.DetallesVenta
                .Where(d => d.VentaId == ventaId)
                .Include(d => d.Producto)
                .ToListAsync();

            return detalles;
        }
    }

}
