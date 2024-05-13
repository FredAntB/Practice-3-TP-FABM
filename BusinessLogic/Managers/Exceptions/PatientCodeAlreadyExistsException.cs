using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPB.BusinessLogic.Managers.Exceptions
{
    public class PatientCodeAlreadyExistsException : Exception
    {
        private const string BaseMessage = "There's already a Patient Code registered with the CI provided, please check if the provided information is correct, or update the patient's data.";

        public PatientCodeAlreadyExistsException() : base(BaseMessage) { }
    }
}
