using InsuranceDream.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceDream.DataAccess
{
  
    public class InsuranceRepository : IInsuranceRepository
    {
        public Insurance GetInsurance()
        {
            return new Insurance
            {
                BasePrice = 200,
                SalesPrice = 240,
                FireOption = new FireOption { Price = 30 }
            };
        }
    }
}
