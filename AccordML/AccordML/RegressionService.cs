using Accord.Statistics.Models.Regression.Linear;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccordML
{
    class RegressionService
    {
        SimpleLinearRegression regression;

        public static double[] sampleInputs = { 10, 20, 30, 40, 50 };
        public static double[] sampleOutputs = { 20, 40, 60, 80, 100 };

        public RegressionService()
        {
            regression = new SimpleLinearRegression();
        }

        public void TrainWithOrdinaryLeastSquares(double[] input, double[] output)
        {
            var ols = new OrdinaryLeastSquares();

            regression = ols.Learn(input, output);
        }

        public double GetTransform(double xPred)
        {
            return regression.Transform(xPred);
        }
    }
}
