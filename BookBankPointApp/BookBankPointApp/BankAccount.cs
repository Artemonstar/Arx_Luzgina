using System;

namespace BookBankPointApp
{
    public class BankAccount
    {
        // Поля
        public string accountNumber;
        public double balance = 0; // Начальный баланс 0

        // Метод для внесения средств
        public string Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                return $"Внесено {amount}. Текущий баланс: {balance}";
            }
            return "Сумма внесения должна быть положительной!";
        }

        // Метод для снятия средств
        public string Withdraw(double amount)
        {
            if (amount > balance)
            {
                return $"Недостаточно средств. Запрошено: {amount}, доступно: {balance}";
            }
            else if (amount > 0)
            {
                balance -= amount;
                return $"Снято {amount}. Текущий баланс: {balance}";
            }
            return "Сумма снятия должна быть положительной!";
        }

        // Метод для получения информации о счете
        public string GetAccountInfo()
        {
            return $"Номер счета: {accountNumber}, Баланс: {balance}";
        }
    }
}