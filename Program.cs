using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Matrix2D
{
    private int[,] data;

    public int Rows { get; private set; }
    public int Columns { get; private set; }

    public Matrix2D(int rows, int columns)
    {
        Rows = rows;
        Columns = columns;
        data = new int[rows, columns];
    }

    public int this[int row, int column]
    {
        get { return data[row, column]; }
        set { data[row, column] = value; }
    }

    public static Matrix2D operator +(Matrix2D matrix1, Matrix2D matrix2)
    {
        if (matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns)
        {
            throw new ArgumentException("Matrices must have the same dimensions for addition.");
        }

        Matrix2D result = new Matrix2D(matrix1.Rows, matrix1.Columns);
        for (int i = 0; i < matrix1.Rows; i++)
        {
            for (int j = 0; j < matrix1.Columns; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return result;
    }

    public static Matrix2D operator -(Matrix2D matrix1, Matrix2D matrix2)
    {
        if (matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns)
        {
            throw new ArgumentException("The matrices must have the same dimensions for subtraction.");
        }

        Matrix2D result = new Matrix2D(matrix1.Rows, matrix1.Columns);
        for (int i = 0; i < matrix1.Rows; i++)
        {
            for (int j = 0; j < matrix1.Columns; j++)
            {
                result[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }
        return result;
    }

    public static bool operator <=(Matrix2D matrix1, Matrix2D matrix2)
    {
        int sum1 = 0;
        int sum2 = 0;

        for (int i = 0; i < matrix1.Rows; i++)
        {
            for (int j = 0; j < matrix1.Columns; j++)
            {
                sum1 += matrix1[i, j];
                sum2 += matrix2[i, j];
            }
        }

        return sum1 <= sum2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Matrix2D matrix1 = new Matrix2D(2, 2);
        Matrix2D matrix2 = new Matrix2D(2, 2);

       

        Matrix2D sumMatrix = matrix1 + matrix2; 
        Matrix2D diffMatrix = matrix1 - matrix2; 
        bool isSumGreater = matrix1 <= matrix2; 
    }
}