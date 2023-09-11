using Constellations.Data;
using Constellations.Interfaces;
using Constellations.Models;
using Microsoft.AspNetCore.Mvc;

namespace Constellations.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StarController : ControllerBase
    {
        private readonly IStarRepository _starRepository;
        private readonly ISpectralClassificationRepository _spectrumClassificationRepository;
        private readonly IUnitOfWork _unitOfWork;
        public StarController(
            IStarRepository starRepository, 
            IUnitOfWork unitOfWork,
            ISpectralClassificationRepository spectralClassificationRepository)
        {

            _starRepository = starRepository;
            _spectrumClassificationRepository = spectralClassificationRepository;
            _unitOfWork = unitOfWork;

        }

        private IActionResult NotFoundResponse(string entityName)
        {
            return NotFound($"{entityName} not found");
        }

        [HttpGet("id")]
        public IActionResult GetStar(int id) 
        {
            Star star = _starRepository.GetById(id);

            if(star == null)
            {
                return NotFoundResponse("Star");
            }

            return Ok(star); 
        }

        [HttpGet]
        public IActionResult GetAllStars() 
        {
            return Ok(_starRepository.GetAll()); 
        }

        [HttpPost]
        public IActionResult PostStar(StarDto star) 
        {
            if (star == null)
            {
                return BadRequest("Request body cannot be empty.");
            }



            if (!ModelState.IsValid)
            {
                return BadRequest("Model not valid");

            }
            return Ok();


        }

        [HttpPut("id")]
        public IActionResult UpdateStar(StarDto star, int id) { return Ok(); }

        [HttpDelete("id")]
        public IActionResult DeleteStar(int id) 
        {
            Star star = _starRepository.GetById(id);
            
            if(star == null)
            {
                return NotFoundResponse("Star");
            }
            
            _starRepository.Remove(star);
            return Ok();
        }

    }
}
