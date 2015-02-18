namespace WebAPI.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;

    using WebAPI.Models;

    public class PatientsController : ApiController
    {
        public IEnumerable<Patient> Get()
        {
            return ObjectCreator.GetPatients();
        }
    }
}
