using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AspNetMvcDi_1.Interfaces;

namespace AspNetMvcDi_1.Models.Managers
{
	public class AccountManager : IAccountManager
	{
		private readonly IAccountRepository _repository;

		public AccountManager(IAccountRepository repository)
		{
			_repository = repository;
		}

		public IEnumerable<Account> GetAllAccounts()
		{
			return _repository.SelectAllAccounts();
		}

		public Account GetAccountById(int id)
		{
			return _repository.SelectById(id);
		}

		public void RegisterAccount(Account account)
		{
			_repository.InsertAccount(account);
		}

		public void RemoveAccount(int id)
		{
			_repository.DeleteAccount(id);
		}

		public IEnumerable<Account> NextAccounts(int skipAmount, int amountToTake)
		{
			var skippedAmount = _repository.SelectAllAccounts()
				.Skip(skipAmount)
				.Take(amountToTake);

			return skippedAmount;
		}
	}
}