﻿using Dapper;
using System.Data;
using System.Reflection;
using TrackerLibrary.Interface;
using TrackerLibrary.Models;

//@PlaceNumber int,
//@PlaceName nvarchar(50), 
//@PrizeAmount money,
//@PrizePercentage float,
//@Id int = 0 output


namespace TrackerLibrary.Connectors;

public class SqlConnector : IDataConnection
{
    #region Fields

    private const string db = "Tournaments";

    #endregion

    #region Public Methods

    public PersonModel CreatePerson(PersonModel model)
    {
        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
        {
            var p = new DynamicParameters();
            p.Add("@FirstName", model.FirstName);
            p.Add("@LastName", model.LastName);
            p.Add("@EmailAddress", model.EmailAddress);
            p.Add("@CellphoneNumber", model.CellphoneNumber);
            p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spPeople_Insert", p, commandType: CommandType.StoredProcedure);

            model.Id = p.Get<int>("@id");

            return model;
        }
    }

    public PrizeModel CreatePrize(PrizeModel model)
    {
        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
        {
            var p = new DynamicParameters();
            p.Add("@PlaceNumber", model.PlaceNumber);
            p.Add("@PlaceName", model.PlaceName);
            p.Add("@PrizeAmount", model.PrizeAmount);
            p.Add("@PrizePercentage", model.PrizePercentage);
            p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

            model.Id = p.Get<int>("@id");

            return model;
        }
    }

    public TeamModel CreateTeam(TeamModel model)
    {
        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
        {
            var p = new DynamicParameters();
            p.Add("@TeamName", model.TeamName);        
            p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spTeams_Insert", p, commandType: CommandType.StoredProcedure);

            model.Id = p.Get<int>("@id");

            foreach(PersonModel tm in model.TeamMembers)
            {
                p = new DynamicParameters();
                p.Add("@TeamId", model.Id);
                p.Add("@PersonId", tm.Id);
                
                connection.Execute("dbo.spTeamMembers_Insert", p, commandType: CommandType.StoredProcedure);
            }

            return model;
        }

        
    }

    public void CreateTournament(TournamentModel model)
    {
        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
        {
            SaveTournament(connection, model);
            SaveTournamentPrizes(connection, model);
            SaveTournamentEntries(connection, model);
        }
    }

    public List<PersonModel> GetPerson_All()
    {
        List<PersonModel> output;

        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
        {
            output = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
        }

        return output;
    }

    public List<TeamModel> GetTeam_All()
    {
        List<TeamModel> output;

        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
        {
            output = connection.Query<TeamModel>("dbo.spTeams_GetAll").ToList();

            foreach (TeamModel team in output)
            {
                var p = new DynamicParameters();
                p.Add("@TeamId", team.Id);

                team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", p, commandType: CommandType.StoredProcedure).ToList();
            }

        }

        return output;
    }

    #endregion

    #region Private Methods

    private void SaveTournament(IDbConnection connection, TournamentModel model)
    {
        var p = new DynamicParameters();
        p.Add("@TournamentName", model.TournamentName);
        p.Add("@EntryFee", model.EntryFee);
        p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

        connection.Execute("dbo.spTournaments_Insert", p, commandType: CommandType.StoredProcedure);

        model.Id = p.Get<int>("@id");
    }

    private void SaveTournamentPrizes(IDbConnection connection, TournamentModel model)
    {
        foreach (PrizeModel pz in model.Prizes)
        {
            var p = new DynamicParameters();
            p.Add("@TournamentID", model.Id);
            p.Add("@PrizeId", pz.Id);
            p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spTournamentPrizes_Insert", p, commandType: CommandType.StoredProcedure);
        }
    }

    private void SaveTournamentEntries(IDbConnection connection, TournamentModel model)
    {
        foreach (TeamModel tm in model.EnteredTeams)
        {
            var p = new DynamicParameters();
            p.Add("@TournamentID", model.Id);
            p.Add("@TeamId", tm.Id);
            p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spTournamentEntries_Insert", p, commandType: CommandType.StoredProcedure);
        }
    }

    #endregion
}
