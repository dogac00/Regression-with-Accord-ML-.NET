using Accord.MachineLearning.DecisionTrees;
using Accord.Math.Optimization.Losses;

namespace AccordML
{
    class RandomForestService
    {
        public void Run()
        {
            // iris datasetini yüklüyoruz
            var iris = new Accord.DataSets.Iris();

            // iris inputları ve outputlarını tanımlıyoruz
            double[][] inputs = iris.Instances;
            int[] outputs = iris.ClassLabels;

            var teacher = new RandomForestLearning()
            {
                NumberOfTrees = 10, // 10 trees in the forest
            };

            // forest variable'ı oluşturup train ediyoruz
            var forest = teacher.Learn(inputs, outputs);

            // kendi inputlarımızla test ediyoruz
            int[] predicated = forest.Decide(inputs);

            // error hesaplama. outputs expected, predicated ise tahmin edilen
            double error = new ZeroOneLoss(outputs).Loss(predicated);

            // error 0 çıkacak
            System.Console.WriteLine(error);
        }
    }
}
