﻿namespace DesignPatterns.ChainOfResponsibility
{
    public class Purchase
    {
        public Purchase(int number, double amount, string purpose)
        {
            Number = number;
            Amount = amount;
            Purpose = purpose;
        }

        public int Number { get; private set; }
        public double Amount { get; private set; }
        public string Purpose { get; private set; }

    }
}
