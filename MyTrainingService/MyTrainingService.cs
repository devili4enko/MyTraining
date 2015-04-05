using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using MyTrainingContract;

namespace MyTrainingService
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class MyTrainingService : IMyTrainingService
    {
        public IEnumerable<Training> GetTrainings()
        {
            return ServiceHelper.Instance.GetTrainings();
        }

        public void AddTrining(Training training)
        {
            throw new NotImplementedException();
        }
    }
}
