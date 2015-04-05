using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;

namespace MyTrainingContract
{
    [ServiceContract]
    public interface IMyTrainingService
    {
        [OperationContract]
        IEnumerable<Training> GetTrainings();

        [OperationContract]
        void AddTrining(Training training);
    }
}
