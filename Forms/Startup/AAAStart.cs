using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RESERBA_Proj
{
    public partial class AAAStart : Form
    {
        public AAAStart()
        {
            InitializeComponent();

        }

        private void AAAStart_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.stretchToFit = true;
            axWindowsMediaPlayer1.settings.autoStart = true;

            string videoPath = System.IO.Path.Combine(Application.StartupPath, "Videos", "RESERBA.mp4");
            axWindowsMediaPlayer1.URL = videoPath;


        }

        private void axWindowsMediaPlayer1_PlayStateChange_1(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // The state '8' means the video has completely finished playing
            if (e.newState == 8)
            {
                // Load the next screen
                AABStart mainscreen = new AABStart();
                mainscreen.Show();
                this.Hide();
            }
        }
    }
}
