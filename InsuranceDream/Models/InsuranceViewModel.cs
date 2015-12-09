using InsuranceDream.Entities;

namespace InsuranceDream.Models
{
    public class InsuranceViewModel
    {
        public float BasePrice { get; internal set; }
        public FireOption FireOption { get; set; }
        public float SalesPrice { get; internal set; }
    }
}