using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UPB.BusinessLogic.Models;

namespace UPB.BusinessLogic.Managers
{
    public class PatientCodeManager
    {
        private List<PatientCode> _patientCodes;

        public PatientCodeManager()
        {
            _patientCodes = new List<PatientCode>();
        }

        public List<PatientCode> GetAll() { return _patientCodes; }

        public PatientCode GetByCi(int ci)
        {
            PatientCode? foundPatientCode;

            foundPatientCode = _patientCodes.Find(x => x.CI == ci);

            if (foundPatientCode == null)
            {
                throw new NotImplementedException();
            }

            return foundPatientCode;
        }

        public void CreatePatientCode(PatientCode newPatientCode)
        {
            PatientCode createdPatientCode = new PatientCode()
            {
                Name = newPatientCode.Name,
                LastName = newPatientCode.LastName,
                CI = newPatientCode.CI,
                Code = GeneratePatientCode(newPatientCode)
            };

            _patientCodes.Add(createdPatientCode);
        }

        public void UpdatePatientCode(int ci, PatientCode updatedPatientCode)
        {
            PatientCode? foundPatientCode;

            foundPatientCode = _patientCodes.Find(x => x.CI == ci);

            if (foundPatientCode == null)
            {
                throw new NotImplementedException();
            }

            foundPatientCode.Name = updatedPatientCode.Name;
            foundPatientCode.LastName = updatedPatientCode.LastName;

            foundPatientCode.Code = GeneratePatientCode(foundPatientCode);
        }

        public void DeletePatientCode(int ci)
        {
            PatientCode? foundPatientCode;

            foundPatientCode = _patientCodes.Find(x => x.CI == ci);

            if (foundPatientCode == null)
            {
                throw new NotImplementedException();
            }

            _patientCodes.Remove(foundPatientCode);
        }

        private string GeneratePatientCode(PatientCode patientCode)
        {
            string code;

            code = $"{patientCode.Name[0]}{patientCode.LastName[0]}-{patientCode.CI}";

            return code;
        }
    }
}
