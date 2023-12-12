using TrackerLibrary;
using TrackerLibrary.Interface;
using TrackerLibrary.Models;

namespace TrackerUI.Forms;

public partial class CreatePrizeForm : Form
{

    #region Constructor

    public CreatePrizeForm()
    {
        InitializeComponent();
    }

    #endregion

    #region Private Methods

    private bool ValidateForm()
    {
        bool output = true;
        int placeNumber = 0;
        bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text, out placeNumber);

        if (placeNumberValidNumber == false)
        {          
            output = false;
        }
       
        if (placeNumber < 1)
        {           
            output = false;
        }

        if (placeNameValue.Text.Length == 0)
        {          
            output = false;
        }

        decimal prizeAmount = 0;
        double prizePercentage = 0;

        bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
        bool prizePercentageValid = double.TryParse(prizePercentageValue.Text, out prizePercentage);

        if (prizeAmountValid == false || prizePercentageValid == false)
        {
            output = false;
        }

        if (prizeAmount <= 0 && prizePercentage <= 0)
        {
            output = false;
        }

        if (prizePercentage < 0 || prizePercentage > 100)
        {
            output = false;
        }

        return output;
    }

    #endregion

    #region Button Controls

    private void createPrizeButton_Click(object sender, EventArgs e)
    {
        if (ValidateForm())
        {
            PrizeModel model = new PrizeModel(
                placeNameValue.Text,
                placeNumberValue.Text,
                prizeAmountValue.Text,
                prizePercentageValue.Text);

            GlobalConfig.Connection.CreatePrize(model);

            placeNumberValue.Text = "";
            placeNameValue.Text = "";
            prizeAmountValue.Text = "0";
            prizePercentageValue.Text = "0";


        }
    }

    #endregion
}
