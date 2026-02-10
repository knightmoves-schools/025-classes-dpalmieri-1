namespace knightmoves;
public class Party
{
    // Add your code here
    public class Person{
        public string firstName;
        public string lastName;

        public Person(string firstName, string lastName){
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
    Person[] Guests = new Person[]{
        new Person("Abdul", "Ahmed"),
        new Person("Name", "Last"),
        new Person("Ramsey", "Freeman")
    };
}







