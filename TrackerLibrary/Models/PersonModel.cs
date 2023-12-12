namespace TrackerLibrary.Models;

public class PersonModel
{
    /// <summary>
    /// The unique identifier for the person.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Represents the person's first name.
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Represents the person's last name.
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Represents the person's email address.
    /// </summary>
    public string EmailAddress { get; set; }

    /// <summary>
    /// Represents the person's cellphone number.
    /// </summary>
    public string CellphoneNumber { get; set; }
}
