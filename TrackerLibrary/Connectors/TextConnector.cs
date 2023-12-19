using TrackerLibrary.Interface;
using TrackerLibrary.Models;
using TrackerLibrary.Connectors.TextHelpers;

namespace TrackerLibrary.Connectors;

public class TextConnector : IDataConnection
{
    private const string PrizesFile = "PrizeModels.csv";
    private const string PeopleFile = "PersonModels.csv";
    private const string TeamFile = "TeamModels.csv";

    /// <summary>
    /// Creates a new person and adds it to the storage.
    /// </summary>
    /// <param name="model">The person model to be added.</param>
    /// <returns>The added person model with a unique ID assigned.</returns>
    /// <remarks>
    /// This method generates a unique ID for the new person by finding the highest existing ID and incrementing it.
    /// It then adds the new person to the list of people and updates the storage file.
    /// </remarks>
    public PersonModel CreatePerson(PersonModel model)
    {
        List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

        int currentId = 1;

        if (people.Count > 0)
        {
            currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
        }

        model.Id = currentId;

        people.Add(model);

        people.SaveToPeopleFile(PeopleFile);

        return model;
    }

    /// <summary>
    /// Creates a new prize and adds it to the storage.
    /// </summary>
    /// <param name="model">The prize model to be added.</param>
    /// <returns>The added prize model with a unique ID assigned.</returns>
    /// <remarks>
    /// This method generates a unique ID for the new prize by finding the highest existing ID and incrementing it.
    /// It then adds the new prize to the list of prizes and updates the storage file.
    /// </remarks>
    public PrizeModel CreatePrize(PrizeModel model)
    {       
        List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

        int currentId = 1;

        if (prizes.Count > 0)
        {
            currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
        }

        model.Id = currentId;
       
        prizes.Add(model);
       
        prizes.SaveToPrizeFile(PrizesFile);

        return model;
    }

    public List<PersonModel> GetPerson_All()
    {
        return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
    }

    public TeamModel CreateTeam(TeamModel model)
    {
        List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);

        int currentId = 1;

        if (teams.Count > 0)
        {
            currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
        }

        model.Id = currentId;

        teams.Add(model);

        teams.SaveToTeamFile(TeamFile); 
        return model;
    }

    public List<TeamModel> GetTeam_All()
    {
        throw new NotImplementedException();
    }
}
