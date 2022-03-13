using StatePattern;

var account = new Account(() => { Console.WriteLine("OnUnFreeze"); });

Console.WriteLine($"Balance: {account.Balance} State:{account.State}");

account.Deposit(500);

Console.WriteLine($"Balance: {account.Balance} State:{account.State}");

account.Withdraw(500);

Console.WriteLine($"Balance: {account.Balance} State:{account.State}");

account.HolderVerified();

account.Withdraw(500);

Console.WriteLine($"Balance: {account.Balance} State:{account.State}");

account.Freeze();

account.Deposit(100);

Console.WriteLine($"Balance: {account.Balance} State:{account.State}");