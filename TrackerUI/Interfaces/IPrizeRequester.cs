using TrackerLibrary.Models;

namespace TrackerUI.Interfaces;

public interface IPrizeRequester
{
    void PrizeComplete(PrizeModel model);
}
