using Accord.Neuro.Learning;
using Accord.Neuro.Networks;

namespace AccordML
{
    class NeuralNetworkService
    {
        public void Run()
        {
            // (inputsCount, layers)
            var neuralNetwork = new DeepBeliefNetwork(2, 2);

            // neural network'u parametre olarak geçiyoruz
            var deepLearning = new DeepNeuralNetworkLearning(neuralNetwork);

            // algorithm'ini bir lambda expression ile atıyoruz
            deepLearning.Algorithm = (activationNetwork, index) => new BackPropagationLearning(activationNetwork);

            deepLearning.Run(new double[2], new double[2]);
        }
    }
}