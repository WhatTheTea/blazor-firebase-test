namespace BlazorFirebaseTest.Models;

public class Person(int Id, string FirstName, string LastName)
{
    public int Id { get; set; } = Id;
    public string FirstName { get; set; } = FirstName;
    public string LastName { get; set; } = LastName;
}