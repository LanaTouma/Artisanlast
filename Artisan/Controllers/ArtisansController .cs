using Microsoft.AspNetCore.Mvc;

using Artisan.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using Artisan.Application.ArtisansAppService;

namespace Artisan.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArtisansController : ControllerBase
    {
        private readonly IArtisanService _artisanService;

        public ArtisansController(IArtisanService artisanService)
        {
            _artisanService = artisanService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Artisans>>> GetAllArtisans()
        {
            var artisans = await _artisanService.GetAllAsync();
            return Ok(artisans);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Artisans>> GetArtisanById(int id)
        {
            var artisan = await _artisanService.GetByIdAsync(id);
            if (artisan == null)
            {
                return NotFound();
            }
            return Ok(artisan);
        }

        [HttpPost]
        public async Task<ActionResult> AddArtisan(Artisans artisan)
        {
            await _artisanService.AddAsync(artisan);
            return CreatedAtAction(nameof(GetArtisanById), new { id = artisan.ArtisanId }, artisan);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateArtisan(int id, Artisans artisan)
        {
            if (id != artisan.ArtisanId)
            {
                return BadRequest();
            }

            await _artisanService.UpdateAsync(artisan);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArtisan(int id)
        {
            await _artisanService.DeleteAsync(id);
            return NoContent();
        }
    }
}
