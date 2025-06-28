using BankingSystemApi.Data;
using BankingSystemApi.DTO;
using BankingSystemApi.Helpers;
using BankingSystemApi.Models;

namespace BankingSystemApi.Services
{
    public class BankAccountService : IBankAccountService
    {

        private readonly ApplicationDbContext _context;

        public BankAccountService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<BankAccountResponse> CreateBankAccountAsync(CreateBankAccountRequest request)
        {
            var encryptedIban = IBANHelper.Encrypt(request.IBAN);
            var hashedIban = IBANHelper.Hash(request.IBAN);
            var maskedIban = IBANHelper.Mask(request.IBAN);

            var account = new BankAccount
            {
                Full_Name = request.Full_Name,
                Email = request.Email,
                Phone = request.Phone,
                IBAN_Encrypted = encryptedIban,
                IBAN_Hash = hashedIban,
                IBAN_Mask = maskedIban,
                Currency = request.Currency,
                IP_Address = request.IP_Address,
                Source_IP_Address = request.Source_IP_Address,
                Host_Name = request.Host_Name,
                Client_Time_Zone = request.Client_Time_Zone,
                Geo_Coordinates = request.Geo_Coordinates,
                Source_App = request.Source_App,
                Source_ID = request.Source_ID,
                Session_ID = request.Session_ID,
                Auth_Type = request.Auth_Type,
                Auth_ID = request.Auth_ID
            };

            _context.BankAccounts.Add(account);
            await _context.SaveChangesAsync();

            return new BankAccountResponse
            {
                ID = account.ID,
                Full_Name = account.Full_Name,
                Email = account.Email,
                Phone = account.Phone,
                IBAN_Mask = account.IBAN_Mask,
                Balance = account.Balance,
                Currency = account.Currency,
                Server_DateTime = account.Server_DateTime,
                DateTime_UTC = account.DateTime_UTC,
                Update_DateTime_UTC = account.Update_DateTime_UTC,
                IP_Address = account.IP_Address,
                Source_IP_Address = account.Source_IP_Address,
                Host_Name = account.Host_Name,
                Client_Time_Zone = account.Client_Time_Zone,
                Geo_Coordinates = account.Geo_Coordinates,
                Source_App = account.Source_App,
                Source_ID = account.Source_ID,
                Session_ID = account.Session_ID,
                Auth_Type = account.Auth_Type,
                Auth_ID = account.Auth_ID
            };
        }

        public async Task<BankAccountResponse> GetBankAccountByIdAsync(int id)
        {
            var account = await _context.BankAccounts.FindAsync(id);
            if (account == null)
                return null;

            return new BankAccountResponse
            {
                ID = account.ID,
                Full_Name = account.Full_Name,
                Email = account.Email,
                Phone = account.Phone,
                IBAN_Mask = account.IBAN_Mask,
                Balance = account.Balance,
                Currency = account.Currency,
                Server_DateTime = account.Server_DateTime,
                DateTime_UTC = account.DateTime_UTC,
                Update_DateTime_UTC = account.Update_DateTime_UTC,
                IP_Address = account.IP_Address,
                Source_IP_Address = account.Source_IP_Address,
                Host_Name = account.Host_Name,
                Client_Time_Zone = account.Client_Time_Zone,
                Geo_Coordinates = account.Geo_Coordinates,
                Source_App = account.Source_App,
                Source_ID = account.Source_ID,
                Session_ID = account.Session_ID,
                Auth_Type = account.Auth_Type,
                Auth_ID = account.Auth_ID
            };
        }

    }
}
