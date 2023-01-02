namespace mydev.ConfigChangesDetection.Services
{
    public interface IValidator
    {
        string GetValidator();
    }
    public class Validator : IValidator
    {
        private readonly string Validation;
        public Validator(string validator)
        {
            Validation = validator;
        }
        public string GetValidator()
        {
            return Validation;
        }
    }
}
