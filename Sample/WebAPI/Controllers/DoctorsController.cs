namespace WebAPI.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;

    using WebAPI.Models;

    public class DoctorsController : ApiController
    {
        public IEnumerable<Doctor> Get()
        {
            return ObjectCreator.GetDoctors();
        }
    }
}
