using CarInsurance.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarInsurance.Service;


namespace CarInsurance.Web.Controllers
{
    public class InsuranceFormController : Controller
    {
        // GET: InsuranceFormController
        public ActionResult Index()
        {
            return View();
        }

        // GET: InsuranceFormController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InsuranceFormController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InsuranceFormController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(InsuranceForm insForm )
        {
            try
            {
                if (ModelState.IsValid) { 
                    InsuranceFormService insFormService = new InsuranceFormService();
                    insFormService.CreateInsuranceForm(insForm);
                    SendEmailService sendEmail = new SendEmailService();
                    sendEmail.SendEmail(insForm);
                    return RedirectToAction(nameof(History));
                }
                else
                {
                    return View(insForm);
                }
                
            }
            catch
            {
                return View(insForm);
            }
        }

        // GET: InsuranceFormController/Edit/5
        public ActionResult Edit(int id)
        {
            InsuranceFormService insFormService = new InsuranceFormService();
            InsuranceForm insForm = insFormService.GetInsuranceForm(id);
            return View(insForm);
        }

        // POST: InsuranceFormController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, InsuranceForm insForm)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    InsuranceFormService insFormService = new InsuranceFormService();
                    insFormService.UpdateInsuranceForm(insForm);
                    return RedirectToAction(nameof(History));
                }
                else
                {
                    return View(insForm);
                }
            }
            catch
            {

                return View(insForm);
            }
            
        }

        // GET: InsuranceFormController/Delete/5
        public ActionResult Delete(int id)
        {
            InsuranceFormService insFormService = new InsuranceFormService();
            insFormService.DeleteInsuranceForm(id);
            return RedirectToAction(nameof(History));
        }

        // POST: InsuranceFormController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return View();
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cal(InsuranceForm insForm)
        {
            try
            {
                InsuranceCalculateService incalservice = new InsuranceCalculateService();

                int insCal = incalservice.Calculate(insForm.TypeCar, insForm.Level);
                

                return RedirectToAction(nameof(Create));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult History()
        {

            InsuranceFormService insuranceFormService = new InsuranceFormService();
            insuranceFormService.GetInsuranceForms();

            List<InsuranceForm> insForms = insuranceFormService.GetInsuranceForms();
            //insForms.Add(new InsuranceForm {
            //Id = 1,
            //TypeCar = "รถไถ"});
            return View(insForms);
        }
        //public ActionResult Edit()
        //{

        //    //InsuranceFormService insuranceFormService = new InsuranceFormService();
        //    //insuranceFormService.GetInsuranceForms();

        //    //List<InsuranceForm> insForms = insuranceFormService.GetInsuranceForms();
        //    //insForms.Add(new InsuranceForm {
        //    //Id = 1,
        //    //TypeCar = "รถไถ"});
        //    return View();
        //}
        public ActionResult GetData()
        {
                return View();
        }
    }
    

}
