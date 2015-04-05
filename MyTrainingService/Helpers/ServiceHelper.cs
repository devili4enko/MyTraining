using System;
using System.Collections.Generic;
using System.Threading;
using MyTrainingContract;

namespace MyTrainingService
{
    public class ServiceHelper : IServiceHelper
    {
        #region SingletonMembers
        private static ServiceHelper _instance;

        private ServiceHelper()
        {
            _trainings = InitializeTrainings();
        }
        
        public static ServiceHelper Instance
        {
            get
            {
                if (_instance != null)
                    return _instance;
                var temp = new ServiceHelper();
                Interlocked.CompareExchange(ref _instance, temp, null);
                return _instance;
            }
        } 
        #endregion

        private List<Training> _trainings; 

        public IEnumerable<Training> GetTrainings()
        {
            throw new NotImplementedException();
        }

        public void SaveTraining(Training training)
        {
            throw new NotImplementedException();
        }

        private void InitializeTrainings()
        {
            _trainings.Add(new Training());
        }
    }
}