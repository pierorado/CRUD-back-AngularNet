using BE_CRUDMASCOTAS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BE_CRUDMascotas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MascotaController : ControllerBase{

        private readonly AplicationDbContext _context;
        public MascotaController(AplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Get(){
            try
            {
                var listMascotas = await _context.Mascotas.ToListAsync();
                return  Ok(listMascotas);
            }
            catch (Exception ex)
            {
                
                return BadRequest(ex.Message);
            }
           
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var mascota = await _context.Mascotas.FindAsync(id);
                if (mascota == null)
                {
                    return NotFound();
                }
                return Ok(mascota);
            }
            catch (Exception ex)
            {
                
                return BadRequest(ex.Message);
            }
        }
    }
}