using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

namespace RESERBA_Proj
{
    public partial class _1Admin3 : Form
    {
        private string _currentUserName = "";
        public _1Admin3()
        {
            InitializeComponent();
            if (!DesignMode) FontManager.ApplyFontToAll(this);
        }

        private void cbGateNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGateNum.SelectedIndex != -1)
            {
                string chosenGate = cbGateNum.SelectedItem?.ToString();
                Dashboard nextScreen = new Dashboard();
                string cleanName = label1.Text.Replace("!", "");
                nextScreen.SetGateNumber(chosenGate, _currentUserName);
                nextScreen.Show();
                this.Hide();
            }
        }
        
        public void SetUser(string userName)
        {
            _currentUserName = userName;
            BtnLabel.Text = "Hello, " + userName + "!";
        }
    }
}
