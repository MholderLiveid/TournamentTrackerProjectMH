﻿using System.Configuration;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using TrackerLibrary.Models;

// * Load the text file
// * Convert text to List<PrizeModel>
// Find the max ID
// Add the new record with new ID (max + 1)
// Convert the prizes to a list<string>
// Save the list<string> to the text file


namespace TrackerLibrary.Connectors.TextHelpers;

public static class TextConnectorProcessor
{
    #region Get the full file path

    public static string FullFilePath(this string fileName)
    {
        return $"{ ConfigurationManager.AppSettings["filePath"] }\\{ fileName }";
    }

    #endregion

    #region Load the text file

    public static List<string> LoadFile(this string file)
    {
        if (!File.Exists(file))
        {
            return new List<string>();
        }

        return File.ReadLines(file).ToList();
    }

    #endregion

    #region Convert text to each of the Lists

    public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
    {
        List<PrizeModel> output = new List<PrizeModel>();

        foreach (string line in lines)
        {
            string[] cols = line.Split(',');

            PrizeModel p = new PrizeModel();
            p.Id = int.Parse(cols[0]);
            p.PlaceNumber = int.Parse(cols[1]);
            p.PlaceName = cols[2];
            p.PrizeAmount = decimal.Parse(cols[3]);
            p.PrizePercentage = double.Parse(cols[4]);
            output.Add(p);
        }

        return output;
    }

    public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
    {
        List<PersonModel> output = new List<PersonModel>();

        foreach (string line in lines)
        {
            string[] cols = line.Split(',');

            PersonModel p = new PersonModel();
            p.Id = int.Parse(cols[0]);
            p.FirstName = cols[1];
            p.LastName = cols[2];
            p.EmailAddress = cols[3];
            p.CellphoneNumber = cols[4];
            output.Add(p);
        }

        return output;
    }

    public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string peopleFileName)
    {
        List<TeamModel> output = new List<TeamModel>();
        List<PersonModel> people = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModels();

        foreach (string line in lines)
        {
            string[] cols = line.Split(",");

            TeamModel t = new TeamModel();
            t.Id = int.Parse(cols[0]);
            t.TeamName = cols[1];

            string[] personIds = cols[2].Split('|');

            foreach(string id in personIds)
            {
                t.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());
            }

            output.Add(t);
        }

        return output;       
    }

    public static List<TournamentModel> ConvertToTournamentModels(
        this List<string> lines, 
        string teamFileName, 
        string peopleFileName,
        string prizeFileName)
    {
        List<TournamentModel> output = new List<TournamentModel>();
        List<TeamModel> teams = teamFileName.FullFilePath().LoadFile().ConvertToTeamModels(peopleFileName);
        List<PrizeModel> prizes = prizeFileName.FullFilePath().LoadFile().ConvertToPrizeModels();

        foreach (string line in lines)
        {
            string[] cols = line.Split(",");

            TournamentModel tm = new TournamentModel();
            tm.Id = int.Parse(cols[0]);
            tm.TournamentName = cols[1];
            tm.EntryFee = decimal.Parse(cols[2]);

            string[] teamIds = cols[3].Split('|');

            foreach (string id in teamIds)
            {
                tm.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First());
            }

            string[] prizeIds = cols[4].Split('|');

            foreach(string id in prizeIds)
            {
                tm.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());
            }

            output.Add(tm);
        }

        return output;
    }

    #endregion

    #region Save the List<string> to the text File

    public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
    {
        List<string> lines = new List<string>();

        foreach (PrizeModel p in models)
        {
            lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
        }

        File.WriteAllLines(fileName.FullFilePath(), lines);

    }

    public static void SaveToPeopleFile(this List<PersonModel> models, string fileName)
    {
        List<string> lines = new List<string>();

        foreach (PersonModel p in models)
        {
            lines.Add($"{p.Id},{p.FirstName},{p.LastName},{p.EmailAddress},{p.CellphoneNumber}");
        }

        File.WriteAllLines(fileName.FullFilePath(), lines);

    }

    public static void SaveToTeamFile(this List<TeamModel> models, string fileName)
    {
        List<string> lines = new List<string>();

        foreach(TeamModel t in models)
        {
            lines.Add($"{t.Id},{t.TeamName},{ConvertPeopleListToString(t.TeamMembers)}");
        }

        File.WriteAllLines(fileName.FullFilePath(), lines);
    }

    public static void SaveToTournamentFile(this List<TournamentModel> models, string fileName)
    {
        List<string> lines = new List<string>();

        foreach (TournamentModel tm in models)
        {
            lines.Add($@"{ tm.Id },
                         { tm.TournamentName }, 
                         { tm.EntryFee }, 
                         { ConvertTeamListToString(tm.EnteredTeams) },
                         { ConvertPrizeListToString(tm.Prizes) },
                         { ConvertRoundListToString(tm.Rounds) }");
        }

        File.WriteAllLines(fileName.FullFilePath(), lines);
    }



    #endregion

    #region Helper Method

    private static string ConvertPeopleListToString(List<PersonModel> people)
    {
        string output = "";

        if (people.Count == 0)
        {
            return "";
        }

        foreach (PersonModel p in people)
        {
            output += $"{p.Id}|";
        }

        output = output.Substring(0, output.Length - 1);

        return output;
    }

    private static string ConvertTeamListToString(List<TeamModel> teams)
    {
        string output = "";

        if (teams.Count == 0)
        {
            return "";
        }

        foreach (TeamModel t in teams)
        {
            output += $"{ t.Id }|";
        }

        output = output.Substring(0, output.Length - 1);

        return output;
    }

    private static string ConvertPrizeListToString(List<PrizeModel> prizes)
    {
        string output = "";

        if (prizes.Count == 0)
        {
            return "";
        }

        foreach (PrizeModel p in prizes)
        {
            output += $"{ p.Id }|";
        }

        output = output.Substring(0, output.Length - 1);

        return output;
    }

    private static string ConvertRoundListToString(List<List<MatchupModel>> rounds)
    {
        string output = "";

        if (rounds.Count == 0)
        {
            return "";
        }

        foreach (List<MatchupModel> r in rounds)
        {
            output += $"{ ConvertMatchupListToString(r) }|";
        }

        output = output.Substring(0, output.Length - 1);

        return output;
    }

    private static string ConvertMatchupListToString(List<MatchupModel> matchups)
    {
        string output = "";

        if (matchups.Count == 0)
        {
            return "";
        }

        foreach (MatchupModel m in matchups)
        {
            output += $"{m.Id}^";
        }

        output = output.Substring(0, output.Length - 1);

        return output;
    }

    #endregion
}
