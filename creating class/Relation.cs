class Relation
{
    public string RelationshipType { get; set; }

    // Constructor
    public Relation(string relationshipType)
    {
        RelationshipType = relationshipType;
    }

    // Method to show the relationship between two people
    public void ShowRelationShip(Person person1, Person person2)
    {
        Console.WriteLine($"Relationship between {person1.FirstName} and {person2.FirstName} is: {RelationshipType}");
    }
}
