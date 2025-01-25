class MainClass
{
    static void Main(string[] args)
    {
        // Creating four Person objects
        Person person1 = new Person(1, "Ian", "Brooks", "Red", 30, true);
        Person person2 = new Person(2, "Gina", "James", "Green", 18, false);
        Person person3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
        Person person4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);

        // Display Gina's information
        Console.WriteLine($"{person2.PersonId}: {person2.FirstName} {person2.LastName}'s favorite colour is {person2.FavoriteColour}");

        // Display all of Mike's information
        Console.WriteLine(person3.ToString());

        person1.ChangeFavoriteColour(); // Change Ian's favorite color & display his information
        Console.WriteLine($"{person1.PersonId}: {person1.FirstName} {person1.LastName}'s favorite colour is: {person1.FavoriteColour}");

        Console.WriteLine($"{person4.FirstName} {person4.LastName}'s Age in 10 years is: {person4.GetAgeInTenYears()}"); // Display Mary's age in 10 years

        Relation relation1 = new Relation("Sisterhood");    // Relation objects 
        relation1.ShowRelationShip(person2, person4);

        Relation relation2 = new Relation("Brotherhood");
        relation2.ShowRelationShip(person1, person3);

        List<Person> peopleList = new List<Person> { person1, person2, person3, person4 };  // Add all Person objects to a list

        // Display average age
        double averageAge = peopleList.Average(p => p.Age); 
        Console.WriteLine($"Average age is: {averageAge}");

        // Find the youngest and oldest person
        Person youngest = peopleList.OrderBy(p => p.Age).First();
        Person oldest = peopleList.OrderByDescending(p => p.Age).First();
        Console.WriteLine($"The youngest person is: {youngest.FirstName}");
        Console.WriteLine($"The oldest person is: {oldest.FirstName}");

        // Display names of people whose first names start with M
        var peopleWithM = peopleList.Where(p => p.FirstName.StartsWith("M")).Select(p => p.FirstName).ToList();
        Console.WriteLine("People whose first names start with M: ");
        foreach (var name in peopleWithM)
        {
            Console.WriteLine(name);
        }

        // Display the person information of the person that likes the colour blue
        var personWithBlue = peopleList.FirstOrDefault(p => p.FavoriteColour == "Blue");
        Console.WriteLine("Person who likes the colour blue:");
        if (personWithBlue != null)
        {
            Console.WriteLine(personWithBlue.ToString());
        }
    }
}
