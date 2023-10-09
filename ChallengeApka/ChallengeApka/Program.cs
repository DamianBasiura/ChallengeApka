using ChallengeApka;
using System.ComponentModel.Design;

Employee employee1 = new Employee("Ewa", "Farna", 33);
Employee employee2 = new Employee("Grzegorz", "Mordka", 76);
Employee employee3 = new Employee("Damian", "Kowalski", 65);

employee1.AddScore(9);
employee2.AddScore(2);
employee3.AddScore(2);

employee1.AddScore(6);
employee2.AddScore(8);
employee3.AddScore(9);

employee1.AddScore(2);
employee2.AddScore(4);
employee3.AddScore(3);

employee1.AddScore(9);
employee2.AddScore(8);
employee3.AddScore(2);

employee1.AddScore(1);
employee2.AddScore(1);
employee3.AddScore(2);

var result = employee1.Result;
Console.WriteLine(employee1.imie + " " + " ==>>" + " " + result);
var result2 = employee2.Result;
Console.WriteLine(employee2.imie + " " + " ==>>" + " " + result2);
var result3 = employee3.Result;
Console.WriteLine(employee3.imie + " " + " ==>>" + " " + result3);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee userWithMaxResult = null;

foreach(var employee in employees)
{
    if (employee.Result > maxResult)
    { 
        userWithMaxResult = employee; 
        maxResult = employee.Result;
    }
}
Console.WriteLine(userWithMaxResult.imie + " " + userWithMaxResult.nazwisko + " " + "w wieku" + " " + userWithMaxResult.wiek + " " + "lat" + " " + "zdobyła najwięcej" + " " + userWithMaxResult.Result + " " + "punktów.");





