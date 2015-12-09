using InsuranceDream.Entities;

namespace InsuranceDream.Business
{
    public interface IInsuranceDreamManager
    {
        Insurance GetInsurance(bool isFireOptionChecked = false);
    }
}