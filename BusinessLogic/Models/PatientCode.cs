using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPB.BusinessLogic.Models
{
    internal class PatientCode
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int CI { get; set; }
        public string Code { get; set; }

        public PatientCode() { }

        public PatientCode(string name, string lastName, int cI, string code)
        {
            Name = name;
            LastName = lastName;
            CI = cI;
            Code = code;
        }
    }
}
