using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MyTrainingContract
{
    [DataContract]
    public class Training
    {
        [DataMember]
        public Guid TrainingId { get; set; }
        [DataMember]
        public string TrainingName { get; set; }
    }
}
