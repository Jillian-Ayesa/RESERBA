using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RESERBA
{
    public partial class Admin3 : Form
    {
        public Admin3()
        {
            InitializeComponent();
        }

        private void CboxGate_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clears any old items out of the box first (optional but good practice)
            CboxGate.Items.Clear();

            // Adds your new items
            CboxGate.Items.Add("GATE 1");
            CboxGate.Items.Add("GATE 2");
            CboxGate.Items.Add("GATE 3");
        }
    }
}
