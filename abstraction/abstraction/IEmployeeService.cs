using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
    internal interface IEmployeeService
    {
        Employee[] GetAll();
        Employee[] FilterByAddress(string address);
    }
}
