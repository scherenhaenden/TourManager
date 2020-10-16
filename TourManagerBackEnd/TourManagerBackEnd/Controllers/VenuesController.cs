using Data.Core.Configuration;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TourManagerBackEnd.Controllers
{
    [ApiController]
    [Route("apipublic/[controller]")]
    public class VenuesController : ControllerBase
    {
        private readonly TourManagerContext _tourManagerContext;

        public VenuesController(
            TourManagerContext tourManagerContext
        )
        {
            _tourManagerContext = tourManagerContext;            
        }


        [AllowAnonymous]
        [HttpPost]
        [Route("addvenue")]
        public void AddVenue(dynamic values)
        {
            
        }
    }
}