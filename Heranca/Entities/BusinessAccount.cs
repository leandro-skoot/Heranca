namespace Heranca.Entities
{
    class BusinessAccount : Account
    {
        public double LoandLimit { get; set; }

        public BusinessAccount() { }

        public BusinessAccount(int number, string holder, double balance, double loandLimit) : base(number, holder, balance)
        {
            LoandLimit = loandLimit;
        }

        public void Loan(double amont)
        {
            if(amont <= LoandLimit)
            {
                Balance += amont;
            }
        }
    }
}
