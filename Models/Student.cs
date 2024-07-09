namespace Models;

public class Student
{

    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime BDate { get; set; }
    public int Score { get; set; }
    public Student()
    {
        
    }
    public Student(string name, string surname, DateTime bDate, int score)
    {
        Name = name;
        Surname = surname;
        BDate = bDate;
        Score = score;
    }
    public override string ToString()
    => $"{Name} - {Surname} - {BDate.ToShortDateString()} - {Score}\n";
}
