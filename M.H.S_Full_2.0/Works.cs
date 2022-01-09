using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M.H.S_Full_2._0
{
    public partial class Works : Form
    {
        public Works()
        {
            InitializeComponent();
            Exibir();
        }

        private void Works_Load(object sender, EventArgs e)
        {

        }
        public void Exibir ()
        {
            if (Program.Zoom == 1)
            {
                PB1.Visible = true;
                PB2.Visible = false;
            }
            else
            {
                if (Program.Zoom == 2)
                {
                    PB1.Visible = false;
                    PB2.Visible = true;
                }
            }
        }

        private void PB2_Click(object sender, EventArgs e)
        {

        }
    }
}
