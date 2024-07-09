namespace Models;

public class Debtor
{

    public string FullName { get; set; }
    public DateTime Birthday { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public int Debt { get; set; }
    public Debtor(string fullName, DateTime birthday, string phone, string email, string address, int debt)
    {
        FullName = fullName;
        Birthday = birthday;
        Phone = phone;
        Email = email;
        Address = address;
        Debt = debt;
    }

    public override string ToString()
    => $"{FullName} - {Birthday.ToShortDateString()}-{Phone}-{Email}-{Address}-{Debt}";

}
