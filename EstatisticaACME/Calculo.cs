﻿using System;
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

            public int Fi(int i)//Quantidade de vezes que aparecem elementos em determinadas classes
            {
                switch (i)
                {
                    case 1:
                        return Array.FindAll(amostra, x => x >= klass1[0] && x <= klass1[1]).Length;
                    case 2:
                        return Array.FindAll(amostra, x => x >= klass2[0] && x <= klass2[1]).Length;
                    case 3:
                        return Array.FindAll(amostra, x => x >= klass3[0] && x <= klass3[1]).Length;
                    case 4:
                        return Array.FindAll(amostra, x => x >= klass4[0] && x <= klass4[1]).Length;
                    case 5:
                        return Array.FindAll(amostra, x => x >= klass5[0] && x <= klass5[1]).Length;
                    case 6:
                        return Array.FindAll(amostra, x => x >= klass6[0] && x <= klass6[1]).Length;
                    case 7:
                        return Array.FindAll(amostra, x => x >= klass7[0] && x <= klass7[1]).Length;
                    case 8:
                        return Array.FindAll(amostra, x => x >= klass8[0] && x <= klass8[1]).Length;
                    case 9:
                        return Array.FindAll(amostra, x => x >= klass9[0] && x <= klass9[1]).Length;
                    case 10:
                        return Array.FindAll(amostra, x => x >= klass10[0] && x <= klass10[1]).Length;
                    default:
                        break;
                }
                return 0;
            }

            public int FAC(int i)//Frequencia acumulada
            {
                switch (i)
                {
                    case 1:
                        return 0;
                    case 2:
                        return Fi(1);
                    case 3:
                        return FAC(2) + Fi(2);
                    case 4:
                        return FAC(3) + Fi(3);
                    case 5:
                        return FAC(4) + Fi(4);
                    case 6:
                        return FAC(5) + Fi(5);
                    case 7:
                        return FAC(6) + Fi(6);
                    case 8:
                        return FAC(7) + Fi(7);
                    case 9:
                        return FAC(8) + Fi(8);
                    case 10:
                        return FAC(9) + Fi(9);
                    default:
                        break;
                }
                return 0;
            }
    }
}
