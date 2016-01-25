using InsuranceDream.DataAccess;
using InsuranceDream.Entities;

namespace InsuranceDream.Business
{
    public class InsuranceDreamManager : IInsuranceDreamManager
    {
        /// <summary>
        /// rregtr
        /// </summary>
        private IInsuranceRepository insuranceRepository;

        public InsuranceDreamManager()
        {
            insuranceRepository = new InsuranceRepository();
        }

        public Insurance GetInsurance(bool isFireOptionChecked = false)
        {
            var currentInsurance = insuranceRepository.GetInsurance();
            if (isFireOptionChecked)
            {
                return CalculateInsurancePrice(currentInsurance);
            }

            return currentInsurance;
        }

        private Insurance CalculateInsurancePrice(Insurance currentInsurance)
        {
            currentInsurance.BasePrice = currentInsurance.BasePrice + currentInsurance.FireOption.Price;
            currentInsurance.SalesPrice = currentInsurance.BasePrice * (float)1.20;
            return currentInsurance;
        }
    }
}
