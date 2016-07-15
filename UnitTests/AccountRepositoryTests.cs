using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Moq;
using AspNetMvcDi_1.Interfaces;
using AspNetMvcDi_1.Models;
using AspNetMvcDi_1.Models.Managers;

namespace UnitTests
{
	[TestFixture]
    public class AccountRepositoryTests
    {
	    private List<Account> _accounts = new List<Account>()
	    {
		    new Account {Id = 1, Login = "Dude", Email = "dude@gmail.com", Password = "Wassup"},
			new Account {Id = 2, Login = "Fellow", Email = "fellow@hotmail.com", Password = "Hello!"},
			new Account {Id = 3, Login = "Dawg", Email = "dawg@ukr.net", Password = "12345"},
			new Account {Id = 4, Login = "Buddy", Email = "buddy@mail.ru", Password = "nfwia897" },
			new Account {Id = 5, Login = "Friend", Email = "friend@yandex.ru", Password = "MKF>..9" }
	    };

		[TestCase(1, 2)]
		[TestCase(0, 0)]
		[TestCase(-1, -3)]
		[TestCase(-2, 2)]
	    public void NextAccounts_DifferentValues_ChecksIfListsAreTheSame(int skip, int amount)
	    {
			// Arrange
		    var mock = new Mock<IAccountRepository>();
		    mock.Setup(m => m.SelectAllAccounts()).Returns(_accounts);
			var target = new AccountManager(mock.Object);

			// Act
		    var expected = target.NextAccounts(skip, amount);
		    var actual = _accounts.Skip(skip).Take(amount);

			// Assert
			Assert.That(actual, Is.EquivalentTo(expected));
	    }
    }
}
