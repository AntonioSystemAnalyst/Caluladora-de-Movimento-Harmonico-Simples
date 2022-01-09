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
    public partial class Main_MHS : Form
    {
        public static double[] Coseno = new double[91];
        public static double[] Seno = new double[91];
        public static double[] Tang = new double[91];

        // Cinematica
        public static double[] Vesc = new double[5];
        public static double[] Ace = new double[5];
        public static double[] Elong = new double[5];
        public static double[] Time = new double[5];
        public static double Temp = 0, Acom = 0, Ax;

        public static double Em; // Energia
        public static double[] Ec = new double[5];
        public static double[] Ep = new double[5];

        public static int Bt = 2;
        public static int Crt = 1;

        public Main_MHS()
        {
            InitializeComponent();
            timer1.Enabled = true;
            TxtAmplitude.Text   = "100";
            TxtFaseInicial.Text = "0";
            TxtMassa.Text       = "10";
            TxtPeriodo.Text     = "4";
            RTBox.Text = " ============================================\n  MHS - Simulação\n ============================================\n\n\n\n\n\n\n\n  Orphew Algorithms";
        }

        private void Main_MHS_Load(object sender, EventArgs e)
        {

        }

        public static void MHS3()
        {
            int i; // Repetição
            // -------------------------------------------------------------------------//
            double K, Vang = 1, M = 1, A = 1, T = 1, Fi = 1, Wgrau, Rs;   // Variaveis 
            // -------------------------------------------------------------------------//
            // Vetor Angulo
            double[] Ang = new double[5];
            // -------------------------------------------------------------------------//
           
            double Epmax = 0, Amax = 0, Vmax = 0, Ecmax = 0;
            // -------------------------------------------------------------------------//
            double PI = 3.14159265;
            double UPI = 0.0174533;
            // ----------------------------------------------- //
            // ----------------------------------------------- // Entradas
            T = Program.Periodo;     // Periodo
            M = Program.Massa;       // Massa
            Fi = Program.FaseInicial; // Fase inicial
            A = Program.Amplitude;   // Amplitude
            // ----------------------------------------------- //
            // ----------------------------------------------- //


            Vang = (2 * PI) / T; // Velocidade Angular
            Temp = (T / 4);
            K = Vang * Vang * M; // Coeficiencte elastico
            Program.Coeficientek = K;
            Wgrau = Math.Ceiling(Vang / UPI); // Velocidade Angular
            Time[0] = 0;
            for (i = 1; i < 5; i++)         // tempo
            {
                Acom = Acom + Temp;
                Time[i] = Acom;
            }
            for (i = 0; i < 5; i++)        // Angulo
            {
                Ang[i] = Time[i] * Wgrau + Fi;
            }

            for (i = 0; i < 5; i++)        // Elongação
            {
                Ax = Ang[i];
                if (Ax > 360)
                {
                    do
                    {
                        Ax = Ax - 360;
                    } while (Ax > 360);
                }
                Rs = Table(2, Ax);
                Elong[i] = A * Rs;
                if (Rs == 0)
                {
                    Elong[i] = Elong[i] * -1;
                }
            }
            for (i = 0; i < 5; i++)        // Velocidade
            {
                Ax = Ang[i];

                if (Ax > 360)
                {
                    do
                    {
                        Ax = Ax - 360;
                    } while (Ax > 360);

                }
                Rs = Table(1, Ax);
                Vesc[i] = (A * (-Vang)) * Rs;
                if (Rs == 0)
                {
                    Vesc[i] = Vesc[i] * -1;
                }
            }
            for (i = 0; i < 5; i++)         // Aceleração
            {
                Ax = Ang[i];
                if (Ax > 360)
                {
                    do
                    {
                        Ax = Ax - 360;
                    } while (Ax > 360);
                }
                Rs = Table(2, Ax);
                Ace[i] = (A * (-Vang * Vang)) * Rs;
                if (Rs == 0)
                {
                    Ace[i] = Ace[i] * -1;
                }
            }
            // --------------------------------------------------------------------------------// Cinematica
            // --------------------------------------------------------------------------------// Dinamica
            for (i = 0; i < 5; i++)
            {
                Ec[i] = (M * (Vesc[i] * Vesc[i])) / 2;
            }
            for (i = 0; i < 5; i++)
            {
                Ep[i] = (K * (Elong[i] * Elong[i])) / 2;
            }
            // --------------------------------------------------------------------------------// Dinamica
            for (i = 0; i < 5; i++)
            {
                if (Vmax < Vesc[i])
                {
                    Vmax = Vesc[i]; // Velocidade Max
                }
            }
            for (i = 0; i < 5; i++)
            {
                if (Amax < Ace[i])
                {
                    Amax = Ace[i]; //  Aceleracao Max
                }
            }
            for (i = 0; i < 5; i++)
            {
                if (Ecmax < Ec[i])
                {
                    Ecmax = Ec[i]; // Energ Cinetica  Max
                }
            }
            Epmax = Ecmax;
            Em = Epmax; //  Energ Mecanic
                        // --------------------------------------------------------------------------------// huehue
            for (i = 0; i < 5; i++)
            {
                Program.VescP[i] = Vesc[i];
                Program.ElongP[i] = Elong[i];
                Program.AceP[i] = Ace[i];
                Program.EpP[i] = Ep[i];
                Program.EcP[i] = Ec[i];

            }

            Program.EnlongMax = Convert.ToInt32(A + 10);
            Program.VelociMax = Convert.ToInt32(Vmax + 10);
            Program.AceleraMax = Convert.ToInt32(Amax + 10);
            Program.EmP = Em;

            if (A > Vmax && A > Amax)
            {
                Program.GeralMax = Convert.ToInt32(A + 10);
            }
            else
            {
                if (Vmax > A && Vmax > Amax)
                {
                    Program.GeralMax = Convert.ToInt32(Vmax + 10);
                }
                else
                {
                    if (Amax > A && Amax > Vmax + 10)
                    {
                        Program.GeralMax = Convert.ToInt32(Amax + 10);
                    }
                }
            }


        }
        // ----------------------------------------------- //
        // ----------------------------------------------- //
        public static double Table(int A, double B)
        {
            int i, cont = -1, T;
            double X, Y, N, R = 0;
            X = B;
            T = A;
            if (T == 1)
            {
                Seno[0] = 0.000000;
                Seno[1] = 0.017452;
                Seno[2] = 0.034899;
                Seno[3] = 0.052336;
                Seno[4] = 0.069756;
                Seno[5] = 0.087156;
                Seno[6] = 0.104528;
                Seno[7] = 0.121869;
                Seno[8] = 0.139173;
                Seno[9] = 0.156434;
                Seno[10] = 0.173648;
                Seno[11] = 0.190809;
                Seno[12] = 0.207912;
                Seno[13] = 0.224951;
                Seno[14] = 0.241922;
                Seno[15] = 0.258819;
                Seno[16] = 0.275637;
                Seno[17] = 0.292372;
                Seno[18] = 0.309017;
                Seno[19] = 0.325568;
                Seno[20] = 0.34202;
                Seno[21] = 0.358368;
                Seno[22] = 0.374607;
                Seno[23] = 0.390731;
                Seno[24] = 0.406737;
                Seno[25] = 0.422618;
                Seno[26] = 0.438371;
                Seno[27] = 0.45399;
                Seno[28] = 0.469472;
                Seno[29] = 0.48481;
                Seno[30] = 0.5;
                Seno[31] = 0.515038;
                Seno[32] = 0.529919;
                Seno[33] = 0.544639;
                Seno[34] = 0.559193;
                Seno[35] = 0.573576;
                Seno[36] = 0.587785;
                Seno[37] = 0.601815;
                Seno[38] = 0.615661;
                Seno[39] = 0.62932;
                Seno[40] = 0.642788;
                Seno[41] = 0.656059;
                Seno[42] = 0.669131;
                Seno[43] = 0.681998;
                Seno[44] = 0.694658;
                Seno[45] = 0.707107;
                Seno[46] = 0.71934;
                Seno[47] = 0.731354;
                Seno[48] = 0.743145;
                Seno[49] = 0.75471;
                Seno[50] = 0.766044;
                Seno[51] = 0.777146;
                Seno[52] = 0.788011;
                Seno[53] = 0.798636;
                Seno[54] = 0.809017;
                Seno[55] = 0.819152;
                Seno[56] = 0.829038;
                Seno[57] = 0.838671;
                Seno[58] = 0.848048;
                Seno[59] = 0.857167;
                Seno[60] = 0.866025;
                Seno[61] = 0.87462;
                Seno[62] = 0.882948;
                Seno[63] = 0.891007;
                Seno[64] = 0.898794;
                Seno[65] = 0.906308;
                Seno[66] = 0.913545;
                Seno[67] = 0.920505;
                Seno[68] = 0.927184;
                Seno[69] = 0.93358;
                Seno[70] = 0.939693;
                Seno[71] = 0.945519;
                Seno[72] = 0.951057;
                Seno[73] = 0.956305;
                Seno[74] = 0.961262;
                Seno[75] = 0.965926;
                Seno[76] = 0.970296;
                Seno[77] = 0.97437;
                Seno[78] = 0.978148;
                Seno[79] = 0.981627;
                Seno[80] = 0.984808;
                Seno[81] = 0.987688;
                Seno[82] = 0.990268;
                Seno[83] = 0.992546;
                Seno[84] = 0.994522;
                Seno[85] = 0.996195;
                Seno[86] = 0.997564;
                Seno[87] = 0.99863;
                Seno[88] = 0.999391;
                Seno[89] = 0.999848;
                Seno[90] = 1;
                if (X >= 0 && X <= 90)
                {
                    for (i = 0; i < 91; i++)
                    {
                        cont = cont + 1;
                        if (X == cont)
                        {
                            R = Seno[cont];
                        }
                    }
                }
                else
                {
                    if (X > 90 && X <= 180)
                    {
                        N = X - 90;
                        X = 90 - N;
                        for (i = 0; i < 91; i++)
                        {
                            cont = cont + 1;
                            if (X == cont)
                            {
                                R = Seno[cont];
                            }
                        }
                    }
                    else
                    {
                        if (X > 180 && X <= 270)
                        {
                            X = (X - 180);
                            for (i = 0; i < 91; i++)
                            {
                                cont = cont + 1;
                                if (X == cont)
                                {
                                    R = Seno[cont] * -1;
                                }
                            }
                        }
                        else
                        {
                            if (X > 270 && X <= 360)
                            {
                                Y = X - 180;
                                N = Y - 90;
                                X = 90 - N;
                                for (i = 0; i < 91; i++)
                                {
                                    cont = cont + 1;
                                    if (X == cont)
                                    {
                                        R = Seno[cont] * -1;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                if (T == 2)
                {
                    Coseno[0] = 1;
                    Coseno[1] = 0.999848;
                    Coseno[2] = 0.999391;
                    Coseno[3] = 0.99863;
                    Coseno[4] = 0.997564;
                    Coseno[5] = 0.996195;
                    Coseno[6] = 0.994522;
                    Coseno[7] = 0.992546;
                    Coseno[8] = 0.990268;
                    Coseno[9] = 0.987688;
                    Coseno[10] = 0.984808;
                    Coseno[11] = 0.981627;
                    Coseno[12] = 0.978148;
                    Coseno[13] = 0.97437;
                    Coseno[14] = 0.970296;
                    Coseno[15] = 0.965926;
                    Coseno[16] = 0.961262;
                    Coseno[17] = 0.956305;
                    Coseno[18] = 0.951057;
                    Coseno[19] = 0.945519;
                    Coseno[20] = 0.939693;
                    Coseno[21] = 0.93358;
                    Coseno[22] = 0.927184;
                    Coseno[23] = 0.920505;
                    Coseno[24] = 0.913545;
                    Coseno[25] = 0.906308;
                    Coseno[26] = 0.898794;
                    Coseno[27] = 0.891007;
                    Coseno[28] = 0.882948;
                    Coseno[29] = 0.87462;
                    Coseno[30] = 0.866025;
                    Coseno[31] = 0.857167;
                    Coseno[32] = 0.848048;
                    Coseno[33] = 0.838671;
                    Coseno[34] = 0.829038;
                    Coseno[35] = 0.819152;
                    Coseno[36] = 0.809017;
                    Coseno[37] = 0.798636;
                    Coseno[38] = 0.788011;
                    Coseno[39] = 0.777146;
                    Coseno[40] = 0.766044;
                    Coseno[41] = 0.75471;
                    Coseno[42] = 0.743145;
                    Coseno[43] = 0.731354;
                    Coseno[44] = 0.71934;
                    Coseno[45] = 0.707107;
                    Coseno[46] = 0.694658;
                    Coseno[47] = 0.681998;
                    Coseno[48] = 0.669131;
                    Coseno[49] = 0.656059;
                    Coseno[50] = 0.642788;
                    Coseno[51] = 0.62932;
                    Coseno[52] = 0.615661;
                    Coseno[53] = 0.601815;
                    Coseno[54] = 0.587785;
                    Coseno[55] = 0.573576;
                    Coseno[56] = 0.559193;
                    Coseno[57] = 0.544639;
                    Coseno[58] = 0.529919;
                    Coseno[59] = 0.515038;
                    Coseno[60] = 0.5;
                    Coseno[61] = 0.48481;
                    Coseno[62] = 0.469472;
                    Coseno[63] = 0.45399;
                    Coseno[64] = 0.438371;
                    Coseno[65] = 0.422618;
                    Coseno[66] = 0.406737;
                    Coseno[67] = 0.390731;
                    Coseno[68] = 0.374607;
                    Coseno[69] = 0.358368;
                    Coseno[70] = 0.34202;
                    Coseno[71] = 0.325568;
                    Coseno[72] = 0.309017;
                    Coseno[73] = 0.292372;
                    Coseno[74] = 0.275637;
                    Coseno[75] = 0.258819;
                    Coseno[76] = 0.241922;
                    Coseno[77] = 0.224951;
                    Coseno[78] = 0.207912;
                    Coseno[79] = 0.190809;
                    Coseno[80] = 0.173648;
                    Coseno[81] = 0.156434;
                    Coseno[82] = 0.139173;
                    Coseno[83] = 0.121869;
                    Coseno[84] = 0.104528;
                    Coseno[85] = 0.087156;
                    Coseno[86] = 0.069756;
                    Coseno[87] = 0.052336;
                    Coseno[88] = 0.034899;
                    Coseno[89] = 0.017452;
                    Coseno[90] = 0;
                    if (X >= 0 && X <= 90)
                    {
                        for (i = 0; i < 91; i++)
                        {
                            cont = cont + 1;
                            if (X == cont)
                            {
                                R = Coseno[cont];
                            }
                        }
                    }
                    else
                    {
                        if (X > 90 && X <= 180)
                        {
                            N = X - 90;
                            X = 90 - N;
                            for (i = 0; i < 91; i++)
                            {
                                cont = cont + 1;
                                if (X == cont)
                                {
                                    R = Coseno[cont] * -1;
                                }
                            }
                        }
                        else
                        {
                            if (X > 180 && X <= 270)
                            {
                                X = (X - 180);
                                for (i = 0; i < 91; i++)
                                {
                                    cont = cont + 1;
                                    if (X == cont)
                                    {
                                        R = Coseno[cont] * -1;
                                    }
                                }
                            }
                            else
                            {
                                if (X > 270 && X <= 360)
                                {
                                    Y = X - 180;
                                    N = Y - 90;
                                    X = 90 - N;
                                    for (i = 0; i < 91; i++)
                                    {
                                        cont = cont + 1;
                                        if (X == cont)
                                        {
                                            R = Coseno[cont];
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (T == 3)
                    {
                        Tang[0] = 0;
                        Tang[1] = 0.017455;
                        Tang[2] = 0.034921;
                        Tang[3] = 0.052408;
                        Tang[4] = 0.069927;
                        Tang[5] = 0.087489;
                        Tang[6] = 0.105104;
                        Tang[7] = 0.122785;
                        Tang[8] = 0.140541;
                        Tang[9] = 0.158384;
                        Tang[10] = 0.176327;
                        Tang[11] = 0.19438;
                        Tang[12] = 0.212557;
                        Tang[13] = 0.230868;
                        Tang[14] = 0.249328;
                        Tang[15] = 0.267949;
                        Tang[16] = 0.286745;
                        Tang[17] = 0.305731;
                        Tang[18] = 0.32492;
                        Tang[19] = 0.344328;
                        Tang[20] = 0.36397;
                        Tang[21] = 0.383864;
                        Tang[22] = 0.404026;
                        Tang[23] = 0.424475;
                        Tang[24] = 0.445229;
                        Tang[25] = 0.466308;
                        Tang[26] = 0.487733;
                        Tang[27] = 0.509525;
                        Tang[28] = 0.531709;
                        Tang[29] = 0.554309;
                        Tang[30] = 0.57735;
                        Tang[31] = 0.600861;
                        Tang[32] = 0.624869;
                        Tang[33] = 0.649408;
                        Tang[34] = 0.674509;
                        Tang[35] = 0.700208;
                        Tang[36] = 0.726543;
                        Tang[37] = 0.753554;
                        Tang[38] = 0.781286;
                        Tang[39] = 0.809784;
                        Tang[40] = 0.8391;
                        Tang[41] = 0.869287;
                        Tang[42] = 0.900404;
                        Tang[43] = 0.932515;
                        Tang[44] = 0.965689;
                        Tang[45] = 1;
                        Tang[46] = 1.03553;
                        Tang[47] = 1.072369;
                        Tang[48] = 1.110613;
                        Tang[49] = 1.150368;
                        Tang[50] = 1.191754;
                        Tang[51] = 1.234897;
                        Tang[52] = 1.279942;
                        Tang[53] = 1.327045;
                        Tang[54] = 1.376382;
                        Tang[55] = 1.428148;
                        Tang[56] = 1.482561;
                        Tang[57] = 1.539865;
                        Tang[58] = 1.600335;
                        Tang[59] = 1.664279;
                        Tang[60] = 1.732051;
                        Tang[61] = 1.804048;
                        Tang[62] = 1.880726;
                        Tang[63] = 1.962611;
                        Tang[64] = 2.050304;
                        Tang[65] = 2.144507;
                        Tang[66] = 2.246037;
                        Tang[67] = 2.355852;
                        Tang[68] = 2.475087;
                        Tang[69] = 2.605089;
                        Tang[70] = 2.747477;
                        Tang[71] = 2.904211;
                        Tang[72] = 3.077684;
                        Tang[73] = 3.270853;
                        Tang[74] = 3.487414;
                        Tang[75] = 3.732051;
                        Tang[76] = 4.010781;
                        Tang[77] = 4.331476;
                        Tang[78] = 4.70463;
                        Tang[79] = 5.144554;
                        Tang[80] = 5.671282;
                        Tang[81] = 6.313752;
                        Tang[82] = 7.11537;
                        Tang[83] = 8.144346;
                        Tang[84] = 9.514364;
                        Tang[85] = 11.43005;
                        Tang[86] = 14.30067;
                        Tang[87] = 19.08114;
                        Tang[88] = 28.63625;
                        Tang[89] = 57.28996;
                        Tang[90] = 0;
                        if (X >= 0 && X < 90)
                        {
                            for (i = 0; i < 91; i++)
                            {
                                cont = cont + 1;
                                if (X == cont)
                                {
                                    R = Tang[cont];
                                }
                            }
                        }
                        else
                        {
                            if (X > 90 && X <= 180)
                            {
                                N = X - 90;
                                X = 90 - N;
                                for (i = 0; i < 91; i++)
                                {
                                    cont = cont + 1;
                                    if (X == cont)
                                    {
                                        R = Tang[cont] * -1;
                                    }
                                }
                            }
                            else
                            {
                                if (X > 180 && X < 270)
                                {
                                    X = (X - 180);
                                    for (i = 0; i < 91; i++)
                                    {
                                        cont = cont + 1;
                                        if (X == cont)
                                        {
                                            R = Tang[cont];
                                        }
                                    }
                                }
                                else
                                {
                                    if (X > 270 && X < 360)
                                    {
                                        Y = X - 180;
                                        N = Y - 90;
                                        X = 90 - N;
                                        for (i = 0; i < 91; i++)
                                        {
                                            cont = cont + 1;
                                            if (X == cont)
                                            {
                                                R = Tang[cont];
                                            }
                                        }
                                    }
                                    if (X == 90 || X == 270)
                                    {
                                        Console.WriteLine(" N existe");
                                        R = -123;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return R;
        }
        // ---------------------------------------------------------------- //
        // ---------------------------------------------------------------- //
        private void BTIniciar_Click(object sender, EventArgs e)
        {
            int i;
            try
            {
                if (TxtFaseInicial.Text != "" || TxtAmplitude.Text != "" || TxtPeriodo.Text != "" || TxtMassa.Text != "")
                {
                    if (Bt % 2 == 0)
                    {
                        Bt = Bt + 1;

                        Program.FaseInicial = Convert.ToInt32(TxtFaseInicial.Text);
                        Program.Amplitude = int.Parse(TxtAmplitude.Text);
                        Program.Periodo = int.Parse(TxtPeriodo.Text);
                        Program.Massa = int.Parse(TxtMassa.Text);

                        TxtFaseInicial.ReadOnly = true;
                        TxtPeriodo.ReadOnly = true;
                        TxtMassa.ReadOnly = true;
                        TxtAmplitude.ReadOnly = true;
                        Crt = 100;
                        MHS3();
                        BTIniciar.Text = "Reiniciar";
                        RTBox.Text = " ============================================\n  MHS - O.A.\n ============================================\n Periodo (s): " + Program.Periodo + " \n Amplitude (m): " + Program.Amplitude + "\n Fase inicial (rad): " + Program.FaseInicial + "\n Massa (kg): " + Program.Massa + "\n ============================================\n Coeficiente elastico (n/m): " + Program.Coeficientek + " \n\n Velocidade Maxima (m/s): " + (Program.VelociMax - 10) + "\n Velocidade Mimina (m/s): -" + (Program.VelociMax - 10) + "\n\n Aceleração Maxima (m/s/s): " + (Program.AceleraMax - 10) + " \n Aceleração Minima (m/s/s): -" + (Program.AceleraMax - 10) + "\n ============================================\n Energia Mecânica (J): " + Program.EmP + "\n Energia Cinética maxima (J):  " + Program.EmP + "\n Energia Potêncial maxima (J): " + Program.EmP + "\n ============================================\n";
                        RTBox.Text += " Enlogação:\n\n";
                        for (i=0; i<5; i++)
                        {
                            RTBox.Text += "   ["+i+"] = " +Elong[i]+ " m\n"; 
                        }
                        RTBox.Text += "\n ============================================\n";
                        RTBox.Text += " Velocidade:\n\n";
                        for (i = 0; i < 5; i++)
                        {
                            RTBox.Text += "   [" + i + "] = " + Vesc[i] + " m/s\n";
                        }
                        RTBox.Text += "\n ============================================\n";
                        RTBox.Text += " Aceleração:\n\n";
                        for (i = 0; i < 5; i++)
                        {
                            RTBox.Text += "   [" + i + "] = " +Ace[i] + " m/s^2\n";
                        }
                        RTBox.Text += "\n ============================================\n";
                        RTBox.Text += " Energia cinética:\n\n";
                        for (i = 0; i < 5; i++)
                        {
                            RTBox.Text += "   [" + i + "] = " + Ec[i] + " j\n";
                        }
                        RTBox.Text += "\n ============================================\n";
                        RTBox.Text += " Energia potêncial:\n\n";
                        
                        for (i = 0; i < 5; i++)
                        {
                            RTBox.Text += "   [" + i + "] = " + Ep[i] + " j\n";
                        }
                        RTBox.Text += "\n ============================================\n";
                    }
                    else
                    {

                        Bt = Bt + 1;

                        TxtAmplitude.Text = "";
                        TxtFaseInicial.Text = "";
                        TxtMassa.Text = "";
                        TxtPeriodo.Text = "";
                        RTBox.Text = " ============================================\n  MHS - Simulação\n ============================================\n\n\n\n\n\n\n\n  Orphew Algorithms";
                        TxtFaseInicial.ReadOnly = false;
                        TxtPeriodo.ReadOnly = false;
                        TxtMassa.ReadOnly = false;
                        TxtAmplitude.ReadOnly = false;
                        Crt = 1;
                        BTIniciar.Text = "Iniciar";
                    }
                }
            }
            catch
            {
                TxtFaseInicial.Text = "ERRO!";
                TxtPeriodo.Text     = "ERRO!";
                TxtMassa.Text       = "ERRO!";
                TxtAmplitude.Text   = "ERRO!";
                Bt = 3;
                BTIniciar.Text = "Reiniciar";
            }
        }

        private void BTElongação_Click(object sender, EventArgs e)
        {
            if (Program.JEnlog == 0)
            {
                if (Crt == 100)
                {
                    Elongação x = new Elongação();
                    x.Show();
                    Program.JEnlog = 1;
                    BTElongação.Enabled = false;
                }
            }
        }

        private void BTVelocidade_Click(object sender, EventArgs e)
        {
            if (Program.JVelo == 0)
            {
                if (Crt == 100)
                {
                    Velocidade x = new Velocidade();
                    x.Show();
                    Program.JVelo = 1;
                    BTVelocidade.Enabled = false;
                }
            }
        }

        private void BTAceleração_Click(object sender, EventArgs e)
        {
            if (Program.JAcel == 0)
            {
                if (Crt == 100)
                {
                    Aceleração x = new Aceleração();
                    x.Show();
                    Program.JAcel = 1;
                    BTAceleração.Enabled = false;
                }
            }
        }

        private void BTEnergia_Click(object sender, EventArgs e)
        {
            if (Program.JEnerg == 0)
            {
                if (Crt == 100)
                {
                    Energia x = new Energia();
                    x.Show();
                    Program.JEnerg = 1;
                    BTEnergia.Enabled = false;
                }
            }
        }

        private void BTGeral_Click(object sender, EventArgs e)
        {
            if (Program.JGeral == 0)
            {
                if (Crt == 100)
                {
                    Geral x = new Geral();
                    x.Show();
                    Program.JGeral = 1;
                    BTGeral.Enabled = false;
                }
            }
        }

        private void BTAnimação_Click(object sender, EventArgs e)
        {
            if (Program.JInfor == 0)
            {
                Program.ControleGif = 0;
                Informações x = new Informações();
                x.Show();
                Program.JInfor = 1;
                BTAnimação.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Program.JEnlog == 0)
            {
                BTElongação.Enabled = true;
            }
            if (Program.JEnerg == 0)
            {
                BTEnergia.Enabled = true;
            }
            if (Program.JAcel == 0)
            {
                BTAceleração.Enabled = true;
            }
            if (Program.JGeral == 0)
            {
                BTGeral.Enabled = true;
            }
            if (Program.JInfor == 0)
            {
                BTAnimação.Enabled = true;
            }
            if (Program.JVelo == 0)
            {
                BTVelocidade.Enabled = true;
            }
        }

  


        // ---------------------------------------------------------------- //
        // ---------------------------------------------------------------- //
    }
}
