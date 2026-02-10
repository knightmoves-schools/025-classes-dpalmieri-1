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
    public string[] Guests{
        Person person1 = new Person("Abdul", "Ahmed");
        Person person2 = new Person("Name", "Last");
        Person person3 = new Person("Ramsey", "Freeman");
        
        return Guests;
    }
}

