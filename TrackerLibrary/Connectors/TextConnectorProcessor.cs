using System.Configuration;
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

    #region Convert text to List<PrizeModel>

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

    #endregion

    #region Save the List<string> to the text File

    public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
    {
        List<string> lines = new List<string>();

        foreach (PrizeModel p in models)
        {
            lines.Add($"{p.Id},{p.PlaceNumber}, {p.PlaceName}, {p.PrizeAmount}, {p.PrizePercentage}");
        }

        File.WriteAllLines(fileName.FullFilePath(), lines);

    }

    #endregion
}
