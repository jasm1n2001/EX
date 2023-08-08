namespace task1;

public class Employee
{
    int _id;
    string _firstName;
    string _lastName;
    int _salary;

    public Employee(int id, string firstName, string lastName, int salary)
    {
        _id = id;
        _firstName = firstName;
        _lastName = lastName;
        _salary = salary;
    }

    public int GetId()
    {
        return _id;

    }

    public string GetFirstName()
    {
        return $"Firsr Name: {_firstName}";

    }

    public string GetLastName()
    {
        return $"Last Name: {_lastName}";

    }
     
     public string Name()
     {
        return $"{_firstName} {_lastName}";
     }

     public int Salary()
     {
        return _salary;
     }

     public void Salary(int salary)
     {
        _salary = salary;
     }

     public int GetAnnualSalary()
     {
        return _salary*12;
     }
     public int RaiseSalary(int perecent, double sl)
     {
        sl = _salary * perecent / 100;

        return _salary + sl;
     }

     public override string ToSring()
     {
        return $"Employee: {_id}, name: {_firstName} {_lastName}, salary: {_salary} )";
     }

}
