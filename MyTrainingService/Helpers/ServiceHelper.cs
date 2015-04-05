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
           InitializeTrainings();
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
            return _trainings;
        }

        public void SaveTraining(Training training)
        {
            throw new NotImplementedException();
        }

        private void InitializeTrainings()
        {
            _trainings=new List<Training>();
            _trainings.Add(new Training
            {
                TrainingId = new Guid(),
                TrainingName = "Name1"
            });
            _trainings.Add(new Training
            {
                TrainingId = new Guid(),
                TrainingName = "Name2"
            }); _trainings.Add(new Training
            {
                TrainingId = new Guid(),
                TrainingName = "Name3"
            }); _trainings.Add(new Training
            {
                TrainingId = new Guid(),
                TrainingName = "Name4"
            });
        }
    }
}