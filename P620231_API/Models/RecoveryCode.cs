namespace P620231_API.Models
{
    public class RecoveryCode
    {
        public int RecoveryCodeId { get; set; }
        public string Email { get; set; } = null!;
        public string RecoveryCode1 { get; set; } = null!;
        public DateTime GenerateDate { get; set; }
        public bool IsUsed { get; set; }

    }
}
