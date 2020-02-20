using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Configuration;
using UI.Utility;

namespace UI.Models.Person
{
    public class PersonService : IPersonService
    {
        public PersonViewModel getConvertedNumber(Person person)
        {
            PersonViewModel personViewModel = new PersonViewModel();
            var baseURl = ConfigurationManager.AppSettings["ApiURL"];
            personViewModel =  MicroServiceHelper.GetAsyncSingle<PersonViewModel>(baseURl, "api/Persons/ConvertNumber/" + person.Number + "/" + person.Name);
            
            return personViewModel;
        }
    }
}