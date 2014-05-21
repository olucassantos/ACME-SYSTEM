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
                get{
                    float x = (R / H);
                    int y = (int)x; // Descarta a parte decimal, arredondando pra baixo
                    if (0 < x - y && x - y <= 0.5) // Se a parte decimal for não-nula e menor ou igual a 0.5
                        x = y + (float)0.5;                 // acrescenta 0.5 à parte inteira
                    else if (0.5 < x - y) // Se a parte decimal for não-nula e maior a 0.5
                        x = y + 1;

                    return x;
                    }
            }

            public int H//Numero de linhas da tabela
            {
                get { 
                        int h = (int)(Math.Ceiling(Math.Sqrt(N)));
                        if (h > 10) { return 10; };
                        return h;
                    }
            }

            public int N//Quantidade de elementos da amostra
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
                int a = 0;
                switch (i)
                {
                    case 1:
                        return a = Array.FindAll(amostra, x => x > klass1[0] && x <= klass1[1]).Length;
                    case 2:
                        return a = Array.FindAll(amostra, x => x > klass2[0] && x <= klass2[1]).Length;
                    case 3:
                        return a = Array.FindAll(amostra, x => x > klass3[0] && x <= klass3[1]).Length;
                    case 4:
                        return a = Array.FindAll(amostra, x => x > klass4[0] && x <= klass4[1]).Length;
                    case 5:
                        return a = Array.FindAll(amostra, x => x > klass5[0] && x <= klass5[1]).Length;
                    case 6:
                        return a = Array.FindAll(amostra, x => x > klass6[0] && x <= klass6[1]).Length;
                    case 7:
                        return a = Array.FindAll(amostra, x => x > klass7[0] && x <= klass7[1]).Length;
                    case 8:
                        return a = Array.FindAll(amostra, x => x > klass8[0] && x <= klass8[1]).Length;
                    case 9:
                        return a = Array.FindAll(amostra, x => x > klass9[0] && x <= klass9[1]).Length;
                    case 10:
                        return a = Array.FindAll(amostra, x => x > klass10[0] && x <= klass10[1]).Length;
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
                        return Fi(1);
                    case 2:
                        return FAC(1) + Fi(2);
                    case 3:
                        return FAC(2) + Fi(3);
                    case 4:
                        return FAC(3) + Fi(4);
                    case 5:
                        return FAC(4) + Fi(5);
                    case 6:
                        return FAC(5) + Fi(6);
                    case 7:
                        return FAC(6) + Fi(7);
                    case 8:
                        return FAC(7) + Fi(8);
                    case 9:
                        return FAC(8) + Fi(9);
                    case 10:
                        return FAC(9) + Fi(10);
                    default:
                        break;
                }
                return 0;
            }

            public float xis(int i)//Valor do classe
            {
                switch (i)
                {
                    case 1:
                        return (klass1[0] + klass1[1]) / 2;
                    case 2:
                        return (klass2[0] + klass2[1]) / 2;
                    case 3:
                        return (klass3[0] + klass3[1]) / 2;
                    case 4:
                        return (klass4[0] + klass4[1]) / 2;
                    case 5:
                        return (klass5[0] + klass5[1]) / 2;
                    case 6:
                        return (klass6[0] + klass6[1]) / 2;
                    case 7:
                        return (klass7[0] + klass7[1]) / 2;
                    case 8:
                        return (klass8[0] + klass8[1]) / 2;
                    case 9:
                        return (klass9[0] + klass9[1]) / 2;
                    case 10:
                        return (klass10[0] + klass10[1]) / 2;
                    default:
                        break;
                }
                return 0;
            }

            public float xifi(int i)
            {
                switch (i)
                {
                    case 1:
                        return (xis(1) * Fi(1));
                    case 2:
                        return (xis(2) * Fi(2));
                    case 3:
                        return (xis(3) * Fi(3));
                    case 4:
                        return (xis(4) * Fi(4));
                    case 5:
                        return (xis(5) * Fi(5));
                    case 6:
                        return (xis(6) * Fi(6));
                    case 7:
                        return (xis(7) * Fi(7));
                    case 8:
                        return (xis(8) * Fi(8));
                    case 9:
                        return (xis(9) * Fi(9));
                    case 10:
                        return (xis(10) * Fi(10));
                    default:
                        break;
                }
                return 0;
            }

            public float variancias(int i)
            {
                int a = 0;
                switch (i)
                {
                    case 1:
                        a = 1;
                        return (float)(((Math.Pow((xis(a) - Media), 2)) * Fi(a)) / N);
                    case 2:
                        a = 2;
                        return (float)(((Math.Pow((xis(a) - Media), 2)) * Fi(a)) / N);
                    case 3:
                        a = 3;
                        return (float)(((Math.Pow((xis(a) - Media), 2)) * Fi(a)) / N);
                    case 4:
                        a = 4;
                        return (float)(((Math.Pow((xis(a) - Media), 2)) * Fi(a)) / N);
                    case 5:
                        a = 5;
                        return (float)(((Math.Pow((xis(a) - Media), 2)) * Fi(a)) / N);
                    case 6:
                        a = 6;
                        return (float)(((Math.Pow((xis(a) - Media), 2)) * Fi(a)) / N);
                    case 7:
                        a = 7;
                        return (float)(((Math.Pow((xis(a) - Media), 2)) * Fi(a)) / N);
                    case 8:
                        a = 8;
                        return (float)(((Math.Pow((xis(a) - Media), 2)) * Fi(a)) / N);
                    case 9:
                        a = 9;
                        return (float)(((Math.Pow((xis(a) - Media), 2)) * Fi(a)) / N);
                    case 10:
                        a = 10;
                        return (float)(((Math.Pow((xis(a) - Media), 2)) * Fi(a)) / N);
                    default:
                        break;
                }
                return 0;
            }

          public float Media
          {
              get
              {
                  float a = 0;
                  for (int i = 0; i < H; i++)
                  {
                      a += xifi(i + 1);
                  }
                  return a/N;
              }
          }

          public float Mediana
          {
              get{
                  if (amostra.Length % 2 == 0)
                  {
                      return (amostra[(N/2) + 1] + amostra[(N/2)-1])/2;
                  }
                  else
                  {
                      return amostra[(N / 2)];
                  }
              }
          }

          public float Moda
          {
              get
              {
                  int xi = 0;
                  float va = 0;
                  for (int i = 0; i < H; i++)
                  {
                      if (va < Fi(i+1))
                      {
                          va = Fi(i + 1);
                          xi = i + 1;
                      }
                  }
                  return xis(xi);
              }
          }

          public float Desvio
          {
              get
              {
                  float a = 0;
                  for (int i = 0; i < H; i++)
                  {
                      a += variancias(i + 1);
                  }
                      return (float)Math.Round(Math.Sqrt(a), 3);
              }
          }
    }
}
