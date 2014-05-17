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
    public partial class InsercaoDados : Form
    {
        float[] amostra;
        string[] classe;

        public InsercaoDados()
        {
            InitializeComponent();
        }

        private void txtEntrada_TextChanged(object sender, EventArgs e)
        {
            if (rdoContinua.Checked == true) { ParserContinua(); }
            if (rdoDiscreta.Checked == true) { ParserDiscreta(); }
        }

        private void ParserContinua()
        {
            txtRol.Clear();
            try
            {
                if (!txtEntrada.Text.EndsWith("-"))
                {
                    amostra = Array.ConvertAll<string, float>(txtEntrada.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), float.Parse);
                    Array.Sort(amostra);
                    for (float i = 0; i < amostra.Length; i++)
                    {
                        txtRol.Text += amostra[int.Parse(i.ToString())].ToString() + " : ";
                    }
                }
            }
            catch
            {
                MessageBox.Show("O formato da amostra não está correto. Use - '15,15,21,32,15'");
            }
        }

        private void ParserDiscreta()
        {
            txtRol.Clear();

                string[] amostraDiscreta = new string[txtEntrada.TextLength];
                    if (!txtEntrada.Text.EndsWith("-"))
                    {
                        amostraDiscreta = txtEntrada.Text.Split(new char[] { ';' });
                    }

                    classe = new string[amostraDiscreta.Length];
                    for (int i = 0; i < amostraDiscreta.Length; i++)
                    {
                        string aux = amostraDiscreta[i];
                        string aux2 = "";
                        for (int j = 0; j < aux.Length; j++)
                        {
                            if (aux[j].ToString() == ":")
                            {
                                for (int x = 0; x < j; x++)
                                {
                                    classe[i] += aux[x];
                                }
                                if (char.IsNumber(aux, aux.Length - 1))
                                {
                                    for (int x = j + 1; x < aux.Length; x++)
                                    {
                                        aux2 += aux[x];
                                    }
                                    amostra[i] = float.Parse(aux2);
                                }
                            }
                        }
                    }

                    for (float k = 0; k < amostraDiscreta.Length; k++)
                    {
                        txtRol.Text += amostraDiscreta[int.Parse(k.ToString())] + " : ";
                    }

        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (rdoContinua.Checked == true)
            {
                CriacaoTabela criacao = new CriacaoTabela(amostra);
                this.Hide();
                criacao.Show();
            }
            else
            {
                CriacaoTabela criacao = new CriacaoTabela(amostra, classe);
                this.Hide();
                criacao.Show();
            }
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtEntrada.Clear();
                Random rand = new Random();
                for (int i = 0; i < int.Parse(txtBox.Text); i++)
                {
                    txtEntrada.Text += rand.Next(-50, 50) + " ";
                }
            }
            catch
            {
                MessageBox.Show("Apenas numeros!");
            }
        }
    }
}
