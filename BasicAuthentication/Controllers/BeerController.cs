using BasicAuthentication.Models;
using BasicAuthentication.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasicAuthentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
   
  
    public class BeerController : ControllerBase
    {
        private readonly IBeerServices _beerServices;
           
        public BeerController(IBeerServices beerServices)
        {
            _beerServices = beerServices;

        }


        [HttpGet]
        public async Task<IEnumerable<Beer>> Get() => await _beerServices.Get();
        
    }
}
