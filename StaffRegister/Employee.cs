namespace StaffRegister;

/// <summary>
/// Stores data for an employee.
/// </summary>
/// <param name="name">Employee name</param>
/// <param name="salary">Employee salary</param>
public class Employee(string name, int salary)
{
    public string Name { get; private set; } = name;
    public int Salary { get; private set; } = salary;
    public SalaryLevel SalaryLevel
    {
        get
        {
            if(Salary < 25000)
                return SalaryLevel.Junior;
            else
                return SalaryLevel.Senior;
        }
    }

    /// <summary>
    /// Returns a string with the format:
    /// Name: {Name} Salary: {Salary}
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return $"Name: {Name} Salary: {Salary} Salary level: {SalaryLevel}";
    }
}
