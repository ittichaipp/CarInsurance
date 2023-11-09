using CarInsurance.Model;
using CarInsurance.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarInsurance.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsuranceFormController : ControllerBase
    {
        // GET: api/<InsuranceFormController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<InsuranceFormController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<InsuranceFormController>
        [HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}
        public void CreateInsuranceForm(InsuranceForm insForm)
        {
            InsuranceFormService createInsuranceFormService = new InsuranceFormService();
            createInsuranceFormService.CreateInsuranceForm(insForm);

            SendEmailService sendEmail = new SendEmailService();
            sendEmail.SendEmail(insForm);

        }

        // PUT api/<InsuranceFormController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<InsuranceFormController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
