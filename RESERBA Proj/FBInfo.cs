using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RESERBA_Proj
{
    public partial class _6_2Info : UserControl
    {
        public _6_2Info()
        {
            InitializeComponent();
            if (!DesignMode) FontManager.ApplyFontToAll(this);
        }
    }
}
