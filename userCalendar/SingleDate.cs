using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class SingleDate : UserControl
    {
        public SingleDate()
        {
            InitializeComponent();
        }

        // [修改文字]
        public void days(int numDay)
        {
            daysLabel.Text = numDay+"";
        }
    }
}
