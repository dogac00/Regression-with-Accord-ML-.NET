using Accord.Statistics.Models.Regression.Linear;
using System;

namespace AccordML
{
    class Program
    {
        static void Main(string[] args)
        {
            DoRandomForest();
        }

        static void DoRegression()
        {
            double[] inputs = { 10, 20, 30, 40, 50 };
            double[] outputs = { 20, 40, 60, 80, 100 };

            var service = new RegressionService();

            service.TrainWithOrdinaryLeastSquares(inputs, outputs);
            Console.WriteLine(service.GetTransform(120));
        }

        static void DoRandomForest()
        {
            RandomForestService service = new RandomForestService();

            service.Run();
        }
    }
}
