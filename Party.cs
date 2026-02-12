namespace knightmoves;
public class Party
{
    // Add your code here
    public class Person{
        public string firstName;
        public string lastName;

        public Person(public string firstName { get; }, public string lastName { get; }){
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
    public Person[] Guests { get; } = new Person[]{
        new Person("Abdul", "Ahmed")
        new Person("Name", "Last")
        new Person("Ramsey", "Freeman")
    }
}















