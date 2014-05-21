using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EstatisticaACME
{
    public partial class ResultadosGraficos : Form
    {
        float[] amostra;
        public ResultadosGraficos(float[] amostrai)
        {
            amostra = amostrai;
            InitializeComponent();
            PrintText();
        }

        public void PrintText()
        {
            Calculo calculo = new Calculo(amostra);
            lblMedia.Text = Math.Round(calculo.Media, 3).ToString();
            lblValores.Text = calculo.N.ToString();
            lblModa.Text = calculo.Moda.ToString();
            lblMediana.Text = calculo.Mediana.ToString();
            lblDesvio.Text = calculo.Desvio.ToString();
        }

        private void ResultadosGraficos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
