namespace knightmoves;
public class Party
{
    // Add your code here
    public class Person{
        public string firstName;
        public string lastName;

        public Person(public string FirstName { get; }, public string LastName { get; }){
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
    public Person[] Guests { get; } = new Person[]{
        new Person("Abdul", "Ahmed"),
        new Person("Name", "Last"),
        new Person("Ramsey", "Freeman"),
    }
}
















