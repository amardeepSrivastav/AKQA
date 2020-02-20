using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI.Models.Person
{
    public interface IPersonService
    {
        PersonViewModel getConvertedNumber(Person person);
    }
}