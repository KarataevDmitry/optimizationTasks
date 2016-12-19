using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OptimisationTasks.OptimisationMethods.Linear
{
        public class Simplex
        {
           
            double[,] table; //симплекс таблица

            int rows, cols;

            List<int> basis; //список базисных переменных
            
            //source - симплекс таблица без базисных переменных
            public Simplex(double[,] source)
            {
                rows = source.GetLength(0);
                cols = source.GetLength(1);
                table = new double[rows, cols + rows - 1];
                basis = new List<int>();

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < table.GetLength(1); j++)
                    {
                        if (j < cols)
                            table[i, j] = source[i, j];
                        else
                            table[i, j] = 0;
                    }
                    //выставляем коэффициент 1 перед базисной переменной в строке
                    if ((cols + i) < table.GetLength(1))
                    {
                        table[i, cols + i] = 1;
                        basis.Add(cols + i);
                    }
                }

                cols = table.GetLength(1);
            }

        //result - в этот массив будут записаны полученные значения X
        public double[,] Calculate(double[] result)
        {
            int mainCol, mainRow; //ведущие столбец и строка

            while (!IsItEnd())
            {
                mainCol = findMainCol();
                if (mainCol == -1)
                {
                    for (int i = 0; i < result.Length; i++)
                    {
                        result[i] = 1e-10;
                        return new double[1, 1];
                    }
                }
                mainRow = findMainRow(mainCol);
                if (mainRow == -1)
                {
                    for (int i = 0; i < result.Length; i++)
                    {
                        result[i] = 1e-10;
                        return new double[1, 1];
                    }
                }
                    basis[mainRow] = mainCol;

                    double[,] new_table = new double[rows, cols];

                    for (int j = 0; j < cols; j++)
                        new_table[mainRow, j] = table[mainRow, j] / table[mainRow, mainCol];

                    for (int i = 0; i < rows; i++)
                    {
                        if (i == mainRow)
                            continue;

                        for (int j = 0; j < cols; j++)
                            new_table[i, j] = table[i, j] - table[i, mainCol] * new_table[mainRow, j];
                    }
                    table = new_table;
                }

                //заносим в result найденные значения X
                for (int i = 0; i < result.Length; i++)
                {
                    int k = basis.IndexOf(i + 1);
                    if (k != -1)
                        result[i] = table[k, 0];
                    else
                        result[i] = 0;
                }

                return table;
            }

            private bool IsItEnd()
            {
                bool flag = true;

                for (int j = 1; j < cols; j++)
                {
                    if (table[rows - 1, j] < 0)
                    {
                        flag = false;
                        break;
                    }
                }

                return flag;
            }

            private int findMainCol()
            {
                int mainCol = 1;

            for (int j = 2; j < cols; j++)
                if (table[rows - 1, j] < table[rows - 1, mainCol]) {
                    mainCol = j;
                }
                else {
                    return -1;
                }                       

                return mainCol;
            }

            private int findMainRow(int mainCol)
            {
                int mainRow = 0;

            for (int i = 0; i < rows - 1; i++)
                if (table[i, mainCol] > 0)
                {
                    mainRow = i;
                    break;
                }
                else {
                    return -1;
                }

                for (int i = mainRow + 1; i < rows - 1; i++)
                    if ((table[i, mainCol] > 0) && ((table[i, 0] / table[i, mainCol]) < 
                    (table[mainRow, 0] / table[mainRow, mainCol])))
                        mainRow = i;

                return mainRow;
            }


        }
    }


