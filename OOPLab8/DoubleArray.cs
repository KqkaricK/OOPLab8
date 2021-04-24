using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLab8
{
    class DoubleArray
    {
        public int[,] dbArray;
        public int n, m;
        public string name;

        public DoubleArray(string Name = "Array", int N = 10, int M = 10)
        {
            name = Name;
            n = N;
            m = M;
            dbArray = new int[n, m];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                for (int k = 0; k < m; k++)
                    dbArray[i, k] = rnd.Next(-10, 11);
        }

        public void Display(DataGridView u)
        {
            u.RowCount = n;
            u.ColumnCount = m;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    u.Rows[i].Cells[j].Value = dbArray[i, j];
                }
            }
        }

        public void PR(TextBox u, TextBox g)
        {
            long cout1 = 1;
            long cout2 = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    if (i > j) { cout1 = cout1 * dbArray[i, j]; cout2 += 1; }
                }
            u.Text = Convert.ToString(cout1);
            g.Text = Convert.ToString(cout2);
        }

        public void SUM(TextBox u, TextBox g)
        {
            int diag;
            if (m < n) diag = m; else diag = n;
            long cout1 = 0;
            long cout2 = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i < j) { cout1 += dbArray[i, j]; cout2 += 1; }
                }
            }
            u.Text = Convert.ToString(cout1);
            g.Text = Convert.ToString(cout2);
        }


        public void Plus(int ggg)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dbArray[i, j] += ggg;
                }
            }
        }

        public void NName(TextBox g)
        {
            g.Text = name;
        }
    }
}
