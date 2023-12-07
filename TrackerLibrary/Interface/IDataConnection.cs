using TrackerLibrary.Models;

namespace TrackerLibrary.Interface;

public interface IDataConnection
{
    PrizeModel CreatePrize(PrizeModel model);
}
