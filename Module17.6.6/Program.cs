using Module17._6._6;


var standardAccount = new Account
{
    Type = "Обычный",
    Balance = 1001
};

standardAccount.CalculateInterest();
Console.WriteLine($"Обычный аккаунт: Баланс = {standardAccount.Balance}, Процентная ставка = {standardAccount.Interest}");

var salaryAccount = new Account
{
    Type = "Зарплатный",
    Balance = 1500
};

salaryAccount.CalculateInterest();
Console.WriteLine($"Зарплатный аккаунт: Баланс = {salaryAccount.Balance}, Процентная ставка = {salaryAccount.Interest}");