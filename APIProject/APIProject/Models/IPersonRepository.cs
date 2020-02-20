using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIProject.Models
{
    public interface IPersonRepository
    {
        string ConvertPersonNumber(int number);
    }
}
