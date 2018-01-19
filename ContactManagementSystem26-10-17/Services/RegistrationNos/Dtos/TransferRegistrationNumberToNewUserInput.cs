namespace ContactManagementSystem26_10_17.Services.RegistrationNos.Dtos
{
    public class TransferRegistrationNumberToNewUserInput
    {
        public string RegNo { get; set; }

        public int RegNoId { get; set; }
        public string NewUserEmail { get; set; }
    }
}