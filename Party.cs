namespace knightmoves;
public class Party
{
    // Add your code here
    public class Person{
        
        public string FirstName { get; }
        public string LastName { get; }

        public Person(string firstName, string lastName){
            this.firstName = FirstName;
            this.lastName = LastName;
        }
    }
    public Person[] Guests { get; } = new Person[]{
        new Person("Abdul", "Ahmed"),
        new Person("Name", "Last"),
        new Person("Ramsey", "Freeman");
    }
}






















