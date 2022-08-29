using System;
using Aryan_Patel_COMP212_Sec003_Lab05ML.Model;


namespace Aryan_Patel_Exe03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Add input data
            var input = new ModelInput();
            input.LPR = (float)0.2;
            input.PEG = (float)0.1;
            input.SCG = (float)0.38;
            input.STG = (float)0.4;
            input.STR = (float)0.0;

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
            Console.WriteLine("Prediction = " + result.Prediction.ToString());
        }
    }
}
