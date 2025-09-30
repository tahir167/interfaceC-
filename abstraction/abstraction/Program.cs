using abstraction;

IEmployeeService employeeService = new EmployeeService();

Employee[] allEmployees = employeeService.GetAll();

foreach (var emp in allEmployees)
{
    Console.WriteLine($"FullName: {emp.FullName}, Email: {emp.Email}, Age: {emp.Age}, Phone: {emp.Phone}");
}

Console.WriteLine("\n== Bakı işçiləri ==");
foreach (var emp in employeeService.FilterByAddress("Bakı"))
{
    Console.WriteLine($"FullName: {emp.FullName}, Address: {emp.Address}, Email: {emp.Email}");
}


Console.WriteLine("\n== Axtarış: 'Tahir' ==");

foreach (var emp in employeeService.SearchByFullName("Tahir"))
{
    Console.WriteLine($"FullName: {emp.FullName}, Address: {emp.Address}, Email: {emp.Email}");
}

Console.WriteLine("\n== Yaşa görə sıralanmış işçilər ==");

foreach (var emp in employeeService.SortByAge())
{
    Console.WriteLine($"FullName: {emp.FullName}, Age: {emp.Age}, Address: {emp.Address}");
}
