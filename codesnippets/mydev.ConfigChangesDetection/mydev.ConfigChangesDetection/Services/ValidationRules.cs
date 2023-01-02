using Microsoft.Extensions.Options;
using mydev.ConfigChangesDetection.Models;
using System.Collections.Generic;
using System.Linq;
namespace mydev.ConfigChangesDetection.Services
{
    public interface IValidationRules
    {
        IEnumerable<IValidator> GetValidationRules();
    }
    public class ValidationRules : IValidationRules
    {
        private IEnumerable<IValidator> _validators;
        public ValidationRules(IOptionsMonitor<ValidatorConfiguration> validatorConfiguration)
        {
            _validators = validatorConfiguration.CurrentValue.Validator.Select(x => new Validator(x));
            validatorConfiguration.OnChange(x =>
            {
                _validators = x.Validator.Select(x => new Validator(x));
            });
            
        }
        public IEnumerable<IValidator> GetValidationRules()
        {
            return _validators;
        }
    }
}
