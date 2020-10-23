using Data.Core.Configuration;
using Data.Core.Domain;
using TourManagerLogic.ApiModels;

namespace TourManagerLogic.Core.Api
{
    public class CustomersApi
    {
        private readonly TourManagerContext _tourManagerContext;

        public CustomersApi(TourManagerContext tourManagerContext)
        {
            _tourManagerContext = tourManagerContext;
        }


        public void Add(ContactsModel values)
        {
            var contacts = new Contacts();

            contacts.Address = values.Address;
            contacts.Email = values.Email;
            contacts.FirstName = values.FirstName;
            contacts.LastName = values.LastName;
            contacts.TelefonNumber = values.TelefonNumber;

            _tourManagerContext.Contacts.Add(contacts);
            _tourManagerContext.SaveChanges();
            
        }
    }
}