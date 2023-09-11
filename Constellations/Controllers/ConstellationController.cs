using Constellations.Interfaces;
using Constellations.Models;
using Microsoft.AspNetCore.Mvc;

namespace Constellations.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConstellationController : ControllerBase
    {
        private readonly IConstellationRepository _constellationRepository;
        private readonly IUnitOfWork _unitOfWork;
        public ConstellationController(IConstellationRepository constellationRepository, IUnitOfWork unitOfWork) 
        {
            _constellationRepository = constellationRepository;
            _unitOfWork = unitOfWork;

        }

        [HttpGet("id")]
        public IActionResult GetConstellation(int id) { return Ok(); }

        [HttpGet]
        public IActionResult GetAllConstellations() { return Ok(); }

        [HttpPost]
        public IActionResult PostConstellation(Constellation constellation) { return Ok(); }

        [HttpPut("id")]
        public IActionResult UpdateConstellation(Constellation constellation, int id) { return Ok(); }

        [HttpDelete("id")]
        public IActionResult DeleteConstellation(int id) { return Ok(); }
    }
}
