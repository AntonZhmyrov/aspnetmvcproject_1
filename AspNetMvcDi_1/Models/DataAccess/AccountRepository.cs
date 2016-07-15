using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AspNetMvcDi_1.Interfaces;

namespace AspNetMvcDi_1.Models.DataAccess
{
	public class AccountRepository : IAccountRepository
	{
		private readonly List<Account> _accounts;

		public AccountRepository()
		{
			_accounts = new List<Account>();

			_accounts.Add(new Account {Id = 1, Login = "Dude", Email = "dude@gmail.com", Password = "Wassup"});
			_accounts.Add(new Account {Id = 2, Login = "Fellow", Email = "fellow@hotmail.com", Password = "Hello!"});
			_accounts.Add(new Account {Id = 3, Login = "Dawg", Email = "dawg@ukr.net", Password = "12345"});
			_accounts.Add(new Account {Id = 4, Login = "Buddy", Email = "buddy@mail.ru", Password = "nfwia897" });
			_accounts.Add(new Account {Id = 5, Login = "Friend", Email = "friend@yandex.ru", Password = "MKF>..9" });
		}


		public IEnumerable<Account> SelectAllAccounts()
		{
			return _accounts;
		}

		public Account SelectById(int id)
		{
			return _accounts.Find(account => account.Id == id);
		}

		public void InsertAccount(Account account)
		{
			_accounts.Add(account); 
		}

		public void DeleteAccount(int id)
		{
			_accounts.Remove(SelectById(id));
		}

		public void UpdateAccount(Account account)
		{
			var acc = SelectById(account.Id);

			acc.Email = account.Email;
			acc.Login = account.Login;
			acc.Password = account.Password;
		}
	}
}