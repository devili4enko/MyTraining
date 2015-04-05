using System.Collections.Generic;
using MyTrainingContract;

namespace MyTrainingService
{
    public interface IServiceHelper
    {
        IEnumerable<Training> GetTrainings();
        void SaveTraining(Training training);
    }
}