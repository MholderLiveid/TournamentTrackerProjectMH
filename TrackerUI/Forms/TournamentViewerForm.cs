using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace TrackerUI.Forms;

public partial class TournamentViewerForm : Form
{
    #region Fields



    #endregion

    #region Constructor

    public TournamentViewerForm()
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



    #endregion
}
