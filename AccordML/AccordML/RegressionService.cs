using Accord.Statistics.Models.Regression.Linear;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccordML
{
    class RegressionService
    {
        SimpleLinearRegression regression;

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
