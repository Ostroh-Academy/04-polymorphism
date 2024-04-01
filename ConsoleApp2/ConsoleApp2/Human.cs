namespace ConsoleApp2;

internal class Human
{
    public Human(string firstName, string middleName, string lastName, DateOnly birthDate)
    {
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
        BirthDate = birthDate;
    }
    
    public static Human CreateHuman(string firstName, string middleName, string lastName, DateOnly birthDate)
    {
        return new Human(firstName, middleName, lastName, birthDate);
    }

    public Guid Id { get; init; } = Guid.NewGuid();
    public string FirstName { get; private set; }
    public string MiddleName { get; private set; }
    public string LastName { get; private set; }
    public DateOnly BirthDate { get; private set; }

    public void UpdateData(string firstName, string middleName, string lastName, DateOnly updBirthDate)
    {
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
        BirthDate = updBirthDate;
    }

    public int GetHumanAge()
    {
        var currentDate = DateTime.UtcNow.Date;
        return currentDate.Year - BirthDate.Year;
    }

    public int GetLetterMatchesAmountFromLastName(char letter)
    {
        return LastName.Count(t => t == letter);
    }

    public override string ToString()
    {
        return $"\nFirstName: {FirstName}" +
               $"\nMiddleName: {MiddleName}" +
               $"\nLastName: {LastName}" +
               $"\nBirthDate: {BirthDate}";
    }
}