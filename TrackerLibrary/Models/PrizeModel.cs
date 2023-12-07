namespace TrackerLibrary.Models;

public class PrizeModel
{
    /// <summary>
    /// The unique identifier for the prize.
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// Represents the unique identifier for the prize.
    /// </summary>
    public int PlaceNumber { get; set; }

    /// <summary>
    /// Represents the friendly name for the place 
    /// (second place, first runner up, etc.).
    /// </summary>
    public string PlaceName { get; set; }

    /// <summary>
    /// Represents the total amount of the prize.
    /// </summary>
    public decimal PrizeAmount { get; set; }

    /// <summary>
    /// Represents the percentage of the overall prize.
    /// </summary>
    public double PrizePercentage { get; set; }
}
