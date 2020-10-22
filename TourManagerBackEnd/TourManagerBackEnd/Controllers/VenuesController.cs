using System;
using System.Linq;
using Data.Core.Configuration;
using Data.Core.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TourManagerBackEnd.ApiModels;

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
        [Route("showvenues")]
        public dynamic ShowVenues()
        {
            return _tourManagerContext.Venues.ToList();
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("addvenue")]
        public dynamic AddVenue(VenueModel values)
        {            
            var Venues = new Venues();

            Venues.Address = values.Address;
            Venues.contactPersons = values.ContactPersons;
            Venues.curfView = DateTime.Now;
            Venues.loadIn = DateTime.Now;
            Venues.Name = values.Name;
            Venues.TelefonNumber = values.Number;            

            _tourManagerContext.Venues.Add(Venues);
            _tourManagerContext.SaveChanges();
            return values;
        }
        
        
        [AllowAnonymous]
        [HttpGet]
        [Route("DeleteVenue")]
        public dynamic DeleteVenue(int id)
        {            
            var entity = _tourManagerContext.Venues.SingleOrDefault(x => x.Id == id);
            _tourManagerContext.Remove(entity);
            _tourManagerContext.SaveChanges();
            
            return true;
        }
        
        
        [AllowAnonymous]
        [HttpPost]
        [Route("UpdateVenue")]
        public dynamic UpdateVenue(VenueModel values)
        {            
            var Venues = new Venues();
            Venues.Address = values.Address;
            Venues.contactPersons = values.ContactPersons;
            Venues.curfView = DateTime.Now;
            Venues.loadIn = DateTime.Now;
            Venues.Name = values.Name;
            Venues.TelefonNumber = values.Number;
            Venues.Id = values.Id;
            _tourManagerContext.Venues.Update(Venues);
            _tourManagerContext.SaveChanges();
            return values;
        }
        
        
        [AllowAnonymous]
        [HttpGet]
        [Route("GetVenuewInformation")]
        public dynamic GetVenuewInformation(int id)
        {
            return _tourManagerContext.Venues.SingleOrDefault(x => x.Id == id);
        }
    }
}