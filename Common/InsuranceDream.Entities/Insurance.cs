using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceDream.Entities
{
    public class Insurance
    {
        public float BasePrice { get; set; }
        public float SalesPrice { get; set; }

        public FireOption FireOption {get;set;}
    }    
}
