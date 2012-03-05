using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tester.SasomaUtils;

namespace Tester
{
    public partial class Processor : Form
    {
        public Processor()
        {
            InitializeComponent();
            //GetInterfaceArray.GetArray();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tester.SasomaUtils.Processor.Act();
        }
    }
}
