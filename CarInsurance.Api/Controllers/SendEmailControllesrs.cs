using CarInsurance.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarInsurance.Service;

namespace CarInsurance.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class SendEmailControllesrs : ControllerBase
    {
        [HttpPost]
        
        public Boolean SendEmail(InsuranceForm insForm)
        {
            SendEmailService sendEmailService = new SendEmailService();
            return sendEmailService.SendEmail(insForm);
        }

        
    }
}
