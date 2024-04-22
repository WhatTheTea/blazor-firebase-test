namespace BlazorFirebaseTest.Models;

public class Person(string Id, string FirstName, string LastName)
{
    public string Id { get; set; } = Id;
    public string FirstName { get; set; } = FirstName;
    public string LastName { get; set; } = LastName;
}