using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Repositories;

namespace NZWalks.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WalksController : Controller
    {
        private readonly IMapper mapper;
        private readonly IWalkRepository walkRepository;

        public WalksController(IWalkRepository walkRepository,IMapper mapper)
        {
            this.mapper = mapper;
            this.walkRepository = walkRepository;
        }

        [HttpGet]
       public async Task<IActionResult> GetAllWalks()
        {
            // fetch data from db - domain walk
            var walksDomain = await walkRepository.GetAllAsync();

            // convert domain walks to dto walks
            var walksDTO = mapper.Map<List<Models.DTO.Walk>>(walksDomain);
            // return response
            return Ok(walksDTO);

        }
    }
}
