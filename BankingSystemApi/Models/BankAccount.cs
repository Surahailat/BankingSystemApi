using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BankingSystemApi.Models
{
    public class BankAccount
    {

            [Key]
            public int ID { get; set; }

            [Required, MaxLength(100)]
            public string Full_Name { get; set; }

            [Required, MaxLength(100), EmailAddress]
            public string Email { get; set; }

            [MaxLength(20)]
            public string Phone { get; set; }

            public DateTime Server_DateTime { get; set; } = DateTime.Now;

            public DateTime DateTime_UTC { get; set; } = DateTime.UtcNow;

            [MaxLength(200)]
            public string IBAN_Hash { get; set; }

            [MaxLength(200)]
            public string IBAN_Encrypted { get; set; }

            [MaxLength(100)]
            public string IBAN_Mask { get; set; }

            public DateTime Update_DateTime_UTC { get; set; } = DateTime.UtcNow;

            [Column(TypeName = "decimal(18,2)")]
            public decimal Balance { get; set; } = 0;

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
