using mydev.ConfigChangesDetection.Models;
using System.Collections.Generic;
using System.Linq;

namespace mydev.ConfigChangesDetection.Services
{
    public interface IValidationEngine
    {
        IEnumerable<ValidationResponse> Validate();
    }
    public class ValidationEngine : IValidationEngine
    {
        private readonly IValidationRules _validationRules;
        public ValidationEngine(IValidationRules validationRules)
        {
            _validationRules= validationRules;
        }
        public IEnumerable<ValidationResponse> Validate()
        {
            return _validationRules.GetValidationRules().Select(x => new ValidationResponse { IsValid = false, Validator = x.GetValidator() });
        }
    }
}
