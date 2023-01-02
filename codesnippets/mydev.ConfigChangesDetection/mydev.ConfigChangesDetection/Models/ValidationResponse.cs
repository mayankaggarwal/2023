namespace mydev.ConfigChangesDetection.Models
{
    public class ValidationResponse
    {
        public bool IsValid { get; set; }
        public string ErrorCode { get; set; }
        public string Message { get; set; }
        public string Validator { get; set; }
    }
}
