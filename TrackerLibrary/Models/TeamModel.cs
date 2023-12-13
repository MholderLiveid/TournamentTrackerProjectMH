namespace TrackerLibrary.Models;

public class TeamModel
{   
    /// <summary>
    /// The unique identifier for the Team.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Represents the set of people that make up this team.
    /// </summary>
    public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

    /// <summary>
    /// Represents the name of this team.
    /// </summary>
    public string TeamName { get; set; }
}
