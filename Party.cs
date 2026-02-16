namespace knightmoves;
public class Party
{
    public Person[] Guests{ get; } =
    {
        new Person("First","Guest"),
        new Person("Second","Guest"),
        new Person("Third","Guest")
    };
};
public class Person
{
   public string FirstName { get; }
   public string LastName { get; }
   public Person(string firstName, string lastName)
   {
        FirstName = firstName;
        LastName = lastName;
   }
};




















