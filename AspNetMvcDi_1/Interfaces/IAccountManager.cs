using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetMvcDi_1.Models;

namespace AspNetMvcDi_1.Interfaces
{
	public interface IAccountManager
	{
		IEnumerable<Account> GetAllAccounts();
		Account GetAccountById(int id);
		void RegisterAccount(Account account);
		void RemoveAccount(int id);
		IEnumerable<Account> NextAccounts(int skipAmount, int amountToTake);
	}
}
