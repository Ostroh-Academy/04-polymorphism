namespace ConsoleApp2;

internal class Student(string firstName, string middleName, string lastName, DateOnly birthDate, int entryYear)
    : Human(firstName, middleName, lastName, birthDate)
{
    public int EntryYear { get; private set; } = entryYear;

    public static Student CreateStudent(string firstName, string middleName, string lastName, DateOnly birthDate,
        int entryYear)
    {
        return new Student(firstName, middleName, lastName, birthDate, entryYear);
    }

    // public override void UpdateData(string firstName, string middleName, string lastName, DateOnly updBirthDate)
    // {
    //     base.UpdateData(firstName, middleName, lastName, updBirthDate);
    //     Console.WriteLine("Enter the entry year: ");
    //     var year = int.Parse(Console.ReadLine());
    //     EntryYear = year;
    // }

    public override string ToString()
    {
        return base.ToString() + $"\nEntryDate: {EntryYear}";
    }
}