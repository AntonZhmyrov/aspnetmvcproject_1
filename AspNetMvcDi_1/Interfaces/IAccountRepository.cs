using System.CodeDom.Compiler;
using System.Collections.Generic;
using AspNetMvcDi_1.Models;

namespace AspNetMvcDi_1.Interfaces
{
	public interface IAccountRepository
	{
		IEnumerable<Account> SelectAllAccounts();
		Account SelectById(int id);
		void InsertAccount(Account account);
		void DeleteAccount(int id);
		void UpdateAccount(Account account);
	}
}
