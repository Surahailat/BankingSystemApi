namespace BankingSystemApi.DTO
{
    public class BankAccountResponse
    {
        public int ID { get; set; }
        public string Full_Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public string IBAN_Mask { get; set; }
        public decimal Balance { get; set; }
        public string Currency { get; set; }

        public DateTime Server_DateTime { get; set; }
        public DateTime DateTime_UTC { get; set; }
        public DateTime Update_DateTime_UTC { get; set; }

        public string IP_Address { get; set; }
        public string Source_IP_Address { get; set; }
        public string Host_Name { get; set; }
        public string Client_Time_Zone { get; set; }
        public string Geo_Coordinates { get; set; }

        public string Source_App { get; set; }
        public string Source_ID { get; set; }
        public string Session_ID { get; set; }

        public string Auth_Type { get; set; }
        public string Auth_ID { get; set; }
    }
}
