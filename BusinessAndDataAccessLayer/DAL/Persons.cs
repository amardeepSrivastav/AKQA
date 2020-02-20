using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class Persons
    {
        public static string ConvertPersonNumber(int number)
        {
            return Repository.NumberToText(number);
        }
    }
}
