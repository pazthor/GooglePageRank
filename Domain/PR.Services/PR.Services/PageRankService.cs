﻿using System;
using System.Drawing;

namespace PR.Services
{
    public class PageRankService
    {
        private double[,] Hyperlink;
        private double[,] DanglingNodes;
        private double[,] MatrixS;
        private double[,] MatrixGoogle;
        private double Alfa;
        private int SizeMatrix;
        private double[] VectorI;
        
        double[,] MatrixTestH =
        {
            {0,0,0,0,0,0,1.0/3.0, 0},
            {1.0/2.0,0,1.0/2.0,1.0/3.0,0,0,0,0},
            {1.0/2.0,0,0,0,0,0,0,0},
            {0,1.0,0,0,0,0,0,0},
            {0,0,1.0/2.0,1.0/3.0,0,0,1.0/3.0,0}, // fila 5
            {0,0,0,1.0/3.0,1.0/3.0,0,0,1.0/2.0},
            {0,0,0,0,1.0/3.0,0,0,1.0/2.0},
            {0,0,0,0,1.0/3.0,1.0,1.0/3.0,0}
        };
        
        private double[] VectorITest = {1,0,0,0,0,0,0,0};
        
        public PageRankService()
        {
            // TODO: Create method for intialization matrix
            Alfa = 0.85;
            SizeMatrix = 8; // test
            Hyperlink = new double[SizeMatrix, SizeMatrix];
            DanglingNodes = new double[SizeMatrix, SizeMatrix];
            MatrixS = new double[SizeMatrix, SizeMatrix];
            MatrixGoogle = new double[SizeMatrix, SizeMatrix];
            VectorI = new double[SizeMatrix]; // vector estacionario
        }
        
        public double[] PageRank()
        {
            // TODO: recibir Matrix H por parametro, no  cargar mediante una matrix ya cargada
            var vectorRes = MultiplicarMatrizVector(MatrixTestH, VectorITest, SizeMatrix);
            for (int i = 0; i < 62; i++)
            {
                vectorRes = MultiplicarMatrizVector(MatrixTestH, vectorRes , SizeMatrix);
            }

            return vectorRes;
        }

        public double[] MultiplicarMatrizVector(double[,] matrix, double[] vector, int sizeRow)
        {
            var vectorResultante = new double[sizeRow];
            for (int i = 0; i < sizeRow; i++)
            {
                for (int j = 0; j < sizeRow; j++)
                {
                    vectorResultante[i] += matrix[i, j] * vector[j];
                }
            }

            return vectorResultante;
        }
    }
}