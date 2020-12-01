using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.ML.Data;


namespace MindMapMachineLearning.Models
{
    class MlOutput : MlInput

    {
        [ColumnName("Prediction")]
        public bool Prediction { get; set; }
        public float Probability { get; set; }
        public float Score { get; set; }


    }
}
