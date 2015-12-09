using InsuranceDream.Controllers;
using InsuranceDream.Models;
using NUnit.Framework;
using System;
using System.Web.Mvc;
using TechTalk.SpecFlow;


namespace InsuranceDream.Specs
{
    [Binding]
    public class DisplayInsurancesSteps
    {
        private InsuranceViewModel insurance;
        private ActionResult actionResult;

        [When(@"I open insurance page")]
        public void WhenIOpenInsurancePage()
        {
            var homeController = new HomeController();
            this.actionResult = homeController.Index() as ViewResult;
        }
        
        [Then(@"the result should show the home insurance")]
        public void ThenTheResultShouldShowTheHomeInsurance()
        {
            var viewResult = this.actionResult as ViewResult;
            Assert.IsInstanceOf<InsuranceViewModel>(viewResult.Model);
            this.insurance = viewResult.Model as InsuranceViewModel;
        }
        
        [Then(@"the base price is (.*)")]
        public void ThenTheBasePriceIs(float basePriceExpected)
        {
            Assert.AreEqual(basePriceExpected, this.insurance.BasePrice);
        }
        
        [Then(@"the sales price is (.*)")]
        public void ThenTheSalesPriceIs(float salesPriceExpected)
        {
            Assert.AreEqual(salesPriceExpected, this.insurance.SalesPrice);
        }

        [Then(@"the Fire Option is display with empty checkbox")]
        public void ThenTheFireOptionIsDisplayWithEmptyCheckbox()
        {
            Assert.IsFalse(this.insurance.FireOption.Checked);
        }

        [Then(@"the Fire Option is (.*)")]
        public void ThenTheFireOptionIs(float fireOptionPriceExpected)
        {
            Assert.AreEqual(fireOptionPriceExpected, this.insurance.FireOption.Price);
        }

        [When(@"I check fire option")]
        public void WhenICheckFireOption()
        {
            var homeController = new HomeController();
            this.actionResult = homeController.CheckFireOption();
        }

        [Then(@"the result should refresh the home insurance")]
        public void ThenTheResultShouldRefreshTheHomeInsurance()
        {
            var jsonResult = this.actionResult as JsonResult;
            Assert.IsInstanceOf<InsuranceViewModel>(jsonResult.Data);
            this.insurance = jsonResult.Data as InsuranceViewModel;
        }
    }
}
