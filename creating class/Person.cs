using System;
using System.Collections.Generic;
using System.Linq;

class Person
{
    public int PersonId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FavoriteColour { get; set; }
    public int Age { get; set; }
    public bool IsWorking { get; set; }

    // Constructor
    public Person(int personId, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
    {
        PersonId = personId;
        FirstName = firstName;
        LastName = lastName;
        FavoriteColour = favoriteColour;
        Age = age;
        IsWorking = isWorking;
    }

    // Method to display person's information
    public void DisplayPersonInfo()
    {
        Console.WriteLine($"{FirstName} {LastName}'s favorite colour is {FavoriteColour}");
    }

    // Method to change the favorite color to white
    public void ChangeFavoriteColour()
    {
        FavoriteColour = "White";
    }

    // Method to get the age in 10 years
    public int GetAgeInTenYears()
    {
        return Age + 10;
    }

    // Overriding ToString method to display person's details
    public override string ToString()
    {
        return $"PersonId: {PersonId}\nFirstName: {FirstName}\nLastName: {LastName}\nFavoriteColour: {FavoriteColour}\nAge: {Age}\nIsWorking: {IsWorking}";
    }
}
