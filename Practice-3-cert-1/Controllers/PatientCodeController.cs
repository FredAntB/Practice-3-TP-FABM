using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UPB.BusinessLogic.Managers;
using UPB.BusinessLogic.Models;

namespace UPB.Practice_3_cert_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PatientCodeController : ControllerBase
    {
        PatientCodeManager _patientCodeManager;
        public PatientCodeController(PatientCodeManager patientCodeManager)
        {
            _patientCodeManager = patientCodeManager;
        }

        [HttpGet]
        public List<PatientCode> Get() { return _patientCodeManager.GetAll(); }

        [HttpGet]
        [Route("{ci}")]
        public PatientCode Get(int ci) { return _patientCodeManager.GetByCi(ci); }

        [HttpPost]
        public void Post([FromBody]PatientCode patientCode) { _patientCodeManager.CreatePatientCode(patientCode); }

        [HttpPut]
        [Route("{ci}")]
        public void Put(int ci, [FromBody] PatientCode patientCode) { _patientCodeManager.UpdatePatientCode(ci, patientCode); }

        [HttpDelete]
        [Route("{ci}")]
        public void Delete(int ci) { _patientCodeManager.DeletePatientCode(ci); }
    }
}
