using BankingSystemApi.DTO;

namespace BankingSystemApi.Services
{
    public interface IBankAccountService
    {
        Task<BankAccountResponse> CreateBankAccountAsync(CreateBankAccountRequest request);
        Task<BankAccountResponse> GetBankAccountByIdAsync(int id);
    }
}
