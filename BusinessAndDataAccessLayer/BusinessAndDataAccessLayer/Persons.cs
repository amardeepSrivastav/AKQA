using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BAL
{
     
    public partial class Persons : IPersons
    {
        public string ConvertPersonNumber(int number)
        {
            return DAL.Persons.ConvertPersonNumber(number);
        }

    }
    public partial class Persons
    {
        public string Name { get; set; }
        public int Number { get; set; }
    }

}
