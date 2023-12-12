using System.Configuration;
using TrackerLibrary.Connectors;
using TrackerLibrary.Interface;

namespace TrackerLibrary;

public static class GlobalConfig
{
    public static IDataConnection Connection { get; private set; }



    public static void InitializeConnections(DatabaseType db)
    {
        if (db == DatabaseType.Sql)
        {
            // TODO - Set up the SQL Connector properly.
            SqlConnector sql = new SqlConnector();
            Connection = sql;
        }

        else if (db == DatabaseType.TextFile)
        {
            // TODO - Create the Text Connections.
            TextConnector text = new TextConnector();
            Connection = text;
        }
    }

    public static string CnnString(string name)
    {
        return ConfigurationManager.ConnectionStrings[name].ConnectionString;
    }
}
