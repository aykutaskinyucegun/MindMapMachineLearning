using System;
using System.IO;
using Microsoft.ML;  
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using MindMapMachineLearning.Models;
using System.Linq;
using static Microsoft.ML.DataOperationsCatalog;
using System.Collections.Generic;

namespace MindMapMachineLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            MLContext ml = new MLContext(seed: 1);

            var trainData = ml.Data.LoadFromTextFile<MlInput>("learningdata.csv", ',', hasHeader: true);

            //var select = ml.Transforms.SelectColumns("Airlines", "Architecture", "Art & Museums", "Automotive", "Banking & Financial", "Cannabis", "Casinos & Lottery");
            //var selectTransform = select.Fit(trainData).Transform(trainData); 

            var inputcolumns = new List<string> { };

            double f1sum = 0;
            int count = 0;

            var techlist = new List<string> {"360 Photo/Video" , "3D Environments" , "3D Modelling" , "AR" , "AR Authoring" , "AR Cloud" , "AR Headsets" , "AR Kit" , "AR: Hololens" , "AR: Magic Leap" , "ARCore" , "Avatar Creation" , "Distribution & Device Management" , "Eye Tracking" , "Haptics & Peripherals" , "Motion Capture" ,
                "Motion Simulators" , "Networking" , "Photogrammetry" , "Spatial Audio" , "Unity" , "Unreal" , "VR" , "VR Authoring" , "VR Headsets" , "VR: Mobile" , "VR: PC" , "Volumetric Capture" , "Web XR"};
            
            foreach (var technology in techlist.ToList())
            {     
                var removedlist = techlist.ToList();
                removedlist.Remove(technology);
                string[] removedarray = removedlist.ToArray();

                var prepedData = ml.Transforms.DropColumns(removedarray);
                var prepedDataTransform = prepedData.Fit(trainData).Transform(trainData);

                TrainTestData trainTestData = ml.Data.TrainTestSplit(prepedDataTransform, testFraction: 0.2);

                IEstimator<ITransformer> dataPipe = ml.Transforms.Concatenate("Features", new[]{"Airlines", "Architecture", "Art & Museums", "Automotive", "Banking & Financial", "Cannabis", "Casinos & Lottery", "Charities", "Education & Training", "Education (K-12)", "Emergency Response", "Health & Medical", "Industrial",
                    "Legal & Insurance", "Media & News & Entertainment", "Military", "Music", "Real Estate", "Restaurant & Food", "Retail", "Sales & Marketing", "Sports", "Telecommunications", "Travel & Tourism", "Collaboration & Social", "Communications", "Data Analytics", "Design", "Gaming", "General Training", "Health & Safety",
                    "LBE", "Leadership", "Marketing", "Rehabilitation", "Simulation", "Tools", "Training: Hands On", "Training: Hard Skills", "Training: Soft Skills"});

                var options = new LbfgsLogisticRegressionBinaryTrainer.Options()
                {
                    LabelColumnName = technology,
                    FeatureColumnName = "Features",
                    MaximumNumberOfIterations = 100,
                    OptimizationTolerance = 1e-8f
                };
     
                var lbfsgLogistic = ml.BinaryClassification.Trainers.LbfgsLogisticRegression(options);
                var trainPipe = dataPipe.Append(lbfsgLogistic);

                Display(trainTestData.TrainSet);
                var model = trainPipe.Fit(trainTestData.TrainSet);

                IDataView predictionView = model.Transform(trainTestData.TestSet);
                CalibratedBinaryClassificationMetrics metrics = ml.BinaryClassification.Evaluate(predictionView, labelColumnName:technology);

                //Console.WriteLine($"F1 {metrics.ConfusionMatrix.GetFormattedConfusionTable().ToString()} ");
                Console.WriteLine($"F1 {metrics.F1Score} ");
                if (metrics.F1Score > 0)
                {
                    f1sum += metrics.F1Score;
                    count++;
                }
            }

            Console.WriteLine($"Average: {f1sum/count}");
        }
       
                static void Display(IDataView data)
                {
                    var preview = data.Preview(maxRows: 1);
                    string display = "";

                    for (int i = 0; i < preview.RowView.Length; i++)
                    {
                        foreach (var item in preview.RowView[i].Values)
                            display += $"{item.Key} : {item. Value} ";

                        Console.WriteLine("-------------");
                        Console.WriteLine(display);
                        display = "";

                    }

                }
        /*
        static string Display(IDataView data)
        {
            var preview = data.Preview(maxRows: 1);
            string display = "";

            for (int i = 0; i < preview.RowView.Length; i++)
            {
                display = preview.RowView[0].Values[0].Key.ToString();
                return display;



            }
            return display;
        }
        */

    }



}
