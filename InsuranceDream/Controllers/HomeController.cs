using InsuranceDream.Business;
using InsuranceDream.Entities;
using InsuranceDream.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsuranceDream.Controllers
{
    public class HomeController : Controller
    {
        private IInsuranceDreamManager insuranceDreamManager;
        public HomeController()
        {
            insuranceDreamManager = new InsuranceDreamManager();
        }

        public ActionResult Index()
        {
            var model = insuranceDreamManager.GetInsurance();
            var viewModel = ConvertInsuranceToViewModel(model);
            return View(viewModel);
        }

        [HttpPost]
        public JsonResult CheckFireOption()
        {
            var model = insuranceDreamManager.GetInsurance(true);
            var viewModel = ConvertInsuranceToViewModel(model);
            return Json(viewModel);
        }

        [HttpPost]
        public JsonResult ReinitPrice()
        {
            var model = insuranceDreamManager.GetInsurance();
            var viewModel = ConvertInsuranceToViewModel(model);
            return Json(viewModel);
        }


        private InsuranceViewModel ConvertInsuranceToViewModel(Insurance insurance)
        {
            var viewModel = new InsuranceViewModel
            {
                BasePrice = insurance.BasePrice,
                SalesPrice = insurance.SalesPrice,
                FireOption = insurance.FireOption
            };

            return viewModel;
        }
    }
}