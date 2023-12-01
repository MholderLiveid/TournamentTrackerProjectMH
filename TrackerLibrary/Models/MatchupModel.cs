namespace TrackerLibrary.Models;

public class MatchupModel
{
    /// <summary>
    /// Represents the set of teams that were involved in this matchup.
    /// </summary>
    public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

    /// <summary>
    /// Represents the winner of the matchup.
    /// </summary>
    public TeamModel Winner { get; set; }

    /// <summary>
    /// Represents the round number that this matchup is a part of.
    /// </summary>
    public int MatchupRound { get; set; }
}

