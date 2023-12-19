using System.Runtime.InteropServices;

namespace TrackerUI.Forms;

public partial class TournamentDashboardForm : Form
{
    #region Fields



    #endregion

    #region Constructor

    public TournamentDashboardForm()
    {
        InitializeComponent();
    }

    #endregion

    #region Drag Form

    [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();

    [DllImport("user32.dll", EntryPoint = "SendMessage")]
    private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

    private void titleLabel_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(this.Handle, 0x112, 0xf012, 0);
    }

    #endregion

    #region Private Methods



    #endregion

    #region Button Controls

   private void exitProgramButton_Click(object sender, EventArgs e)
    {
        string message = "Do you want to exit the application?";
        string caption = "Exit Application";

        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
        MessageBoxIcon icon = MessageBoxIcon.Warning;

        DialogResult dialogResult = MessageBox.Show(message, caption, buttons, icon);
        if (dialogResult == DialogResult.Yes)
        {
            Application.Exit();
        }
    }

    #endregion

 
}
