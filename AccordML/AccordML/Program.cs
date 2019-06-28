using Accord.Statistics.Models.Regression.Linear;
using System;

namespace AccordML
{
    class Program
    {
        static void Main(string[] args)
        {
            DoNeuralNetworks();
        }

        static void DoRegression()
        {
            var service = new RegressionService();

            service
                .TrainWithOrdinaryLeastSquares(RegressionService.sampleInputs, RegressionService.sampleOutputs);

            Console.WriteLine(service.GetTransform(120));
        }

        static void DoRandomForest()
        {
            RandomForestService service = new RandomForestService();

            service.Run();
        }

        static void DoNeuralNetworks()
        {
            NeuralNetworkService service = new NeuralNetworkService();

            service.Run();
        }
    }
}
