using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPB.BusinessLogic.Managers.Exceptions
{
    public class PatientCodeNotFoundException : Exception
    {
        private const string BaseMessage = "The Patient Code you're looking for was not found.";
        public PatientCodeNotFoundException() : base(BaseMessage) { }
        public PatientCodeNotFoundException(string method) : base("In the " + method + " method. " + BaseMessage) { }

        public string GetErrorType()
        {
            return BaseMessage;
        }
    }
}
