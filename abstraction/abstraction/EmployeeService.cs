using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
    internal class EmployeeService : IEmployeeService

    {
        private Employee[] employees;

        public EmployeeService()
        {
            employees = new Employee[]
            {
            new Employee { FullName = "Tahir Məmmədov", Address = "Bakı", Email = "tahir@mail.com", Age = 23, Phone = "0501234567" },
            new Employee { FullName = "Əli Əliyev", Address = "Gəncə", Email = "eli@mail.com", Age = 30, Phone = "0519876543" },
             new Employee { FullName = "mezahir elestunov", Address = "Bakı", Email = "mezi@mail.com", Age = 50, Phone = "0555555555" },
            new Employee { FullName = "Aysel Həsənova", Address = "Sumqayıt", Email = "aysel@mail.com", Age = 27, Phone = "0701122334" }
            };
        }

        public Employee[] GetAll()
        {
            return employees;
        }
        public Employee[] FilterByAddress(string address)
        {
            int count = 0;

            foreach (var emp in employees)
            {
                if (emp.Address == address)
                {
                    count++;
                }
            }

            Employee[] filtered = new Employee[count];
            int index = 0;

            foreach (var emp in employees)
            {
                if (emp.Address == address)
                {
                    filtered[index] = emp;
                    index++;
                }
            }

            return filtered;
        }
        public Employee[] SearchByFullName(string fullNamePart)
        {
            int count = 0;

            foreach (var emp in employees)
            {
                if (emp.FullName.Contains(fullNamePart))
                {
                    count++;
                }
            }

            Employee[] filtered = new Employee[count];
            int index = 0;

            foreach (var emp in employees)
            {
                if (emp.FullName.Contains(fullNamePart))
                {
                    filtered[index] = emp;
                    index++;
                }
            }

            return filtered;
        }
        public Employee[] SortByAge()
        {
            Employee[] sorted = new Employee[employees.Length];
            for (int i = 0; i < employees.Length; i++)
            {
                sorted[i] = employees[i];
            }

            for (int i = 0; i < sorted.Length - 1; i++)
            {
                for (int j = 0; j < sorted.Length - i - 1; j++)
                {
                    if (sorted[j].Age > sorted[j + 1].Age)
                    {
                        Employee temp = sorted[j];
                        sorted[j] = sorted[j + 1];
                        sorted[j + 1] = temp;
                    }
                }
            }

            return sorted;
        }


    }
}
