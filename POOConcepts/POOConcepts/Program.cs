using POOConcepts;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");

Employee employee1 = new SalaryEmployee()
{
    Id = 3011,
    Frisname = "Dubraska",
    LastName = "Pimentel",
    Birthday = new Date(1986, 9, 7),
    HiringDate = new Date(2007, 10, 21),
    IsActive = true,
    Salary = 1815453.45M,
};
Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee()
{
    Id = 1011,
    Frisname = "Anais",
    LastName = "Mendoza",
    Birthday = new Date(2010, 11, 11),
    HiringDate = new Date(2020, 3, 29),
    IsActive = true,
    Sales = 320000000M,
    CommissionPersentaje = 0.03F,
};
Console.WriteLine(employee2);
//try
//{
//	Console.WriteLine(new Date(2024, 2, 29));
//	Console.WriteLine(new Date(1984, 3, 29));
//	Console.WriteLine(new Date(1986, 9, 7));
//    Console.WriteLine(new Date(2010, 11, 30));
//}
//catch (Exception erro)
//{
//	Console.WriteLine(erro.Message);
//}