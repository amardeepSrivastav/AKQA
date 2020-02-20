using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BAL;


namespace APIProject.Controllers
{
    
    public class PersonController : ApiController
    {
        IPersons _persons;
        
        public PersonController(IPersons persons)
        {
            _persons = persons;
        }
        [Route("api/Persons/ConvertNumber/{Number}/{Name}")]
        [HttpGet]
        public IHttpActionResult ConvertNumber([FromUri]Persons persons)
        {
            ReturnPerson returnPerson = new ReturnPerson();
            returnPerson.ConvertedNumber = _persons.ConvertPersonNumber(persons.Number);
            returnPerson.Name = persons.Name;
            return Ok(returnPerson);
        }
    }
}
