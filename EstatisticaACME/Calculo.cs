using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstatisticaACME
{
    class Calculo
    {
        public float[] amostra;
        private int qtdValores;

        #region Construtores
            public Calculo(float[] rol)
            {
                amostra = new float[rol.Length];
                amostra = rol;
                qtdValores = amostra.Length;
            }
        #endregion

            public float R//Valor MAX - Valor MIN. Usado para calcular o Numero de linhas da tabela.
            {
                get { return amostra[qtdValores - 1] - amostra[0]; }
            }

            public float K//Amplitude da classe
            {
                    
                get { return (float)((int)(((R / H) + 0.4f) * 2.0f)) * 0.5f; }
            }

            public int H//Numero de linhas da tabela
            {
                get { return 10; }
            }

            public float N//Quantidade de elementos da amostra
            {
                get { return amostra.Distinct().ToArray().Length; }
            }

            #region Classes
            public float[] klass1
            {
                get{
                    float[] valors = new float[2];
                    valors[0] = (amostra[0] -1);
                    valors[1] = float.Parse(Math.Round((valors[0] + K),2).ToString());
                    return valors;
                  }
                
            }

            public float[] klass2
            {
                get
                {
                    float[] valors = new float[2];
                    valors[0] = klass1[1];
                    valors[1] = float.Parse(Math.Round((valors[0] + K), 2).ToString());
                    return valors;
                }
            }

            public float[] klass3
            {
                get
                {
                    float[] valors = new float[2];
                    valors[0] = klass2[1];
                    valors[1] = float.Parse(Math.Round((valors[0] + K), 2).ToString());
                    return valors;
                }

            }

            public float[] klass4
            {
                get
                {
                    float[] valors = new float[2];
                    valors[0] = klass3[1];
                    valors[1] = float.Parse(Math.Round((valors[0] + K), 2).ToString());
                    return valors;
                }

            }

            public float[] klass5
            {
                get
                {
                    float[] valors = new float[2];
                    valors[0] = klass4[1];
                    valors[1] = float.Parse(Math.Round((valors[0] + K), 2).ToString());
                    return valors;
                }

            }

            public float[] klass6
            {
                get
                {
                    float[] valors = new float[2];
                    valors[0] = klass5[1];
                    valors[1] = float.Parse(Math.Round((valors[0] + K), 2).ToString());
                    return valors;
                }

            }

            public float[] klass7
            {
                get
                {
                    float[] valors = new float[2];
                    valors[0] = klass6[1];
                    valors[1] = float.Parse(Math.Round((valors[0] + K), 2).ToString());
                    return valors;
                }

            }

            public float[] klass8
            {
                get
                {
                    float[] valors = new float[2];
                    valors[0] = klass7[1];
                    valors[1] = float.Parse(Math.Round((valors[0] + K), 2).ToString());
                    return valors;
                }

            }

            public float[] klass9
            {
                get
                {
                    float[] valors = new float[2];
                    valors[0] = klass8[1];
                    valors[1] = float.Parse(Math.Round((valors[0] + K), 2).ToString());
                    return valors;
                }

            }

            public float[] klass10
            {
                get
                {
                    float[] valors = new float[2];
                    valors[0] = klass9[1];
                    valors[1] = float.Parse(Math.Round((valors[0] + K), 2).ToString());
                    return valors;
                }

            }
            #endregion

            public float Fi//Quantidade de vezes que aparece um elemento
            {

            }
    }
}
