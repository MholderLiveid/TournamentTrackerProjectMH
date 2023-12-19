using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using TrackerLibrary;
using TrackerLibrary.Models;
using TrackerUI.Interfaces;

namespace TrackerUI.Forms;

public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
{
    #region Properties

    List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
    List<TeamModel> selectedTeams = new List<TeamModel>();
    List<PrizeModel> selectedPrizes = new List<PrizeModel>();

    #endregion

    #region Constructor

    public CreateTournamentForm()
    {
        InitializeComponent();

        WireUpLists();
    }

    #endregion

    #region Drag Form

    [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();

    [DllImport("user32.dll", EntryPoint = "SendMessage")]
    private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

    private void titlePanel_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(this.Handle, 0x112, 0xf012, 0);
    }

    #endregion

    #region Public Methods

    public void PrizeComplete(PrizeModel model)
    {
        selectedPrizes.Add(model);
        WireUpLists();
    }

    public void TeamComplete(TeamModel model)
    {
        selectedTeams.Add(model);
        WireUpLists();
    }

    #endregion

    #region Private Methods

    private void WireUpLists()
    {
        selectTeamDropDown.DataSource = null;
        selectTeamDropDown.DataSource = availableTeams;
        selectTeamDropDown.DisplayMember = "TeamName";

        tournamentTeamsListBox.DataSource = null;
        tournamentTeamsListBox.DataSource = selectedTeams;
        tournamentTeamsListBox.DisplayMember = "TeamName";

        prizesListBox.DataSource = null;
        prizesListBox.DataSource = selectedPrizes;
        prizesListBox.DisplayMember = "PlaceName";
    }

    #endregion

    #region Button Controls

    private void addTeamButton_Click(object sender, EventArgs e)
    {
        TeamModel t = (TeamModel)selectTeamDropDown.SelectedItem;

        if (t != null)
        {
            availableTeams.Remove(t);
            selectedTeams.Add(t);

            WireUpLists();
        }
    }

    private void createPrizeButton_Click(object sender, EventArgs e)
    {
        CreatePrizeForm frm = new CreatePrizeForm(this);
        frm.Show();
    }

    private void createNewTeamLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        CreateTeamForm frm = new CreateTeamForm(this);
        frm.Show();
    }

    private void removeSelectedPlayersButton_Click(object sender, EventArgs e)
    {
        TeamModel t = (TeamModel)tournamentTeamsListBox.SelectedItem;

        if (t != null)
        {
            selectedTeams.Remove(t);
            availableTeams.Add(t);

            WireUpLists();
        }
    }

    private void removeSelectedPrizeButton_Click(object sender, EventArgs e)
    {
        PrizeModel p = (PrizeModel)prizesListBox.SelectedItem;

        if (p != null)
        {
            selectedPrizes.Remove(p);

            WireUpLists();
        }
    }

    #endregion



}
