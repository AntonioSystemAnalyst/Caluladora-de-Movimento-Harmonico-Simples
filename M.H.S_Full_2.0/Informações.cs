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
    public partial class Informações : Form
    {
        public static int Option = 0;
        public Informações()
        {
            InitializeComponent();
            Option = 0;
        }

        private void BTAvançar_Click(object sender, EventArgs e)
        {
                 
            Option = Option + 1;

            if (Option == 0)
            {
                PB1.Visible = true;
                PB2.Visible = false;
                PB3.Visible = false;
                PB4.Visible = false;
                PB5.Visible = false;
                PB6.Visible = false;
                PB7.Visible = false;
                PB8.Visible = false;
                PB9.Visible = false;
                PB10.Visible = false;
                PB11.Visible = false;
                PB12.Visible = false;
                PB13.Visible = false;
                PB14.Visible = false;
                BTVoltar.Enabled = false;
            }
            else
            {
                if (Option == 1)
                {
                    PB1.Visible = false;
                    PB2.Visible = true;
                    PB3.Visible = false;
                    PB4.Visible = false;
                    PB5.Visible = false;
                    PB6.Visible = false;
                    PB7.Visible = false;
                    PB8.Visible = false;
                    PB9.Visible = false;
                    PB10.Visible = false;
                    PB11.Visible = false;
                    PB12.Visible = false;
                    PB13.Visible = false;
                    PB14.Visible = false;
                    BTVoltar.Enabled = true;
                }
                else
                {
                    if (Option == 2)
                    {
                        PB1.Visible = false;
                        PB2.Visible = false;
                        PB3.Visible = true;
                        PB4.Visible = false;
                        PB5.Visible = false;
                        PB6.Visible = false;
                        PB7.Visible = false;
                        PB8.Visible = false;
                        PB9.Visible = false;
                        PB10.Visible = false;
                        PB11.Visible = false;
                        PB12.Visible = false;
                        PB13.Visible = false;
                        PB14.Visible = false;
                    }
                    else
                    {
                        if (Option == 3)
                        {
                            PB1.Visible = false;
                            PB2.Visible = false;
                            PB3.Visible = false;
                            PB4.Visible = true;
                            PB5.Visible = false;
                            PB6.Visible = false;
                            PB7.Visible = false;
                            PB8.Visible = false;
                            PB9.Visible = false;
                            PB10.Visible = false;
                            PB11.Visible = false;
                            PB12.Visible = false;
                            PB13.Visible = false;
                            PB14.Visible = false;
                        }
                        else
                        {
                            if (Option == 4)
                            {
                                PB1.Visible = false;
                                PB2.Visible = false;
                                PB3.Visible = false;
                                PB4.Visible = false;
                                PB5.Visible = true;
                                PB6.Visible = false;
                                PB7.Visible = false;
                                PB8.Visible = false;
                                PB9.Visible = false;
                                PB10.Visible = false;
                                PB11.Visible = false;
                                PB12.Visible = false;
                                PB13.Visible = false;
                                PB14.Visible = false;
                            }
                            else
                            {
                                if (Option == 5)
                                {
                                    PB1.Visible = false;
                                    PB2.Visible = false;
                                    PB3.Visible = false;
                                    PB4.Visible = false;
                                    PB5.Visible = false;
                                    PB6.Visible = true;
                                    PB7.Visible = false;
                                    PB8.Visible = false;
                                    PB9.Visible = false;
                                    PB10.Visible = false;
                                    PB11.Visible = false;
                                    PB12.Visible = false;
                                    PB13.Visible = false;
                                    PB14.Visible = false;
                                }
                                else
                                {
                                    if (Option == 6)
                                    {
                                        PB1.Visible = false;
                                        PB2.Visible = false;
                                        PB3.Visible = false;
                                        PB4.Visible = false;
                                        PB5.Visible = false;
                                        PB6.Visible = false;
                                        PB7.Visible = true;
                                        PB8.Visible = false;
                                        PB9.Visible = false;
                                        PB10.Visible = false;
                                        PB11.Visible = false;
                                        PB12.Visible = false;
                                        PB13.Visible = false;
                                        PB14.Visible = false;
                                    }
                                    else
                                    {
                                        if(Option == 7)
                                        {
                                            PB1.Visible = false;
                                            PB2.Visible = false;
                                            PB3.Visible = false;
                                            PB4.Visible = false;
                                            PB6.Visible = false;
                                            PB7.Visible = false;
                                            PB8.Visible = true;
                                            PB9.Visible = false;
                                            PB10.Visible = false;
                                            PB11.Visible = false;
                                            PB12.Visible = false;
                                            PB13.Visible = false;
                                            PB14.Visible = false;
                                        } 
                                        else
                                        {
                                            if (Option == 8)
                                            {
                                                PB1.Visible = false;
                                                PB2.Visible = false;
                                                PB3.Visible = false;
                                                PB4.Visible = false;
                                                PB6.Visible = false;
                                                PB7.Visible = false;
                                                PB8.Visible = false;
                                                PB9.Visible = true;
                                                PB10.Visible = false;
                                                PB11.Visible = false;
                                                PB12.Visible = false;
                                                PB13.Visible = false;
                                                PB14.Visible = false;
                                            }
                                            else
                                            {
                                                if (Option == 9)
                                                {
                                                    PB1.Visible = false;
                                                    PB2.Visible = false;
                                                    PB3.Visible = false;
                                                    PB4.Visible = false;
                                                    PB6.Visible = false;
                                                    PB7.Visible = false;
                                                    PB8.Visible = false;
                                                    PB9.Visible = false;
                                                    PB10.Visible = true;
                                                    PB11.Visible = false;
                                                    PB12.Visible = false;
                                                    PB13.Visible = false;
                                                    PB14.Visible = false;
                                                    BTZoom.Visible = false;
                                                    Program.Zoom = 0;
                                                }
                                                else
                                                {
                                                    if (Option == 10)
                                                    {
                                                        PB1.Visible = false;
                                                        PB2.Visible = false;
                                                        PB3.Visible = false;
                                                        PB4.Visible = false;
                                                        PB6.Visible = false;
                                                        PB7.Visible = false;
                                                        PB8.Visible = false;
                                                        PB9.Visible = false;
                                                        PB10.Visible = false;
                                                        PB11.Visible = true;
                                                        PB12.Visible = false;
                                                        PB13.Visible = false;
                                                        PB14.Visible = false;
                                                        BTZoom.Visible = true;
                                                        Program.Zoom = 1;
                                                    }
                                                    else
                                                    {
                                                        if (Option == 11)
                                                        {
                                                            PB1.Visible = false;
                                                            PB2.Visible = false;
                                                            PB3.Visible = false;
                                                            PB4.Visible = false;
                                                            PB6.Visible = false;
                                                            PB7.Visible = false;
                                                            PB8.Visible = false;
                                                            PB9.Visible = false;
                                                            PB10.Visible = false;
                                                            PB11.Visible = false;
                                                            PB12.Visible = true;
                                                            PB13.Visible = false;
                                                            PB14.Visible = false;
                                                            BTZoom.Visible = true;
                                                            Program.Zoom = 2;
                                                        }
                                                        else
                                                        {
                                                            if (Option == 12)
                                                            {
                                                                PB1.Visible = false;
                                                                PB2.Visible = false;
                                                                PB3.Visible = false;
                                                                PB4.Visible = false;
                                                                PB6.Visible = false;
                                                                PB7.Visible = false;
                                                                PB8.Visible = false;
                                                                PB9.Visible = false;
                                                                PB10.Visible = false;
                                                                PB11.Visible = false;
                                                                PB12.Visible = false;
                                                                PB13.Visible = true;
                                                                PB14.Visible = false;
                                                                BTZoom.Visible = false;
                                                                BTAvançar.Enabled = true;
                                                                Program.Zoom = 0;
                                                            }
                                                            else
                                                            {
                                                                if (Option == 13)
                                                                {
                                                                    PB1.Visible = false;
                                                                    PB2.Visible = false;
                                                                    PB3.Visible = false;
                                                                    PB4.Visible = false;
                                                                    PB6.Visible = false;
                                                                    PB7.Visible = false;
                                                                    PB8.Visible = false;
                                                                    PB9.Visible = false;
                                                                    PB10.Visible = false;
                                                                    PB11.Visible = false;
                                                                    PB12.Visible = false;
                                                                    PB13.Visible = false;
                                                                    PB14.Visible = true;
                                                                    BTAvançar.Enabled = false;
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                                                            
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void BTVoltar_Click(object sender, EventArgs e)
        {
            Option = Option - 1;


            if (Option == 0)
            {
                PB1.Visible = true;
                PB2.Visible = false;
                PB3.Visible = false;
                PB4.Visible = false;
                PB5.Visible = false;
                PB6.Visible = false;
                PB7.Visible = false;
                PB8.Visible = false;
                PB9.Visible = false;
                PB10.Visible = false;
                PB11.Visible = false;
                PB12.Visible = false;
                PB13.Visible = false;
                PB14.Visible = false;
                BTVoltar.Enabled = false;
            }
            else
            {
                if (Option == 1)
                {
                    PB1.Visible = false;
                    PB2.Visible = true;
                    PB3.Visible = false;
                    PB4.Visible = false;
                    PB5.Visible = false;
                    PB6.Visible = false;
                    PB7.Visible = false;
                    PB8.Visible = false;
                    PB9.Visible = false;
                    PB10.Visible = false;
                    PB11.Visible = false;
                    PB12.Visible = false;
                    PB13.Visible = false;
                    PB14.Visible = false;
                    BTVoltar.Enabled = true;
                }
                else
                {
                    if (Option == 2)
                    {
                        PB1.Visible = false;
                        PB2.Visible = false;
                        PB3.Visible = true;
                        PB4.Visible = false;
                        PB5.Visible = false;
                        PB6.Visible = false;
                        PB7.Visible = false;
                        PB8.Visible = false;
                        PB9.Visible = false;
                        PB10.Visible = false;
                        PB11.Visible = false;
                        PB12.Visible = false;
                        PB13.Visible = false;
                        PB14.Visible = false;
                    }
                    else
                    {
                        if (Option == 3)
                        {
                            PB1.Visible = false;
                            PB2.Visible = false;
                            PB3.Visible = false;
                            PB4.Visible = true;
                            PB5.Visible = false;
                            PB6.Visible = false;
                            PB7.Visible = false;
                            PB8.Visible = false;
                            PB9.Visible = false;
                            PB10.Visible = false;
                            PB11.Visible = false;
                            PB12.Visible = false;
                            PB13.Visible = false;
                            PB14.Visible = false;
                        }
                        else
                        {
                            if (Option == 4)
                            {
                                PB1.Visible = false;
                                PB2.Visible = false;
                                PB3.Visible = false;
                                PB4.Visible = false;
                                PB5.Visible = true;
                                PB6.Visible = false;
                                PB7.Visible = false;
                                PB8.Visible = false;
                                PB9.Visible = false;
                                PB10.Visible = false;
                                PB11.Visible = false;
                                PB12.Visible = false;
                                PB13.Visible = false;
                                PB14.Visible = false;
                            }
                            else
                            {
                                if (Option == 5)
                                {
                                    PB1.Visible = false;
                                    PB2.Visible = false;
                                    PB3.Visible = false;
                                    PB4.Visible = false;
                                    PB5.Visible = false;
                                    PB6.Visible = true;
                                    PB7.Visible = false;
                                    PB8.Visible = false;
                                    PB9.Visible = false;
                                    PB10.Visible = false;
                                    PB11.Visible = false;
                                    PB12.Visible = false;
                                    PB13.Visible = false;
                                    PB14.Visible = false;
                                }
                                else
                                {
                                    if (Option == 6)
                                    {
                                        PB1.Visible = false;
                                        PB2.Visible = false;
                                        PB3.Visible = false;
                                        PB4.Visible = false;
                                        PB5.Visible = false;
                                        PB6.Visible = false;
                                        PB7.Visible = true;
                                        PB8.Visible = false;
                                        PB9.Visible = false;
                                        PB10.Visible = false;
                                        PB11.Visible = false;
                                        PB12.Visible = false;
                                        PB13.Visible = false;
                                        PB14.Visible = false;
                                    }
                                    else
                                    {
                                        if (Option == 7)
                                        {
                                            PB1.Visible = false;
                                            PB2.Visible = false;
                                            PB3.Visible = false;
                                            PB4.Visible = false;
                                            PB6.Visible = false;
                                            PB7.Visible = false;
                                            PB8.Visible = true;
                                            PB9.Visible = false;
                                            PB10.Visible = false;
                                            PB11.Visible = false;
                                            PB12.Visible = false;
                                            PB13.Visible = false;
                                            PB14.Visible = false;
                                        }
                                        else
                                        {
                                            if (Option == 8)
                                            {
                                                PB1.Visible = false;
                                                PB2.Visible = false;
                                                PB3.Visible = false;
                                                PB4.Visible = false;
                                                PB6.Visible = false;
                                                PB7.Visible = false;
                                                PB8.Visible = false;
                                                PB9.Visible = true;
                                                PB10.Visible = false;
                                                PB11.Visible = false;
                                                PB12.Visible = false;
                                                PB13.Visible = false;
                                                PB14.Visible = false;
                                            }
                                            else
                                            {
                                                if (Option == 9)
                                                {
                                                    PB1.Visible = false;
                                                    PB2.Visible = false;
                                                    PB3.Visible = false;
                                                    PB4.Visible = false;
                                                    PB6.Visible = false;
                                                    PB7.Visible = false;
                                                    PB8.Visible = false;
                                                    PB9.Visible = false;
                                                    PB10.Visible = true;
                                                    PB11.Visible = false;
                                                    PB12.Visible = false;
                                                    PB13.Visible = false;
                                                    PB14.Visible = false;
                                                    BTZoom.Visible = false;
                                                    Program.Zoom = 0;
                                                }
                                                else
                                                {
                                                    if (Option == 10)
                                                    {
                                                        PB1.Visible = false;
                                                        PB2.Visible = false;
                                                        PB3.Visible = false;
                                                        PB4.Visible = false;
                                                        PB6.Visible = false;
                                                        PB7.Visible = false;
                                                        PB8.Visible = false;
                                                        PB9.Visible = false;
                                                        PB10.Visible = false;
                                                        PB11.Visible = true;
                                                        PB12.Visible = false;
                                                        PB13.Visible = false;
                                                        PB14.Visible = false;
                                                        BTZoom.Visible = true;
                                                        Program.Zoom = 1;
                                                    }
                                                    else
                                                    {
                                                        if (Option == 11)
                                                        {
                                                            PB1.Visible = false;
                                                            PB2.Visible = false;
                                                            PB3.Visible = false;
                                                            PB4.Visible = false;
                                                            PB6.Visible = false;
                                                            PB7.Visible = false;
                                                            PB8.Visible = false;
                                                            PB9.Visible = false;
                                                            PB10.Visible = false;
                                                            PB11.Visible = false;
                                                            PB12.Visible = true;
                                                            PB13.Visible = false;
                                                            PB14.Visible = false;
                                                            BTZoom.Visible = true;
                                                            Program.Zoom = 2;
                                                        }
                                                        else
                                                        {
                                                            if (Option == 12)
                                                            {
                                                                PB1.Visible = false;
                                                                PB2.Visible = false;
                                                                PB3.Visible = false;
                                                                PB4.Visible = false;
                                                                PB6.Visible = false;
                                                                PB7.Visible = false;
                                                                PB8.Visible = false;
                                                                PB9.Visible = false;
                                                                PB10.Visible = false;
                                                                PB11.Visible = false;
                                                                PB12.Visible = false;
                                                                PB13.Visible = true;
                                                                PB14.Visible = false;
                                                                BTZoom.Visible = false;
                                                                BTAvançar.Enabled = true;
                                                                Program.Zoom = 0;
                                                            }
                                                            else
                                                            {
                                                                if (Option == 13)
                                                                {
                                                                    PB1.Visible = false;
                                                                    PB2.Visible = false;
                                                                    PB3.Visible = false;
                                                                    PB4.Visible = false;
                                                                    PB6.Visible = false;
                                                                    PB7.Visible = false;
                                                                    PB8.Visible = false;
                                                                    PB9.Visible = false;
                                                                    PB10.Visible = false;
                                                                    PB11.Visible = false;
                                                                    PB12.Visible = false;
                                                                    PB13.Visible = false;
                                                                    PB14.Visible = true;
                                                                    BTAvançar.Enabled = false;
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }

                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Informações_Load(object sender, EventArgs e)
        {
        }
        private void Informações_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.JInfor = 0;
        }

        private void BTZoom_Click(object sender, EventArgs e)
        {
            Works y = new Works();
            y.Show();
        }
    }
}
