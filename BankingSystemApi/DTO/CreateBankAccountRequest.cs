using System.ComponentModel.DataAnnotations;

namespace BankingSystemApi.DTO
{
    public class CreateBankAccountRequest
    {
        [Required, MaxLength(100)]
        public string Full_Name { get; set; }

        [Required, MaxLength(100), EmailAddress]
        public string Email { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        [Required, MaxLength(50)]
        public string IBAN { get; set; }

        [Required, StringLength(3)]
        public string Currency { get; set; }

        [MaxLength(50)]
        public string IP_Address { get; set; }

        [MaxLength(50)]
        public string Source_IP_Address { get; set; }

        [MaxLength(100)]
        public string Host_Name { get; set; }

        [MaxLength(50)]
        public string Client_Time_Zone { get; set; }

        [MaxLength(100)]
        public string Geo_Coordinates { get; set; }

        [MaxLength(50)]
        public string Source_App { get; set; }

        [MaxLength(50)]
        public string Source_ID { get; set; }

        [MaxLength(100)]
        public string Session_ID { get; set; }

        [MaxLength(50)]
        public string Auth_Type { get; set; }

        [MaxLength(50)]
        public string Auth_ID { get; set; }
    }
}
