namespace TrackerLibrary.Models;

public class TournamentModel
{
    /// <summary>
    /// The unique identifier for the Tournament.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the tournament.
    /// </summary>
    public string TournamentName { get; set; }

    /// <summary>
    /// Gets or sets the entry fee for the tournament.
    /// </summary>
    public decimal EntryFee { get; set; }

    /// <summary>
    /// Gets or sets the list of teams that have entered the tournament.
    /// </summary>
    public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

    /// <summary>
    /// Gets or sets the list of prizes for the tournament.
    /// </summary>
    public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

    /// <summary>
    /// Gets or sets the list of rounds in the tournament, where each round is a list of matchups.
    /// </summary>
    public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
}
