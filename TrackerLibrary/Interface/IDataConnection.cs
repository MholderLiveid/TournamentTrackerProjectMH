﻿using TrackerLibrary.Models;

namespace TrackerLibrary.Interface;

public interface IDataConnection
{
    PrizeModel CreatePrize(PrizeModel model);
    PersonModel CreatePerson(PersonModel model);
    TeamModel CreateTeam(TeamModel model);
    void CreateTournament(TournamentModel model);

    List<TeamModel> GetTeam_All();
    List<PersonModel> GetPerson_All();
}
