using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborat3
{
    class Matrix3<T>
    {
        Dictionary<string, T> matr = new Dictionary<string, T>();
        int maxX;
        int maxY;
        int maxZ;
        IMatrixCheckEmpty<T> сheckEmpty;
        public Matrix3(int x, int y, int z, IMatrixCheckEmpty<T> сheckEmptyParam)
        {
            this.maxX = x;
            this.maxY = y;
            this.maxZ = z;
            this.сheckEmpty = сheckEmptyParam;
        }
        public T this[int x, int y, int z]
        {
            get
            {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z);
                if (this.matr.ContainsKey(key)) { return this.matr[key]; }
                else { return this.сheckEmpty.getEmptyElement(); }
            }
            set
            {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z);
                this.matr.Add(key, value);
            }
            
        }
        void CheckBounds(int x, int y, int z)
        {
            if ((x < 0) || (x > this.maxX)) throw new Exception("x=" + x + "выходит за границы матрицы");
            if ((y < 0) || (y > this.maxY)) throw new Exception("y=" + y + "выходит за границы матрицы");
            if ((z < 0) || (z > this.maxZ)) throw new Exception("z=" + z + "выходит за границы матрицы");
        }
        string DictKey(int x, int y, int z) { return x.ToString() + "_" + y.ToString() + "_" + z.ToString(); }
        
        public override string ToString()
        {
            StringBuilder b = new StringBuilder();
            for (int i = 0; i < this.maxZ; i++)
            {
                for (int j = 0; j < this.maxY; j++)
                {
                    b.Append("[");
                    for (int k = 0; k < this.maxX; k++)
                    {
                        if (k > 0) { b.Append("\t"); }
                        if (!this.сheckEmpty.checkEmptyElement(this[i, j, k])) { b.Append(this[i, j, k].ToString()); }
                        else { b.Append(" - "); }
                    }
                    b.Append("]\n");
                }
                b.Append("\n\n\n");
            }
            return b.ToString();
        }
    }
}
