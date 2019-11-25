using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparseMatrix
{
    public class Matrix3<T>
    {
        Dictionary<string, T> matr = new Dictionary<string, T>();
        int maxX;
        int maxY;
        int maxZ;
        T nullelement;
        public Matrix3(int x, int y, int z, T nullp)
        {
            this.maxX = x;
            this.maxY = y;
            this.maxZ = z;
            this.nullelement = nullp;
        }
        public T this[int x, int y, int z]
        {
            get
            {
                Check(x, y, z);
                string Key = DictKey(x, y, z);
                if(this.matr.ContainsKey(Key))
                {
                    return this.matr[Key];
                }
                else
                {
                    return this.nullelement;
                }
            }
            set
            {
                Check(x, y, z);
                string Key = DictKey(x, y, z);
                this.matr.Add(Key, value);
            }
        }
        IMatrixCheckEmpty<T> сheckEmpty;
        void Check(int x, int y, int z)
        {
            if ((x < 0) || (x > this.maxX)) throw new Exception("x=" + x + "выходит за границы матрицы");
            if ((y < 0) || (y > this.maxY)) throw new Exception("y=" + y + "выходит за границы матрицы");
            if ((z < 0) || (z > this.maxZ)) throw new Exception("z=" + z + "выходит за границы матрицы");
        }

        string DictKey(int x, int y, int z)
        {
            return x.ToString() + "_" + y.ToString() + "_" + z.ToString();
        }
        public override string ToString()
        {
            StringBuilder B= new StringBuilder();
            for(int k = 0; k< this.maxZ; k++)
            {
                B.Append("[");
                for (int j = 0; j < this.maxY; j++)
                {
                    for (int i = 0; i < this.maxX; i++)
                    {
                        if (i > 0) { B.Append("\t"); }
                        if (!this.сheckEmpty.checkEmptyElement(this[i, j, k]))
                        {
                            B.Append(this[i, j,k].ToString()); }
                        else
                        {
                            B.Append(" - ");
                        }
                    }
                }
                B.Append("]");
            }
            return B.ToString();
        }
    }
    public interface IMatrixCheckEmpty<T>
    {  T getEmptyElement();
       bool checkEmptyElement(T element);
    }
    class FigureMatrixCheckEmpty : IMatrixCheckEmpty<GeomFigure>
    {  public GeomFigure getEmptyElement()
        {
            return null;
        }
      public bool checkEmptyElement(GeomFigure element)
        {
            bool Result = false;
            if (element == null)
            {
                Result = true;
            }
            return Result;
        }
    }
    }
