using System.Text;
using ConsoleApp2;

Console.OutputEncoding = Encoding.Unicode;

Console.WriteLine($"Оберіть опцію:" +
                  $"\n1 - Human" +
                  $"\n2 - Student");

var key = Console.ReadKey().Key;

var human = key switch
{
    ConsoleKey.D1 => Human.CreateHuman("some", "funny", "human", new DateOnly(1984, 10, 31)),
    ConsoleKey.D2 => Student.CreateStudent("very", "cool", "student", new DateOnly(2004, 01, 04), 2021),
    _ => throw new ArgumentException("You've picked a wrong option")
};

Console.WriteLine(human);

Console.WriteLine($"\nHuman properties:" +
                  $"\nAge: {human.GetHumanAge()}" +
                  $"\nLetters amount: {human.GetLetterMatchesAmountFromLastName('u')}");
                  
human.UpdateData("test", "update", "data", human.BirthDate);

Console.WriteLine(human);