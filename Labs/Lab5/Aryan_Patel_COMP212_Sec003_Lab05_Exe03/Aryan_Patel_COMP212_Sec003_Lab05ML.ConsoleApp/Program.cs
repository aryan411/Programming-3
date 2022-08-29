// This file was auto-generated by ML.NET Model Builder. 

using System;
using Aryan_Patel_COMP212_Sec003_Lab05ML.Model;

namespace Aryan_Patel_COMP212_Sec003_Lab05ML.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                STG = 0F,
                SCG = 0F,
                STR = 0F,
                LPR = 0F,
                PEG = 0F,
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual UNS with predicted UNS from sample data...\n\n");
            Console.WriteLine($"STG: {sampleData.STG}");
            Console.WriteLine($"SCG: {sampleData.SCG}");
            Console.WriteLine($"STR: {sampleData.STR}");
            Console.WriteLine($"LPR: {sampleData.LPR}");
            Console.WriteLine($"PEG: {sampleData.PEG}");
            Console.WriteLine($"\n\nPredicted UNS value {predictionResult.Prediction} \nPredicted UNS scores: [{String.Join(",", predictionResult.Score)}]\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
