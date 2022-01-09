using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M.H.S_Full_2._0
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        // Dados
        public static int Periodo = 0;
        public static int Massa = 0;
        public static int FaseInicial = 0;
        public static int Amplitude = 0;
        // -------------------------------------------------------------------------//
        // Cinematica
        public static double[] VescP = new double[5];
        public static double[] AceP = new double[5];
        public static double[] ElongP = new double[5];
        public static double[] TimeP = new double[5];
        // public static double Temp = 0, Acom = 0, Ax;
        // -------------------------------------------------------------------------//
        // Vetor Angulo
        public static double[] AngP = new double[5];
        // -------------------------------------------------------------------------//
        public static double EmP; // Energia
        public static double[] EcP = new double[5];
        public static double[] EpP = new double[5];
        // -------------------------------------------------------------------------//
        public static int EnlongMax = 0; // Enlongação Maxima
        public static int VelociMax = 0; // Velocidade Maxima
        public static int AceleraMax = 0; // Aceleração Maxima
        public static int GeralMax = 0;   // Geral Maxima
        public static double Coeficientek = 0; // Coeficiente da mola
        // -------------------------------------------------------------------------//
        public static int ControleGif = 0;
        public static int JEnlog = 0;
        public static int JVelo = 0;
        public static int JAcel = 0;
        public static int JEnerg = 0;
        public static int JGeral = 0;
        public static int JInfor = 0;
        // -------------------------------------------------------------------------//
        public static int Zoom = 0;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_MHS());
        }
    }
}
