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
    public partial class CriacaoTabela : Form
    {
        float[] amostra;
        ComboBox combo = new ComboBox();
        public CriacaoTabela(float[] amostrai)
        {
            InitializeComponent();
            Calculo calcula = new Calculo(amostrai);
            lblTeste.Text = calcula.Fi(1).ToString();
            amostra = amostrai;
        }

        public CriacaoTabela(float[] amostra, string[] classe)
        {
            InitializeComponent();
        }

        private void CriacaoTabela_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void oque(ComboBox comboi)
        {
            combo = comboi;

            switch (combo.SelectedIndex)
            {
                case 0://Classes
                    classes(colunas);
                    break;
                case 1://FAC
                    facs(colunas);
                    break;
                case 2://Fi
                    fis(colunas);
                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                default:
                    break;
            }
        }

        private Label[] colunas
        {
            get
            {
                #region Colunas
                #region Coluna 1
                Label[] colu1 = new Label[10];
                colu1[0] = col1lin1;
                colu1[1] = col1lin2;
                colu1[2] = col1lin3;
                colu1[3] = col1lin4;
                colu1[4] = col1lin5;
                colu1[5] = col1lin6;
                colu1[6] = col1lin7;
                colu1[7] = col1lin8;
                colu1[8] = col1lin9;
                colu1[9] = col1lin10;
                #endregion

                #region Coluna 2
                Label[] colu2 = new Label[10];
                colu2[0] = col2lin1;
                colu2[1] = col2lin2;
                colu2[2] = col2lin3;
                colu2[3] = col2lin4;
                colu2[4] = col2lin5;
                colu2[5] = col2lin6;
                colu2[6] = col2lin7;
                colu2[7] = col2lin8;
                colu2[8] = col2lin9;
                colu2[9] = col2lin10;
                #endregion

                #region Coluna 3
                Label[] colu3 = new Label[10];
                colu3[0] = col3lin1;
                colu3[1] = col3lin2;
                colu3[2] = col3lin3;
                colu3[3] = col3lin4;
                colu3[4] = col3lin5;
                colu3[5] = col3lin6;
                colu3[6] = col3lin7;
                colu3[7] = col3lin8;
                colu3[8] = col3lin9;
                colu3[9] = col3lin10;
                #endregion

                #region Coluna 4
                Label[] colu4 = new Label[10];
                colu4[0] = col4lin1;
                colu4[1] = col4lin2;
                colu4[2] = col4lin3;
                colu4[3] = col4lin4;
                colu4[4] = col4lin5;
                colu4[5] = col4lin6;
                colu4[6] = col4lin7;
                colu4[7] = col4lin8;
                colu4[8] = col4lin9;
                colu4[9] = col4lin10;
                #endregion

                #region Coluna 5
                Label[] colu5 = new Label[10];
                colu5[0] = col5lin1;
                colu5[1] = col5lin2;
                colu5[2] = col5lin3;
                colu5[3] = col5lin4;
                colu5[4] = col5lin5;
                colu5[5] = col5lin6;
                colu5[6] = col5lin7;
                colu5[7] = col5lin8;
                colu5[8] = col5lin9;
                colu5[9] = col5lin10;
                #endregion

                #region Coluna 6
                Label[] colu6 = new Label[10];
                colu6[0] = col6lin1;
                colu6[1] = col6lin2;
                colu6[2] = col6lin3;
                colu6[3] = col6lin4;
                colu6[4] = col6lin5;
                colu6[5] = col6lin6;
                colu6[6] = col6lin7;
                colu6[7] = col6lin8;
                colu6[8] = col6lin9;
                colu6[9] = col6lin10;
                #endregion
                #endregion
                switch (combo.Name)
                {
                    case "col1" :
                        return colu1;
                    case "col2":
                        return colu2;
                    case "col3":
                        return colu3;
                    case "col4":
                        return colu4;
                    case "col5" :
                        return colu5;
                    case "col6" :
                        return colu6;
                    default:
                        return null;
                }
            }
        }


        private void classes(Label[] col)
        {
            Calculo calculo = new Calculo(amostra);
            string[] klas = new string[10];
            #region klass
            klas[0] = calculo.klass1[0].ToString() + " : " + calculo.klass1[1].ToString();
            klas[1] = calculo.klass2[0].ToString() + " : " + calculo.klass2[1].ToString();
            klas[2] = calculo.klass3[0].ToString() + " : " + calculo.klass3[1].ToString();
            klas[3] = calculo.klass4[0].ToString() + " : " + calculo.klass4[1].ToString();
            klas[4] = calculo.klass5[0].ToString() + " : " + calculo.klass5[1].ToString();
            klas[5] = calculo.klass6[0].ToString() + " : " + calculo.klass6[1].ToString();
            klas[6] = calculo.klass7[0].ToString() + " : " + calculo.klass7[1].ToString();
            klas[7] = calculo.klass8[0].ToString() + " : " + calculo.klass8[1].ToString();
            klas[8] = calculo.klass9[0].ToString() + " : " + calculo.klass9[1].ToString();
            klas[9] = calculo.klass10[0].ToString() + " : " + calculo.klass10[1].ToString();
            #endregion
            for (int i = 0; i < calculo.H; i++)
            {
                col[i].Text = klas[i];
            }
        }

        private void fis(Label[] col)
        {
            Calculo calculo = new Calculo(amostra);
            for (int i = 0; i < calculo.H; i++)
            {
                col[i].Text = calculo.Fi(i).ToString() ;
            }
        }

        private void facs(Label[] col)
        {
            Calculo calculo = new Calculo(amostra);
            for (int i = 0; i < calculo.H; i++)
            {
                col[i].Text = calculo.FAC(i).ToString();
            }
        }

        private void col1_SelectedIndexChanged(object sender, EventArgs e)
        {
            oque(col1);
        }

        private void col2_SelectedIndexChanged(object sender, EventArgs e)
        {
            oque(col2);
        }

        private void col3_SelectedIndexChanged(object sender, EventArgs e)
        {
            oque(col3);
        }

        private void col4_SelectedIndexChanged(object sender, EventArgs e)
        {
            oque(col4);
        }

        private void col5_SelectedIndexChanged(object sender, EventArgs e)
        {
            oque(col5);
        }

        private void col6_SelectedIndexChanged(object sender, EventArgs e)
        {
            oque(col6);
        }
    }
}
