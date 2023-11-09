using CarInsurance.Model;
using CarInsurance.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;


namespace CarInsurance.Service
{
    public class SendEmailService : ISendEmailService
    {
        public bool SendEmail(InsuranceForm insForm)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.exim.go.th");
                MailMessage myMail = new MailMessage();
                myMail.From = new MailAddress("ittichai@exim.go.th");
                myMail.Subject = "ยืนยันคำสั่งซื้อหมายเลข #"+insForm.Id;
                myMail.Body = "สวัสดีคุณ " + insForm.FirstName + " " + insForm.LastName + "\n\t" +
                    "นี่คือระบบตอบรับอัตโนมัติในการยืนยันคำสั่งซื้อหมายเลข #" + insForm.Id+"\n\n"+
                    "ขอบคุณที่ใช้บริการ ";
                myMail.To.Add(insForm.Email);

                smtpClient.Send(myMail);
                return true; 
            }
            catch (Exception ex)
            {
               return false;
            }
            
        }

        
    }
    
}
