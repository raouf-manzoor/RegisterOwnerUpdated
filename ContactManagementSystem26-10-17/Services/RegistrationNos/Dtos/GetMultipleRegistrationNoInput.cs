namespace ContactManagementSystem26_10_17.Services.RegistrationNos.Dtos
{
    public class GetMultipleRegistrationNoInput
    {
        public int UserId { get; set; }
        public int Digits { get; set; }

        public int Quantity { get; set; }
    }
}