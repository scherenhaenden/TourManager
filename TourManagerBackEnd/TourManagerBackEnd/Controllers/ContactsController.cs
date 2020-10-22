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
    public class ContactsController : ControllerBase
    {
        private readonly TourManagerContext _tourManagerContext;

        public ContactsController(
            TourManagerContext tourManagerContext
        )
        {
            _tourManagerContext = tourManagerContext;            
        }     
        
        
        [AllowAnonymous]
        [HttpPost]
        [Route("Add")]
        public dynamic Add(ContactsModel values)
        {            
            var contacts = new Contacts();

            contacts.Address = values.Address;
            contacts.Email = values.Email;
            contacts.FirstName = values.FirstName;
            contacts.LastName = values.LastName;
            contacts.TelefonNumber = values.TelefonNumber;

            _tourManagerContext.Contacts.Add(contacts);
            _tourManagerContext.SaveChanges();
            return values;
        }
        
        [AllowAnonymous]
        [HttpGet]
        [Route("ShowEntities")]
        public dynamic ShowVenues()
        {
            return _tourManagerContext.Contacts.ToList();
        }
        
      
    }
}